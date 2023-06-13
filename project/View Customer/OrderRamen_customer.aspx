<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderRamen_customer.aspx.cs" Inherits="project.View_Customer.OrderRamen_customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Order Ramen</h1>
            <h3>Menu Ramen</h3>
            <asp:GridView ID="orderRamenGV" runat="server" OnSelectedIndexChanged="orderRamenGV_SelectedIndexChanged" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="selectedBtn" runat="server" Text="Add" OnClick="selectedBtn_Click" CommandArgument='<%# Eval("ramenId")%>'/>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="ramenId" HeaderText="Ramen ID" />
                    <asp:BoundField DataField="ramenName" HeaderText="Ramen Name" />
                    <asp:BoundField DataField="meatName" HeaderText="Meat" />
                    <asp:BoundField DataField="ramenBorth" HeaderText="Borth" />
                    <asp:BoundField DataField="ramenPrice" HeaderText="Price" />
                </Columns>
            </asp:GridView>
            <br />
        </div>
        <div>
            <h3>Your Order</h3>
            <asp:GridView ID="cartGV" runat="server"></asp:GridView>
        </div>
        <div>
            <asp:Button ID="deleteBtn" runat="server" Text="Delete all" OnClick="deleteBtn_Click" />
            <asp:Button ID="buyBtn" runat="server" Text="Buy cart" OnClick="buyBtn_Click" />
        </div>
    </form>
</body>
</html>
