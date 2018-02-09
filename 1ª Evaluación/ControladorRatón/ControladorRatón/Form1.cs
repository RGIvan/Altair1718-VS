using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControladorRatón
{
    public partial class Form1 : Form
    {

        int RatonX = 0;
        int RatonY = 0;

        public Form1()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }


        private void onMouseMove(object sender, MouseEventArgs e)
        {
            Point pos = new Point(e.X, e.Y);

            RatonX = pos.X;
            RatonY = pos.Y;
            this.Invalidate();
            
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics grafico = e.Graphics;
            Pen pen = new Pen(Color.Black, 3);

            Point[] array = new Point[2];


            array[0].X = RatonX;
            array[0].Y = RatonY;

            array[1].X = panel1.Width / 2;
            array[1].Y = 0;

            array[2].X = panel1.Width / 2;
            array[2].Y = 0;


            grafico.DrawLines(pen, array);
        }
    }
}
