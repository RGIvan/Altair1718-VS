using LogicaNegocioYAccesoDatos.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaNegocioYAccesoDatos.Entidades;

namespace LogicaNegocioYAccesoDatos
{
    public class LNyAD
    {
        static PacientesTableAdapter pacientesAdapter = new PacientesTableAdapter();
        static DataSet1.PacientesDataTable pacientesTabla = new DataSet1.PacientesDataTable();

        static ProvinciasTableAdapter provinciasAdapter = new ProvinciasTableAdapter();
        static DataSet1.ProvinciasDataTable provinciasTabla = new DataSet1.ProvinciasDataTable();

        public static List<Provincia> ListaProvincias()
        {
            provinciasTabla = provinciasAdapter.GetData();
            List<Provincia> lista = new List<Provincia>();
            foreach (DataSet1.ProvinciasRow p in provinciasTabla)
            {
                lista.Add(new Provincia(p));
            }
            return lista;
        }

        public static DataSet1.PacientesDataTable TablaPacientes(byte idProvincia)
        {
            if (idProvincia == 0)
                pacientesTabla = pacientesAdapter.GetPacientesConProvincia();
            else
                pacientesTabla = pacientesAdapter.GetPacientesPorIdProvincia(idProvincia);
            return pacientesTabla;
        }

        public static void EliminarPaciente(int idPaciente)
        {
            pacientesAdapter.DeletePacientes(idPaciente);
        }

        public static Paciente ObtenerPaciente(int idPaciente)
        {

            DataSet1.PacientesRow regPaciente = pacientesTabla.FindByidPaciente(idPaciente);
            return new Paciente(regPaciente);
        }

        public static void ActualizarYAnyadirRegistro(Paciente paciente)
        {
            DataSet1.PacientesRow regPaciente;
            if (paciente.IdPaciente > 0) //existe, edito
                regPaciente = pacientesTabla.FindByidPaciente(paciente.IdPaciente);
            else
                regPaciente = pacientesTabla.NewPacientesRow();

            //Actualización

            regPaciente.nombPaciente = paciente.NombrePaciente;
            regPaciente.movil = paciente.Movil;
            regPaciente.tlfno = paciente.Telefono;
            if (paciente.Email==string.Empty)
             regPaciente.email = " ";
            else
            regPaciente.email = paciente.Email;

            regPaciente.domicilio = paciente.Domicilio;
            regPaciente.cp = paciente.CP;
            regPaciente.idProvincia = paciente.IdProvincia;
            regPaciente.fecha = paciente.Fecha;
            regPaciente.altura = paciente.Altura;
            regPaciente.peso = paciente.Peso;
            regPaciente.sexo = paciente.Sexo;

            if (paciente.IdPaciente < 0)
                pacientesTabla.AddPacientesRow(regPaciente);

            pacientesAdapter.Update(regPaciente);
        }

        public static bool BuscaUsuarioPorNombre(string nombre)
        {
            pacientesTabla = pacientesAdapter.GetData();
            foreach (DataSet1.PacientesRow p in pacientesTabla)
            {
                if (p.nombPaciente.ToUpper().Equals(nombre))
                return true;
            }
            return false;
        }
    }
}
