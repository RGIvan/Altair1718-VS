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
        int numCiclos = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grfx = panel1.CreateGraphics();

            Point[] tabPuntos = new Point[panel1.Width];

            int x, y;

            int amlitud = panel1.Height / 2;

            for (x = 0; x < tabPuntos.Length; x++)

            {

                y = amlitud - (int)(amlitud * Math.Sin(x * numCiclos * 2 * Math.PI / 900));

                tabPuntos[x] = new Point(x, y);

            }

            grfx.DrawLines(new Pen(Color.Black, 2), tabPuntos);
        }
    }
}