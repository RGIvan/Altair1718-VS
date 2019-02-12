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
        }

        private void tsbUsuarios_Click(object sender, EventArgs e)
        {
            UIUsuario usu = new UIUsuario();
            this.Hide();
            usu.ShowDialog();
        }

        private void tsbProductos_Click(object sender, EventArgs e)
        {
            UIProducto usu = new UIProducto();
            this.Hide();
            usu.ShowDialog();
        }

        private void tsbRestaurante_Click(object sender, EventArgs e)
        {
            UIRestaurante usu = new UIRestaurante();
            this.Hide();
            usu.ShowDialog();
        }
    }
}
