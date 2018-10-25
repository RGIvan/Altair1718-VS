using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prac_ComboBox
{
    public partial class FormComboBox : Form
    {
        List<Equipo> listaEquipos = new List<Equipo>();
        bool comboCargado = false;

        public FormComboBox()
        {
            InitializeComponent();

        }

        private void FormComboBox_Load(object sender, EventArgs e)
        {
            foreach (Equipo p in listaEquipos)
                cbEquipos1.Items.Add(p);
            cbEquipos1.DisplayMember = "Nombre";
            cbEquipos1.SelectedIndex = -1;
            cbEquipos1.Text = "Selecciona un equipo";
        }

        #region ----- Zona del Combo enlazado a datos


        #endregion

        private void btnInsertar1_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar1_Click(object sender, EventArgs e)
        {

        }

        private void btnAbrir1_Click(object sender, EventArgs e)
        {
            string ruta, linea;
            if (opFileDlgAbrirArchivo.ShowDialog() != DialogResult.Cancel)
            {
                ruta = opFileDlgAbrirArchivo.FileName;
                StreamReader fOrigen = new StreamReader(ruta, Encoding.Default);

                while (!(fOrigen.EndOfStream))
                {
                    linea = fOrigen.ReadLine();
                    linea = linea.Trim();
                    if ((linea.Length > 1))
                    {
                        cbEquipos1.Items.Add(linea);
                    }
                }

                fOrigen.Close();
            }
        }

        private void cbEquipos1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbEquipos1.Text = ((Equipo)(cbEquipos1.SelectedItem)).Nombre;
        }
    }
}
