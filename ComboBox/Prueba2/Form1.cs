using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba2
{
    public partial class Form1 : Form
    {
        List<Pintura> listaPinturas = new List<Pintura>();
        bool comboCargado = false;
        Color nuevoColor;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboCargado)
            //{
                lbColor.BackColor = ((Pintura)(cbColor.SelectedItem))._Color;
            //}

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaPinturas.Add(new Pintura(Color.Blue, "Azul", 4.0));
            listaPinturas.Add(new Pintura(Color.Red, "Rojo", 3.45));
            listaPinturas.Add(new Pintura(Color.Orange, "Naranja", 6.40));
            listaPinturas.Add(new Pintura(Color.Lime, "Verde", 4.15));


            // Enlazamos el combo a la lista
            //cbColor.DataSource = listaPinturas;
            //cbColor.DisplayMember = "Nombre"; // <-- Indicamos la propiedad que se verá
            //cbColor.ValueMember = "_Color"; // <-- Indicamos la propiedad que se guardará en value
            foreach (Pintura p in listaPinturas)
                cbColor.Items.Add(p);
            cbColor.DisplayMember = "Nombre"; // <-- Indicamos la propiedad que se verá


            cbColor.SelectedIndex = -1;
            cbColor.Text = "Selecciona un Color";
            comboCargado = true;

            nuevoColor = this.BackColor;
        }

        private void btnEligeColor_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == colorDialog1.ShowDialog())
            {
                btnEligeColor.BackColor = colorDialog1.Color;
                nuevoColor = colorDialog1.Color;
            }
        }
        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            double precio = 0;
            bool nombreOK = txtNombreColor.Text.Length > 0;
            bool precioOK = Double.TryParse(txtPrecio.Text, out precio);
            bool colorOk = (nuevoColor != this.BackColor);


            if (!nombreOK || !precioOK)
            {
                MessageBox.Show("Error","Hay error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            cbColor.Items.Add(new Pintura(nuevoColor, txtNombreColor.Text, precio));
        }
    }
}