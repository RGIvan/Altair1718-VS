using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LogicaNegocioyADatos.DataSet1TableAdapters;
using LogicaNegocioyADatos.Entidades;

namespace LogicaNegocioyADatos
{
    public class LNyAD
    {
        // Construimos nuestro adaptador y nuestra tabla para cada tabla del DS
        static AlumnosTableAdapter alumnosAdapt = new AlumnosTableAdapter();
        static GruposTableAdapter gruposAdapt = new GruposTableAdapter();

        static DataSet1.AlumnosDataTable alumnosTabla = new DataSet1.AlumnosDataTable();
        static DataSet1.GruposDataTable gruposTabla = new DataSet1.GruposDataTable();

        public static List<Grupo> ListaGrupos()
        {
            Grupo grupo;
            List<Grupo> listaGrupos = new List<Grupo>();
            
            gruposTabla = gruposAdapt.GetData();
            //La recorro para construir la lista de Grupos
            foreach (DataSet1.GruposRow regGrupo in gruposTabla)
            {
                grupo = new Grupo(regGrupo.idGrupo, regGrupo.nombre, regGrupo.alias);
                listaGrupos.Add(grupo);
            }

            return listaGrupos;
        }

        public static DataSet1.AlumnosDataTable TablaAlumnos(int idGrupo)
        {
            if(idGrupo == 0) //<-- todos los alumnos
                alumnosTabla = alumnosAdapt.GetAlumnosConAliasGrupo();
            else
                alumnosTabla = alumnosAdapt.GetDataByIdGrupo(idGrupo);

            return alumnosTabla;
        }

        public static void EliminarAlumno(int idAlumno)
        {
            //------ Dos formas de hacerlo ------:
            // 1) Obteniendo el registro a borrar y aplicándole .Delete();
            // Obtengo el registro de la tabla alumnos que le corresponde
            DataSet1.AlumnosRow regAlumno = alumnosTabla.FindByidAlumno(idAlumno);
            regAlumno.Delete();

            // 2) mediante la consulta que implementamos en el dataset
            //int alumnosBorrados = alumnosAdapt.DeleteByIdAlumno(idAlumno);

            alumnosAdapt.Update(alumnosTabla);

            alumnosTabla.AcceptChanges();
        }

        public static Alumno DevuelveAlumno(int idAlumno)
        {
            // Obtengo el registro de la tabla alumnos que le corresponde
            DataSet1.AlumnosRow regAlumno = alumnosTabla.FindByidAlumno(idAlumno);

            // Como el constructor no admite valores null y teléfono y email pueden serlo...
            string telefono, email;
            if (regAlumno.IstelefonoNull()) //<-- Ojo que es un método
                telefono = String.Empty;
            else
                telefono = regAlumno.telefono;

            if (regAlumno.IsemailNull()) //<-- Ojo que es un método
                email = String.Empty;
            else
                email = regAlumno.email;

            return new Alumno(idAlumno, regAlumno.apellidosNombre, regAlumno.dni, regAlumno.idGrupo, regAlumno.movil, telefono, email);
        }

        public static void ModificaAlumno(Alumno alum)
        {
            DataSet1.AlumnosRow alumnoReg = alumnosTabla.FindByidAlumno(alum.IdAlumno);
            // rellenamos el registro con los nuevos valores
            alumnoReg.apellidosNombre = alum.ApellidosNombre;
            alumnoReg.dni = alum.Dni;
            alumnoReg.idGrupo = alum.IdGrupo;
            alumnoReg.movil = alum.Movil;
            alumnoReg.telefono = alum.Telefono;
            alumnoReg.email = alum.Email;

            // Actualizamos la BD
            alumnosAdapt.Update(alumnoReg);  // <-- Actualizamos la BD
            alumnosTabla.AcceptChanges();
        }

        public static void AddAlumno(Alumno alum)
        {
            // Obtenemos un registro vacío, del mismo tipo que los registros de la tabla
            DataSet1.AlumnosRow alumnoReg = alumnosTabla.NewAlumnosRow();

            // rellenamos el registro con los nuevos valores
            alumnoReg.apellidosNombre = alum.ApellidosNombre;
            alumnoReg.dni = alum.Dni;
            alumnoReg.idGrupo = alum.IdGrupo;
            alumnoReg.movil = alum.Movil;
            alumnoReg.telefono = alum.Telefono;
            alumnoReg.email = alum.Email;

            alumnosTabla.AddAlumnosRow(alumnoReg);

            // Actualizamos la BD
            alumnosAdapt.Update(alumnoReg);  // <-- Actualizamos la BD
            alumnosTabla.AcceptChanges();
        }
    }
}
