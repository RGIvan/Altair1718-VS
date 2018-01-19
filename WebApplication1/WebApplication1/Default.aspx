<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 118px;
            height: 127px;
        }
        .auto-style2 {
            width: 173px;
        }
        .auto-style3 {
            width: 71px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lbEntrada" runat="server" Font-Bold="True" Font-Names="Arial" ForeColor="#336699" Text="Buenos días" BorderStyle="Inset"></asp:Label>
        <br />
        <br />
        <img alt="Android" class="auto-style1" src="Imagenes/índice.jpg" /><asp:TextBox ID="txtNombre" runat="server" BackColor="#CCCCCC" Font-Size="Medium" ForeColor="#666666" Width="171px" Height="16px" BorderStyle="Dotted" Font-Bold="True">Introduce tu nombre</asp:TextBox>
        </div>
        <br />
        <asp:Label ID="lbSaludo" runat="server" Font-Bold="True" Font-Size="Medium" Visible="False"></asp:Label>
        <p>

        <asp:Button ID="btnSaludo" runat="server" Font-Bold="True" Font-Size="Medium" Text="Saludar" Width="77px" Height="23px" BorderStyle="Dashed" OnClick="btnSaludo_Click" />
        </p>
        <asp:RadioButton ID="rdMayu" runat="server" Text="Mayúscula" Font-Bold="True" Checked="True" />
        <asp:RadioButton ID="rdMin" runat="server" Text="Minúscula" Font-Bold="True" />
        <br />
        <br />
        <table style="width: 64%;">
            <tr>
                <td class="auto-style3"><img src="Imagenes/android.png" width="80" height="80" /></td>
                <td class="auto-style2">asdasdsadsadasdasdsadasdadadadsadsasadsadsadsa<br />
                    asdsadadsadadadadadadsadadadadsadadadadsadad<br />
                    asadadsadsasadsadasdasdsadasasdsadasdasdasdada<br />

                </td>
            </tr>
        </table>
    </form>
</body>
</html>