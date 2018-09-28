using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WForm
{
    public partial class FormPrueba1 : Form
    {
        public FormPrueba1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txbCaja.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Elija un sexo, por favor", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            if (rgbMujer.Checked)
            {
                lbCabecera.BackColor = rgbMujer.BackColor;
                lbCabecera.Text = txbCaja.Text;
                lbCabecera.ForeColor = Color.Black;
            }

            else if (rgbHombre.Checked)
            {
                lbCabecera.BackColor = rgbHombre.BackColor;
                lbCabecera.Text = txbCaja.Text;
                lbCabecera.ForeColor = Color.White;
            }

        }

        private void FormPrueba1_DoubleClick(object sender, EventArgs e)
        {
            //DialogResult dr = colorDialog1.ShowDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            
            this.BackColor = colorDialog1.Color;
        }
    }
}
