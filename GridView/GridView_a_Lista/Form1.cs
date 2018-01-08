using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GridView_a_Lista
{
    public partial class Form1 : Form
    {
        List<Equipo> listaEquipos = new List<Equipo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarFichero_Click(object sender, EventArgs e)
        {
            Equipo equipo;

            //Construir un StreamReader
            Stream myStream = null;
            StreamReader sr = null;

            //Abrimos el OpenFileDialog para elegir el fichero que nos interese
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog.OpenFile()) != null)
                {
                    try
                    {
                        //...Hacemos que el StreamReader se asocie al fichero seleccionado
                        //  Abrimos el fichero
                        sr = new StreamReader(myStream, Encoding.Default);

                        //  Lo recorremos capturando cada linea del fichero
                        clbAnadidos.Items.Clear(); // <-- Limpiamos la lista chequeable para recargarla
                        string linea;

                        while (!sr.EndOfStream)
                        {
                            linea = sr.ReadLine();
                            

                            if (linea.Length != 0)
                            {
                                // Construimos el equipo a partir de la linea
                                equipo = new Equipo(linea);
                                // Lo añadimos al chListBox: Hemos sobreescrito el .ToString() para esto
                                clbAnadidos.Items.Add(equipo);
                                // Lo añadimos a la lista de equipos
                                listaEquipos.Add(equipo);
                            }
                        }
                        lbAnadidos.Text = "Equipo        Pts Pg Pe Pp gf gc";
                        sr.Close();
                        dgv.DataSource = listaEquipos;

                        // centramos horizontalmente las columnas de datos numéricos
                        for (int i = 2; i < dgv.Columns.Count; i++)
                        {
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        }
                    }
                    catch
                    {
                        sr.Close();
                        MessageBox.Show("** El fichero elegido contiene errores de formato **", "Fallo de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;      //<-- ¿En qué fila he picado?
            if (fila < 0)
                return;
            int colum = e.ColumnIndex;  //<-- ¿En qué columna he picado?
            string[] tabCeldas = {"el botón", " el nombre","puntos", "partidos ganados", "partidos empatados", "partidos perdidos", "goles a favor", "goles en contra" };
            string nombrEquipo = dgv.Rows[fila].Cells[1].Value.ToString();
            string frase = "Ha pulsado en ";
            if (colum > 1)
                frase += "los " + dgv.Rows[fila].Cells[colum].Value.ToString() + " ";

            frase += tabCeldas[colum] + " del " + nombrEquipo;

            MessageBox.Show(frase, "Atención",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void btnOrdenarListaEquipos_Click(object sender, EventArgs e)
        {
            listaEquipos.Reverse();
            dgv.Refresh();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            clbAnadidos.Items.Clear();

            foreach (Equipo eq in listaEquipos)
            {
                clbAnadidos.Items.Add(eq);
            }
        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNombre.Checked) {

                listaEquipos.Sort((x, y) => string.Compare(x.Nombre, y.Nombre));
                dgv.Refresh();
            } 
        }

        private void rbPuntos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPuntos.Checked)
            {
                listaEquipos.Sort((x, y) => string.Compare(x.Puntos.ToString("00"), y.Puntos.ToString("00")));
                dgv.Refresh();
            }
        }
    }
}