<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderRamen_customer.aspx.cs" Inherits="project.View_Customer.OrderRamen_customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="orderRamenGV" runat="server" OnSelectedIndexChanged="orderRamenGV_SelectedIndexChanged" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="selectedBtn" runat="server" Text="Select" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="ramenName" HeaderText="Ramen Name" />
                    <asp:BoundField DataField="meatName" HeaderText="Meat" />
                    <asp:BoundField DataField="ramenBorth" HeaderText="Borth" />
                    <asp:BoundField DataField="ramenPrice" HeaderText="Price" />
                </Columns>
            </asp:GridView>
            <br />

            <asp:Label ID="ramenNameLbl" runat="server" Text="Ramen name "></asp:Label>
            <asp:TextBox ID="ramenNameTxt" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="meatNameLbl" runat="server" Text="Meat "></asp:Label>
            <asp:DropDownList ID="meatNameList" runat="server">
                <asp:ListItem Text="Tontkatsu"></asp:ListItem>
                <asp:ListItem Text="Babi"></asp:ListItem>
            </asp:DropDownList>
            <br />

            <asp:Label ID="ramenBorthLbl" runat="server" Text="Broth "></asp:Label>
            <asp:TextBox ID="ramenBorthTxt" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="ramenPriceLbl" runat="server" Text="Price "></asp:Label>
            <asp:TextBox ID="ramenPriceTxt" runat="server"></asp:TextBox>
            <br />

        </div>
        <div>
            <asp:GridView ID="cartGV" runat="server"></asp:GridView>
        </div>
        <div>
            <asp:Button ID="deleteBtn" runat="server" Text="Delete all" />
            <asp:Button ID="buyBtn" runat="server" Text="Buy cart" />
        </div>
    </form>
</body>
</html>
