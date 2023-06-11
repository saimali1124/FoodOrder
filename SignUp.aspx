<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign Up</title>
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
            width: 47%;
            height: 244px;
            margin-bottom: 27px;
        }
        .auto-style9 {
            margin-left: 1px;
            margin-bottom: 16px;
            margin-top: 0px;
        }
        .auto-style19 {
            width: 214px;
            height: 53px;
            text-align: center;
        }
        .auto-style20 {
            height: 53px;
            width: 237px;
        }
        .auto-style23 {
            width: 214px;
            height: 51px;
            text-align: center;
        }
        .auto-style24 {
            height: 51px;
            width: 237px;
        }
        .auto-style25 {
            width: 214px;
            height: 52px;
            text-align: center;
        }
        .auto-style26 {
            height: 52px;
            width: 237px;
        }
        .auto-style27 {
            margin-left: 55px;
        }
        .auto-style28 {
            height: 104px;
        }
        .auto-style29 {
            width: 214px;
            height: 66px;
            text-align: center;
        }
        .auto-style30 {
            height: 66px;
            width: 237px;
        }
        .auto-style31 {
            margin-left: 274px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style28">
            &nbsp;
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="Red" Text="FOOD ORDER" BackColor="White"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Button ID="Button2" runat="server" CssClass="auto-style31" OnClick="Button2_Click" Text="Home" Width="107px" />
            <br />
            &nbsp;
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Black" Text="Sign Up" BackColor="White"></asp:Label>
            <br />
            <br />
            <br />
        </div>
        <table border="1" class="auto-style1">
            <tr>
                <td class="auto-style19">Name</td>
                <td class="auto-style20">
                    <asp:TextBox ID="TextBox1" runat="server" Height="29px" Width="229px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style19">Email</td>
                <td class="auto-style20">
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style9" Height="32px" Width="229px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style23">Contact</td>
                <td class="auto-style24">
                    <asp:TextBox ID="TextBox3" runat="server" Height="29px" Width="229px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style25">Address</td>
                <td class="auto-style26">
                    <asp:TextBox ID="TextBox4" runat="server" Height="29px" Width="229px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style25">Password</td>
                <td class="auto-style26">
                    <asp:TextBox ID="TextBox5" runat="server" Height="29px" TextMode="Password" Width="229px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style25">Account Type</td>
                <td class="auto-style26">
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="18px" Width="233px">
                        <asp:ListItem>User</asp:ListItem>
                        <asp:ListItem>Admin</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style29"></td>
                <td class="auto-style30">
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style27" Text="Sign Up" Width="131px" OnClick="Button1_Click1" />
                    <br />
                    <br />
                    <asp:Label ID="Label3" runat="server" Font-Size="Medium" BackColor="White"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
