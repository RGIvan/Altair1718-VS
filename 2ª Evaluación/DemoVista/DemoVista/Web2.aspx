<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Web2.aspx.cs" Inherits="DemoVista.Web2" %>

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
            Variable peso:
                <asp:Label ID="peso" runat="server" Text=""></asp:Label>
            <br />
            <br />
            Variable volumen:
                <asp:Label ID="volumen" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Button ID="enviar" runat="server" Text="Enviar" />
        </div>
    </form>
</body>
</html>
