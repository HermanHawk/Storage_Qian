<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserOrderInfo.aspx.cs" Inherits="UserOrderInfo" %>

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
        联系人：<asp:TextBox ID="txtConsignee" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        联系电话：<asp:TextBox ID="txtTelephone" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        送货地址：<asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="136px" Width="952px" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px">
            <Columns>
                <asp:ImageField DataImageUrlField="spProductImages" ControlStyle-Height="200px" ControlStyle-Width="200px">
                </asp:ImageField>
                <asp:ImageField HeaderText="用户DIY图纸" DataImageUrlField="spUserDiyPhoto">
                </asp:ImageField>
                <asp:BoundField HeaderText="商品名称" DataField="spProductName" />
                <asp:BoundField HeaderText="大小" DataField="spProductSize" />
                <asp:BoundField DataFormatString="{0:N2}" HeaderText="单价" DataField="spProductPrice" />
                <asp:BoundField HeaderText="数量" DataField="spAmount" />
                <asp:BoundField DataFormatString="{0:N2}" HeaderText="总金额" DataField="spProductTotal" />
            </Columns>
        </asp:GridView>
        合计金额：<asp:Label ID="lblSum" runat="server" ForeColor="Red" Text="Label"></asp:Label>
        <asp:LinkButton ID="lbPay" runat="server" OnClick="lbPay_Click">支付</asp:LinkButton>
        <div id ="paymentCode" runat="server">
           <asp:TextBox ID="txtPwd1" runat="server" Height="25px" Width="60px"></asp:TextBox>
           <asp:TextBox ID="txtPwd2" runat="server" Height="25px" Width="60px"></asp:TextBox>
           <asp:TextBox ID="txtPwd3" runat="server" Height="25px" Width="60px"></asp:TextBox>
           <asp:TextBox ID="txtPwd4" runat="server" Height="25px" Width="60px"></asp:TextBox>
           <asp:TextBox ID="txtPwd5" runat="server" Height="25px" Width="60px"></asp:TextBox>
           <asp:TextBox ID="txtPwd6" runat="server" Height="25px" Width="60px"></asp:TextBox>
           <asp:LinkButton ID="lbOk" runat="server" OnClick="lbOk_Click">提交订单</asp:LinkButton>
        </div> 
       </div>
    </form>
</body>
</html>
