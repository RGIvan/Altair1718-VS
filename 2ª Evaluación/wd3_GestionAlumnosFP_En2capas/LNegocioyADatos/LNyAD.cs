using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNegocioyADatos.Entidades;
using LNegocioyADatos.DataSet1TableAdapters;

namespace LNegocioyADatos
{
    public class LNyAD
    {
        static GruposTableAdapter gruposAdapter = new GruposTableAdapter();
        static DataSet1.GruposDataTable gruposTabla = new DataSet1.GruposDataTable();

        static AlumnosTableAdapter alumnosAdapter = new AlumnosTableAdapter();
        static DataSet1.AlumnosDataTable alumnosTabla = new DataSet1.AlumnosDataTable();
        public static List<Grupo> ListaGrupos()
        {
            List<Grupo> lista = new List<Grupo>();
            // cargamos la tabla de grupos y con ella la lista
            gruposTabla = gruposAdapter.GetData();
            foreach (DataSet1.GruposRow g in gruposTabla)
                lista.Add(new Grupo(g));

            return lista;
        }

        public static DataSet1.AlumnosDataTable TablaAlumnos(int idGrupo)
        {
            
            if (idGrupo == 0)
                alumnosTabla = alumnosAdapter.GetAlumnosConAliasGrupo();
            else
                alumnosTabla = alumnosAdapter.GetAlumnosPorIdGrupo(idGrupo);

            return alumnosTabla;
        }

        /*
        ● Obtengo el registro correspondiente a dicho alumno
        ● elimino el registro
        ● actualizo la BD
        */
        public static void EliminarAlumno(int idAlumno)
        {
            alumnosAdapter.DeletePorIdAlumno(idAlumno);
        }

        /*
            ● Obtengo el registro correspondiente a dicho alumno
            ● Devuelvo el alumno a editar, a partir de dicho registro
        */
        /// <summary>
        /// Obtengo el registro correspondiente a dicho alumno
        /// </summary>
        /// <param name="idAlumno"> id del alumno a devolver</param>
        /// <returns>Devuelvo el alumno a editar, a partir de dicho registro</returns>
        public static Alumno ObtenerAlumno(int idAlumno)
        {
            // Obtengo el registro correspondiente a dicho alumno
            DataSet1.AlumnosRow regAlumno = alumnosTabla.FindByidAlumno(idAlumno);
            return new Alumno(regAlumno);
        }

        public static void ActualizarAnyadirRegistro(Alumno alum)
        {
            DataSet1.AlumnosRow regAlumno;
            // si el alumno ya existe (estamos modificando) tomo su registro de la tabla
            // si no, Construimos un registro nuevo
            if (alum.IdAlumno>0) 
                regAlumno = alumnosTabla.FindByidAlumno(alum.IdAlumno);
            else
                regAlumno = alumnosTabla.NewAlumnosRow();

            // actualizo el registro
            regAlumno.apellidosNombre = alum.ApellidosNombre;
            regAlumno.dni = alum.Dni;
            regAlumno.movil = alum.Movil;
            regAlumno.telefono = alum.Telefono;
            regAlumno.email = alum.Email;
            regAlumno.idGrupo = alum.IdGrupo;

            // Si era un alumno nuevo, añado el registro a la tabla
            if (alum.IdAlumno < 0)
                alumnosTabla.AddAlumnosRow(regAlumno);
            
            // En cualquier caso, actualizo la bd
            alumnosAdapter.Update(regAlumno);
        }

        public static bool ExisteDNI(string dni)
        {
            // Versión sin acceder a la BD
            foreach (DataSet1.AlumnosRow reg in alumnosTabla)
                if (dni == reg.dni)
                    return true;

            return false;

            //// Versión consultando a la BD
            //return (alumnosAdapter.ContarDNI(dni)>0);
        }
    }
}
