<%@ Page Language="C#" AutoEventWireup="True" %>
<!--En el siguiente ejemplo de código es equivalente Página1a pero se muestra cómo especificar el controlador del evento 
    y agregarlo mediante programación al evento en el método Page_Load.
    -->

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Ejemplo 2 de Button Command</title>
<script runat="server">

    void Page_Load(Object sender, EventArgs e)
    {

        // Manually register the event-handling method for the Command  
        // event of the Button controls.
        Button1.Command += new CommandEventHandler(this.BtnCommand_Click);
        Button2.Command += new CommandEventHandler(this.BtnCommand_Click);
        Button3.Command += new CommandEventHandler(this.BtnCommand_Click);
        Button4.Command += new CommandEventHandler(this.BtnCommand_Click);
        Button5.Command += new CommandEventHandler(this.BtnCommand_Click);

    }
      void BtnCommand_Click(Object sender, CommandEventArgs e) 
      {

         switch(e.CommandName)
         {

            case "Sort":

               // Call the method to sort the list.
               OrdenarLista((String)e.CommandArgument);
               break;

            case "Submit":

               // Display a lbMensaje for the Submit button being clicked.
               lbMensaje.Text = "Has \"Clicado\" en el botón Submit";

               // Test whether the command argument is an empty string ("").
               if((String)e.CommandArgument == "")
               {
                  // End the lbMensaje.
                  lbMensaje.Text += ".";
               }
               else
               {
                  // Display an error lbMensaje for the command argument. 
                  lbMensaje.Text += ", Sin embargo no se reconoce el argumento.";
               }                
               break;

            default:

               // The command name is not recognized. Display an error lbMensaje.
               lbMensaje.Text = "Nombre del Command no reconocido.";
               break; 

         }

      }

      void OrdenarLista(string commandArgument)
      {

         switch(commandArgument)
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

               // The command argument is not recognized. Display an error lbMensaje.
               lbMensaje.Text = "Argumento Command No reconocido.";
               break;

         }

      }


    

   </script>

</head>

<body>

   <form id="form1" runat="server">

      <h3>Ejemplo 2 de Button Command </h3>

      Haz Click en uno de los command buttons.

      <br /><br />
      <!-- Podemos quitar   OnCommand="BtnCommand_Click"  de todos los botones -->
      <asp:Button id="Button1"
           Text="Sort Ascendente"
           CommandName="Sort"
           CommandArgument="Ascendente"
           runat="server"/>

      &nbsp;

      <asp:Button id="Button2"
           Text="Sort Descendente"
           CommandName="Sort"
           CommandArgument="Descendente"
           runat="server"/>

      <br /><br />

      <asp:Button id="Button3"
           Text="Submit"
           CommandName="Submit"
           runat="server"/>

      &nbsp;

      <asp:Button id="Button4"
           Text="Command Name desconocido"
           CommandName="NombreDesconocido"
           CommandArgument="Argumento Desconocido"
           runat="server"/>

      &nbsp;

      <asp:Button id="Button5"
           Text="Submit Argumento Command Desconocido"
           CommandName="Submit"
           CommandArgument="Argumento Desconocido"
           runat="server"/>

      <br /><br />

      <asp:Label id="lbMensaje" runat="server"/>

   </form>

</body>
</html>
