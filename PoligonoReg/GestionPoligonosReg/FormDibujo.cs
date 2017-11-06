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
         Graphics grafica;
        public FormDibujo()
        {
            InitializeComponent();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(lbColor.BackColor, (float)cbGrosor.SelectedItem);
            Point[] tabPuntos = new Point[(int)nudNumLados.Value];

            Point centro = new Point(trackX.Value, 500 - trackY.Value);
            int radio = trackRadio.Value;
            int angulo = 2 * (int)(Math.PI / (int)nudNumLados.Value);

            for (int i = 0; i < tabPuntos.Length; i++)
            {
                tabPuntos[i].X = trackX.Value + (int)(trackRadio.Value * Math.Cos(i * (2 * Math.PI / ((int)nudNumLados.Value)) + (trackGiro.Value * Math.PI / 180)));
                tabPuntos[i].Y = (550 - trackY.Value) + (int)(trackRadio.Value * Math.Sin(i * (2 * Math.PI / ((int)nudNumLados.Value)) + (trackGiro.Value * Math.PI / 180)));
            }

            grafica.DrawPolygon(pen, tabPuntos);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            this.lbColor.BackColor = this.colorDialog.Color;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿De verdad quieres borrar el fondo?", "Borrar fondo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                this.grafica.Clear(Color.White);
            }
        }

        private void rbNegro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNegro.Checked)
            {
                lbColor.BackColor = Color.Black;
            }
        }

        private void rbVerde_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVerde.Checked)
            {
                lbColor.BackColor = Color.Lime;
            }
        }

        private void rbRojo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRojo.Checked)
            {
                lbColor.BackColor = Color.Red;
            }
        }

        private void rbAzul_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAzul.Checked)
            {
                lbColor.BackColor = Color.Blue;
            }
        }

        private void panelDibujo_Click(object sender, MouseEventArgs e)
        {
            trackX.Value = 500 - e.Y;
            trackY.Value = e.X;
        }

        private void FormDibujo_Load(object sender, EventArgs e)
        {
            for (float num = 1.0F; num <= 4; num += 0.5F)
            {
                cbGrosor.Items.Add(num);
            }
            cbGrosor.SelectedItem = 2F;

            grafica = panelDibujo.CreateGraphics();
        }

        private void Caja(object sender, EventArgs e)
        {
            txtRadio.Text = trackRadio.Value.ToString();
        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {
            
        }
    }
}