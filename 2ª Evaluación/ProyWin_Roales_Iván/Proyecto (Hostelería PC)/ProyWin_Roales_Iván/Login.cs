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
    public partial class Login : Form
    {
        Usuario usu;
        public Login()
        {
            InitializeComponent();
        }

        #region Entrar
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string texto = String.Empty;

            if (txbUsuario.Text == String.Empty)
            {
                texto = "El usuario está vacío\n";
                errorProvider1.SetError(txbUsuario, "El campo está vacío.");
                txbPass.Text = String.Empty;
            }

            if (txbPass.Text == String.Empty)
            {
                texto = "La contraseña está vacía\n";
                errorProvider1.SetError(txbPass, "El campo está vacío.");
                txbPass.Text = String.Empty;
            }

            if (texto != String.Empty)
            {
                MessageBox.Show(texto, "Los campos están vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (LNyAD.BuscarUsuario(txbUsuario.Text) == null)
            {
                errorProvider1.SetError(txbUsuario, "Usuario incorrecto");
                MessageBox.Show("El usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbPass.Text = String.Empty;
                btnRegistro.Focus();
            }

            usu = LNyAD.BuscarPorUserPass(txbUsuario.Text, txbPass.Text);

            if (usu != null)
            {
                errorProvider1.Clear();
                if (usu.Acceso == 0)
                    MessageBox.Show("Debes de darte de alta en la aplicación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if
                    (usu.Acceso == 2)
                {
                    txbPass.Text = String.Empty;
                    txbUsuario.Text = String.Empty;
                    btnEntrar.Focus();
                    MenuUsuario interfaz = new MenuUsuario();
                    interfaz.Usu = usu;
                    this.Hide();
                    interfaz.ShowDialog();
                    interfaz.Dispose();
                }

                if (usu.Acceso == 1)
                {
                    txbPass.Text = String.Empty;
                    txbUsuario.Text = String.Empty;
                    btnEntrar.Focus();
                    MenuAdmin interfaz = new MenuAdmin();
                    interfaz.Usu = usu;
                    this.Hide();
                    interfaz.ShowDialog();
                    interfaz.Dispose();
                }

                if (usu.Acceso == 3)
                {
                    txbPass.Text = String.Empty;
                    txbUsuario.Text = String.Empty;
                    btnEntrar.Focus();
                    UIDes interfaz = new UIDes();
                    interfaz.Usu = usu;
                    this.Hide();
                    interfaz.ShowDialog();
                    interfaz.Dispose();
                }
            }

            else

            {
                errorProvider1.SetError(txbPass, "La contraseña es incorrecta");
                MessageBox.Show("La contraseña no es válida o es errónea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbPass.Text = String.Empty;
                btnEntrar.Focus();
            }
        } 
        #endregion

        private void Login_Load(object sender, EventArgs e)
        {
            btnEntrar.Select();
        }

        #region Registro
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txbPass.Text = String.Empty;
            txbUsuario.Text = String.Empty;
            Registro regUser = new Registro();
            regUser.ShowDialog();
            regUser.Dispose();
            
        }
        #endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}