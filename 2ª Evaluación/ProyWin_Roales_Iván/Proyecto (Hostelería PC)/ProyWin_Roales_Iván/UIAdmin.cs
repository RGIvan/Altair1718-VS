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
    public partial class UIAdmin : Form
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

        public UIAdmin()
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

            int idUsuario = Convert.ToInt32(dgv.Rows[fila].Cells[2].Value);
            LNyAD.BorrarUsuario(idUsuario);
        }

        private void EditarRegistro(int fila)
        {
            int idUsuario = Convert.ToInt32(dgv.Rows[fila].Cells[2].Value);
            Usuario usu = LNyAD.ObtenerUsuarioPorId(idUsuario);

            EditUsuarioAdmin fEditUsuario = new EditUsuarioAdmin();

            fEditUsuario.ShowDialog();

            fEditUsuario.Dispose();
        } 
        #endregion

        #region tsb
        private void tsbUsuario_Click(object sender, EventArgs e)
        {
            dgv.DataSource = LNyAD.TablaUsuarios();
            dgv.Columns["idUsuario"].Visible = false;
            dgv.Columns[3].HeaderText = "Usuario";
            dgv.Columns[4].HeaderText = "Contraseña";
            dgv.Columns[5].HeaderText = "Nombre";
            dgv.Columns[6].HeaderText = "Apellidos";
            dgv.Columns[7].HeaderText = "Acceso";
            dgv.Columns[0].DisplayIndex = dgv.Columns.Count - 1;
        }

        private void tsbAnadirUsuario_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();

            AnadirUsuario fAnadirUsuario = new AnadirUsuario();

            fAnadirUsuario.ShowDialog();

            fAnadirUsuario.Dispose();
        } 
        #endregion

        private void UIUsuario_Load(object sender, EventArgs e)
        {
            
        }
    }
}