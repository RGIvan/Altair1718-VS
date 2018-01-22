<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DemoASP.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>ASP. Mi primera página.</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table style="width: 100%;">
                <tr>
                    <td><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/500_333.png" Height="259px" style="margin-right: 0px" Width="316px" /></td>
                    <td>AQUÍ VA EL TEXTO QUE SE VA A MOSTRAR EN LA PARTE DERECHA DE LA TABLA. ESTA TABLA SOLO TIENE UNA FILA Y DOS COLUMNAS.</td>
                </tr>
            </table>
            Porfavor introduce tu nombre:
            <br />
            ¿A quién quieres saludar?
            <asp:DropDownList ID="ddListNombres" runat="server"></asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnSaludo" runat="server" Text="Saludar" OnClick="btnSaludo_Click" />
            <br />
            
            <br />
            <asp:Label ID="lbSaludo" runat="server" Text="Label" Font-Bold="True" Font-Size="Large" Visible="False"></asp:Label>
            <br />
            <asp:TextBox ID="txtAniadir" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="btnAniadir" runat="server" Text="Añadir nombre" OnClick="btnAniadir_Click" />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Ir a Google.es" PostBackUrl="http://www.google.es/" />
        </div>
    </form>
</body>
</html>
