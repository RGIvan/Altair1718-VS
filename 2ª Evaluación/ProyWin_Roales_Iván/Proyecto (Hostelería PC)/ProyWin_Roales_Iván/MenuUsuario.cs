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
    public partial class MenuUsuario : Form
    {
        #region Propiedades
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
        #endregion

        public MenuUsuario()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void tsbUsuarios_Click(object sender, EventArgs e)
        {
            this.Close();
            UIUsuario usu = new UIUsuario();
            usu.Show();
        }

        private void tsbProductos_Click(object sender, EventArgs e)
        {
            this.Close();
            UIProducto usu = new UIProducto();
            usu.Show();
        }

        private void tsbRestaurante_Click(object sender, EventArgs e)
        {
            this.Close();
            UIRestaurante usu = new UIRestaurante();
            usu.Show();
        }
    }
}
