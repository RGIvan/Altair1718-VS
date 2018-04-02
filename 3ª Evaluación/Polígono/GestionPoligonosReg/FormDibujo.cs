using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPoligonosReg
{
    public partial class FormDibujo : Form
    {
        const double PI = Math.PI;
        float grosor = 2;
        Color color = Color.Black;
        int radio = 100;
        int numlados = 5;
        int cordx = 275;
        int cordy = 275;
        int giro = 0;
        Graphics grap;
        public FormDibujo()
        {
            InitializeComponent();
            grap = panelDibujo.CreateGraphics();
        }

        private void FormDibujo_Load(object sender, EventArgs e)
        {
            for (double i = 1; i < 4; i += 0.5)
            {
                cbGrosor.Items.Add(i);
            }
            cbGrosor.SelectedItem = 2;
            cbGrosor.Text = "2";
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            Pen lapiz = new Pen(color, grosor);
            Point[] tabVertices = new Point[numlados];
            double angulo = (360 / numlados) * PI / 180;
            for (int i = 0; i < tabVertices.Length; i++)
            {
                tabVertices[i] = new Point(cordx + (int)(radio * Math.Cos(i * angulo)), cordy + (int)(radio * Math.Sin(i * angulo)));
            }


            grap.DrawPolygon(lapiz, tabVertices);

        }

        private void cbGrosor_SelectedIndexChanged(object sender, EventArgs e)
        {
            grosor = Convert.ToSingle(cbGrosor.Text);
        }

        private void nudNumLados_ValueChanged(object sender, EventArgs e)
        {
            numlados = (int)nudNumLados.Value;
        }

        private void trackRadio_Scroll(object sender, EventArgs e)
        {
            radio = trackRadio.Value;
            txtRadio.Text = radio.ToString();
        }

        private void rbColor_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton pulsado = (RadioButton)sender;
            switch (pulsado.Name)
            {

                case "rbNegro":
                    color = rbNegro.ForeColor;
                    break;

                case "rbVerde":
                    color = rbVerde.ForeColor;
                    break;

                case "rbAzul":
                    color = rbAzul.ForeColor;
                    break;

                case "rbRojo":
                    color = rbRojo.ForeColor;
                    break;
            }
            lbColor.BackColor = color;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            grap.Clear(Color.White);
        }

        private void trackY_Scroll(object sender, EventArgs e)
        {
            cordy = trackY.Maximum - trackY.Value;
            lbCoord.Text = "(" + cordx + ", " + trackY.Value + ")";
        }

        private void trackX_Scroll(object sender, EventArgs e)
        {
            cordx = trackX.Value;
            lbCoord.Text = "(" + cordx + ", " + trackY.Value + ")";
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            color = colorDialog.Color;
            lbColor.BackColor = color;
            if (color == rbNegro.ForeColor)
            {
                rbNegro.Checked = true;
            }
            else if (color == rbAzul.ForeColor)
            {
                rbAzul.Checked = true;
            }
            else if (color == rbVerde.ForeColor)
            {
                rbVerde.Checked = true;
            }
            else if (color == rbRojo.ForeColor)
            {
                rbRojo.Checked = true;
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Pen lapiz = new Pen(color, grosor);
            Point[] tabVertices = new Point[numlados];
            double angulo = (360 / numlados) * PI / 180;
            for (int i = 0; i < tabVertices.Length; i++)
            {
                tabVertices[i] = new Point(cordx + (int)(radio * Math.Cos(i * angulo)), cordy + (int)(radio * Math.Sin(i * angulo)));
            }


            grap.DrawPolygon(lapiz, tabVertices);

            for (int i = 0; i < tabVertices.Length; i++)
            {
                for (int j = i+1; j < tabVertices.Length; j++)
                {
                    grap.DrawLine(lapiz, tabVertices[i], tabVertices[j]);
                }
            }
        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {
            Brush brocha = new SolidBrush(color);
            Point[] tabVertices = new Point[numlados];
            double anguloB = (360 / numlados) * PI / 180;
            for (int i = 0; i < tabVertices.Length; i++)
            {
                tabVertices[i] = new Point(cordx + (int)(radio * Math.Cos(i * anguloB)), cordy + (int)(radio * Math.Sin(i * anguloB)));
            }

            grap.FillPolygon(brocha, tabVertices);
        }

        private void txtRadio_TextChanged(object sender, EventArgs e)
        {
            string valorString = txtRadio.Text;
            if(valorString == "") {
                valorString = "0";
            }
            int valor = Convert.ToInt32(valorString);
            if (valor > 250 || valor < 0)
            {
                MessageBox.Show("El valor debe ser entre 0 y 250", "Entre 0 y 250", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRadio.Text = radio.ToString();
            }
            else {
                radio = valor;
                txtRadio.Text = valor.ToString();
                trackRadio.Value = valor;
            }
        }
        private void txtRadio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)){
                e.Handled = false;
            }
            else {
                e.Handled = true;
                MessageBox.Show("Solo números entre 0 y 250", "Solo números", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panelDibujo_MouseClick(object sender, MouseEventArgs e)
        {
            trackX.Value = e.X;
            trackY.Value = 500 - e.Y;
            cordy = e.Y;
            cordx = e.X;
            lbCoord.Text = "(" + e.X + ", " + e.Y + ")";
        }
    }
}