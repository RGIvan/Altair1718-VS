using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConectaPuntos
{
    public partial class Form1 : Form
    {
        Point[] tabPuntos = new Point[1000];
        int numPuntos = 0;
        Pen lapiz = new Pen(Color.Black);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics grafico = CreateGraphics();

            for (int i = 0; i < numPuntos; i++)
            {
                for (int j = 0; j < numPuntos; j++)
                {
                    grafico.DrawLine(lapiz, tabPuntos[i], tabPuntos[j]);
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)

        {
            numPuntos = 0;
            Invalidate();

            tabPuntos[numPuntos++] = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)

        {
            if (e.Button != MouseButtons.Left)
            
            tabPuntos[numPuntos++] = new Point(e.X, e.Y);
        }
    }
}
