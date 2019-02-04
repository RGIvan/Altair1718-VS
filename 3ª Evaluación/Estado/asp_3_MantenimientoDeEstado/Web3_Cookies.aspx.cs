using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp_3_MantenimientoDeEstado
{
    public partial class Web3_Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Page.PreviousPage != null && Page.PreviousPage.IsCrossPagePostBack)
                {
                    // Recupero el campo oculto
                    HiddenField campOculto = Page.PreviousPage.FindControl("hiddenOrigen") as HiddenField;
                    // Recupero el resto de controles (2 formas)
                    TextBox password = Page.PreviousPage.FindControl("txbPass") as TextBox;
                    TextBox movil = Page.PreviousPage.FindControl("txbMovil") as TextBox;
                    TextBox fijo = (TextBox)Page.PreviousPage.FindControl("txbTlfno");
                    TextBox email = (TextBox)Page.PreviousPage.FindControl("txbEmail");

                    // Los muestro en pantalla
                    lblOrigen.Text = campOculto.Value;
                    lblMovil.Text = movil.Text;
                    lblFijo.Text = fijo.Text;
                    lblEmail.Text = email.Text;

                    lblPass.Text = password.Text;
                    lblPass.Attributes["type"] = "password";

                    // Muestro usuario por estado de sesión
                    lblUsuario.Text = String.Format("{0} {1}", Session["nombre"], Session["apellidos"]);
                }
            }
        }

        protected void imgBtnCookies_Click(object sender, ImageClickEventArgs e)
        {
            // Almaceno los datos en cookies: Controles optativos
            if (txbPoblacion.Text != null)
                Response.Cookies["cookies"]["poblacion"] = txbPoblacion.Text;
            if (txbCodPostal.Text != null)
                Response.Cookies["cookies"]["codPostal"] = txbCodPostal.Text;
            if (lblFijo.Text != null)
                Response.Cookies["cookies"]["fijo"] = lblFijo.Text;
            // Almaceno los datos en cookies: Controles obligatorios (no pueden ser null)
            Response.Cookies["cookies"]["movil"] = lblMovil.Text;
            Response.Cookies["cookies"]["password"] = lblPass.Text;
            Response.Cookies["cookies"]["email"] = lblEmail.Text;

            // Caducidad de las cookies (5 minutos)
            Response.Cookies["cookies"].Expires = DateTime.Now.AddMinutes(5);

            Response.Redirect("Web4_CookiesXConsulta.aspx");
        }
    }
}