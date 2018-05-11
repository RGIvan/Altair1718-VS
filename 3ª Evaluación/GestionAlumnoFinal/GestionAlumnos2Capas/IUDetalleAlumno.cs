using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LNegocioyADatos;
using LNegocioyADatos.Entidades;


using System.Text.RegularExpressions;// para usar expresiones regulares

namespace InterfazUsuario
{
    public partial class IUDetalleAlumno : Form
    {
        Alumno alum;
        public IUDetalleAlumno()
        {
            InitializeComponent();
        }
        public IUDetalleAlumno(Alumno alum)
        {
            InitializeComponent();
            this.alum = alum;
        }
        private void IUDetalleAlumno_Load(object sender, EventArgs e)
        {   // cargando el combo
            List<Grupo> listaGrupos = LNyAD.ListaGrupos();

            cbGruposDetalle.DataSource = listaGrupos;
            cbGruposDetalle.DisplayMember = "nombre";
            cbGruposDetalle.ValueMember = "idGrupo";

            if (alum.IdAlumno > 0) // alumno existente)
            {
                txbIndice.Visible = true;

                txbIndice.Text = alum.IdAlumno.ToString();
                txbApellNom.Text = alum.ApellidosNombre;
                txbDni.Text = alum.Dni;
                txbMovil.Text = alum.Movil;
                txbTelefono.Text = alum.Telefono;
                txbMail.Text = alum.Email;
                cbGruposDetalle.SelectedValue = alum.IdGrupo;
                //...
            }
            else // alumno nuevo
            {
                // si el formulario es global hay que limpiar los controles
                txbApellNom.Clear();
                txbIndice.Visible = false;
                cbGruposDetalle.SelectedIndex = -1;
                cbGruposDetalle.Text = "Seleccione un Grupo";
                //...
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cerramos devolviendo Cancelar:
            this.DialogResult = DialogResult.Cancel;

            // También valdría: this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (HayError())
                return;

            // actualizo el alumno
            alum.ApellidosNombre = txbApellNom.Text;
            alum.Dni = txbDni.Text;
            alum.Movil = txbMovil.Text;
            alum.Telefono = txbTelefono.Text;
            alum.Email = txbMail.Text;
            alum.IdGrupo = (int)cbGruposDetalle.SelectedValue; // <-- Se hace Casting pq SelectedValue es un object

            if (alum.IdAlumno > 0) // alumno existente)
                LNyAD.ActualizarRegistro(alum);
            else
                LNyAD.AnyadirRegistro(alum);

            // Me salgo respondiendo OK
            this.DialogResult = DialogResult.OK;
        }

        private bool HayError()
        {
            bool hayError = false;
            string mensajeErrores = String.Empty;
            int valorInt;
            // Limpio los errorProviders para que aparezcan de nuevo sólo los incorrectos
            errorProvider.Clear();

            //string expRegTelefono = @"^[0-9]{9}$";
            //string expRegDNI = @"^[0-9]{8}-[A-Z]{1}$";
            //string expRegEmail = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";


            #region Validar Nombre (no puede estar vacío)

            string[] tabApellidosNombre;

            //Comprobacion del campo Apellidos,Nombre
            if (txbApellNom.Text.Length <= 0)
            {
                hayError = true;
                mensajeErrores += "El campo Apellidos, Nombre no puede estar vacio\n";
                errorProvider.SetError(txbApellNom, "Debe introducir sus Apellidos, Nombre");
            }
            else if (txbApellNom.Text != alum.ApellidosNombre) // comprobación de Apellidos, Nombre si lo he cambiado
            {
                tabApellidosNombre = txbApellNom.Text.Split(',');

                if (tabApellidosNombre.Length != 2)
                {
                    hayError = true;
                    mensajeErrores += " Formato campo Apellidos, Nombre incorrecto (Apellido1 Apellido2, Nombre1 Nombre2)\n";
                    errorProvider.SetError(txbApellNom, "Formato incorrecto");
                }
                else
                {
                    //Rizando el Rizo: Comprobamos que estén compuesto po
                    string expRegApellidos = @"^[A-ZÑÁÉÍÓÚ]{1}[a-zñáéíóú]+( [A-ZÑÁÉÍÓÚ]{1}[a-zñáéíóú]+)*$";
                    string expRegNombre = @"^[A-ZÑÁÉÍÓÚ]{1}[a-zñáéíóú.]+( [A-ZÑÁÉÍÓÚ]{1}[a-zñáéíóú.]+)*$";

                    //Valido los apellidos
                    if (!Regex.IsMatch(tabApellidosNombre[0].Trim(), expRegApellidos))
                    {
                        hayError = true;
                        mensajeErrores += "Campo Apellidos, Nombre incorrecto\n";
                        errorProvider.SetError(txbApellNom, "Formato Apellidos incorrecto");
                        //pBoxApellidosNom.Show();
                    }
                    else if (!Regex.IsMatch(tabApellidosNombre[1].Trim(), expRegNombre))
                    {
                        hayError = true;
                        mensajeErrores += "Campo Apellidos, Nombre incorrecto\n";
                        errorProvider.SetError(txbApellNom, "Formato Nombre incorrecto");
                        //pBoxApellidosNom.Show();
                    }
                }
            }
            #endregion

            #region Validar DNI (El formato del DNI debe ser XXXXXXXX-letraMayúscula)
            string dni = txbDni.Text; // por claridad uso una variable más corta
            if (dni.Length <= 0)
            {
                hayError = true;
                mensajeErrores += "El campo DNI no puede estar vacio\n";
                errorProvider.SetError(txbApellNom, "Debe introducir sus DNI");
            }
            else if (dni != alum.Dni) // comprobación de DNI si lo he cambiado
            {
                // compruebo el formato
                if (dni.Length != 10 || !Int32.TryParse(dni.Substring(0, 8), out valorInt) || dni.IndexOf('-') != 8 || dni[9] < 'A' || dni[9] > 'Z')
                {
                    mensajeErrores += "El formato del DNI debe ser 8cifras-letraMayúscula\n";
                    errorProvider.SetError(txbDni, "Formato incorrecto");
                    hayError = true;
                }
                else if (LNyAD.ExisteDNI(dni))// compruebo si ya existe
                {
                    mensajeErrores += "El formato del DNI ya existe en la BD\n";
                    errorProvider.SetError(txbDni, "Ya existe este DNI");
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
                    if (!Int32.TryParse(strTelefono, out valor) || valor < 900000000 || valor > 999999999)
                    {
                        mensajeErrores += "El Teléfono 9 cifras y comienza por 9\n";
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

            if (!Regex.IsMatch(txbMail.Text, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
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
