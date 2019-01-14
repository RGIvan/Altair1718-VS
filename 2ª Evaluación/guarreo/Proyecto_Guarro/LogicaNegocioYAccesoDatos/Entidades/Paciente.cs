using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocioYAccesoDatos.Entidades
{
    public class Paciente
    {
        int idPaciente, fecha;
        string nombPaciente, telefono, movil, email, domicilio, cp, sexo;
        byte altura, idProvincia;
        float peso;

        //------- Constructor/es --------
        //(te escribo el típico sólo por si te sirve copiar algo, pero si quieres lo borras) 
        public Paciente(int idPaciente, string nombPaciente, string movil, string tlfno, string email, string domicilio, string cp, byte idProvincia, int fecha, byte altura, float peso, string sexo)
        {
            this.idPaciente = idPaciente;
            this.nombPaciente = nombPaciente;
            this.movil = movil;
            this.telefono = tlfno;
            this.email = email;
            this.domicilio = domicilio;
            this.cp = cp;
            this.idProvincia = idProvincia;
            this.fecha = fecha;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
        }

        public Paciente(DataSet1.PacientesRow regPaciente)
        {
            this.idPaciente = regPaciente.idPaciente;
            this.nombPaciente = regPaciente.nombPaciente;
            this.movil = regPaciente.movil;
            this.telefono = regPaciente.tlfno;
            this.email = regPaciente.email;
            this.domicilio = regPaciente.domicilio;
            this.cp = regPaciente.cp;
            this.idProvincia = regPaciente.idProvincia;
            this.fecha = regPaciente.fecha;
            this.altura = regPaciente.altura;
            this.peso = regPaciente.peso;
            this.sexo = regPaciente.sexo;
        }
        public Paciente()
        {
            this.idPaciente = -1;
            this.nombPaciente = string.Empty;
            this.movil = string.Empty;
            this.telefono = string.Empty;
            this.email = string.Empty;
            this.domicilio = string.Empty;
            this.cp = string.Empty;
            this.idProvincia = 0;
            this.fecha = 0;
            this.altura = 0;
            this.peso = 0;
            this.sexo = string.Empty;
        }

        //-- Las propiedades
        public int IdPaciente
        {
            get { return idPaciente; }
            set { idPaciente = value; }
        }
        public byte IdProvincia
        {
            get { return idProvincia; }
            set { idProvincia = value; }
        }
        public string NombrePaciente
        {
            get { return nombPaciente; }
            set { nombPaciente = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Movil
        {
            get { return movil; }
            set { movil = value; }
        }

        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }
        public string CP
        {
            get { return cp; }
            set { cp = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public byte Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public float Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }


    }
}
