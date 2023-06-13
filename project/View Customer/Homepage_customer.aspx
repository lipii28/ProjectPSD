<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage_customer.aspx.cs" Inherits="project.View.Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="orderRamen" runat="server" Text="Order Ramen" OnClick="orderRamen_Click" />
            <asp:Button ID="history" runat="server" Text="History" OnClick="history_Click" />
            <asp:Button ID="profile" runat="server" Text="Profile" OnClick="profile_Click" />
            <asp:Button ID="logout" runat="server" Text="Log Out" OnClick="logout_Click" />

        </div>
    </form>
</body>
</html>
