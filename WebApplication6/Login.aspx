<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication6.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>
    <style type="text/css">
        #Text1 {
            height: 22px;
        }
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
            text-align: right;
        }
        .auto-style4 {
            text-align: right;
        }
        .auto-style5 {
            text-align: center;
        }
        #TextboxUsername {
            width: 131px;
        }
        .auto-style6 {
            margin-left: 67px;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">

    <h1 class="auto-style5">Login</h1>
    

    <table class="auto-style1">
        <tr>
            <td class="auto-style3">Username</td>
            <td>
                <asp:TextBox ID="TextboxUsername" runat="server"></asp:TextBox>         
            </td>
           
            <td class="auto-style2">
                
  
            </td>           
         
        </tr>
        <tr>
            <td class="auto-style4">Password</td>
            <td>

                <asp:TextBox ID="TextboxPassword" runat="server"></asp:TextBox>

            </td>
           

            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>             
                <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button_Login_Click" />              
                <asp:Button ID="Button2" runat="server" Text="Register" OnClick="Button_Register_Click" CssClass="auto-style6"/>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    

    </form>
    

</body>

</html>
