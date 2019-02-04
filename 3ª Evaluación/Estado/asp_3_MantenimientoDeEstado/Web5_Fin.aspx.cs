using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp_3_MantenimientoDeEstado
{
    public partial class Web5_Fin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Muestro usuario por sesión de estado
                lblUsuario.Text = String.Format("{0} {1}", Session["nombre"], Session["apellidos"]);
                // Recupero la fecha y la hora de inicio de sesión
                lblHora.Text = Application["horainicio"].ToString();
                // Muestro las cadenas de consultas enviadas de la página anterior
                lblCodPostal.Text = Request.QueryString["lblCodPostal"];
                lblPoblacion.Text = Request.QueryString["lblPoblacion"];
                lblEmail.Text = Request.QueryString["lblEmail"];
                lblFijo.Text = Request.QueryString["lblFijo"];
                lblMovil.Text = Request.QueryString["lblMovil"];
                lblPass.Text = Request.QueryString["lblPass"];
            }
        }
    }
}