using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoButtonCommand
{
    public partial class Pagina1b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCommand_Click(object sender, CommandEventArgs e)
        {

            switch (e.CommandName)
            {

                case "Sort":

                    // Call the method to sort the list.
                    OrdenarLista((String)e.CommandArgument);
                    break;

                case "Submit":

                    // Display a message for the Submit button being clicked.
                    lbMensaje.Text = "Has \"Clicado\" en el botón Submit";

                    // Test whether the command argument is an empty string ("").
                    if ((String)e.CommandArgument == "")
                    {
                        // End the message.
                        lbMensaje.Text += ".";
                    }
                    else
                    {
                        // Display an error message for the command argument. 
                        lbMensaje.Text += ", Sin embargo no se reconoce el argumento.";
                    }
                    break;

                default:

                    // The command name is not recognized. Display an error message.
                    lbMensaje.Text = "Nombre del Command no reconocido.";
                    break;

            }

        }

        void OrdenarLista(string commandArgument)
        {

            switch (commandArgument)
            {

                case "Ascendente":

                    // Insert code to sort the list in Ascendente order here.
                    lbMensaje.Text = "Has \"Clicado\" en el botón de Sort Ascendente";
                    break;

                case "Descendente":

                    // Insert code to sort the list in Descendente order here.
                    lbMensaje.Text = "Has hecho \"Clic\"  en el botón de Sort Descendente";
                    break;

                default:

                    // The command argument is not recognized. Display an error message.
                    lbMensaje.Text = "Argumento Command No reconocido.";
                    break;

            }

        }
    }
}