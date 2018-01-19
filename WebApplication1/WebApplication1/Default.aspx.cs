using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lbEntrada.Text = "Bienvenido";
                lbEntrada.Visible = true;
            }

            else
            {
                lbEntrada.Visible = false;
            }
        }

        protected void btnSaludo_Click(object sender, EventArgs e)
        {
            lbSaludo.Text = "¡Hola " + txtNombre.Text + "!";
            lbSaludo.Visible = true;

            if (rdMayu.Checked)
            {
                lbSaludo.Text = "¡HOLA" + txtNombre.Text;
            }

            if (rdMin.Checked)
            {
                lbSaludo.Text = "¡Hola" + txtNombre.Text;
            }
        }
    }
}