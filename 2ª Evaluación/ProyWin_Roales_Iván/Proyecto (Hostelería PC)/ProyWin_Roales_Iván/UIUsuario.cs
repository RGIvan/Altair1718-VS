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

        Producto pro;

        public Producto Pro
        {
            get
            {
                return pro;
            }

            set
            {
                pro = value;
            }
        }

        Restaurante res;

        public Restaurante Res
        {
            get
            {
                return res;
            }

            set
            {
                res = value;
            }
        } 
        #endregion

        public UIUsuario()
        {
            InitializeComponent();
        }

        #region Cells
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int colum = e.ColumnIndex;
            int fila = e.RowIndex;

            if (colum == 1)
                EditarRegistroProducto(fila);
            else if (dgv.Columns[colum].HeaderText == "Del")
                BorrarRegistroProducto(fila);
            else
                return;
        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int colum = e.ColumnIndex;
            int fila = e.RowIndex;

            if (colum == 1)
                EditarRegistroRestaurante(fila);
            else if (dgv2.Columns[colum].HeaderText == "Del")
                BorrarRegistroRestaurante(fila);
            else
                return;
        } 
        #endregion

        #region Editar Registro
        private void EditarRegistroUsuario(int fila)
        {

        }

        private void EditarRegistroProducto(int fila)
        {

        }

        private void EditarRegistroRestaurante(int fila)
        {

        } 
        #endregion

        #region Borrar Registro
        private void BorrarRegistroProducto(int fila)
        {
            if (DialogResult.No == MessageBox.Show("¿Está seguro de eliminar a:\n" + dgv.Rows[fila].Cells["nombre"].Value.ToString() + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                return;

            int idProducto = Convert.ToInt32(dgv.Rows[fila].Cells[2].Value);
            LNyAD.BorrarProducto(idProducto);
        }

        private void BorrarRegistroRestaurante(int fila)
        {
            if (DialogResult.No == MessageBox.Show("¿Está seguro de eliminar a:\n" + dgv.Rows[fila].Cells["nombre"].Value.ToString() + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                return;

            int idRestaurante = Convert.ToInt32(dgv.Rows[fila].Cells[2].Value);
            LNyAD.BorrarRestaurante(idRestaurante);
        }

        private void BorrarRegistroUsuario(int fila)
        {

        }
        #endregion

        #region tsb
        private void tsbRestaurante_Click(object sender, EventArgs e)
        {
            dgv2.DataSource = LNyAD.TablaRestaurante();
            dgv2.Columns["idRestaurante"].Visible = false;
            dgv2.Columns[3].HeaderText = "NIF";
            dgv2.Columns[4].HeaderText = "Descripción";
            dgv2.Columns[5].HeaderText = "Ciudad";
            dgv2.Columns[6].HeaderText = "Teléfono";
            dgv2.Columns[7].HeaderText = "Nombre";
            dgv2.Columns[0].DisplayIndex = dgv2.Columns.Count - 1;
            dgv.Visible = false;
            dgv2.Visible = true;
        }

        private void tsbProductos_Click(object sender, EventArgs e)
        {
            dgv.DataSource = LNyAD.TablaProducto();
            dgv.Columns["idProducto"].Visible = false;
            dgv.Columns[3].HeaderText = "Nombre";
            dgv.Columns[4].HeaderText = "Precio";
            dgv.Columns[5].HeaderText = "Cantidad";
            dgv.Columns[6].HeaderText = "idRestaurante";
            dgv.Columns[0].DisplayIndex = dgv.Columns.Count - 1;
            dgv2.Visible = false;
            dgv.Visible = true;
        } 
        #endregion

        private void UIUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}