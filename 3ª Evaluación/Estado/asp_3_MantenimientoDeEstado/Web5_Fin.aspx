<%@ Page Language="C#" UnobtrusiveValidationMode="None" AutoEventWireup="true" CodeBehind="Web5_Fin.aspx.cs" Inherits="asp_3_MantenimientoDeEstado.Web5_Fin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Web5_Fin</title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <table>
                <caption>CADENA DE CONSULTA</caption>
                <tr>
                    <th colspan="3">Usuario: 
                        <asp:Label ID="lblUsuario" runat="server"></asp:Label>
                    </th>
                </tr>
                <tr>
                    <th colspan="3">Fecha y Hora de inicio de Sesión:
                        <asp:Label ID="lblHora" runat="server"></asp:Label>
                    </th>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:Label ID="lblPass" runat="server" SkinID="skinPass"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Móvil</td>
                    <td>
                        <asp:Label ID="lblMovil" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Tlfno Fijo</td>
                    <td>
                        <asp:Label ID="lblFijo" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>E-mail</td>
                    <td>
                        <asp:Label ID="lblEmail" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Población</td>
                    <td>
                        <asp:Label ID="lblPoblacion" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Código Postal</td>
                    <td>
                        <asp:Label ID="lblCodPostal" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
