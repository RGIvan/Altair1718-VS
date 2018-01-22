<%@ Page Language="C#" AutoEventWireup="True" %>    <!-- CodeBehind="Pagina1.aspx.cs" Inherits="DemoButtonCommand.WebForm1" %> -->
<!--En el ejemplo de código se muestra cómo especificar y crear codificar el controlador 
    del evento Command para ordenar una lista cuando se haga clic en el control Button. 
    Se especifica el controlador del evento de forma declarativa mediante la propiedad OnCommand del control Button
    Fíjate que ni siquiera hace falta especificar el CodeBehind="Pagina1.aspx.cs"
    En el archivo Pagina1.aspx.cs correspondiente, no hay ningún controlador salvo el Page_Load que siempre se pone al construir la página.-->
    

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Ejemplo de Button Command</title>
<script runat="server">

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
       <div style="font-family: Arial, Helvetica, sans-serif; font-size:small; background-color: #FFFFCC;">
    En el ejemplo de código se muestra cómo especificar y crear codificar el controlador 
    del evento Command para ordenar una lista cuando se haga clic en el control Button. 
    Se especifica el controlador del evento de forma declarativa mediante la propiedad OnCommand del control Button
    Fíjate que ni siquiera hace falta especificar el CodeBehind="Pagina1.aspx.cs"
    En el archivo Pagina1.aspx.cs correspondiente, no hay ningún controlador salvo el Page_Load que siempre se pone al construir la página.
       </div>
      <h3>Ejemplo 1a de Button Command </h3>

      Haz Click en uno de los command buttons.

      <br /><br />

      <asp:Button id="Button1"
           Text="Sort Ascendente"
           CommandName="Sort"
           CommandArgument="Ascendente"
           OnCommand="BtnCommand_Click" 
           runat="server"/>

      &nbsp;

      <asp:Button id="Button2"
           Text="Sort Descendente"
           CommandName="Sort"
           CommandArgument="Descendente"
           OnCommand="BtnCommand_Click" 
           runat="server"/>

      <br /><br />

      <asp:Button id="Button3"
           Text="Submit"
           CommandName="Submit"
           OnCommand="BtnCommand_Click" 
           runat="server"/>

      &nbsp;

      <asp:Button id="Button4"
           Text="Command Name desconocido"
           CommandName="NombreDesconocido"
           CommandArgument="Argumento Desconocido"
           OnCommand="BtnCommand_Click" 
           runat="server"/>

      &nbsp;

      <asp:Button id="Button5"
           Text="Submit Argumento Command Desconocido"
           CommandName="Submit"
           CommandArgument="Argumento Desconocido"
           OnCommand="BtnCommand_Click" 
           runat="server"/>

      <br /><br />

      <asp:Label id="lbMensaje" runat="server" Font-Names="Arial Black"/>

       <br />
       <br />
       <br />
       <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://msdn.microsoft.com/es-es/library/system.web.ui.webcontrols.button.command(v=vs.110).aspx">Ver artículo original</asp:HyperLink>

   </form>
</body>
</html>
