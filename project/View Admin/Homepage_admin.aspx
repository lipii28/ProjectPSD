<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage_admin.aspx.cs" Inherits="project.View_Admin.Homepage_admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="ManageRamenBtn" runat="server" Text="Manage Ramen" OnClick="ManageRamenBtn_Click" />
            <asp:Button ID="OrderQueueBtn" runat="server" Text="Order Queue" OnClick="OrderQueueBtn_Click" />
            <asp:Button ID="ProfileBtn" runat="server" Text="Profile" OnClick="ProfileBtn_Click" />
            <asp:Button ID="HistoryBtn" runat="server" Text="History" OnClick="HistoryBtn_Click" />
            <asp:Button ID="ReportBtn" runat="server" Text="Report" OnClick="ReportBtn_Click" />
            <asp:Button ID="LogoutBtn" runat="server" Text="Logout" OnClick="LogoutBtn_Click" style="height: 26px" />

            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
