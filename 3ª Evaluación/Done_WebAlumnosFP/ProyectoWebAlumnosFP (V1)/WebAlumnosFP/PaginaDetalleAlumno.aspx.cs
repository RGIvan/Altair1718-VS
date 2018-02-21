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
    public partial class PaginaDetalleAlumno : System.Web.UI.Page
    {
        Alumno alum;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                CargaCombo();
                try
                {
                    alum = (Alumno)Session["Alumno"];
                    if (alum.IdAlumno != -1)
                        CargarControles();
                }
                catch
                {
                    Response.Redirect("Default.aspx");
                }
            }
        }

        private void CargaCombo()
        {
            List<Grupo> listaGrupos = LNyAD.ListaGrupos();

            // Enlazo el combo del panelControles con la listaTodosMasGrupos
            ddlGrupos.DataSource = listaGrupos;		// Origen de datos
            ddlGrupos.DataTextField = "Nombre";	// Campo asociado a Display "Text"
            ddlGrupos.DataValueField = "IDGrupo";	// Campo asociado a Valúe "no se verá"

            // y en los proyectos web es necesaria esta línea para realizar el enlace
            ddlGrupos.DataBind();
        }

        private void CargarControles()
        {
            //--- Actualizamos los controles del panelDetalle con los campos de dicho registro
            txbApellNom.Text = alum.ApellidosNombre;
            txbDNI.Text = alum.Dni;
            ddlGrupos.SelectedValue = alum.IdGrupo.ToString();// <-- seleccionamos el valor del combo
            txbMovil.Text = alum.Movil;
            txbTelefono.Text = alum.Telefono;
            txbMail.Text = alum.Email;
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            // Si hay error en los datos Me salgo
            if (!Page.IsValid)
                return;

            alum =new Alumno(((Alumno)Session["Alumno"]).IdAlumno,
                txbApellNom.Text,
                txbDNI.Text,
                Convert.ToInt32(ddlGrupos.SelectedValue),// <-- seleccionamos el valor del combo
                txbMovil.Text,
                txbTelefono.Text,
                txbMail.Text);

            if(alum.IdAlumno==-1)
                LNyAD.AddAlumno(alum);
            else
                LNyAD.ModificaAlumno(alum);

            Response.Redirect("Default.aspx");
        }
    }
}