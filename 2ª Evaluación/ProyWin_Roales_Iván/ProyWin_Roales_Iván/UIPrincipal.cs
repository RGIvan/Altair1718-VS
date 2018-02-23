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
    public partial class UIPrincipal : Form
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

        public UIPrincipal()
        {
            InitializeComponent();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsbUsuarios_Click(object sender, EventArgs e)
        {
            dgv.DataSource = LNyAD.TablaUsuarios();
            dgv.Columns["idUsuario"].Visible = false;
            dgv.Columns[2].HeaderText = "Nombre";
            dgv.Columns[3].HeaderText = "Apellidos";
            dgv.Columns[4].HeaderText = "Usuario";
            dgv.Columns[5].HeaderText = "Password";
            dgv.Columns[6].HeaderText = "Acceso";
            dgv.Columns[0].DisplayIndex = dgv.Columns.Count - 1;
        }
    }
}
