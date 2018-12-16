//Plantilla examen
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ElipsesRectangulos
{
    public partial class FormDibujo : Form
    {
        Color color = Color.FromArgb(0, 0, 0);
        Graphics pizarra;

        public FormDibujo()
        {
            InitializeComponent();

            for (double i = 1; i <= 5; i += 0.5)
            {
                cbGrosor.Items.Add(i);
            }

            cbGrosor.SelectedItem = 2.0;

            nudEjeY.ReadOnly = true;
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            int ejeX = Convert.ToInt32(txbLong.Text);
            int ejeY = Convert.ToInt32(nudEjeY.Value);

            int x0 = tracX.Value;
            int y0 = tracY.Value - panelDibujo.Height;

            int x = x0 - ejeX / 2;
            int y = y0 - ejeY / 2;

            pizarra = panelDibujo.CreateGraphics();
            color = lbColor.BackColor;

            Pen boli = new Pen(color, Convert.ToSingle(cbGrosor.Text));
            Brush brocha = new SolidBrush(color);

            Rectangle r = new Rectangle(x, y, ejeX, ejeY);

            if (rbRectang.Checked)
            {
                pizarra.DrawRectangle(boli, r);
                if (chbRellenar.Checked)
                    pizarra.FillRectangle(brocha, r);

            } else if (rbElipse.Checked)

            {
                pizarra.DrawEllipse(boli, r);
                if (chbRellenar.Checked)
                {
                    pizarra.FillEllipse(brocha, r);
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Pregunta", "Confirmar", MessageBoxButtons.YesNo);
                
                if (d == DialogResult.Yes)
                {
                    pizarra.Clear(Color.White);
                }
        }

        private void btnIgualaEjes_Click(object sender, EventArgs e)
        {
            if (txbLong.BackColor == Color.Blue)
                nudEjeY.Value = Convert.ToDecimal(txbLong.Text);
        }

        private void chbEjeYmanual_Click(object sender, MouseEventArgs e)
        {
            if (chbEjeYmanual.Checked)
                nudEjeY.ReadOnly = false;
            else
                nudEjeY.ReadOnly = true;
        }

        private void btnActualizaEjeX_Click(object sender, EventArgs e)
        {
            tracEjeX.Value = Convert.ToInt32(txbLong.Text);

            if (txbLong.Text == tracEjeX.Value.ToString())
            {
                txbLong.BackColor = Color.Blue;
            }
        }

        private void tracEjeX_Scroll(object sender, EventArgs e)
        {
            txbLong.Text = tracEjeX.Value.ToString();
        }

        private void txbLong_TextChanged(object sender, EventArgs e)
        {
            if (tracEjeX.Value.ToString() == txbLong.Text)
                txbLong.BackColor = Color.Blue;
            else
                txbLong.BackColor = Color.Cyan;
        }

        private void lbColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            lbColor.BackColor = colorDialog.Color;
        }

        private void txbX_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txbY_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tracY_Scroll(object sender, EventArgs e)
        {
            txbY.Text = tracY.Value.ToString();
        }

        private void tracX_Scroll(object sender, EventArgs e)
        {
            txbX.Text = tracX.Value.ToString();
        }

        private void panelDibujo_MouseClick(object sender, MouseEventArgs e)
        {
            tracX.Value = e.X;
            tracY.Value = e.Y;

            txbX.Text = tracX.Value.ToString();
            txbY.Text = tracY.Value.ToString();
        }
    }
}