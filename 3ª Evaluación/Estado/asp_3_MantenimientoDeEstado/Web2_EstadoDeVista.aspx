<%@ Page Language="C#" UnobtrusiveValidationMode="None" AutoEventWireup="true" CodeBehind="Web2_EstadoDeVista.aspx.cs" Inherits="asp_3_MantenimientoDeEstado.Web2_EstadoDeVista" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Web2_EstadoDeVista</title>
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
            <table>
                <caption>ESTADO DE VISTA (<asp:Label ID="lblUsuario" runat="server" Width="200px"></asp:Label>)</caption>
                <tr>
                    <th>Acceso anterior:
                        <asp:Label ID="lbHoraAnterior" runat="server" Width="200px"></asp:Label>
                    </th>
                    <th style="background-color: darksalmon;">Acceso actual: 
                        <asp:Label ID="lblHora" runat="server" Font-Bold="True"></asp:Label>
                    </th>
                    <th>
                        <asp:Button ID="btnViewState" runat="server" Text="Actualizar hora en ViewState" CausesValidation="False" OnClick="btnViewState_Click" BackColor="#FF4220" BorderStyle="None" Font-Bold="True" ForeColor="White" ToolTip="Pulsar para Actualizar la hora" />
                    </th>
                </tr>
                <tr>
                    <td ><b>Password &nbsp;&nbsp;</b></td>
                    <td>
                        <asp:TextBox ID="txbPass" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="CompruebaPass" runat="server" ErrorMessage="Debe introducir el password" ControlToValidate="txbPass"></asp:RequiredFieldValidator>

                    </td>
                </tr>
                <tr>
                    <td ><b>Repetir &nbsp;&nbsp;</b></td>
                    <td>
                        <asp:TextBox ID="txbRepitePass" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="CompruebaRepitePass" runat="server" ErrorMessage="Debe repetir el password" ControlToValidate="txbRepitePass"></asp:RequiredFieldValidator>
                        &nbsp;<asp:CompareValidator ID="ComparaPass" runat="server" ErrorMessage="Los password no coinciden" ControlToCompare="txbPass" ControlToValidate="txbRepitePass"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td ><b>Móvil &nbsp;&nbsp;</b> </td>
                    <td>
                        <asp:TextBox ID="txbMovil" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="CompruebaMovil" runat="server" ErrorMessage="Debe introducir número de móvil" ControlToValidate="txbMovil"></asp:RequiredFieldValidator>
                        &nbsp;<asp:RangeValidator ID="RangoMovil" runat="server" ErrorMessage="El móvil debe tener 9 dígitos y comenzar por 6 o 7" MaximumValue="799999999" MinimumValue="600000000" Type="Integer" ControlToValidate="txbMovil"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td ><b> Tlfno &nbsp;&nbsp;</b></td>
                    <td>
                        <asp:TextBox ID="txbTlfno" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RangeValidator ID="RangoFijo" runat="server" ErrorMessage="El fijo de 9 dígitos y que comience por 954 o 955" ControlToValidate="txbTlfno" MaximumValue="955999999" MinimumValue="954000000"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td ><b> Email &nbsp;&nbsp;</b></td>
                    <td>
                        <asp:TextBox ID="txbEmail" runat="server" Width="300px" TextMode="Email"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RFVemail" runat="server" ErrorMessage="Debe introducir su e-mail" ControlToValidate="txbEmail"></asp:RequiredFieldValidator>
                        &nbsp;<asp:RegularExpressionValidator ID="REVemail" runat="server" ErrorMessage="El texto introducido no es un email correcto" ControlToValidate="txbEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                
                <tr>
                    <td></td>
                    <td><asp:ImageButton ID="imgBtnEmail" runat="server" ImageUrl="~/img/next.png" PostBackUrl="~/Web3_Cookies.aspx" ToolTip="Ir a Cookies" />
                        </td>
                    <td></td>
                </tr>
                    <tr>
                    <td colspan="3">
                        <asp:HiddenField ID="hiddenOrigen" runat="server" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
