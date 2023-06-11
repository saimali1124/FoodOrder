<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderHistory.aspx.cs" Inherits="OrderHistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order History</title>
    <style>
        body {
            background-image: url('bg.jpg');
            background-repeat: no-repeat;
            background-attachment: fixed;
            background-size: 100% 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" BackColor="White" Font-Size="XX-Large" ForeColor="#CC0000" Text="FOOD ORDER"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign Out" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Home" Width="62px" />
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label2" runat="server" BackColor="White" Font-Size="X-Large" ForeColor="#660066" Text="Your Order History:"></asp:Label>
        </p>
        <asp:GridView ID="GridView1" runat="server" BackColor="White">
        </asp:GridView>
        <p>
            &nbsp;</p>
        <asp:Label ID="Label3" runat="server" BackColor="White" Font-Size="Large" Text="Add Review:"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" BackColor="White" Text="RestaurantID"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Width="133px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" BackColor="White" Text="Order ID"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Width="156px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" BackColor="White" Text="Review"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Width="169px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Submit" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" BackColor="White"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" BackColor="White" Font-Size="Large" Text="All Reviews:"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GridView2" runat="server" BackColor="White">
        </asp:GridView>
    </form>
</body>
</html>
