﻿using System;
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
        Usuario usuarioDentro;

        public Usuario UsuarioDentro
        {
            get
            {
                return usuarioDentro;
            }

            set
            {
                usuarioDentro = value;
            }
        }
        #endregion

        private void UIUsuario_Load(object sender, EventArgs e)
        {
            CargarDGV();
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

            int idUsuario = Convert.ToInt32(dgv.Rows[fila].Cells[2].Value);
            LNyAD.BorrarUsuario(idUsuario);
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
            
        }
    }
}