using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using LogicaNegocioyADatos; // No se te olvide AGREGAR REFERENCIA al proyecto LogicaNegocioyADatos
using LogicaNegocioyADatos.Entidades;

namespace WebAlumnosFP
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CargaCombo();
                CargaAlumnosGrupo();
            }

        }

        private void CargaCombo()
        {
            List<Grupo> listaTodosMasGrupos = LNyAD.ListaGrupos();

            // Inserto en primer lugar el "grupo 0"
            listaTodosMasGrupos.Insert(0, new Grupo(0, "Todos los grupos", "todos"));

            // Enlazo el combo del panelControles con la listaTodosMasGrupos
            ddlGrupos.DataSource = listaTodosMasGrupos;		// Origen de datos
            ddlGrupos.DataTextField = "Nombre";	// Campo asociado a Display "Text"
            ddlGrupos.DataValueField = "IDGrupo";	// Campo asociado a Valúe "no se verá"

            // y en los proyectos web es necesaria esta línea para realizar el enlace
            ddlGrupos.DataBind();
        }

        private void CargaAlumnosGrupo()
        {
            // Tomo el id del grupo a partir del elemento seleccionado del combo
            int idGrupo = Convert.ToInt32(ddlGrupos.SelectedValue);
            bool sonTodos = (idGrupo == 0);

            // Asociamos el datagrid a la tabla de alumnos correspondiente
            dgv.DataSource = LNyAD.TablaAlumnos(idGrupo);
            // y en los proyectos web es necesaria esta línea para realizar el enlace
            dgv.DataBind();
            //---- ocultamos las columnas de id
            // Ocultamos o mostramos la columna de Grupo según convenga:
            // Si son todos (idGrupo == 0) se mostrará
            // Si no -------- NO se mostrará
            // dgv.Columns[1].Visible = false;  //** esto no funciona AQUÍ en Web
            // Hay que hacerlo celda a celda, pero...
            // ** SI ENCUENTRAS UNA FORMA MEJOR, SERÁS RECOMPENSADO :)**
            // Ocultar cabeceras
            dgv.HeaderRow.Cells[1].Visible = false; // la de idAlumno
            dgv.HeaderRow.Cells[2].Visible = false; // la de idGrupo
            dgv.HeaderRow.Cells[3].Visible = sonTodos; // la de Grupo
            // Ocultar celdas
            foreach (GridViewRow fila in dgv.Rows)
            {
                fila.Cells[1].Visible = false; // la columna idAlumno
                fila.Cells[2].Visible = false; // la de idGrupo
                fila.Cells[3].Visible = sonTodos;// la de Grupo
            }


            // Actualizamos la etiqueta de cabecera
            lbCabecera.Text = String.Format("Alumnos de {0}.  ({1} alumnos)", ddlGrupos.SelectedItem.Text, dgv.Rows.Count);

        }

        protected void dgv_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            //----- Busco el alumno selecionado y borro el registro
            // Capturamos el idAlumnos del registro seleccionado del dgv 
            //                                      fila dgv    celda del idAlumno
            int idAlumno = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[1].Text);

            LNyAD.EliminarAlumno(idAlumno);

            CargaAlumnosGrupo();
        }


        protected void dgv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            
            // Capturamos el idAlumnos del registro seleccionado del dgv 
            //                                      fila dgv    celda del idAlumno
            int idAlumno = Convert.ToInt32(dgv.Rows[e.NewEditIndex].Cells[1].Text);

            // Obtengo el alumno correspondiente al id obtenido ya que no puedo acceder directamente al registro
            Alumno alumno = LNyAD.DevuelveAlumno(idAlumno);

            // Guardo el alumno en la variable de sesión
            Session["Alumno"] = alumno;

            Response.Redirect("PaginaDetalleAlumno.aspx");
        }

        protected void btnAnyadir_Click(object sender, EventArgs e)
        {
            Session["Alumno"] = new Alumno(-1, "", "", 0, "", "", "");

            Response.Redirect("PaginaDetalleAlumno.aspx");
        }


        protected void ddlGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaAlumnosGrupo();
        }
    }
}