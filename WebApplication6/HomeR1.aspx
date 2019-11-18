<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeR1.aspx.cs" Inherits="WebApplication6.HomeR1" %>
<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
   
    <meta charset="utf-8" />
    <title>Plants</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 210px;
            height: 177px;
        }
        .auto-style3 {
            width: 206px;
        }
        .auto-style4 {
            width: 168px;
            height: 206px;
        }
        .auto-style5 {
            width: 173px;
        }
        .auto-style6 {
            width: 183px;
            height: 225px;
        }
        .auto-style7 {
            width: 193px;
        }
        .auto-style8 {
            width: 163px;
            height: 212px;
        }
        .auto-style9 {
            width: 147px;
        }
        .auto-style10 {
            width: 140px;
            height: 183px;
            margin-left: 3px;
        }
        .auto-style11 {
            width: 206px;
            height: 49px;
        }
        .auto-style12 {
            width: 173px;
            height: 49px;
        }
        .auto-style13 {
            width: 193px;
            height: 49px;
        }
        .auto-style14 {
            width: 147px;
            height: 49px;
        }
        .auto-style15 {
            height: 49px;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">

    <table cellpadding="2" class="auto-style1">
        <tr>
            <td class="auto-style3">
                <img alt="Plant1" class="auto-style2" src="http://localhost:64124/images/Plant1.jpg" /></td>
            <td class="auto-style5">
                <img alt="Plant2" class="auto-style4" src="http://localhost:64124/images/Plant2.jpg" /></td>
            <td class="auto-style7">
                <img alt="Plant3" class="auto-style6" src="http://localhost:64124/images/Plant3.jpg" /></td>
            <td class="auto-style9">
                <img alt="Plant4" class="auto-style8" src="http://localhost:64124/images/Plant4.jpg" /></td>
            <td>
                <img alt="Plant5" class="auto-style10" src="http://localhost:64124/images/Plant5.jpg" /></td>
        </tr>
        <tr>
            <td class="auto-style3">Plant 1</td>
            <td class="auto-style5">Plant 2</td>
            <td class="auto-style7">Plant 3</td>
            <td class="auto-style9">Plant 4</td>
            <td>Plant 5</td>
        </tr>
        <tr>
            <td class="auto-style11">Last Watered:<asp:TextBox ID="Plant1Status" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style12">Last Watered:<asp:TextBox ID="Plant2Status" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style13">Last Watered:<asp:TextBox ID="Plant3Status" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style14">Last Watered:<asp:TextBox ID="Plant4Status" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style15">Last Watered:<asp:TextBox ID="Plant5Status" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

    </form>

</body>
</html>