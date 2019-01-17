using LogicaNegocioYAccesoDatos;
using LogicaNegocioYAccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUPacientes
{
    public partial class IUDetalle : Form
    {
        Paciente paciente;
        public IUDetalle()
        {
            InitializeComponent();
        }

        public Paciente Paciente
        {
            get { return paciente; }
            set { paciente = value; }

        }

        private void IUDetalle_Load(object sender, EventArgs e)
        {
            txbIndice.Text = paciente.IdPaciente.ToString();
            txbApellNom.Text = paciente.NombrePaciente;
            txbMovil.Text = paciente.Movil;
            txbTelefono.Text = paciente.Telefono;
            txbMail.Text = paciente.Email;
            txbDomicilio.Text = paciente.Domicilio;
            txbCP.Text = paciente.CP;
            cbProvinciasDetalle.SelectedValue = paciente.IdProvincia;
            txbFecha.Text = paciente.Fecha.ToString();
            txbAltura.Text = paciente.Altura.ToString();
            txbPeso.Text = paciente.Peso.ToString();
            if (paciente.Sexo == "H")
                rbH.Checked = true;
            else
                rbM.Checked = true;
            if (paciente.IdPaciente < 0)
            {
                cbProvinciasDetalle.SelectedIndex = -1;
                cbProvinciasDetalle.Text = "Elija una Provincia";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (HayErrror())
                return;
            paciente.NombrePaciente = txbApellNom.Text;
            paciente.Movil = txbMovil.Text;
            paciente.Telefono = txbTelefono.Text;

            if (txbMail.Text.Length > 0)
                paciente.Email = txbMail.Text;
            else
                paciente.Email = string.Empty;

            if (txbDomicilio.Text.Length > 0)
                paciente.Domicilio = txbDomicilio.Text;
            else
                paciente.Domicilio = string.Empty;

            if (txbDomicilio.Text.Length > 0)
                paciente.CP = txbCP.Text;
            else
                paciente.CP = string.Empty;

            paciente.IdProvincia = (byte)cbProvinciasDetalle.SelectedValue;
            paciente.Fecha = Convert.ToInt32(txbFecha.Text);
            paciente.Altura = Convert.ToByte(txbAltura.Text);
            paciente.Peso = Convert.ToSingle(txbPeso.Text);
            if (rbH.Checked)
                paciente.Sexo = "H";
            else
                paciente.Sexo = "M";
            DialogResult = DialogResult.OK;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private bool HayErrror()
        {
            bool hayError = false;
            string mensajeErrores = string.Empty;

            errorProvider.Clear();
            //APELLIDOS Y NOMBRE
            //Compruebo Longitud del nombre
            if (txbApellNom.Text.Length < 1 || txbApellNom.Text.Length > 50)
            {
                hayError = true;
                mensajeErrores += "Nombre y Apellidos demasiado corto o largo\n";
                errorProvider.SetError(txbApellNom, "Formato Incorrecto");
            }
            //Compruebo que el formato sea algo,algo
            if (txbApellNom.Text.Trim().IndexOf(',') == -1 || txbApellNom.Text.Trim().IndexOf(',') == 0)
            {
                hayError = true;
                mensajeErrores += "El formato es: \"<Apellido/s,Nombre/s>\"\n";
                errorProvider.SetError(txbApellNom, "Formato Incorrecto");
            }
            //compurebo que no exista el usuario en la bbdd
            if (LNyAD.BuscaUsuarioPorNombre(txbApellNom.Text.Trim().ToUpper()) && paciente.IdPaciente < 0)
            {
                hayError = true;
                mensajeErrores += "Ya existe este paciente. \n";
                errorProvider.SetError(txbApellNom, "Existe el Paciente");
            }
            //CONTROL TELEFONOS
            if (ValidaTelefonos(txbMovil.Text, txbTelefono.Text, cbProvinciasDetalle.SelectedIndex))
            {
                hayError = true;
                mensajeErrores += "Hay un error con el/los telefono/s. \n\t-Debe haber al menos uno\n\t-El movil comienza por 6 o 7 y es de 9 cifras\n\t-El fijo empieza por 9 seguido del prefijo de la provincia, y tiene 9 cifras.\n";
                errorProvider.SetError(txbMovil, "Error de formato");
                errorProvider.SetError(txbTelefono, "Error de formato");

            }
            //PROVINCIA SELECCIONADA
            if (cbProvinciasDetalle.SelectedIndex == -1)
            {
                mensajeErrores += "Elija una Provincia.\n";
                errorProvider.SetError(cbProvinciasDetalle, "Elija Una");
                hayError = true;
            }
            //CONTROL DOMICILIO Y CP
            //Longitud de ambos campos
            if (txbDomicilio.Text.Length > 100)
            {
                hayError = true;
                mensajeErrores += "Dirección demasiado larga.\n";
                errorProvider.SetError(txbCP, "Campo no puede estar vacío");
            }
            if (txbDomicilio.Text.Length > 0 && txbCP.Text.Length > 5)
            {

                hayError = true;
                mensajeErrores += "Código postal incorrecto, máximo 5 cifras.\n";
                errorProvider.SetError(txbCP, "Formato Incorrecto");
            }
            //Controlar que si el domicilio está, debe haber codigo postal
            if (txbDomicilio.Text.Length > 0 && txbCP.Text.Length == 0)
            {
                hayError = true;
                mensajeErrores += "Si Hay domicilio, debe haber código postal.\n";
                errorProvider.SetError(txbCP, "Campo no puede estar vacío");
            }
            //Control de que el cp sea bueno
            int cp = 0;
            if (txbDomicilio.Text.Length > 0)
            {
                if (!Int32.TryParse(txbCP.Text, out cp))
                {
                    hayError = true;
                    mensajeErrores += "Formato de código postal incorrecto.\n";
                    errorProvider.SetError(txbCP, "Formato incorrecto");
                }
                if (cbProvinciasDetalle.SelectedIndex != -1)
                {
                    if (provincias[cbProvinciasDetalle.SelectedIndex].IDProvincia != cp / 1000)
                    {
                        hayError = true;
                        mensajeErrores += "Formato de código postal incorrecto.\n\t-El CP de Cada Provincia empieza por:\n\tAlmeria 4,Cádiz 11,Córdoba 14,Granada 18,Huelva 21,\n\t\tJaen 23,Málaga 29,Sevilla 41";
                        errorProvider.SetError(txbCP, "Formato incorrecto");
                    }
                }
            }

            //CONTROL EMAIL
            if (txbMail.Text.Length > 0 && !Regex.IsMatch(txbMail.Text, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
            {
                mensajeErrores += "El formato del email no es correcto\n";
                errorProvider.SetError(txbMail, "Formato Incorrecto");
                hayError = true;
            }

            //CONTROL DEL DIA
            if (!compruebaFecha(txbFecha.Text))
            {
                hayError = true;
                mensajeErrores += "Fecha (AAMMDD)\n";
                errorProvider.SetError(txbFecha, "Formato Incorrecto");
            }
            //CONTROL DE PESO
            if (!compruebaPeso(txbPeso.Text))
            {
                hayError = true;
                mensajeErrores += "Peso (45,0-250,0)\n";
                errorProvider.SetError(txbPeso, "Formato Incorrecto");
            }
            //CONTROL ALTURA
            if (!compruebaAltura(txbAltura.Text))
            {
                hayError = true;
                mensajeErrores += "Altura (150-220)\n";
                errorProvider.SetError(txbAltura, "Formato Incorrecto");
            }
            //CONTROL GÉNERO
            //Por defecto se señala "mujer"
            if (hayError)
            {
                MessageBox.Show(mensajeErrores, "Error en el formulario");
            }
            return hayError;
        }

        private bool compruebaAltura(string text)
        {
            int altura;

            if (Int32.TryParse(text, out altura))
            {
                if (altura >= 150 && altura <= 220)
                    return true;
            }
            return false;
        }

        private bool compruebaPeso(string text)
        {
            {
                Single peso;
                bool error = false;

                if (Single.TryParse(text, out peso))
                {
                    if (peso <= 250 && peso >= 45)
                        error = true;
                }


                return error;
            }
        }

        private bool compruebaFecha(string fechaText) //comprueba el formato y requisitos de la fecha
        {
            if (fechaText.Length != 6)
                return false;

            int fecha;
            if (!Int32.TryParse(fechaText, out fecha))
                return false;


            int año = Convert.ToInt32(fechaText.Substring(0, 2));
            int mes = Convert.ToInt32(fechaText.Substring(2, 2));
            int dia = Convert.ToInt32(fechaText.Substring(4));


            //int año = fecha / 1000;
            //int mes = fecha / 100 - año * 100;
            //int dia = fecha % 100;
            //año += 1900;

            if (año >= 16 && año <= 99 && mes >= 1 && mes <= 12 && dia >= 1 && diaValido(dia, mes))
                return true;
            return false;

        }

        private bool diaValido(int dia, int mes)
        {
            switch (mes)
            {
                default:
                    if (dia <= 31)
                        return true;
                    return false;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (dia <= 30)
                        return true;
                    return false;
                case 2: //no contemplo bisiestos
                    if (dia <= 28)
                        return true;
                    return false;
            }
        }


        List<Provincia> provincias = LNyAD.ListaProvincias();

        private bool ValidaTelefonos(string movil, string telefono, int provincia)
        {
            bool fijoB = false, movilB = false, error = false;
            int Tmovil;
            if (telefono.Length > 0)
                fijoB = true;
            if (movil.Length > 0)
                movilB = true;

            if (!movilB && !fijoB) //Faltan ambos campos
                return true;

            else //Compruebo los formatos
            {
                if (fijoB)
                {
                    if (telefono.Length == 9)
                    {
                        if (!telefono.Substring(0, 3).Equals(provincias[provincia].IDPrefijo.ToString()))
                            error = true;
                    }
                    else error = true;
                }

                if (movilB && Int32.TryParse(movil, out Tmovil)) //numerico
                {
                    if (movil.Length == 9 && (movil[0] == '6' || movil[0] == '7')) { } //Movil bueno
                    else error = true;
                }
            }
            return error;
        }

        //----- Los nombres de los controles en orden de colocación. Espero te sea útil --------

        //txbIndice
        //txbApellNom
        //txbMovil
        //txbTelefono
        //txbMail
        //txbDomicilio
        //txbCP
        //cbProvinciasDetalle
        //txbFecha
        //txbAltura
        //txbPeso
        //rbH
        //rbM   
    }
}
