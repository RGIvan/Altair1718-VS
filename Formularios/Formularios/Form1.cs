using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }


        private void miTexto(object sender, PaintEventArgs e)
        {
            Graphics grfx = e.Graphics;

            string texto = "ClientSizeClientSizeClientSize";

            Font fuente = this.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            Brush brocha = new SolidBrush(Color.Black);

            //Random azar = new Random();

            //int r = azar.Next(255),

            //    g = azar.Next(255),

            //    b = azar.Next(255);

            //grfx.Clear(Color.FromArgb(r,g,b));



            float x = ClientSize.Width / 2,

                  y = ClientSize.Height / 2;

            StringFormat formato = new StringFormat();

            formato.Alignment = StringAlignment.Center;

            formato.LineAlignment = StringAlignment.Center;

            grfx.DrawString(texto, fuente, brocha, x, y, formato);
        }
    }
}
