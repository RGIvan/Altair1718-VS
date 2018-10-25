using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rellenar_Click(object sender, EventArgs e)
        {

        }

        private void vaciar_Click(object sender, EventArgs e)
        {
            Graphics gp = Pane1.CreateGraphics();
            gp.Clear(Color.GhostWhite);
        }

        private void lineas_Click(object sender, EventArgs e)
        {
            Graphics lineas = Pane1.CreateGraphics();
            Pen pluma2 = new Pen(Color.Red, 3);
            Point punto1 = new Point(10, 10);
            Point punto2 = new Point(10, 100);
            Point punto3 = new Point(200, 50);
            Point punto4 = new Point(250, 300);
            Point[] puntos = { punto1, punto2, punto3, punto4 };
            lineas.DrawLines(pluma2, puntos);
        }

        private void linea_Click(object sender, EventArgs e)
        {
            Graphics linea = Pane1.CreateGraphics();
            Pen pluma1 = new Pen(Color.Red, 3);
            linea.DrawLine(pluma1, 0, 0, Pane1.Width, Pane1.Height);
        }

        private void rec_Click(object sender, EventArgs e)
        {
            Graphics rec = Pane1.CreateGraphics();
            Pen pluma3 = new Pen(Color.Red, 3);
            rec.DrawRectangle(pluma3, 130, 20, 400, 300);
        }

        private void pol_Click(object sender, EventArgs e)
        {
            Graphics pol = Pane1.CreateGraphics();
            Pen pluma4 = new Pen(Color.Red, 3);
            Point puntopol1 = new Point(50, 50);
            Point puntopol2 = new Point(100, 25);
            Point puntopol3 = new Point(200, 5);
            Point puntopol4 = new Point(250, 50);
            Point puntopol5 = new Point(300, 100);
            Point puntopol6 = new Point(350, 200);
            Point puntopol7 = new Point(250, 250);
            Point[] puntospol = { puntopol1, puntopol2, puntopol3, puntopol4, puntopol5, puntopol6 };
            pol.DrawPolygon(pluma4, puntospol);
        }
    }
}