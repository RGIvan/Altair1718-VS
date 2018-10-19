using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPoligonosReg
{
    public partial class FormDibujo : Form
    {

        public FormDibujo()
        {
            InitializeComponent();
        }

        private void FormDibujo_Load(object sender, EventArgs e)
        {
            for (double i = 1; i < 4; i += 0.5)
            {
                cbGrosor.Items.Add(i);
            }

            cbGrosor.SelectedItem = 2;
            cbGrosor.Text = "2";
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            
        }

        private void rbNegro_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            
        }

        private void trackY_Scroll(object sender, EventArgs e)
        {
            
        }

        private void trackX_Scroll(object sender, EventArgs e)
        {
            
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {
            
        }

        private void panelDibujo_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void trackRadio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtRadio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
