using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoVista
{
    public partial class Web2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["peso"] != null)
                Session.Add("peso", peso.Text);

            if (Session["volumen"] != null)
                Session.Add("volumen", peso.Text);
        }
    }
}