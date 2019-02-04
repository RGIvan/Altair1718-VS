using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidationGroup
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Fíjate que si a alguno de los validadores no se le adjudica ValidationGroup
            // Validará en el cliente antes de entrar aquí
            if (Page.IsPostBack)
                lbAviso.Text += "   He hecho PostBack";
        }

        protected void btnValidarTodo_Click(object sender, EventArgs e)
        {

            Page.Validate("ValidarAdmin");
            Page.Validate("ValidarCliente");

            if (Page.IsValid)
            {
                Page.Response.Redirect("PaginaGeneral.aspx");
                //Page.Response.Redirect("http://www.google.es");
            }
        }
    }
}