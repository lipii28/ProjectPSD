<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageRamenpage_admin.aspx.cs" Inherits="project.View_Admin.ManageRamenpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="RamenGV" runat="server"></asp:GridView>
            <asp:Button ID="UpdateBtn" runat="server" Text="Update" />
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </div>
    </form>
</body>
</html>
