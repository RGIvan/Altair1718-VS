using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DEMO
{
    public partial class Default : System.Web.UI.Page
    {
        String texto = "";
        String textoBienvenida = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lbSaludo.Visible = false;
            }
            else
            {
                if (CheckBorrar.Checked)
                {
                    txtNombre.Visible = false;
                }
                else
                {
                    txtNombre.Visible = true;
                }

                if (CheckPagina.Checked)
                {
                    ImageButton1.Enabled = true;
                }
                else
                {
                    ImageButton1.Enabled = false;
                }
            }
        }

        protected void btnSaludo_Click(object sender, EventArgs e)
        {

            texto = txtNombre.Text;

            textoBienvenida = "¡Bienvenido";

            if (radioMayusculas.Checked)
            {
                textoBienvenida = textoBienvenida.ToUpper();
                texto = texto.ToUpper();
            }
            else
            {
                textoBienvenida = textoBienvenida.ToLower();
                texto = texto.ToLower();
            }

            lbSaludo.Text = textoBienvenida + " " + texto + "!";
            lbSaludo.Visible = true;
        }
    }
}