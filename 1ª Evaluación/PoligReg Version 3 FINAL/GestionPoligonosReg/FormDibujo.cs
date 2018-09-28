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

        Graphics grfx;
        Point mousePos;
        Color color = Color.Black;
        int radio = 100, coordX = 250, coordY = 250, giro = 0;
        double escala = 550.0 / 500;
       
        public FormDibujo()
        {
            InitializeComponent();
        }

        private void FormDibujo_Load_1(object sender, EventArgs e)
        {
            for (float i = 1F; i <= 4; i += 0.5F)
            {
                cbGrosor.Items.Add(i);
            }
            cbGrosor.SelectedItem = 2.0F;
            grfx = panelDibujo.CreateGraphics();
        }

        //-------------------eje X e Y--------------------
        private void panelDibujo_MouseClick(object sender, MouseEventArgs e)
        {
            mousePos = new Point(e.X, e.Y);
            coordX = e.X;
            coordY = e.Y;
            trackX.Value = (int)(e.X * escala);
            trackY.Value = 550 - (int)(e.Y * escala);
            txtXcentro.Text = trackX.Value.ToString();
            txtYcentro.Text = trackY.Value.ToString();
        }

        private void trackX_Scroll(object sender, EventArgs e)
        {
            //Así estaba antes lbCoord.Text = "(" + trackX.Value + "," + trackY.Value + ")";
            txtXcentro.Text = trackX.Value.ToString();
            coordX = (int)(trackX.Value / escala);

        }
        private void trackY_Scroll(object sender, EventArgs e)
        {
            //Así estaba antes lbCoord.Text = "(" + trackX.Value + "," + trackY.Value + ")";
            txtYcentro.Text = trackY.Value.ToString();
            coordY = 500 - (int)(trackY.Value / escala);
        }

        //------------------TXTBOX EJE X e Y (EXTRA)-----------
       

        private void btnSincronizar_Click(object sender, EventArgs e)
        {
            trackX.Value = Convert.ToInt32(txtXcentro.Text);
            trackY.Value = Convert.ToInt32(txtYcentro.Text);

            txtXcentro.BackColor = txtYcentro.BackColor = Color.LawnGreen;
            coordX = (int)(trackX.Value / escala);
            coordY = 500 - (int)(trackY.Value / escala);
        }

        private void txtXcentro_Leave(object sender, EventArgs e)
        {
            int nuevoXcentro = CambiaTextBox(txtXcentro, 550, trackX.Value);
            if (nuevoXcentro > -1)
            {
                if (trackX.Value != nuevoXcentro)
                    txtXcentro.BackColor = Color.Red;
                else
                    txtXcentro.BackColor = Color.LawnGreen;
            }
            else
            {
                txtXcentro.Text = (trackX.Value * escala).ToString();
                txtXcentro.BackColor = Color.LawnGreen;
            }
        }

        private void txtYcentro_Leave(object sender, EventArgs e)
        {
            int nuevoYcentro = CambiaTextBox(txtYcentro, 550, trackY.Value);
            if (nuevoYcentro > -1)
            {
                if (trackY.Value != nuevoYcentro)
                    txtYcentro.BackColor = Color.Red;
                else
                    txtYcentro.BackColor = Color.LawnGreen;
            }
            else
            {
                txtYcentro.Text = (trackY.Value * escala).ToString();
                txtYcentro.BackColor = Color.LawnGreen;
            }
        }

        //---------------RADIO-----------------
        private void trackRadio_ValueChanged(object sender, EventArgs e)
        {
            radio = trackRadio.Value;
            txtRadio.Text = trackRadio.Value.ToString();
        }

        private void txtRadio_Leave(object sender, EventArgs e)
        {
            int nuevoRadio = CambiaTextBox(txtRadio, 250, radio);
            if (nuevoRadio > -1)
            {
                radio = nuevoRadio;
                trackRadio.Value = radio;
            }
        }




        //-------------GIRO---------------


        private void txtGiro_Leave(object sender, EventArgs e)
        {
            int nuevoGiro = CambiaTextBox(txtGiro, 90, giro);
            if (nuevoGiro > -1)
            {
                giro = nuevoGiro;
                trackGiro.Value = giro;
            }
        }

        private void trackGiro_Scroll(object sender, EventArgs e)
        {
            giro = trackGiro.Value;
            txtGiro.Text = trackGiro.Value.ToString();
        }
        //----------------COLOR-------------------


        private void rbNegro_Click(object sender, EventArgs e)
        {
            RadioButton botonPulsado = (RadioButton)sender;
            switch (botonPulsado.Name)
            {
                case "rbNegro":
                    color = Color.Black;
                    break;
                case "rbRojo":
                    color = Color.Red;
                    break;
                case "rbVerde":
                    color = Color.Green;
                    break;
                case "rbAzul":
                    color = Color.Blue;
                    break;
            }
            lbColor.BackColor = color;
        }


        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            rbNegro.Checked = false;
            rbRojo.Checked = false;
            rbVerde.Checked = false;
            rbAzul.Checked = false;
            color = colorDialog.Color;
            lbColor.BackColor = color;
            //if(color==Color.Black || color == Color.Red || color == Color.Green || color == Color.Blue)
            if(color== Color.Black)
                rbNegro.Checked = true;
            else if (color == Color.Red)
                rbRojo.Checked = true;
            else if (color == Color.Green)
                rbVerde.Checked = true;
            else if (color == Color.Blue)
                rbAzul.Checked = true;

        }

        private void rbNegro_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton botonPulsado = (RadioButton)sender;
            switch (botonPulsado.Name)
            {
                case "rbNegro":
                    color = Color.Black;
                    break;
                case "rbRojo":
                    color = Color.Red;
                    break;
                case "rbVerde":
                    color = Color.Green;
                    break;
                case "rbAzul":
                    color = Color.Blue;
                    break;

            }
            lbColor.BackColor = color;
        }
       

       
        //------------Dibujar Vertice--------------
        private void btnDibujar_Click(object sender, EventArgs e)
        {
            if (txtXcentro.BackColor == Color.Red || txtYcentro.BackColor == Color.Red)
            {
                MessageBox.Show("Las coordenadas no están sincronizadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                
            Pen pen = new Pen(lbColor.BackColor, (float)cbGrosor.SelectedItem);
            
            
            Point[] tabPoints = new Point[(int)nudNumLados.Value];

            int radius = trackRadio.Value;
            int angle = 2 * (int)(Math.PI / (int)nudNumLados.Value);

            for (int i = 0; i < tabPoints.Length; i++)
            {

                tabPoints[i].X = coordX + (int)(trackRadio.Value * Math.Cos(i * (2 * Math.PI / ((int)nudNumLados.Value)) + (trackGiro.Value * Math.PI / 180)));
                tabPoints[i].Y = coordY + (int)(trackRadio.Value * Math.Sin(i * (2 * Math.PI / ((int)nudNumLados.Value)) + (trackGiro.Value * Math.PI / 180)));
            }

            grfx.DrawPolygon(pen, tabPoints);
        }

       
        
        //-------------Unir vertices de poligono---------------
        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (txtXcentro.BackColor == Color.Red || txtYcentro.BackColor == Color.Red)
            {
                MessageBox.Show("Las coordenadas no están sincronizadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Pen pen = new Pen(lbColor.BackColor, (float)cbGrosor.SelectedItem);
         


            Point centre = new Point(trackX.Value, 500 - trackY.Value);
            Point[] tabPoints = new Point[(int)nudNumLados.Value];

            int radius = trackRadio.Value;
            int angle = 2 * (int)(Math.PI / (int)nudNumLados.Value);

            for (int i = 0; i < tabPoints.Length; i++)
            {

                tabPoints[i].X = coordX + (int)(trackRadio.Value * Math.Cos(i * (2 * Math.PI / ((int)nudNumLados.Value)) + (trackGiro.Value * Math.PI / 180)));
                tabPoints[i].Y = coordY + (int)(trackRadio.Value * Math.Sin(i * (2 * Math.PI / ((int)nudNumLados.Value)) + (trackGiro.Value * Math.PI / 180)));

            }
            for (int i = 0; i < nudNumLados.Value; i++)
            {
                for (int b = 0; b < nudNumLados.Value; b++)
                {
                    grfx.DrawLine(pen, tabPoints[i], tabPoints[b]);
                }

            }
        }

        private void txtXcentro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYcentro_TextChanged(object sender, EventArgs e)
        {

        }

        //--------------Rellenar Poligono--------------
        private void btnRellenar_Click(object sender, EventArgs e)
        {
            if (txtXcentro.BackColor == Color.Red || txtYcentro.BackColor == Color.Red)
            {
                MessageBox.Show("Las coordenadas no están sincronizadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Pen pen = new Pen(lbColor.BackColor, (float)cbGrosor.SelectedItem);
            Point[] tabPoints = new Point[(int)nudNumLados.Value];

            for (int i = 0; i < tabPoints.Length; i++)
            {
                tabPoints[i].X = coordX + (int)(trackRadio.Value * Math.Cos(i * (2 * Math.PI / ((int)nudNumLados.Value)) + (trackGiro.Value * Math.PI / 180)));
                tabPoints[i].Y = coordY + (int)(trackRadio.Value * Math.Sin(i * (2 * Math.PI / ((int)nudNumLados.Value)) + (trackGiro.Value * Math.PI / 180)));
            }

            SolidBrush color = new SolidBrush(lbColor.BackColor);
            grfx.FillPolygon(color, tabPoints);
        }




        //--------------borrar panel--------------
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes==MessageBox.Show("¿Estás seguro de borrar el dibujo?","Copnfirmar",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2))
                grfx.Clear(panelDibujo.BackColor);
        }



     

       
         //----------------METODO PARA COMPROBAR TEXTO-----------------------
        int CambiaTextBox(TextBox tb, int maxValor, int valorAnterior)
        {
            int nuevoValor;
            bool esCorrecto = Int32.TryParse(tb.Text, out nuevoValor);
            if (esCorrecto)
            {
                if (nuevoValor < 0 || nuevoValor > maxValor)
                {
                    MessageBox.Show("Tiene que ser un entero entre 0 y " + maxValor, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb.Text = valorAnterior.ToString();
                    return -1;
                }
                else
                {
                    return nuevoValor;
                }
            }
            else
            {
                MessageBox.Show("Tiene que ser un entero entr 0 y " + maxValor, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRadio.Text = valorAnterior.ToString();
                return -1;
            }
        }

    }
}
    
            
