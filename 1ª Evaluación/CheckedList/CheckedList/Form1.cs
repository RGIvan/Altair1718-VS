using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            
        }

        private void rbtnUnClic_CheckedChanged(object sender, EventArgs e)
        {
            checkedListBox1.CheckOnClick = true;
        }

        private void rbtnDosClics_CheckedChanged(object sender, EventArgs e)
        {
            checkedListBox1.CheckOnClick = false;
        }

        private void ordenAlfabetico_CheckedChanged(object sender, EventArgs e)
        {
            if (ordenAlfabetico.Checked)
            {
                checkedListBox1.Sorted = true;
            }else
            {
                checkedListBox1.Sorted = false;
            }
        }

        private void multiColumn_CheckedChanged(object sender, EventArgs e)
        {
            if (multiColumn.Checked)
            {
                checkedListBox1.MultiColumn = true;
            }
            else
            {
                checkedListBox1.MultiColumn = false;
            }
        }
    }
}
