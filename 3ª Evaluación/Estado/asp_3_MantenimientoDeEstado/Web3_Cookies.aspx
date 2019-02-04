<%@ Page Language="C#" UnobtrusiveValidationMode="None" AutoEventWireup="true" CodeBehind="Web3_Cookies.aspx.cs" Inherits="asp_3_MantenimientoDeEstado.Web3_Cookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Web3_Cookies</title>
    <script type="text/javascript">
        function CodPostal(sender, args) {
            var valor = document.getElementById("txbCodPostal").value;
            try {
                args.IsValid = parseInt(valor) && valor > 40999 && valor < 42000;
            }
            catch (e) {
                args.IsValid = false;
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <table>
                <caption>PostBack</caption>
                <tr>
                    <th>Password</th>
                    <th>Móvil</th>
                    <th>Tlfno Fijo</th>
                    <th>E-mail</th>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPass" runat="server" SkinID="skinPass"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblMovil" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblFijo" runat="server" Text=""></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblEmail" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
            <div id="vacia"></div>
        <table>
            <caption>COOKIES</caption>
            <tr>
                <th colspan="3">Usuario: 
                    <asp:Label ID="lblUsuario" runat="server" Text=""></asp:Label>
                </th>
            </tr>
            <tr>
                <td>Población</td>
                <td>
                    <asp:TextBox ID="txbPoblacion" runat="server"></asp:TextBox>
                </td>
                <td></td>
            </tr>
            <tr>
                <td>Código Postal</td>
                <td>
                    <asp:TextBox ID="txbCodPostal" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:CustomValidator ID="CVcodPostal"
                        runat="server"
                        ErrorMessage="El código postal debe ser de 5 cifras y comenzar por 41"
                        ControlToValidate="txbCodPostal"
                        EnableClientScript="true"
                        ClientValidationFunction="CodPostal"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <th>(HiddenField)
                </th>
                <asp:Label ID="lblTxtOrigen" runat="server" Text=""></asp:Label>
                <th colspan="2">
                    <asp:Label ID="lblOrigen" runat="server" Text="Label"></asp:Label>
                </th>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:ImageButton ID="imgBtnCookies" runat="server" ImageUrl="~/img/next.png" ToolTip="Ir a Cookies por cadena de Consulta" OnClick="imgBtnCookies_Click" />
                </td>
            </tr>
        </table>
        </div>
    </form>
</body>
</html>
