<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loginpage.aspx.cs" Inherits="project.View_Login.Loginpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1>Log In</h1>
            <br/>
            <asp:TextBox ID="Username" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="Password" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="Remember_me" runat="server" Text ="Remember me"/>
            <br />
            <asp:Button ID="submit" runat="server" Text="Log In" OnClick="submit_Click" />


            

        </div>
    </form>
</body>
</html>
