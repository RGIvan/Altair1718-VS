using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectangulo
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
            Graphics grafico = e.Graphics;

            Pen penNegro = new Pen(Color.Black, 2);

            int margenX = ClientSize.Width / 20;
            int margenY = ClientSize.Height / 20;
            int xIzquierda = margenX;
            int xDerecha = ClientSize.Width - margenX;
            int ySuperior = margenY;
            int yInferior = ClientSize.Height - margenY;
            int ancho = ClientSize.Width / 2;
            int alto = ClientSize.Height / 2;

            Point pSupIz = new Point(xIzquierda, ySuperior);
            Point pSupde = new Point(xDerecha, ySuperior);
            Point pInfIz = new Point(xIzquierda, yInferior);
            Point pInfDe = new Point(xDerecha, yInferior);

            grafico.DrawLine(penNegro, pSupIz, pSupde); 
            grafico.DrawLine(penNegro, pSupde, pInfDe); 
            grafico.DrawLine(penNegro, pInfDe, pInfIz); 
            grafico.DrawLine(penNegro, pInfIz, pSupIz);

            Rectangle rect = new Rectangle(xIzquierda, ySuperior, ancho, alto);
        }
    }
}
