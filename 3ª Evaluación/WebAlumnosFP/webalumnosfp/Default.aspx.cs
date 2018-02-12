using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicaNegocioyADatos;
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
            }

            CargaAlumnosGrupo();
        }

        private void CargaCombo()
        {
            List<Grupo> listaTodosMasGrupos = LNyAD.ListaGrupos();

            listaTodosMasGrupos.Insert(0, new Grupo(0, "Todos los grupos", "todos"));

            ddlGrupos.DataSource = listaTodosMasGrupos;
            ddlGrupos.DataTextField = "Nombre";
            ddlGrupos.DataValueField = "IDGrupo";

            ddlGrupos.DataBind();
        }


        private void CargaAlumnosGrupo()
        {
            int idGrupo = Convert.ToInt32(ddlGrupos.SelectedValue);
            bool sonTodos = (idGrupo == 0);

            dgv.DataSource = LNyAD.TablaAlumnos(idGrupo);
        }



        protected void btnAnyadir_Click(object sender, EventArgs e)
        {

            Response.Redirect("PaginaDetalleAlumno.aspx");

        }

        protected void dgv_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void dgv_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
    }
}