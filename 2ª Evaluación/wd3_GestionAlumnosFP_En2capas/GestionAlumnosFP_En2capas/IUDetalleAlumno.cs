using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;
using LNegocioyADatos.Entidades;
using LNegocioyADatos;

namespace InterfazUsuario
{
    public partial class IUDetalleAlumno : Form
    {
        Alumno alum;
        public IUDetalleAlumno()
        {
            InitializeComponent();
        }

        #region ------ Propiedades -------
        public Alumno Alum
        {
            get { return alum; }
            set { alum = value; }
        }

        #endregion
        private void FormDetalleAlumno_Load(object sender, EventArgs e)
        {
            // si indice es negativo oculto el textBox, en caso contrario lo muestro
            txbIndice.Visible = (alum.IdAlumno > 0);

            txbIndice.Text = alum.IdAlumno.ToString();
            txbApellNom.Text = alum.ApellidosNombre;
            txbDni.Text = alum.Dni;
            txbMovil.Text = alum.Movil;
            txbTelefono.Text = alum.Telefono;
            txbMail.Text = alum.Email;
            cbGruposDetalle.SelectedValue = alum.IdGrupo;
            if (alum.IdGrupo < 0) // <-- estaríamos en Añadir alumno
            {
                cbGruposDetalle.SelectedIndex = -1;
                cbGruposDetalle.Text = "Seleccione un grupo";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (HayErrorEnDatos())
                return;

            // actualizo el alumno
            alum.ApellidosNombre = txbApellNom.Text;
            alum.Dni = txbDni.Text;
            alum.Movil = txbMovil.Text;
            alum.Telefono = txbTelefono.Text;
            alum.Email = txbMail.Text;
            alum.IdGrupo = (int)cbGruposDetalle.SelectedValue;

            // Me salgo respondiendo OK
            this.DialogResult = DialogResult.OK;
        }

        private bool HayErrorEnDatos()
        {
            bool hayError = false;
            string mensajeErrores = String.Empty;
            int valorInt=0;
            // Limpio los errorProviders para que aparezcan de nuevo sólo los incorrectos
            errorProvider.Clear();

            #region Validar Nombre (no puede estar vacío y el formato tiene que ser Apellidos, Nombre/s)
            string[] tabApellidosNombre;
            //Comprobacion del campo Apellidos,Nombre
            // compruebo que hay una coma
            tabApellidosNombre = txbApellNom.Text.Split(',');

            if (tabApellidosNombre.Length != 2)
            {
                hayError = true;
                mensajeErrores += " Formato campo Apellidos, Nombre incorrecto (Apellidos, Nombre/s)\n";
                errorProvider.SetError(txbApellNom, "Formato incorrecto");
            }
            #endregion


            #region Validar DNI (El formato del DNI debe ser XXXXXXXX-letraMayúscula)
            string dni = txbDni.Text; // por claridad uso una variable más corta
            if (dni.Length <= 0)
            {
                hayError = true;
                mensajeErrores += "El campo DNI no puede estar vacio\n";
                errorProvider.SetError(txbDni, "Debe introducir su DNI");
            }
            else if (dni != alum.Dni) // comprobación de DNI si lo he cambiado
            {
                // compruebo el formato
                // longitud==10         se puede convertir a entero los 8 primeros dígitos    después tiene que haber un guión y una letra mayúscula
                if (dni.Length != 10 || !Int32.TryParse(dni.Substring(0, 8), out valorInt) || dni.IndexOf('-') != 8 || dni[9] < 'A' || dni[9] > 'Z')
                {
                    mensajeErrores += "El formato del DNI debe ser 8cifras-letraMayúscula\n";
                    errorProvider.SetError(txbDni, "Formato incorrecto");
                    hayError = true;
                }
                else if(LNyAD.ExisteDNI(dni))// compruebo si el dni ya existe y cambia el false
                {
                    mensajeErrores += "El DNI ya existe en la base de datos\n";
                    errorProvider.SetError(txbDni, "DNI repetido");
                    hayError = true;
                }
            }
            #endregion

            #region Validar idGrupo (Debe tener uno seleccionado)
            if (cbGruposDetalle.SelectedIndex < 0)
            {
                mensajeErrores += "Debe seleccionar un grupo\n";
                errorProvider.SetError(cbGruposDetalle, "Seleccione un grupo");
                hayError = true;
            }
            #endregion


            #region Validar Teléfonos (debe haber al menos uno y correcto)
            string strTelefono = txbTelefono.Text, strMovil = txbMovil.Text;
            // ¿Están los dos teléfonos vacíos ?
            if (strTelefono.Length == 0 && strMovil.Length == 0)
            {
                mensajeErrores += "Debe introducir al menos un teléfono\n";
                errorProvider.SetError(txbTelefono, "Debe introducir al menos un teléfono");
                errorProvider.SetError(txbMovil, "Debe introducir al menos un teléfono");
                hayError = true;
            } // Longitud del teléfono que hayas introducido
            else
            {
                int valor;
                if (strTelefono.Length > 0) // Si he escrito el teléfono, lo compruebo
                {
                    if (!Int32.TryParse(strTelefono, out valor) || valor < 954000000 || valor > 955999999)
                    {
                        mensajeErrores += "El Teléfono 9 cifras y comienza por 954 o 955\n";
                        errorProvider.SetError(txbTelefono, "Teléfono incorrecto");
                        hayError = true;
                    }
                }
                if (strMovil.Length > 0) // Si he escrito el móvil, lo compruebo
                {
                    if (!Int32.TryParse(strMovil, out valor) || valor < 600000000 || valor > 799999999)
                    {
                        mensajeErrores += "El Móvil 9 cifras y comienza por 6 o por 7\n";
                        errorProvider.SetError(txbMovil, "Móvil incorrecto");
                        hayError = true;
                    }
                }
            }
            #endregion

            #region Validar e-mail (formato adecuado)
            //MailAddress email= 
            if (txbMail.Text.Length>0 && !Regex.IsMatch(txbMail.Text, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
            {
                mensajeErrores += "El formato del e-mail no es correcto\n";
                errorProvider.SetError(txbMail, "Debe introducir un e-mail Correcto");
                hayError = true;
            }
            #endregion



            if (hayError)
                MessageBox.Show(mensajeErrores, "Error en los Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return hayError;
        }
    }
}
