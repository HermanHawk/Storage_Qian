<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShoppingCart.aspx.cs" Inherits="ShoppingCart" %>

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
      <span class="l toptext">你的DY购物车</span>
      <div class="r login">
         <ul>
            <li><a href ="UserOrder.aspx">我的订单</a></li>
            <li><a href="#">帮助</a></li>
            <li><a href="home.aspx">返回首页</a></li>
         </ul>
      </div>
     </div>
    </div>
       <div class="w" style="padding-bottom:100px;" >
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" OnRowDataBound="GridView1_RowDataBound" GridLines="None" BorderStyle="Solid" Width="951px" BorderColor="#CCCCCC" BorderWidth="1px" BackColor="#FFF4E8">
            <Columns>
                <asp:ImageField DataImageUrlField="spProductImages"><ControlStyle Height="150px" Width="150px"></ControlStyle>
                </asp:ImageField>
                <asp:BoundField HeaderText="商品名称" DataField="spProductName" />
                <asp:BoundField HeaderText="大小" DataField="spProductSize" />
                <asp:BoundField DataFormatString="{0:N2}" HeaderText="价格" DataField="spProductPrice" />
                <asp:BoundField HeaderText="数量" DataField="spAmount" />
                <asp:ImageField HeaderText="用户DIY图纸" DataImageUrlField="spUserDiyPhoto">
                </asp:ImageField>
                <asp:BoundField DataFormatString="{0:N2}" HeaderText="总金额" DataField="spProductTotal" />
                <asp:BoundField HeaderText="日期" DataField="spDate" />
                <asp:ButtonField CommandName="del" HeaderText="删除" Text="删除" />
            </Columns>
            <FooterStyle BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" />
        </asp:GridView>
         <div class="btnshop">
           <asp:Label ID="lblSum" runat="server" Visible="False"></asp:Label>
           <asp:Button ID="btnClear" runat="server" OnClientClick="javascript:return confirm('确认要删除吗？')" Text="清空购物车" OnClick="btnClear_Click" />
           <asp:Button ID="btnSubmit" runat="server" Text="提交订单" OnClick="btnSubmit_Click" />
         </div>
      </div>
    </form>
</body>
</html>
