using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp_3_MantenimientoDeEstado
{
    public partial class Web4_CookiesXConsulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Muestro usuario por estado de sesión
                lblUsuario.Text = String.Format("{0} {1}", Session["nombre"], Session["apellidos"]);
            }

            if (Request.Cookies["cookies"] != null)
            {
                // Muestro las Cookies en su Label correspondiente
                lblCodPostal.Text = Server.HtmlEncode(Request.Cookies["cookies"]["codPostal"]);
                lblPoblacion.Text = Server.HtmlEncode(Request.Cookies["cookies"]["poblacion"]);
                lblEmail.Text = Server.HtmlEncode(Request.Cookies["cookies"]["email"]);
                lblFijo.Text = Server.HtmlEncode(Request.Cookies["cookies"]["fijo"]);
                lblMovil.Text = Server.HtmlEncode(Request.Cookies["cookies"]["movil"]);
                lblPass.Text = Server.HtmlEncode(Request.Cookies["cookies"]["password"]);
            }
        }

        protected void imgBtnFin_Click(object sender, ImageClickEventArgs e)
        {
            // Envío por cadena de consulta (no se utilizan para transmitir información importante o confidencial)
            Response.Redirect(String.Format("Web5_Fin.aspx?&lblCodPostal={0}&lblPoblacion={1}&lblEmail={2}&lblMovil={3}&lblFijo={4}&lblPass={5}", lblCodPostal.Text, lblPoblacion.Text, lblEmail.Text, lblMovil.Text, lblFijo.Text, lblPass.Text));
        }
    }
}