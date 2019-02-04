using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp_3_MantenimientoDeEstado
{
    public partial class Web1_EstadoSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Recupero la fecha y la hora de inicio de sesión
            lblHoraInicio.Text = Application["horainicio"].ToString();

            if (Session["horaInicio"] == null)
                Session["horaInicio"] = DateTime.Now;

            lbInicioSesion.Text = Session["horaInicio"].ToString();
        }

        protected void imgBtnPass_Click(object sender, ImageClickEventArgs e)
        {
            // Estado de Sesión
            Session["nombre"] = txbNombre.Text;
            Session["apellidos"] = txbApellidos.Text;

            Response.Redirect("Web2_EstadoDeVista.aspx");
        }
    }
}