<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Restaurants.aspx.cs" Inherits="Restaurants" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Restaurants</title>
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

        <asp:Label ID="RestI" runat="server" Text="Restaurant ID"></asp:Label>
        <asp:TextBox ID="RestID" runat="server"></asp:TextBox>

        <asp:Label ID="RestN" runat="server" Text="Restaurant Name"></asp:Label>
        <asp:TextBox ID="RestName" runat="server"></asp:TextBox>

        <asp:Label ID="RestL" runat="server" Text="Restaurant Location"></asp:Label>
        <asp:TextBox ID="RestLocation" runat="server"></asp:TextBox>

         <asp:Label ID="RestS" runat="server" Text="Restaurant Open Status"></asp:Label>
        <asp:TextBox ID="RestStatus" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit"/>

        <br /><br />

        <div>
            <asp:GridView ID="OpeningRest1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="RestaurantID">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField ButtonType="Button" ShowEditButton="True" >
                    <ControlStyle BackColor="#00CC00" ForeColor="White" />
                    </asp:CommandField>
                    <asp:CommandField ButtonType="Button" ShowDeleteButton="True">
                    <ControlStyle BackColor="#990000" ForeColor="White" />
                    </asp:CommandField>
                    
                </Columns>
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
    </form>
</body>
</html>

