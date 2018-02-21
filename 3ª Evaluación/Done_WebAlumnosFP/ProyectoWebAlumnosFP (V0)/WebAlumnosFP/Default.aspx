<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAlumnosFP.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .columna_izquierda {
            width: 25%;
        }
        .columna_central {
            width: 50%;
            text-align:center;
        }
        .columna_derecha {
            width: 25%;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lbCabecera" runat="server" Text=""></asp:Label>
        <asp:Panel ID="panelAlumnos" runat="server" Width="100%" Height="350" ScrollBars="Auto">
            <asp:GridView ID="dgv" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnRowDeleting="dgv_RowDeleting" OnRowEditing="dgv_RowEditing">
                <Columns>
                    <asp:CommandField ButtonType="Button" DeleteText="Del" EditText="Edit" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" />
                </Columns>
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#330099" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <SortedAscendingCellStyle BackColor="#FEFCEB" />
                <SortedAscendingHeaderStyle BackColor="#AF0101" />
                <SortedDescendingCellStyle BackColor="#F6F0C0" />
                <SortedDescendingHeaderStyle BackColor="#7E0000" />
            </asp:GridView>

        </asp:Panel>
        <br />
        <asp:Panel ID="panelControles" runat="server" Width="100%" Height="75" BackColor="#FF8000">
            <br />
            <table style="width:100%;">
                <tr>
                    <td class="columna_izquierda">&nbsp;
                        <asp:Button ID="btnAnyadir" runat="server" Text="Añadir Alumno" Font-Bold="True" OnClick="btnAnyadir_Click" /></td>
                    <td class="columna_central">
                        <asp:DropDownList ID="ddlGrupos" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlGrupos_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td class="columna_derecha">&nbsp;&nbsp;
                        <asp:Button ID="btnGestionGrupos" runat="server" Font-Bold="True" Text="Gestionar Grupos" />
                    </td>
                </tr>
                
            </table>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
