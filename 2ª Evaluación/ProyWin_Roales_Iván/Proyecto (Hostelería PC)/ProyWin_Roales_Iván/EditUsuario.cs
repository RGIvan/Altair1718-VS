using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocioyADatos.Entidades;
using LogicaNegocioyADatos;

namespace InterfazUsuario
{
    public partial class EditUsuario : Form
    {
        Usuario usu;

        public Usuario Usu
        {
            get
            {
                return usu;
            }

            set
            {
                usu = value;
            }
        }

        public EditUsuario()
        {
            InitializeComponent();
        }

        private void EditUsuario_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (!HayErrorEnFormulario())
            {
                this.usu = new Usuario();   

                usu.Login = txbUsuario.Text;
                usu.Password = txbPass.Text;
                usu.Nombre = txbNombre.Text;
                usu.Apellidos = txbApellidos.Text;

                LNyAD.EditarUsuario(usu);
                MessageBox.Show("El usuario se ha editado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private bool HayErrorEnFormulario()
        {
            errorProvider1.Clear();

            string texto = "";
            bool error = false;

            if (txbUsuario.ForeColor == Color.DarkRed || txbUsuario.Text == String.Empty)
            {
                texto = "El nombre de usuario está vacío\n";
                errorProvider1.SetError(txbUsuario, "El campo está vacío");
                btnRegistro.Focus();
                error = true;
            }

            if (txbPass.ForeColor == Color.DarkRed || txbPass.Text == String.Empty)
            {
                texto = "La contraseña está vacía\n";
                errorProvider1.SetError(txbPass, "El campo está vacío");
                btnRegistro.Focus();
                error = true;
            }

            if (txbNombre.ForeColor == Color.DarkRed || txbNombre.Text == String.Empty)
            {
                texto = "El nombre está vacío\n";
                errorProvider1.SetError(txbNombre, "El campo está vacío");
                btnRegistro.Focus();
                error = true;
            }

            if (txbApellidos.ForeColor == Color.DarkRed || txbApellidos.Text == String.Empty)
            {
                texto = "El nombre está vacío\n";
                errorProvider1.SetError(txbApellidos, "El campo está vacío");
                btnRegistro.Focus();
                error = true;
            }

            if (texto != String.Empty)
            {
                MessageBox.Show(texto, "Los campos están vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                error = true;
            }

            return error;
        }
    }
}