using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wd1a_GestionBDAlumnosFP.DataSet1TableAdapters;

namespace wd1a_GestionBDAlumnosFP
{
    public partial class Form1 : Form
    {

        //Crea el adaptador de tabla
        GruposTableAdapter gruposAdapt = new GruposTableAdapter();

        //Crea la tabla 
        DataSet1.GruposDataTable gruposTabla = new DataSet1.GruposDataTable();

        
        public Form1()
        {
            InitializeComponent();

            // Cargamos la tabla Grupos
            gruposAdapt.Fill(gruposTabla);
            gruposTabla = gruposAdapt.GetData();
        }
    }
}
