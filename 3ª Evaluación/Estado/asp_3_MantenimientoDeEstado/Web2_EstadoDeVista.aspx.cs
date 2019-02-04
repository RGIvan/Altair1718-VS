using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp_3_MantenimientoDeEstado
{
    public partial class Web2_EstadoDeVista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // ViewState: útil para la página en la que está (para no perder los datos si se recarga)
            if (ViewState["hora"] == null)
                ViewState.Add("hora", DateTime.Now.ToLongTimeString());
            else
                ViewState["hora"] = DateTime.Now.ToLongTimeString();


            // Establezco la hora en el Label
            //lblHora.Text = ViewState["hora"].ToString();

            if (!Page.IsPostBack)
            {
                ViewState.Add("pass", "");

                lblHora.Text = ViewState["hora"].ToString();
                // Guardo en un campo oculto la url actual
                hiddenOrigen.Value = "Url de origen => " + Page.Request.Url.AbsolutePath;
                // Muestro usuario por sesión de estado
                lblUsuario.Text = String.Format("{0} {1}", Session["nombre"], Session["apellidos"]);
            }
            //else
            //    txbPass.Text = ViewState["pass"].ToString();

        }

        protected void btnViewState_Click(object sender, EventArgs e)
        {
            // Establezco la nueva hora cada vez que pulso el botón
            //ViewState["hora"] = DateTime.Now.ToLongTimeString();
            //lblHora.Text = ViewState["hora"].ToString();
            lbHoraAnterior.Text = lblHora.Text;
            lblHora.Text = ViewState["hora"].ToString();
  
        }
    }
}