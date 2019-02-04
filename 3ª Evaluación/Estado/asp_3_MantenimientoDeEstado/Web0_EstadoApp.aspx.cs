using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp_3_MantenimientoDeEstado
{
    public partial class Web0_EstadoApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["horaInicio"] == null)
                Application["horaInicio"] = DateTime.Now;

            Application["autor"] = "Dani";
            Response.Redirect("Web1_EstadoSesion.aspx");
        }
    }
}