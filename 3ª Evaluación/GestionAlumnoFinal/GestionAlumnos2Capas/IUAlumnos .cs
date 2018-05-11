using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LNegocioyADatos;
using LNegocioyADatos.Entidades;

namespace InterfazUsuario
{
    public partial class IUAlumno : Form
    {
        bool comboCargado = false;
        public IUAlumno()
        {
            InitializeComponent();
        }

        private void IUAlumno_Load(object sender, EventArgs e)
        {
            // cargando el combo
            List<Grupo> listaGrupos = LNyAD.ListaGrupos();
            listaGrupos.Insert(0, new Grupo(0, "Todos", "Todos los grupos"));

            cbGrupos.DataSource = listaGrupos;
            cbGrupos.DisplayMember = "nombre";
            cbGrupos.ValueMember = "idGrupo";
            comboCargado = true;

            CargaAlumnosGrupo();
            // añadimos la columna Borrar
            DataGridViewButtonColumn columBorrar = new DataGridViewButtonColumn();
            columBorrar.Text = "X";
            columBorrar.HeaderText = "Del";
            columBorrar.ToolTipText = "Eliminar registro";
            columBorrar.UseColumnTextForButtonValue = true;
            dgv.Columns.Add(columBorrar);

            // Ocultamos las columnas de id's
            dgv.Columns["idAlumno"].Visible = false;
            dgv.Columns["idGrupo"].Visible = false;
        }

        private void CargaAlumnosGrupo()
        {
            int idGrupo = Convert.ToInt32(cbGrupos.SelectedValue.ToString());

            dgv.DataSource = LNyAD.TablaAlumnos(idGrupo);

            // Cuando se trata de un grupo concreto no hace falta ver la columna del Alias
            dgv.Columns["Grupo"].Visible = (idGrupo == 0);

            lbCabecera.Text = "(" + dgv.RowCount + ") Alumnos de " + cbGrupos.Text;

        }

        private void cbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCargado)
            {
                CargaAlumnosGrupo();
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numColum = e.ColumnIndex;
            // si no es la primera columna (Editar) ni la última (Borrar)
            if (numColum != 0 && dgv.Columns[numColum].HeaderText!="Del")
                return;

            // Si llego aquí Me interesa la fila: ¿Qué fila se ha pulsado
            int numFila = e.RowIndex;

            if (numColum == 0) // estamos en Editar
            {
                // obtenemos el id del alumno
                int idAlum = Convert.ToInt32(dgv.Rows[numFila].Cells["idAlumno"].Value);

                Alumno alum = LNyAD.ObtenerAlumnoPorId(idAlum);

                IUDetalleAlumno formDetalle = new IUDetalleAlumno(alum);

                if (DialogResult.OK == formDetalle.ShowDialog())
                {
                    CargaAlumnosGrupo();
                }

            }
            else // estamos en Borrar ==> Confirmar borrado
            {
                if (DialogResult.No == MessageBox.Show("¿está seguro de eliminar a:\n" + dgv.Rows[numFila].Cells["apellidosNombre"].Value.ToString() + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    return;

                LNyAD.EliminarRegistro(Convert.ToInt32(dgv.Rows[numFila].Cells["idAlumno"].Value));
            }
            
            
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            Alumno alum = new Alumno();

            IUDetalleAlumno formDetalle = new IUDetalleAlumno(alum);

            if (DialogResult.OK == formDetalle.ShowDialog())
            {
                CargaAlumnosGrupo();
            }
        }
    }
}