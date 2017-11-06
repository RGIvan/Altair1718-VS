using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Clases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (txtClase.Text != ""){
                richTextBox.Text = " public class " + txtClase.Text + " {\n ";
            }

            for (int i = 0; i < dataGridView.RowCount -1 ; i++)
            {
                richTextBox.Text += dataGridView.Rows[i].Cells[0].Value;
                richTextBox.Text += " " + dataGridView.Rows[i].Cells[1].Value + ";\n";
            }

            for (int i = 0; i < dataGridView.RowCount-1; i++)
            {

            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }
    }
}
