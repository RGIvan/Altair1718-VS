using LogicaNegocioyADatos;
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
<<<<<<< HEAD
=======

            CargaAlumnosGrupo();
>>>>>>> a15c4e1838895338c99de307af6206cc774984f7
        }

        private void CargaCombo()
        {
            List<Grupo> listaTodosMasGrupos = LNyAD.ListaGrupos();
<<<<<<< HEAD
=======

            listaTodosMasGrupos.Insert(0, new Grupo(0, "Todos los grupos", "todos"));

            ddlGrupos.DataSource = listaTodosMasGrupos;
            ddlGrupos.DataTextField = "Nombre";
            ddlGrupos.DataValueField = "IDGrupo";

            ddlGrupos.DataBind();
>>>>>>> a15c4e1838895338c99de307af6206cc774984f7
        }


        private void CargaAlumnosGrupo()
        {

        }



        protected void btnAnyadir_Click(object sender, EventArgs e)
        {

            Response.Redirect("PaginaDetalleAlumno.aspx");

        }
    }
}