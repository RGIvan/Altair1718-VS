using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormFrase
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
            StringFormat formato = new StringFormat();

            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            grafico.DrawString("Hola", this.Font, new SolidBrush(Color.Red), ClientSize.Width /2, ClientSize.Height /2, formato);

            formato.Alignment = StringAlignment.Far;
            formato.LineAlignment = StringAlignment.Near;
            grafico.DrawString("Hola", this.Font, new SolidBrush(Color.Red), ClientSize.Width, 0 , formato);

            formato.Alignment = StringAlignment.Near;
            formato.LineAlignment = StringAlignment.Near;
            grafico.DrawString("Hola", this.Font, new SolidBrush(Color.Red), 0, 0, formato);

            formato.Alignment = StringAlignment.Far;
            formato.LineAlignment = StringAlignment.Far;
            grafico.DrawString("Hola", this.Font, new SolidBrush(Color.Red), ClientSize.Width, ClientSize.Height, formato);
        }
    }
}
