using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LNegocioyADatos.DataSet1TableAdapters;
using LNegocioyADatos.Entidades;

namespace LNegocioyADatos
{
    public class LNyAD
    {
        static AlumnosTableAdapter alumnosAdapter = new AlumnosTableAdapter();
        static DataSet1.AlumnosDataTable alumnosTabla = new DataSet1.AlumnosDataTable();
        static GruposTableAdapter gruposAdapter = new GruposTableAdapter();
        static DataSet1.GruposDataTable gruposTabla = new DataSet1.GruposDataTable();

        public static DataSet1.AlumnosDataTable TablaAlumnos(int idGrupo)
        {
            // cargo la tabla
            if(idGrupo==0)
                alumnosTabla = alumnosAdapter.GetDataConAliasGrupo();
            else
                alumnosTabla = alumnosAdapter.GetDataByIdGrupo(idGrupo);
            return alumnosTabla;
        }


        public static DataSet1.GruposDataTable TablaGrupos()
        {
            // cargo la tabla
            gruposTabla = gruposAdapter.GetData();
            return gruposTabla;
        }

        public static List<Grupo> ListaGrupos()
        {
            // cargo la tabla
            List<Grupo> listaGrupos = new List<Grupo>();
            gruposTabla = gruposAdapter.GetData();
            // relleno la lista con los grupos obtenidos de la tabla
            foreach (DataSet1.GruposRow g in gruposTabla)
                listaGrupos.Add(new Grupo(g.idGrupo, g.alias, g.nombre));

            return listaGrupos;
        }

        public static void EliminarRegistro(int idAlum)
        {
            DataSet1.AlumnosRow regBorrar = alumnosTabla.FindByidAlumno(idAlum);
            regBorrar.Delete();

            alumnosAdapter.Update(regBorrar);

            //// otra forma. Consulta específica
            //alumnosAdapter.DeleteQueryPorIdAlumno(idAlum);
        }

        public static Alumno ObtenerAlumnoPorId(int idAlum)
        {
            DataSet1.AlumnosRow regAlum = alumnosTabla.FindByidAlumno(idAlum);
            return new Alumno(regAlum);
        }

        public static bool ExisteDNI(string dni)
        {
            // accedemos a la consulta del dataset. Si se ha encontrado un DNI igual, es que existe
            if(alumnosAdapter.BuscarDNI(dni) > 0)
                return true;
            else
                return false;
        }

        public static void ActualizarRegistro(Alumno alum)
        {
            DataSet1.AlumnosRow regAlum = alumnosTabla.FindByidAlumno(alum.IdAlumno);

            // actualizo el registro
            regAlum.apellidosNombre = alum.ApellidosNombre;
            regAlum.dni = alum.Dni;
            regAlum.movil = alum.Movil;
            regAlum.telefono = alum.Telefono;
            regAlum.email = alum.Email;
            regAlum.idGrupo = alum.IdGrupo;

            // actualizo la bd
            alumnosAdapter.Update(regAlum);

        }

        public static void AnyadirRegistro(Alumno alum)
        {
            DataSet1.AlumnosRow regAlum = alumnosTabla.NewAlumnosRow();

            // relleno el registro como huce en Actualizar
            regAlum.apellidosNombre = alum.ApellidosNombre;
            regAlum.dni = alum.Dni;
            regAlum.movil = alum.Movil;
            regAlum.telefono = alum.Telefono;
            regAlum.email = alum.Email;
            regAlum.idGrupo = alum.IdGrupo;

            // Añado el registro a la tabla
            alumnosTabla.AddAlumnosRow(regAlum);
                 // actualizo la bd
            alumnosAdapter.Update(regAlum);
        }
    }
}
