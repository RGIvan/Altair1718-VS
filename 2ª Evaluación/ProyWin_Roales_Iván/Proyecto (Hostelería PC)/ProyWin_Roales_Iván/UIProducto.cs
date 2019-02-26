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
    public partial class UIProducto : Form
    {
        #region Propiedades
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
        #endregion

        public UIProducto()
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

            int idProducto = Convert.ToInt32(dgv.Rows[fila].Cells[2].Value);
            LNyAD.BorrarProducto(idProducto);
        }

        private void EditarRegistro(int fila)
        {
            int idProducto = Convert.ToInt32(dgv.Rows[fila].Cells[2].Value);
            Producto pro = LNyAD.ObtenerProductoPorId(idProducto);

            FormProducto fproducto = new FormProducto();

            fproducto.btnRegistro.Hide();

            fproducto.ShowDialog();

            fproducto.Dispose();
        }
        #endregion

        #region tsb
        private void tsbAnadirProducto_Click(object sender, EventArgs e)
        {
            Producto pro = new Producto();

            FormProducto fproducto = new FormProducto();

            fproducto.btnEditar.Hide();

            fproducto.ShowDialog();

            fproducto.Dispose();
        }

        #endregion

        private void UIUsuario_Load(object sender, EventArgs e)
        {
            dgv.DataSource = LNyAD.TablaProducto();
            dgv.Columns["idProducto"].Visible = false;
            dgv.Columns["idRestaurante"].Visible = false;
            dgv.Columns[3].HeaderText = "Nombre";
            dgv.Columns[4].HeaderText = "Precio";
            dgv.Columns[5].HeaderText = "Cantidad";
            dgv.Columns[0].DisplayIndex = dgv.Columns.Count - 1;
            dgv.Visible = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}