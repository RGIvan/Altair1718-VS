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

namespace InterfazUsuario
{
    public partial class Login : Form
    {

        Usuario usu;

        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string texto = String.Empty;

            if (txbUsuario.ForeColor == Color.Gray || txbUsuario.Text == String.Empty) 
            {
                texto = "El campo de usuario está vacío.\n";
                errorProvider1.SetError(txbUsuario, "El campo está vacío.");
                txbPass.Text = String.Empty;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
