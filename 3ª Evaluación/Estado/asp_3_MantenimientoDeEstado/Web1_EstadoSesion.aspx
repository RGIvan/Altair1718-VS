<%@ Page Language="C#" UnobtrusiveValidationMode="None" AutoEventWireup="true" CodeBehind="Web1_EstadoSesion.aspx.cs" Inherits="asp_3_MantenimientoDeEstado.Web1_EstadoSesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Web1_EstadoSesion</title>
        <style>
        td{
            padding:7px;
        }
        tr>td:first-child{
            text-align:right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <table style="width: 40%">
                <caption>ESTADO DE SESIÓN</caption>
                <tr>
                    <th colspan="3" style="text-align: right"> Arranca la aplicación: 
                        <asp:Label ID="lblHoraInicio" runat="server"></asp:Label>
                    </th>
                </tr>
                <tr>
                    <th colspan="3" style="text-align: right"> Inicio de Sesion: 
                        <asp:Label ID="lbInicioSesion" runat="server"></asp:Label>
                    </th>
                </tr>
                <tr><td colspan="3">&nbsp;</td></tr>
                
                <tr>
                    <td>
                       <b>Nombre</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txbNombre" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="CompruebaNombre" runat="server" ControlToValidate="txbNombre"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b> Apellidos</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txbApellidos" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="CompruebaApellidos" runat="server" ErrorMessage="Tiene que indicar su/s Apellidos" ControlToValidate="txbApellidos"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:ImageButton ID="imgBtnPass" runat="server" ImageUrl="~/img/next.png" OnClick="imgBtnPass_Click" ToolTip="Ir a Estado de Vista Y HiddenField" />
                    </td>
                    <td></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
