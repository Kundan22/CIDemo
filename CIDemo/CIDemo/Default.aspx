<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CIDemo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family:Verdana;">
        <strong>Arithmatic Operations<br />
        </strong><br />
    </div>
        <table style="font-family:Verdana;">
            <tr>
                <td>
                    <asp:TextBox ID="txtNum1" runat="server" Width="50px"></asp:TextBox>
                </td>
                <td>
                    <asp:DropDownList ID="ddlOperation" runat="server" Height="16px" Width="44px">
                        <asp:ListItem Value="Add">+</asp:ListItem>
                        <asp:ListItem Value="Subtract">-</asp:ListItem>
                        <asp:ListItem Value="Multiply">x</asp:ListItem>
                        <asp:ListItem Value="Devide">/</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:TextBox ID="txtNum2" runat="server" Width="50px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnResult" runat="server" Text="Result" OnClick="btnResult_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="4">
                    <br />
                    <asp:Label ID="lblResult" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
