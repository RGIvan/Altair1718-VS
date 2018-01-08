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
        Graphics grfx;
        Point posRaton;
        
        public FormDibujo()
        {
            InitializeComponent();
        }

        private void trackRadio_ValueChanged(object sender, EventArgs e)
        {
            txtRadio.Text = trackRadio.Value.ToString();
        }

        private void FormDibujo_Load(object sender, EventArgs e)
        {

            for (float i = 0.5F; i<=4; i+=0.5F)
            {
                cbGrosor.Items.Add(i);
            }
            cbGrosor.SelectedItem = 2.0F;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            lbColor.BackColor = colorDialog.Color;
        }

        private void rbNegro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNegro.Checked)
            {
                lbColor.BackColor = Color.Black;
            }else if (rbVerde.Checked)
            {
                lbColor.BackColor = Color.Lime;
            }else if (rbRojo.Checked)
            {
                lbColor.BackColor = Color.Red;
            }
            else if (rbAzul.Checked)
            {
                lbColor.BackColor = Color.Blue;
            }
        }

        private void trackGiro_ValueChanged(object sender, EventArgs e)
        {
            txtGiro.Text = trackGiro.Value.ToString();
        }

        private void panelDibujo_MouseClick(object sender, MouseEventArgs e)
        {
            posRaton = new Point(e.X, e.Y);
            trackX.Value = e.X;
            trackY.Value = 500-e.Y;
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            grfx = panelDibujo.CreateGraphics();
            grfx.Clear(panelDibujo.BackColor);
        
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(lbColor.BackColor, (float)cbGrosor.SelectedItem);
            grfx = panelDibujo.CreateGraphics();

            Point[] tabPuntos = new Point[(int)nudNumLados.Value];

            Point centro = new Point(trackX.Value, 500-trackY.Value);

            int radio = trackRadio.Value;
            int angulo = 2 * (int)(Math.PI / (int)nudNumLados.Value); 

            for (int i = 0; i < tabPuntos.Length; i++)
            {
                tabPuntos[i].X = trackX.Value + (int)(trackRadio.Value * Math.Cos(i * (2 * Math.PI / ((int)nudNumLados.Value)) + (trackGiro.Value * Math.PI / 180)));
                tabPuntos[i].Y = (550 - trackY.Value) + (int)(trackRadio.Value * Math.Sin(i * (2 * Math.PI / ((int)nudNumLados.Value)) + (trackGiro.Value * Math.PI / 180)));
            }

            grfx.DrawPolygon(pen, tabPuntos);
        }

        private void txtRadio_TextChanged(object sender, EventArgs e)
        {
            if(txtRadio.Text != "")
            {
                if (Convert.ToInt32(txtRadio.Text) >= 250)
                    txtRadio.Text = "250";

                else if (Convert.ToInt32(txtRadio.Text) < 0)
                    txtRadio.Text = "0";
                trackRadio.Value = Convert.ToInt32(txtRadio.Text);

            }
            else
                txtRadio.Text = "0";
        }

        private void txtGiro_TextChanged(object sender, EventArgs e)
        {
            if (txtGiro.Text != "")
            {
                if (Convert.ToInt32(txtGiro.Text) >= 90)
                    txtGiro.Text = "90";

                else if (Convert.ToInt32(txtGiro.Text) < 0)
                    txtGiro.Text = "0";
                trackGiro.Value = Convert.ToInt32(txtGiro.Text);

            }
            else
                txtGiro.Text = "0";
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(lbColor.BackColor, (float)cbGrosor.SelectedItem);
            Point[] tabPuntos = new Point[(int)nudNumLados.Value];

            grfx = panelDibujo.CreateGraphics();
            Point centro = new Point(trackX.Value, 500 - trackY.Value);
            int radio = trackRadio.Value;
            int angulo = 2 * (int)(Math.PI / (int)nudNumLados.Value);

            for (int i = 0; i < tabPuntos.Length; i++)
            {
                tabPuntos[i].X = trackX.Value + (int)(trackRadio.Value * Math.Cos(i * (2 * Math.PI / ((int)nudNumLados.Value)) + (trackGiro.Value * Math.PI / 180)));
                tabPuntos[i].Y = (550 - trackY.Value) + (int)(trackRadio.Value * Math.Sin(i * (2 * Math.PI / ((int)nudNumLados.Value)) + (trackGiro.Value * Math.PI / 180)));
            }

            for (int i = 0; i < nudNumLados.Value; i++)
            {
                for (int b = 0; b < nudNumLados.Value; b++)
                {
                    grfx.DrawLine(pen, tabPuntos[i], tabPuntos[b]);
                }

            }
        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(lbColor.BackColor, (float)cbGrosor.SelectedItem);
            Point[] tabPuntos = new Point[(int)nudNumLados.Value];

            for (int i = 0; i < tabPuntos.Length; i++)
            {
                tabPuntos[i].X = trackX.Value + (int)(trackRadio.Value * Math.Cos(i * (2 * Math.PI / ((int)nudNumLados.Value)) + (trackGiro.Value * Math.PI / 180)));
                tabPuntos[i].Y = (550 - trackY.Value) + (int)(trackRadio.Value * Math.Sin(i * (2 * Math.PI / ((int)nudNumLados.Value)) + (trackGiro.Value * Math.PI / 180)));
            }

            SolidBrush color = new SolidBrush(lbColor.BackColor);
            grfx.FillPolygon(color, tabPuntos);
        }
    }
}
