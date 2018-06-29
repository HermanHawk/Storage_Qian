<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserOrder.aspx.cs" Inherits="UserOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="index.css" type="text/css" rel="stylesheet" />
<script src="https://code.jquery.com/jquery-3.2.1.min.js" type="text/javascript"></script> 
<script src="index.js" type="text/javascript"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="header">
      <div class="w">
          <span class="l toptext">你的订单列表</span>
        <div class="r login">
         <ul>
            <li><a href ="UserOrder.aspx">我的订单</a></li>
            <li><a href="#">帮助</a></li>
            <li><a href="home.aspx">返回首页</a></li>
         </ul>
       </div>
     </div>
    </div>
        <div class="w">
           <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" SelectCommand="SELECT TOP (5) Orders.UserAddress, Orders.orderDate, OrderItems.orderPrice, OrderItems.orderSumPrice, OrderItems.amount, OrderItems.ProductName, OrderItems.ProductImages, OrderItems.ProductDiv, OrderItems.ProductSize, OrderItems.OrderID FROM OrderItems INNER JOIN Orders ON OrderItems.OrderID = Orders.OrderID
where orders.userTel = @telephone
ORDER BY orders.orderDate DESC">
            <SelectParameters>
                <asp:SessionParameter Name="telephone" SessionField="telephone" />
            </SelectParameters>
        </asp:SqlDataSource>
      <div class="personlite">
         <div class="name">
            <asp:Label ID="lblUserOrder" runat="server" Text="Label"></asp:Label>
         </div>
        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" RepeatColumns="1" RepeatDirection="Horizontal">
            <ItemTemplate>
              <div class="tb">
                订单时间：
                <asp:Label ID="orderDateLabel" runat="server" Text='<%# Eval("orderDate") %>' />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                订单号:
                <asp:Label ID="lblOrderID" runat="server" Text='<%# Eval("orderID") %>'></asp:Label>
                <br />
                <asp:Image ID="Image1" runat="server" Height="60px" ImageUrl='<%# Eval("ProductImages") %>' Width="60px" />
                <asp:Label ID="lblProductName" runat="server" Text='<%# Eval("ProductName") %>' />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                DIY图纸：
                <asp:Image ID="Image2" runat="server" Height="60px" ImageUrl='<%# Eval("ProductDiv") %>' Width="60px" />&nbsp;&nbsp;&nbsp;
                大小:
                <asp:Label ID="ProductSizeLabel" runat="server" Text='<%# Eval("ProductSize") %>' />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                单价:
                <asp:Label ID="orderPriceLabel" runat="server" Text='<%# Eval("orderPrice") %>' />&nbsp;&nbsp;&nbsp;&nbsp;
                数量:
                <asp:Label ID="amountLabel" runat="server" Text='<%# Eval("amount") %>' />&nbsp;&nbsp;&nbsp;&nbsp;
                总额:
                <asp:Label ID="orderSumPriceLabel" runat="server" Text='<%# Eval("orderSumPrice") %>' />&nbsp;&nbsp;&nbsp;
                
                地址:
                <asp:Label ID="UserAddressLabel" runat="server" Text='<%# Eval("UserAddress") %>' />
              </div>
            </ItemTemplate>
        </asp:DataList>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="查看更多" />
      </div>
     </div>
    </form>
</body>
</html>
