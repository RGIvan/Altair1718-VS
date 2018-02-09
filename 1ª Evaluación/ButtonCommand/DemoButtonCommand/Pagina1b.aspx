<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina1b.aspx.cs" Inherits="DemoButtonCommand.Pagina1b" %>


<!--En el ejemplo de código se muestra cómo especificar y crear codificar el controlador del evento Command para ordenar una lista 
    cuando se haga clic en el control Button. 
    Se especifica el controlador del evento de forma declarativa mediante la propiedad OnCommand del control Button
    pero ahora, en la línea de directivas de esta página se especifica que debe buscar el código en... CodeBehind="Pagina1b.aspx.cs"
    Es en el archivo Pagina1.aspx.cs correspondiente, donde se controlarán los eventos.-->
    

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Ejemplo 1b de Button Command</title>
</head>

<body>

   <form id="form1" runat="server">

      <h3>Ejemplo 1b de Button Command</h3>

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

      <asp:Label id="lbMensaje" runat="server"/>

   </form>

</body>
</html>
