using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConectaPuntos1
{
    public partial class Form1 : Form
    {
        List<Point> listaPuntos = new List<Point>();
        Pen lapiz = new Pen(Color.Black);
        int intervalo = 3, cont=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // inicializamos la tabla
            listaPuntos.Clear();
            Invalidate();
            // Guardamos la posición actual del ratón
            listaPuntos.Add(new Point(e.X, e.Y));
            //numPtos++;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // si cuando muevo el ratón no tengo el botón izquierdo pulsado, me salgo
            if (e.Button != MouseButtons.Left)
                return;

            if (cont % intervalo == 0)
            {
                // En caso contrario, guardamos la posición actual del ratón e incrementamso numPuntos
                listaPuntos.Add(new Point(e.X, e.Y));

                // Opcional: voy a mostrar "el punto"
                Graphics grf = CreateGraphics();
                grf.DrawLine(Pens.Black, e.X, e.Y, e.X, e.Y + 1);
            }
            cont++;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics grf = CreateGraphics();

            for (int i = 0; i < listaPuntos.Count - 1; i++)
                for (int j = i + 1; j < listaPuntos.Count; j++)
                    grf.DrawLine(lapiz, listaPuntos[i], listaPuntos[j]);

            grf.Dispose();
        }
    }
}
