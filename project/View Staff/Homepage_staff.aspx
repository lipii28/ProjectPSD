<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage_staff.aspx.cs" Inherits="project.View_Staff.Homepage_staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Button ID="Home" runat="server" Text="Home" OnClick ="Home_Click"/>
            <asp:Button ID="Manage_ramen" runat="server" Text="Manage Ramen" OnClick ="Manage_ramen_Click"/>
            <asp:Button ID="Order" runat="server" Text="Order" OnClick ="Order_Click"/>
            <asp:Button ID="Login" runat="server" Text="Login" OnClick ="Login_Click"/>
            <asp:Button ID="Logout" runat="server" Text="Logout" OnClick ="Logout_Click"/>
            <br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>

        </div>
    </form>
</body>
</html>
