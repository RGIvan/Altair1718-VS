using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelFiguras
{
    public partial class Form1 : Form

    {
        Color color = Color.Black;

        public Form1()

        {
            InitializeComponent();
            this.ResizeRedraw = true;
            this.MinimumSize = new Size(600, 300);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            int x = 300;
            int y = 20;
            Size clientSize = this.ClientSize;
            int width = clientSize.Width - 350;
            clientSize = this.ClientSize;
            int height = clientSize.Height - 40;

            Rectangle rect = new Rectangle(x, y, width, height);

            Pen pen = new Pen(this.color);

            Brush brush = new SolidBrush(this.color);

            if (this.cbRelleno.Checked)
            {
                if (this.rbElipse.Checked)
                    graphics.FillEllipse(brush, 300, 20, this.ClientSize.Width - 350, this.ClientSize.Height - 40);
                else
                    graphics.FillRectangle(brush, rect);
            }
            else if (this.rbElipse.Checked)
                graphics.DrawEllipse(pen, 300, 20, this.ClientSize.Width - 350, this.ClientSize.Height - 40);
            else
                graphics.DrawRectangle(pen, rect);
        }

        private void rbRojo_CheckedChanged(object sender, EventArgs e)

        {
            this.color = Color.Red;
            this.Invalidate();
        }

        private void rbAzul_CheckedChanged(object sender, EventArgs e)

        {
            this.color = Color.Blue;
            this.Invalidate();
        }

        private void rbVerde_CheckedChanged(object sender, EventArgs e)

        {
            this.color = Color.Green;
            this.Invalidate();
        }

        private void cbColores_CheckedChanged(object sender, EventArgs e)

        {
            this.gbColor.Visible = !this.gbColor.Visible;
        }

        private void cbRelleno_CheckedChanged(object sender, EventArgs e)

        {
            this.Invalidate();
        }

        private void rbRectangulo_CheckedChanged(object sender, EventArgs e)

        {
            this.Invalidate();
        }

        private void rbElipse_CheckedChanged(object sender, EventArgs e)

        {
            this.Invalidate();
        }
    }
}
