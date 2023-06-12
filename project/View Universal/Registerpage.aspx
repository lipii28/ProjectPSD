<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registerpage.aspx.cs" Inherits="project.View_Universal.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1>Register</h1>
            <br/>
            <asp:Label ID="label1" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="Username" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="label2" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="Email" runat="server"></asp:TextBox>
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">   

                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>

            </asp:RadioButtonList>
            <br />
            <asp:Label ID="label3" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="Password" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="label4" runat="server" Text="Confirm Password"></asp:Label>
            <asp:TextBox ID="Confirmpassword" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="submit" runat="server" Text="Register" OnClick="submit_Click" />
            <br />
            <br />
            <asp:Label ID="falidasi" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>
