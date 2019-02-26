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
    public partial class IUAlumnos : Form
    {
        // Construimos los adaptadores y tablas que necesitamos


        //** ATENCIÓN: otra forma de hacerlo
        // Construyo el objeto formulario detalle (fDetalle) que voy a usar en toda la aplicación
        IUDetalleAlumno fDetalle = new IUDetalleAlumno();

        bool comboCargardo = false;
        public IUAlumnos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cargamos los combos
            CargaCombos();

            // Cargamos la tabla de alumnos
            CargaAlumnosGrupo();

            // Vamos a añadir la columna del botón de borrar (btnBorrar) una vez cargado el dgv
            // Primero la construimos...
            DataGridViewButtonColumn btnBorrar = new DataGridViewButtonColumn();
            btnBorrar.Width = 40;
            btnBorrar.HeaderText = "Del";
            btnBorrar.ToolTipText = "Eliminar Registro";
            btnBorrar.Text = "X";
            btnBorrar.UseColumnTextForButtonValue = true;

            // LO QUE SIGUE HAY QUE PENSARLO: Dónde coloco la columna del botón borrar
            //... Y luego la añadimos al dgv
            dgv.Columns.Add(btnBorrar);
        }

        private void CargaCombos()
        {
            // Como ya hemos construido el fDetalle, podemos cargar los dos combos "del tirón:)"
            // Importante: para poder cargar el combo del fDetalle hay que cambiar su modificador de acceso
            // Con una sola lectura de la BD llenamos dos listas y enlazamos cada combo a la suya.

            List<Grupo> listaGrupos = LNyAD.ListaGrupos();
            List<Grupo> listaTodosMasGrupos = new List<Grupo>(listaGrupos);
            // Inserto en primer lugar el "grupo Todos"
            listaTodosMasGrupos.Insert(0, new Grupo(0, "", "Todos los grupos")); // <-- Cargo este grupo ficticio para que salga en primer lugar

            // Enlazamos los combos a sus respectivas listas
            // Pongo la lista "listaTodosMasGrupos" como origen de datos del combo del principal
            cbGrupos.DataSource = listaTodosMasGrupos;
            cbGrupos.DisplayMember = "Nombre"; // <-- Indicamos qué propiedad se va a mostrar
            cbGrupos.ValueMember = "IdGrupo";// <-- Indicamos qué propiedad se va a guardar en Value

            fDetalle.cbGruposDetalle.DataSource = listaGrupos;
            fDetalle.cbGruposDetalle.DisplayMember = "Nombre"; // <-- Indicamos qué propiedad se va a mostrar
            fDetalle.cbGruposDetalle.ValueMember = "IdGrupo";// <-- Indicamos qué propiedad se va a guardar en Value

            comboCargardo = true;
        }

        private void cbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboCargardo)
                CargaAlumnosGrupo();
        }

        void CargaAlumnosGrupo()
        {
            // inicialmente actuamos como en la versión anterior
            int idGrupo = (int)cbGrupos.SelectedValue;

            dgv.DataSource = LNyAD.TablaAlumnos(idGrupo);

            // Ocultábamos las columnas de id's
            dgv.Columns["idAlumno"].Visible = false;
            dgv.Columns["idGrupo"].Visible = false;
            // Si es un grupo concreto oculto la columna Grupo porque ya aparece en la cabecera
            dgv.Columns["Grupo"].Visible = (idGrupo==0);

            lbCabecera.Text = String.Format("Alumnos de {0} ({1} alumnos)", cbGrupos.Text, dgv.RowCount);
        }


        // Controlaremos el evento que me dice qué botón hemos pulsado.
        // Si no es el de editar ni el de borrar, no hago nada
        // Si es el de editar llamaré a un método «EditarRegistro» que actúe en consecuencia
        // Si es el de borrar llamo a un método «BorrarRegistro» 
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int colum = e.ColumnIndex;
            int fila = e.RowIndex;
            if (colum == 0) // <-- he pulsado el botón Editar
                EditarRegistro(fila);
            else if (dgv.Columns[colum].HeaderText == "Del")// <-- he pulsado el botón Borrar
                BorrarRegistro(fila);
            else
                return;
        }

        /* BorrarRegistro. Una forma de actuar:
        ● Confirmo que quiero borrar al alumno concreto
        ● Obtengo el id del alumno que quiero eliminar
        ● LLamo a un método de LNyAD que elimine realmente el registro
*/
        private void BorrarRegistro(int fila)
        {
            if (DialogResult.No == MessageBox.Show("¿Está seguro de eliminar a:\n" + dgv.Rows[fila].Cells["apellidosNombre"].Value.ToString() + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                return;
            // obtengo el id del alumno que quiero editar
            int idAlumno = Convert.ToInt32(dgv.Rows[fila].Cells["idAlumno"].Value);

            LNyAD.EliminarAlumno(idAlumno);

            // como hemos usado la opción de borrar directamente de la BD tengo que recargar el dgv
            CargaAlumnosGrupo();
            dgv.ClearSelection();
        }

        /* EditarRegistro. Una forma de actuar:
            ● Obtengo el id del alumno que quiero editar
        */
        private void EditarRegistro(int fila)
        {
            // obtengo el id del alumno que quiero editar
            int idAlumno = Convert.ToInt32(dgv.Rows[fila].Cells["idAlumno"].Value);

            // Construimos el alumnos a editar
            Alumno alum = LNyAD.ObtenerAlumno(idAlumno);
            // Asigno el alumno a la propiedad del FormDetalle
            fDetalle.Alum = alum;

            if (fDetalle.ShowDialog() == DialogResult.OK)
            {
                LNyAD.ActualizarAnyadirRegistro(alum);
            }

        }


        private void btnAnadir_Click(object sender, EventArgs e)
        {
            // Construimos el alumnos a editar
            Alumno alum = new Alumno();
            // Asigno el alumno a la propiedad del FormDetalle
            fDetalle.Alum = alum;
            if (fDetalle.ShowDialog() == DialogResult.OK)
            {
                LNyAD.ActualizarAnyadirRegistro(alum);
                // Para que aparezca el idAlumno real de la BD volvemos a cargar la tabla
                // además mostrará, si es el caso, el Alias del grupo
                CargaAlumnosGrupo();
            }

        }

    }
}
