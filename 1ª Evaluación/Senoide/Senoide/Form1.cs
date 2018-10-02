using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Senoide
{
    public partial class Form1 : Form
    {
        Graphics grafico;
        public Form1()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            grafico = this.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);
            Point[] puntos = new Point[ClientSize.Width];

            int x = 0, y = 0;

            for (x = 0; x < ClientSize.Width; x++)
            {
                y =ClientSize.Height/2 - (int)(200 *Math.Sin(x*4*Math.PI/ ClientSize.Width));
                puntos[x] = new Point(x, y); // con el +50 estoy desplazando la figura a la derecha 50 pixeles 

                //puntos[x] = new Point(x+50, y); // con el +50 estoy desplazando la figura a la derecha 50 pixeles 
            }

            // eje horizontal
            grafico.DrawLine(new Pen(Color.Red), 0, ClientSize.Height / 2, ClientSize.Width, ClientSize.Height / 2);
            // eje vertical
            grafico.DrawLine(new Pen(Color.Red), 0, 0, 0, ClientSize.Height);

            grafico.DrawLines(lapiz, puntos);
        }
    }
}
