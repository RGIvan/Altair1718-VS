<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DemoVista.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form" runat="server">
        <div style="width: 873px">
            <h1>Iván Roales García</h1>
            <h2></h2>
            <br />
            <br />
            Peso:
            <asp:TextBox ID="peso" runat="server" Width="142px"></asp:TextBox>
            <br />
            <br />
            Volumen:
            <asp:TextBox ID="volumen" runat="server" Width="142px"></asp:TextBox>
            <br />
            <br />
            Densidad:
            <asp:TextBox ID="densidad" runat="server" Width="142px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="enviar" runat="server" Text="Enviar" OnClick="enviar_Click" />
            <br />
            <br />
            <asp:Button ID="ViewState" runat="server" Text="ViewState" OnClick="ViewState_Click" />
        </div>
    </form>
    <br />
    <br />
    Hora de comienzo de la aplicación:
    <asp:Label ID="horainicioA" runat="server" Text=""></asp:Label>
    <br />
    <br />
    Hora de comienzo de la sesión:
    <asp:Label ID="horainicioS" runat="server" Text=""></asp:Label>
</body>
</html>
