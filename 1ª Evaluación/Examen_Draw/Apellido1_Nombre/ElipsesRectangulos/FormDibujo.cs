//Alumno:
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
            int y0 = panelDibujo.Height - tracY.Value;

            int x = x0 - ejeX / 2;
            int y = y0 - ejeY / 2;

            pizarra = panelDibujo.CreateGraphics();
            color = lbColor.BackColor;

            Pen boli = new Pen(color, Convert.ToInt32(cbGrosor.Text));
            Brush brocha = new SolidBrush(color);

            Rectangle r = new Rectangle(x0, y0, ejeX, ejeY);

            if (rbRectang.Checked)
            {
                pizarra.DrawRectangle(boli, r);

                if (chbRellenar.Checked)
            
                pizarra.FillRectangle(brocha, r);
            }

            else if (rbElipse.Checked)
            {
                pizarra.DrawEllipse(boli, r);

                if (chbRellenar.Checked)
                {
                    pizarra.FillEllipse(brocha, r);
                }
            }
        }

        private void panelDibujo_MouseClick(object sender, MouseEventArgs e)
        {
            tracX.Value = e.X;
            tracY.Value = 450 - e.Y;

            txbX.Text = tracX.Value.ToString();
            txbY.Text = tracY.Value.ToString();
        }

        private void tracEjeX_Scroll(object sender, EventArgs e)
        {
            txbLong.Text = tracEjeX.Value.ToString();
        }

        private void btnIgualaEjes_Click(object sender, EventArgs e)
        {
            if (txbLong.BackColor == Color.Blue)
            {
                nudEjeY.Value = Convert.ToDecimal(txbLong.Text);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("¿Quieres borrar el panel?", "Confirmar", MessageBoxButtons.YesNo);

            if (d == DialogResult.Yes)
            {
                pizarra.Clear(Color.White);
            }
        }
    }
}
