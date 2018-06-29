<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddCartSuccess.aspx.cs" Inherits="AddCartSuccess" %>

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
      <span class="l toptext">欢迎来到DY商城!</span>
      <div class="r buycar">
         <span class="icon car"></span>购物车(<span id="shuliang">&nbsp 0 &nbsp</span>)
         <span id="buys">你的购物车还没有商品，快去挑选吧！</span>
      </div>
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
        <p style="font-size:18px;display:block;text-align:center">加入购物车成功！</p>
        <div class="jiesuan"><a><asp:LinkButton ID="lbPay" runat="server" OnClick="lbPay_Click" ForeColor="#CC3300">跳转到结算页面</asp:LinkButton></a></div>
    </div>
    </form>
</body>
</html>
