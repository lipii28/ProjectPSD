<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hompage_admin.aspx.cs" Inherits="project.View_Admin.Hompage_staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="ManageRamenBtn" runat="server" Text="Manage Ramen" />
            <asp:Button ID="OrderQueueBtn" runat="server" Text="Order Queue" />
            <asp:Button ID="ProfileBtn" runat="server" Text="Profile" />
            <asp:Button ID="HistoryBtn" runat="server" Text="History" />
            <asp:Button ID="ReportBtn" runat="server" Text="Report" />
            <asp:Button ID="LogoutBtn" runat="server" Text="Logout" />

            <asp:GridView ID="GridView1" runat="server"></asp:GridView>

        </div>
    </form>
</body>
</html>
