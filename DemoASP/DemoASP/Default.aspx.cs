using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoASP {
    public partial class Default : System.Web.UI.Page {
        String nuevoNombre;

        protected void Page_Load(object sender, EventArgs e) {

            if (!Page.IsPostBack) {
                ddListNombres.Items.Add("Adrián");
                ddListNombres.Items.Add("asdsesdsdes");
                ddListNombres.Items.Add("iisiidisds");

                nuevoNombre = "NuevoNombre";
            } else {
                nuevoNombre = txtAniadir.Text;
            }

            txtAniadir.Text = nuevoNombre;
        }

        protected void btnSaludo_Click(object sender, EventArgs e) {
            lbSaludo.Visible = true;
            lbSaludo.Text = "Bienvenido/a " + ddListNombres.SelectedItem.ToString() + "!";
            // Response.Redirect("http://altair.com.es");
        }

        protected void btnAniadir_Click(object sender, EventArgs e) {
            ddListNombres.Items.Add(txtAniadir.Text);
            txtAniadir.Text = String.Empty;
        }
    }
}