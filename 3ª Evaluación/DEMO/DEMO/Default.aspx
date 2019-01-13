<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DEMO.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <img src="Imagenes/mm.png" style="height: 114px; width: 121px" />
            <br />
            Por favor, introduce tu nombre:
            <asp:TextBox ID="txtNombre" runat="server" BackColor="#FFFF99" Font-Size="Larger" ForeColor="Blue"></asp:TextBox>
            &nbsp;<asp:Button ID="btnSaludo" runat="server" Text="Saludar" Font-Bold="True" Font-Size="Medium" OnClick="btnSaludo_Click" />
            &nbsp;
            <asp:CheckBox ID="CheckBorrar" runat="server" Font-Bold="True" Text="Borrar a la vuelta" AutoPostBack="True" />
            &nbsp;
       
            <asp:RadioButton ID="radioMayusculas" runat="server" Text="Mayúsculas" GroupName="letra" />
            &nbsp;
       
            <asp:RadioButton ID="radioMinusculas" runat="server" Text="minúsculas" GroupName="letra" />
            <br />
            <br />
            <asp:Label ID="lbSaludo" runat="server" Text="Label" Font-Bold="True" Font-Names="Arial" Font-Size="X-Large" ForeColor="Red" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="Medium" Text="Botón" Width="166px" PostBackUrl="http://virtual.altair.edu.es/" />
            <br />
            <br />
            <asp:CheckBox ID="CheckPagina" runat="server" Text="Web Altair" AutoPostBack="True" />
            <br />
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Imagenes/check.jpg" Width="50" PostBackUrl="http://virtual.altair.edu.es/" Enabled="False" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
