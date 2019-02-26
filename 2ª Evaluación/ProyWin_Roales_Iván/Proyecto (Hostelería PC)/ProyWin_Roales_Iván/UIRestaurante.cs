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
    public partial class UIRestaurante : Form
    {
        #region Propiedades
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

        public UIRestaurante()
        {
            InitializeComponent();
        }

        #region Cells
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int colum = e.ColumnIndex;
            int fila = e.RowIndex;

            if (colum == 1)
                EditarRegistro(fila);
            else if (dgv.Columns[colum].HeaderText == "Del")
                BorrarRegistro(fila);
            else
                return;
        }
        #endregion

        #region Registros
        private void BorrarRegistro(int fila)
        {
            if (DialogResult.No == MessageBox.Show("¿Está seguro de eliminar a:\n" + dgv.Rows[fila].Cells["nombre"].Value.ToString() + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                return;

            int idRestaurante = Convert.ToInt32(dgv.Rows[fila].Cells[2].Value);
            LNyAD.BorrarRestaurante(idRestaurante);
        }

        private void EditarRegistro(int fila)
        {
            int idRestaurante = Convert.ToInt32(dgv.Rows[fila].Cells[2].Value);
            Restaurante res = LNyAD.ObtenerRestaurantePorId(idRestaurante);

            FormRestaurante fusuario = new FormRestaurante();

            fusuario.btnRegistro.Hide();

            fusuario.ShowDialog();

            fusuario.Dispose();
        } 
        #endregion

        #region tsb

        private void tsbAnadirUsuario_Click(object sender, EventArgs e)
        {
            Producto res = new Producto();

            FormProducto fproducto = new FormProducto();

            fproducto.btnEditar.Hide();

            fproducto.ShowDialog();

            fproducto.Dispose();
        } 
        #endregion

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UIUsuario_Load(object sender, EventArgs e)
        {
            dgv.DataSource = LNyAD.TablaRestaurante();
            dgv.Columns["idRestaurante"].Visible = false;
            dgv.Columns[3].HeaderText = "Nombre";
            dgv.Columns[4].HeaderText = "Precio";
            dgv.Columns[5].HeaderText = "Cantidad";
            dgv.Columns[0].DisplayIndex = dgv.Columns.Count - 1;
        }
    }
}