<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ValidationGroup.Default" UnobtrusiveValidationMode="None"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Prueba de Validation Group</title>
    <style type="text/css">
        .auto-style1 {
            width: 100px;
            height: 26px;
        }
        .auto-style2 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <asp:Label ID="lbAviso" runat="server" Text=""></asp:Label>
            <table width="100%" cellspacing="12">
                <tr>
                    <td align="center" bgcolor="#CCFFCC">
                        <asp:Label ID="Label1" runat="server" Text="Validacion Clientes"></asp:Label></td>
                    <td align="center" bgcolor="#CCFFCC">
                        <asp:Label ID="Label2" runat="server" Text="Validacion Admin"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 84px">
                        <table style="width: 100%;">
                            <tr>
                                <td style="width: 100px">
                                    <asp:Label ID="Label3" runat="server" Text="Usuario : "></asp:Label>
                                </td>
                                <td style="width: 75px" align="center">
                                    <asp:TextBox ID="txtUsu" runat="server" BackColor="#FFCC00"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:RequiredFieldValidator ID="valReqUsuario" runat="server"
                                        Display="Dynamic" ErrorMessage="El campo usuario no puede estar vacio"
                                        ValidationGroup="ValidarCliente" ControlToValidate="txtUsu"
                                        ForeColor="Red">El campo usuario no puede estar vacio</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td style="width: 84px">
                        <table style="width: 100%;">
                            <tr>
                                <td style="width: 100px">
                                    <asp:Label ID="Label4" runat="server" Text="CorreoAdmin : "></asp:Label>
                                </td>
                                <td align="center">
                                    <asp:TextBox ID="txtCorreo" runat="server" BackColor="#FFCC00"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:RequiredFieldValidator ID="valReqMail" runat="server"
                                        Display="Dynamic" ErrorMessage="El campo correo de admin no puede estar vacio"
                                        ValidationGroup="ValidarAdmin" ControlToValidate="txtCorreo"
                                        ForeColor="Red">El campo correo de admin no puede estar vacio</asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="valExpRegMail" runat="server"
                                        ControlToValidate="txtCorreo" Display="Dynamic"
                                        ErrorMessage="El campo Correo Admin no es un correo valido"
                                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                        ValidationGroup="ValidarAdmin" ForeColor="Red">El campo Correo Admin no es un correo valido</asp:RegularExpressionValidator>
                                </td>
                            </tr>
                        </table>


                    </td>
                </tr>
                <tr>
                    <td>
                        <table style="width: 100%;">
                            <tr>
                                <td style="width: 100px">
                                    <asp:Label ID="Label5" runat="server" Text="Contraseña : "></asp:Label>
                                </td>
                                <td style="width: 75px" align="center">
                                    <asp:TextBox ID="txtPass" runat="server" BackColor="#FFCC00"
                                        TextMode="Password"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:RequiredFieldValidator ID="valReqPassword1" runat="server"
                                        Display="Dynamic" ErrorMessage="El campo contraseña no puede estar vacio"
                                        ValidationGroup="ValidarCliente" ControlToValidate="txtPass"
                                        ForeColor="Red">El campo contraseña no puede estar vacio</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>
                        <table style="width: 100%;">
                            <tr>
                                <td class="auto-style1">
                                    <asp:Label ID="Label6" runat="server" Text="Contraseña : "></asp:Label>
                                </td>
                                <td align="center" class="auto-style2">
                                    <asp:TextBox ID="txtPassAdmin" runat="server" BackColor="#FFCC00"
                                        TextMode="Password"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:RequiredFieldValidator ID="valReqPasword2" runat="server"
                                        Display="Dynamic" ErrorMessage="El campo contraseña no puede estar vacio"
                                        ValidationGroup="ValidarAdmin" ControlToValidate="txtPassAdmin"
                                        ForeColor="Red">El campo contraseña no puede estar vacio</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnValidarTodo" runat="server" Text="Validar Todo" Width="289px" OnClick="btnValidarTodo_Click" />
                    </td>
                </tr>
                <tr>
                    <td align="center" bgcolor="#CCFFCC">
                        <asp:Button ID="Button1" runat="server" Text="Validar Cliente"
                            ValidationGroup="ValidarCliente" PostBackUrl="~/PaginaCliente.aspx" />
                    </td>
                    <td align="center" bgcolor="#CCFFCC">
                        <asp:Button ID="Button2" runat="server" Text="Validar Admin"
                            ValidationGroup="ValidarAdmin" PostBackUrl="~/PaginaAdministrador.aspx" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
