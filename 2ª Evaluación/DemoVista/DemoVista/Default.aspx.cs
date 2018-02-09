using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoVista
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void enviar_Click(object sender, EventArgs e)
        {
            if (Session["peso"] == null)
                Session.Add("peso", peso.Text);
            else
                Session["volumen"] = volumen.Text;

            if (Session["densidad"] == null)
                Session.Add("densidad", densidad.Text);

            Response.Redirect("Web2.aspx");
        }

        protected void ViewState_Click(object sender, EventArgs e)
        {
            if (Application["horainicioA"] == null)
                Application.Add("horainicioA", DateTime.Now);

            horainicioA.Text = Application["horainicioA"].ToString();

            if (Session["horainicioS"] == null)
                Session.Add("horainicioS", DateTime.Now);

            horainicioS.Text = Session["horainicioS"].ToString();
        }
    }
}