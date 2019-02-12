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
    public partial class MenuAdmin : Form
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

        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbUsuarios_Click(object sender, EventArgs e)
        {
            UIUsuario adminUsuario = new UIUsuario();
            this.Hide();
            adminUsuario.ShowDialog();
        }

        private void tsbProductos_Click(object sender, EventArgs e)
        {
            UIProducto adminProducto = new UIProducto();
            this.Hide();
            adminProducto.ShowDialog();
        }

        private void tsbRestaurante_Click(object sender, EventArgs e)
        {
            UIRestaurante adminRestaurante = new UIRestaurante();
            this.Hide();
            adminRestaurante.ShowDialog();
        }
    }
}
