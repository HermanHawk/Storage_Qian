<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserOrderSuccess.aspx.cs" Inherits="UserOrderSuccess" %>

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
        下单成功！
        
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" SelectCommand="SELECT * FROM [Orders] WHERE ([OrderID] = @OrderID)">
            <SelectParameters>
                <asp:QueryStringParameter Name="OrderID" QueryStringField="OrderID" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        <asp:GridView ID="gvOrderItems" runat="server" AutoGenerateColumns="False" DataSourceID="dsOriderItems" Width="952px">
            <Columns>
                <asp:ImageField DataImageUrlField="ProductImages" HeaderText="图片" SortExpression="ProductImages" ControlStyle-Height="300px" ControlStyle-Width="300px">
                </asp:ImageField>
                <asp:ImageField DataImageUrlField="ProductDiv" HeaderText="用户Div图纸" SortExpression="ProductDiv">
                </asp:ImageField>
                <asp:BoundField DataField="ProductName" HeaderText="名称" SortExpression="ProductName" />
                <asp:BoundField DataField="amount" HeaderText="数量" SortExpression="amount" />
                <asp:BoundField DataField="orderPrice" HeaderText="单价" SortExpression="orderPrice" DataFormatString="{0:N2}" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="dsOriderItems" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" SelectCommand="SELECT OrderItems.amount, OrderItems.orderPrice, OrderItems.ProductName, OrderItems.ProductImages, OrderItems.ProductDiv,Orders.OrderID FROM OrderItems INNER JOIN Orders ON OrderItems.OrderID = Orders.OrderID WHERE (Orders.OrderID = @OrderID)">
            <SelectParameters>
                <asp:QueryStringParameter Name="OrderID" QueryStringField="OrderID" />
            </SelectParameters>
        </asp:SqlDataSource>&nbsp;&nbsp;&nbsp;
        <br />
        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1">
            <ItemTemplate>
                订单号:
                <asp:Label ID="lblOrderID" runat="server" Text='<%# Eval("OrderID") %>'></asp:Label>
                <br />
                联系人:
                <asp:Label ID="lbluserName" runat="server" Text='<%# Eval("userName") %>'></asp:Label>
                <br />
                联系方式:
                <asp:Label ID="lblUserTel" runat="server" Text='<%# Eval("UserTel") %>'></asp:Label>
                <br />
                送货地址:
                <asp:Label ID="lblUserAddress" runat="server" Text='<%# Eval("UserAddress") %>'></asp:Label>
                <br />
                日期:
                <asp:Label ID="lblorderDate" runat="server" Text='<%# Eval("orderDate") %>'></asp:Label>
                <br />
                <br />
            </ItemTemplate>
        </asp:DataList>
        已付:<asp:Label ID="lblPay" runat="server" Text="Label"></asp:Label>&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="hylReturn" runat="server" NavigateUrl="~/home.aspx">返回</asp:HyperLink>
      </div>
    </form>
</body>
</html>
