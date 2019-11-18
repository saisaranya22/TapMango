<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication6.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Register</div>
       
        <table class="auto-style2">
            <tr>
                <td>Username</td>
                <td>
                    <asp:TextBox ID="TextboxUsername" runat="server"></asp:TextBox>
                    
                </td>
               
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="TextboxPassword" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">UserLevel</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem Value="1">R1</asp:ListItem>
                        <asp:ListItem Value="2">R2</asp:ListItem>
                        <asp:ListItem Value="3">R3</asp:ListItem>
                        <asp:ListItem Value="4">R4</asp:ListItem>
                        <asp:ListItem Value="5">R5</asp:ListItem>
                    </asp:DropDownList>
                    </td>
               
                <td class="auto-style3"></td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Register_Button" runat="server" Text="Register" OnClick="TextBox2_TextChanged"/>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
       
    </form>
</body></html>
