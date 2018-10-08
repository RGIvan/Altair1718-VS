using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estrella
{
    public partial class Form1 : Form
    {
        int numVertices = 5;
        bool bRellenar;
        double anguloGiro;
        Graphics grafico;
        Point[] tablaPuntos;
        Point centro;
        Brush brochaAzul;
        Pen penNegro;

        public Form1()
        {
            InitializeComponent();
            this.ResizeRedraw = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)

        {
            grafico = e.Graphics;
            penNegro = new Pen(Color.Black, 2);
            brochaAzul = new SolidBrush(Color.Blue);
            tablaPuntos = new Point[numVertices];
            centro = new Point(ClientSize.Width / 2, ClientSize.Height / 2);

            int margenX = ClientSize.Width / 20;
            int margenY = ClientSize.Height / 20;
            int ancho = ClientSize.Width - 2 * margenX;
            int alto = ClientSize.Height - 2 * margenY;
            double anguloBase = 2 * Math.PI / numVertices;
            int radio;

            if (ancho < alto)
                radio = ancho / 2;
            else
                radio = alto / 2;

            for (int i = 0; i < tablaPuntos.Length; i++)

            {
                tablaPuntos[i].X = centro.X + (int)(radio * Math.Cos(i * anguloBase * 2 + anguloGiro));
                tablaPuntos[i].Y = centro.Y + (int)(radio * Math.Sin(i * anguloBase * 2 + anguloGiro));
            }

            if (ClientSize.Width < ClientSize.Height)
                grafico.DrawPolygon(penNegro, tablaPuntos);
            else 
                grafico.FillPolygon(brochaAzul, tablaPuntos);

            if (bRellenar)
                grafico.FillPolygon(brochaAzul, tablaPuntos, FillMode.Winding);
            else
                grafico.FillPolygon(brochaAzul, tablaPuntos, FillMode.Alternate);
        }

        private void btnRellenar_Click(object sender, EventArgs e)

        {
            bRellenar =! bRellenar;

            if (bRellenar)
                btnRellenar.Text = "Vaciar";
            else
                btnRellenar.Text = "Rellenar";

            Invalidate();
        }

        private void btnGirar_Click(object sender, EventArgs e)

        {
            anguloGiro += Convert.ToInt32(txtGiro.Text) * Math.PI / 180;
            Invalidate();
        }
    }
}
