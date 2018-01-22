<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ValidacionesSeguimiento.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Inicio</title>
    <style type="text/css">
        .auto-style1 {
            width: 419px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label id="lbBienvenido" style="font-family: Arial, Helvetica, sans-serif; font-size: medium; border-style: dashed; font-weight: bold; color: #000080;">Bienvenido a ASP.NET</label>
            <br />
            <br />
            <table>
                <tr>
                    <td class="auto-style1">
                        <label style="font-family: Arial, Helvetica, sans-serif; font-size: small; font-weight: bold;">Nombre: </label>
                        <input type="text" id="txtNombre" name="nombre" /><asp:RequiredFieldValidator ID="valNombre" runat="server" ErrorMessage="*Introduce un nombre" Font-Bold="True" ForeColor="Red" ControlToValidate="txtNombre"></asp:RequiredFieldValidator>

                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <label style="font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: #000000; font-size: small;">Apellidos: </label>
                        <input type="text" id="txtApellidos" name="apellidos" /><asp:RequiredFieldValidator ID="valApellidos" runat="server" ErrorMessage="*Introduce un apellido" Font-Bold="True" ForeColor="Red" ControlToValidate="txtApellidos" EnableClientScript="False"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
        </div>
    </form>
    <asp:Button ID="btnEnviar" runat="server" Text="Enviar" BorderColor="#663300" BorderStyle="Dotted" Font-Bold="True" Font-Size="Small" OnClick="btnEnviar_Click" />
</body>
</html>