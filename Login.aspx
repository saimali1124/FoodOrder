<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
        Login
    </title>
    <style>
        body {
            background-image: url('bg.jpg');
            background-repeat: no-repeat;
            background-attachment: fixed;
            background-size: 100% 100%;
        }
    </style>
    <style type="text/css">
        .auto-style1 {
            height: 74px;
            width: 936px;
        }
        .auto-style2 {
            width: 35%;
            height: 176px;
            margin-top: 51px;
        }
        .auto-style3 {
            height: 47px;
        }
        .auto-style4 {
            height: 47px;
            width: 159px;
            text-align: center;
        }
        .auto-style5 {
            width: 159px;
            text-align: center;
        }
        .auto-style6 {
            margin-right: 0px;
            margin-top: 0px;
        }
        .auto-style7 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="Red" Text="FOOD ORDER" BackColor="White"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" CssClass="auto-style7" Height="32px" OnClick="Button2_Click" Text="Home" Width="69px" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Size="X-Large" Text="LOG IN" Font-Bold="True" BackColor="White"></asp:Label>
        </div>
        <table class="auto-style2" dir="ltr" border="1">
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label4" runat="server" BackColor="White" Text="Email"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server" Height="24px" Width="148px" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label5" runat="server" BackColor="White" Text="Password"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server" Height="24px" Width="148px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style6" Height="27px" OnClick="Button1_Click" Text="Login" Width="155px" />
                    <br />
                    <br />
                    <asp:Label ID="Label3" runat="server" BackColor="White"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
