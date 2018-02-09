using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenoideWin
{
    public partial class Form1 : Form
    {
        private int altura;
        private int numpuntos;
        private Graphics grafica;

        public Form1()
        {
            InitializeComponent();
            this.numpuntos = this.PanelDibujo.Size.Width;
            this.grafica = this.PanelDibujo.CreateGraphics();
            for (double num = 0.5; num <= 4.0; num += 0.5)
            {
                this.cbGrosor.Items.Add(num);
            }
            this.cbGrosor.SelectedIndex = 4;
            this.BackColor = Color.White;
            this.altura = this.PanelDibujo.Height / 2;
        }

        private void PanelDibujo_Paint(object sender, PaintEventArgs e)
        {
            
        }


        private void lbColorTrazo_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.lbColorTrazo.BackColor = this.colorDialog1.Color;
            this.lbColorTrazo2.ForeColor = this.lbColorTrazo.BackColor;
        }

        private void chbBlanco_CheckedChanged(object sender, EventArgs e)
        {
            if (chbBlanco.Checked)
            {
                PanelDibujo.BackColor = Color.White;
            }
        }

        private void chbNegro_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNegro.Checked)
            {
                PanelDibujo.BackColor = Color.Black;
            }
        }

        private void chbVerde_CheckedChanged(object sender, EventArgs e)
        {
            if (chbVerde.Checked)
            {
                PanelDibujo.BackColor = Color.Lime;
            }
        }

        private void chbAzul_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAzul.Checked)
            {
                PanelDibujo.BackColor = Color.Blue;
            }
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            float width = Convert.ToSingle(this.cbGrosor.SelectedItem);
            Pen pen = new Pen(this.colorDialog1.Color, width);
            this.grafica.DrawLine(new Pen(this.colorDialog1.Color), new Point(0, this.altura), new Point(this.PanelDibujo.Width, this.altura));
            double num = Convert.ToDouble(this.nudCiclos.Value);
            double num2 = 3.1415926535897931 * Convert.ToDouble(this.nudDesfase.Value) / 180.0;
            int num3 = Convert.ToInt32(this.altura * this.nudOffset.Value / 400m);
            Point[] array = new Point[this.numpuntos];
            int num4 = this.trkbAmplitud.Value * this.altura / 400;
            for (int i = 0; i < this.numpuntos; i++)
            {
                int y = this.altura - num3 - Convert.ToInt32((double)num4 * Math.Sin(num2 + (double)i * num * 2.0 * 3.1415926535897931 / (double)this.numpuntos));
                array[i] = new Point(i, y);
            }
            this.grafica.DrawLines(pen, array);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.grafica.Clear(this.BackColor);
        }
    }
}