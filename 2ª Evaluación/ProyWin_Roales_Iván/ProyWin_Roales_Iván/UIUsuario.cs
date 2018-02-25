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
    public partial class UIUsuario : Form
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

        public UIUsuario()
        {
            InitializeComponent();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsbRestaurante_Click(object sender, EventArgs e)
        {
            dgv.DataSource = LNyAD.TablaRestaurante();
            dgv.Columns["idRestaurante"].Visible = false;
            dgv.Columns[3].HeaderText = "NIF";
            dgv.Columns[4].HeaderText = "Descripción";
            dgv.Columns[5].HeaderText = "Ciudad";
            dgv.Columns[6].HeaderText = "Teléfono";
            dgv.Columns[7].HeaderText = "Nombre del restaurante";
            dgv.Columns[0].DisplayIndex = dgv.Columns.Count - 1;
        }

        private void tsbProductos_Click(object sender, EventArgs e)
        {
            dgv.DataSource = LNyAD.TablaProducto();
            dgv.Columns["idProducto"].Visible = false;
            dgv.Columns[3].HeaderText = "Nombre del producto";
            dgv.Columns[4].HeaderText = "Precio";
            dgv.Columns[5].HeaderText = "Cantidad";
            dgv.Columns[6].HeaderText = "idRestaurante";
            dgv.Columns[0].DisplayIndex = dgv.Columns.Count - 1;
        }

        private void tsbUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void UIUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
