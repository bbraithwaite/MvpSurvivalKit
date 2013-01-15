<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="MvpSurvivalKit.Web.Checkout" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>Products</h3>
        <ul>
        <asp:Repeater ID="uiProducts" runat="server">
            <ItemTemplate>
                <li><%#Eval("ProductName") %> : <%# Eval("UnitPrice", "{0:c}") %></li>
            </ItemTemplate>
        </asp:Repeater>
        </ul>

        Subtotal: <asp:Label ID="uiSubTotal" runat="server"></asp:Label><br />
        Discount: <asp:Label ID="uiDiscount" runat="server"></asp:Label><br />
        Total: <asp:Label ID="uiTotal" runat="server"></asp:Label>

        <h3>Checkout</h3>
        <div>
            <asp:Label ID="uiCardNumber" runat="server" AssociatedControlID="uxCardNumber">Card Number:</asp:Label>
            <asp:TextBox ID="uxCardNumber" runat="server" ></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="uiCustomerName" runat="server" AssociatedControlID="uxCustomerName">Card Name:</asp:Label>
            <asp:TextBox ID="uxCustomerName" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="uxCheckout" runat="server" Text="Checkout" onclick="uxCheckout_Click" />
    </div>
    </form>
</body>
</html>
