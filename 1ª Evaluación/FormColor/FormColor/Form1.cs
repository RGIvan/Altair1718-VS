using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grfx = e.Graphics;
            Random azar = new Random();
            int r = azar.Next(255);
            int g = azar.Next(254);
            int b = azar.Next(253);

            grfx.Clear(Color.FromArgb(r,g,b));
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Invalidate();
        }
    }
}
