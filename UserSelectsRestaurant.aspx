<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserSelectsRestaurant.aspx.cs" Inherits="UserSelectsRestaurant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Choose</title>
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

            <br />
            <asp:Label ID="Label2" runat="server" BackColor="White" Font-Size="XX-Large" ForeColor="#CC0000" Text="FOOD ORDER"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign Out" Width="68px" />
            <br />
            <br />
            <br />

            <asp:GridView ID="GridView_UserSelectedRest" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView_UserSelectedRest_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>

        </div>

        <br />

        <asp:Label ID="lbl_ChooseFoods_UserSelectedRest" runat="server" Text="Choose Food ID " BackColor="White"></asp:Label>
        <asp:TextBox ID="txtbox_Foods_UserSelectedRest" runat="server" ></asp:TextBox>
        <br />
        <asp:Label ID="lbl_ChooseFoodsQuantity_UserSelectedRest" runat="server" Text="Choose Food Quantity " BackColor="White"></asp:Label>
        <asp:TextBox ID="txtbox_FoodsQuantity_UserSelectedRest" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbl_UserSOrderMethod" runat="server" Text="Choose Order Method " BackColor="White"></asp:Label>
        <asp:TextBox ID="txtbox_UserSOrderMethod" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbl_UserSPaymentType" runat="server" Text="Choose Payment Type " BackColor="White"></asp:Label>
        <asp:TextBox ID="txtbox_UserSPaymentType" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="label1" runat="server" Text="In Case of Payment Type Card, Enter Card ID and Card Pin" BackColor="White"></asp:Label>
        <br />
        <asp:Label ID="lbl_UserSCardID" runat="server" Text="Card ID " BackColor="White"></asp:Label>
        <asp:TextBox ID="txtbox_UserSCardID" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbl_UserSPin" runat="server" Text="Pin " BackColor="White"></asp:Label>
        <asp:TextBox ID="txtbox_UserSPin" runat="server"></asp:TextBox>
        <br /><br />

        <asp:Button ID="bttn_Submit_OrderList" runat="server" Text="Submit" OnClick="bttn_Submit_OrderList_Click" />

        <asp:Button ID="btn_Back_UserSelectedRest" runat="server" Text="Go Back" OnClick="btn_Back_UserSelectedRest_Click" />

    </form>
</body>
</html>
