<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Inicio</title>
    <style type="text/css">
        .auto-style1 {
            width: 118px;
            height: 127px;
        }

        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbEntrada" runat="server" Font-Bold="True" Font-Names="Arial" ForeColor="#336699" Text="Mi primera página web en ASP.NET" BorderStyle="Inset"></asp:Label>
            <br />
            <br />
            <img alt="Android" class="auto-style1" src="Imagenes/indice.jpg" /><asp:TextBox ID="txtNombre" runat="server" BackColor="#CCCCCC" Font-Size="Medium" ForeColor="#666666" Width="301px" Height="21px" BorderStyle="Dotted" Font-Bold="True"> Introduce un nombre al que saludar</asp:TextBox>
            <br />
            <asp:Button ID="btnSaludo" runat="server" Text="Saludar" OnClick="btnSaludo_Click" Font-Bold="True" BackColor="White" BorderStyle="Dashed" />
            <br />
            <br />
            <asp:Label ID="lbSaludo" runat="server" Font-Bold="True" Font-Size="Medium" Visible="False" BorderColor="#666633" BorderStyle="Solid"></asp:Label>
        </div>
        <br />
        <div style="position: relative">
            <asp:DropDownList ID="listaNombres" runat="server" Font-Bold="True" ForeColor="#663300"></asp:DropDownList>
            <br />
            <br />
            <label style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: small; border-style: none; font-weight: bold; color: #669900; font-style: normal; text-transform: none;">Introduce un nuevo nombre:</label>
            <br />
            <asp:TextBox ID="txtAdd" runat="server" BorderColor="#99CC00"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Añadir Nombre" OnClick="btnAdd_Click" Font-Bold="True" ForeColor="#663300" BackColor="White" Height="27px" BorderColor="Maroon" BorderStyle="Double" />
        </div>
        <br />
        <asp:RadioButton ID="rdMayu" runat="server" Text="Mayúscula" Font-Bold="True" Checked="True" Font-Italic="False" Font-Size="Medium" ForeColor="#999966" OnCheckedChanged="rdMayu_CheckedChanged" />
        <asp:RadioButton ID="rdMin" runat="server" Text="Minúscula" Font-Bold="True" ForeColor="#999966" OnCheckedChanged="rdMin_CheckedChanged" />
        <br />
        <br />
        <table style="width: 32%; height: 103px;">
            <tr>
                <td>
                    <asp:Image ID="imgAndroid" runat="server" ImageUrl="~/imagenes/android.png" Height="113px" Style="margin-right: 0px" Width="97px" BorderColor="#66FF99" BorderStyle="Dashed" /></td>
                <td style="font-family: Calibri; font-size: medium; background-color: #C0C0C0; border: thin double #808000; list-style-type: georgian; table-layout: fixed; border-collapse: separate; border-spacing: inherit; overflow: auto">Este es el texto que se mostrará en la tabla. Este es el texto que se mostrará en la tabla.</td>
            </tr>
        </table>
        <br />
        <asp:Button ID="btnGoogle" runat="server" Text="Ir a Google" PostBackUrl="http://www.google.es/" BackColor="White" Font-Bold="True" Font-Italic="True" ForeColor="#003399" Height="28px" OnClick="btnGoogle_Click" />
    </form>
</body>
</html>
