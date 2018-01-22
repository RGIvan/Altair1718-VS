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
        string nombre;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                lbEntrada.Text = "Bienvenido/a";
                lbEntrada.Visible = true;
                listaNombres.Items.Add("Iván");
                listaNombres.Items.Add("Roberto");
                listaNombres.Items.Add("Paco");
                nombre = "newName";
            }

            else
            {
                lbEntrada.Visible = false;
                nombre = txtAdd.Text;
            }

            txtAdd.Text = nombre;
        }

        protected void btnSaludo_Click(object sender, EventArgs e)
        {
            lbSaludo.Text = "Bienvenido/a " + listaNombres.SelectedItem.ToString();

            lbSaludo.Visible = true;

            if (rdMayu.Checked)
            {
                lbSaludo.Text = "BIENVENIDO/A " + listaNombres.SelectedItem.ToString();
            }

            if (rdMin.Checked)
            {
                lbSaludo.Text = "Bienvenido/a " + listaNombres.SelectedItem.ToString();
            }
        }

        protected void rdMin_CheckedChanged(object sender, EventArgs e)
        {
            rdMayu.Checked = false;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            listaNombres.Items.Add(txtAdd.Text);
            txtAdd.Text = String.Empty;
        }

        protected void btnGoogle_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://www.google.es/");
        }
    }
}