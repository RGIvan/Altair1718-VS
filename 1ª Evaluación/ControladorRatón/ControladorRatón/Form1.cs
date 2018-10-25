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
        Point[] tabPuntos = new Point[16];
        Point posRaton;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 0;
            for (int x = 0; x < 5; x++)
            {
                tabPuntos[i++] = new Point(x * ClientSize.Width / 4, 0);
                tabPuntos[i++] = new Point(x * ClientSize.Width / 4, ClientSize.Height);
            }
            for (int y = 1; y < 4; y++)
            {
                tabPuntos[i++] = new Point(0, y * ClientSize.Height / 4);
                tabPuntos[i++] = new Point(ClientSize.Width, y * ClientSize.Height / 4);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                return;
            {
                posRaton = new Point(e.X, e.Y);
                Graphics graf = CreateGraphics();
                Pen lapiz = new Pen(Color.Black);
                graf.Clear(Color.White);

                for (int i = 0; i < tabPuntos.Length; i++)
                {
                    graf.DrawLine(lapiz, posRaton, tabPuntos[i]);
                }
            }
        }
    }
}
