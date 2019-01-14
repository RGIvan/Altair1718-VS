using LogicaNegocioYAccesoDatos;
using LogicaNegocioYAccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUPacientes
{
    public partial class IUPacientes : Form
    {
        bool comboCargado = false;
        IUDetalle fDetalle = new IUDetalle();
        public IUPacientes()
        {
            InitializeComponent();
        }

        private void IUPacientes_Load(object sender, EventArgs e)
        {
            CargaCombos();
            CargaPacientesProvincia();
            DataGridViewButtonColumn btnBorrar = new DataGridViewButtonColumn();

            btnBorrar.HeaderText = "Del";
            btnBorrar.ToolTipText = "Borrar Registro";
            btnBorrar.Text = "X";
            btnBorrar.Width = 40;
            btnBorrar.UseColumnTextForButtonValue = true;

            dgv.Columns.Add(btnBorrar);


        }

        private void CargaPacientesProvincia()
        {
            byte idProvincia = (byte)cbProvincias.SelectedValue;
            dgv.DataSource = LNyAD.TablaPacientes(idProvincia);
            //idProvincia, idPaciente ni el domicilio.
            dgv.Columns["idProvincia"].Visible = false;
            dgv.Columns["idPaciente"].Visible = false;
            dgv.Columns["domicilio"].Visible = false;

            dgv.Columns["Provincia"].Visible = (idProvincia == 0);

            lbCabecera.Text = String.Format("{0} Pacientes", dgv.RowCount);
            dgv.ClearSelection();
        }

        private void CargaCombos()
        {
            List<Provincia> listaProvincias = LNyAD.ListaProvincias();
            List<Provincia> listaTodasProvincias = new List<Provincia>(listaProvincias);

            listaTodasProvincias.Insert(0, new Provincia(0, "Andalucía", 0));

            cbProvincias.DataSource = listaTodasProvincias;
            cbProvincias.DisplayMember = "nombre";
            cbProvincias.ValueMember = "idProvincia";

            fDetalle.cbProvinciasDetalle.DataSource = listaProvincias;
            fDetalle.cbProvinciasDetalle.DisplayMember = "nombre";
            fDetalle.cbProvinciasDetalle.ValueMember = "idProvincia";


            comboCargado = true;
        }

        private void cbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCargado)
                CargaPacientesProvincia();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            int columna = e.ColumnIndex;

            if (columna == 0)
                EditarPaciente(fila);
            else if (dgv.Columns[columna].HeaderText == "Del")
                BorrarPaciente(fila);
            else
                return;
        }

        private void EditarPaciente(int fila)
        {
            int idPaciente = Convert.ToInt32(dgv.Rows[fila].Cells["idPaciente"].Value);
            Paciente paciente = LNyAD.ObtenerPaciente(idPaciente);
            fDetalle.Paciente = paciente;
            if (fDetalle.ShowDialog()==DialogResult.OK)
            {
                LNyAD.ActualizarYAnyadirRegistro(paciente);
            }


        }

        private void BorrarPaciente(int fila)
        {
            string nombrePaciente = dgv.Rows[fila].Cells["nombPaciente"].Value.ToString();
            if (DialogResult.No == MessageBox.Show("¿está seguro que desea borrar los datos del paciente: \n" + nombrePaciente + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                return;

            int idPaciente = Convert.ToInt32(dgv.Rows[fila].Cells["idPaciente"].Value);
            LNyAD.EliminarPaciente(idPaciente);
            CargaPacientesProvincia();

        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();

            fDetalle.Paciente = paciente;
            if (fDetalle.ShowDialog() == DialogResult.OK)
            {
                LNyAD.ActualizarYAnyadirRegistro(paciente);
                CargaPacientesProvincia();
            }
        }
    }
}
