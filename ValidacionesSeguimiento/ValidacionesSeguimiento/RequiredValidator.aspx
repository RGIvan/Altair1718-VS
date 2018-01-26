<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RequiredValidator.aspx.cs" Inherits="ValidacionesSeguimiento.Default" %>

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
            <label id="lbBienvenido" style="font-family: Arial, Helvetica, sans-serif; font-size: medium; border-style: dashed; font-weight: bold; color: #000080;">Pruebas RequiredFieldValidator</label>
            <br />
            <br />
            <table>
                <tr>
                    <td class="auto-style1">
                        <label style="font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif; font-size: small; font-weight: bold;">Nombre: </label>
                       <asp:TextBox ID="txtNombre" runat="server" Width="170px"></asp:TextBox> <asp:RequiredFieldValidator ID="valNombre" runat="server" ErrorMessage="*Introduce un nombre" Font-Bold="True" ForeColor="Red" ControlToValidate="txtNombre"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <label style="font-weight: bold; font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif; color: #000000; font-size: small;">Apellidos: </label>
                       <asp:TextBox ID="TxtApellidos" runat="server" Width="170px"></asp:TextBox><asp:RequiredFieldValidator ID="valApellidos" runat="server" ErrorMessage="*Introduce un apellido" Font-Bold="True" ForeColor="Red" ControlToValidate="txtApellidos" EnableClientScript="False"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
        </div>
        <br />
       <asp:ImageButton ID="btn" runat="server" OnClick="btnEnviar_Click" ImageUrl="~/img/button.png" Height="50px" Width="50px" />
    </form>
</body>
</html>