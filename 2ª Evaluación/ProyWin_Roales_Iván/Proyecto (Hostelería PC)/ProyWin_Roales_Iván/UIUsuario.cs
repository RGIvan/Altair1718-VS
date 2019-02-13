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

        #endregion

        private void UIUsuario_Load(object sender, EventArgs e)
        {
            CargarDGV();
            dgv.Columns[0].DisplayIndex = dgv.Columns.Count - 1;
            dgv.Columns["idusuario"].Visible = false;
        }

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
            if (DialogResult.No == MessageBox.Show("¿Está seguro de eliminar a:\n" + dgv.Rows[fila].Cells["usuario"].Value.ToString() + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                return;
            {

                if (LNyAD.BuscarAdministrador().Count == 1 && usu.Acceso == 1)
                {
                    MessageBox.Show("No se puede borrar al único administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    int idUsuario = Convert.ToInt32(dgv.Rows[fila].Cells[2].Value);
                    LNyAD.BorrarUsuario(idUsuario);
                    CargarDGV();
                }
            }
        }

        private void EditarRegistro(int fila)
        {
            int idUsuario = Convert.ToInt32(dgv.Rows[fila].Cells[2].Value);

            FormUsuario fusuario = new FormUsuario();

            fusuario.btnCrear.Hide();

            fusuario.ShowDialog();

            fusuario.Dispose();
        } 
        #endregion

        #region tsb

        private void tsbAnadirUsuario_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();

            FormUsuario fusuario = new FormUsuario();

            fusuario.btnEditar.Hide();

            fusuario.ShowDialog();

            fusuario.Dispose();
        } 
        #endregion

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDGV()
        {
            if (usu.Acceso == 1)
            {
                dgv.DataSource = LNyAD.TablaUsuarios();
            }

            else

            {
                dgv.DataSource = LNyAD.TablaUsuarios(usu.IdUsuario);
                tsbAnadirUsuario.Visible = false;
                dgv.Columns["del"].Visible = false;
            }
        }
    }
}