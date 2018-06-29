<%@ Page Language="C#" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="index.css" type="text/css" rel="stylesheet" />
    <script src="https://code.jquery.com/jquery-3.2.1.min.js" type="text/javascript"></script> 
    <script src="index.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="header">
     <div class="w">
      <span class="l toptext">欢迎来到DY商城!</span>
      <div class="r buycar">
           <a href="ShoppingCart.aspx" style="color:#CCC">
         <span class="icon car"></span>购物车(<span id="shuliang">&nbsp <asp:Label ID="lblSpCount" runat="server" Text="0"></asp:Label> &nbsp</span>)
               </a>
         <span id="buys">
             <asp:Label ID="lblSpDescribe" runat="server" Text="你的购物车还没有商品，快去挑选吧！"></asp:Label></span>
      </div>
      <div class="r login">
         <ul>
            <li><a><asp:HyperLink ID="hplUserinfo" runat="server" NavigateUrl="UserInfo.aspx"  >[hplUserinfo]</asp:HyperLink></a></li>
             <li><a><asp:LinkButton ID="lbtnLogout" runat="server" OnClick="lbtnLogout_Click" >退出</asp:LinkButton></a></li>
            <li><a id="userLoginShow" runat="server" href="login.aspx">登录</a></li>
            <li><a id="userRegister" runat="server" href="register.aspx">注册</a></li>
            <li><a href ="UserOrder.aspx">我的订单</a></li>
            <li><a href="#">帮助</a></li>
         </ul>
      </div>
     </div>
    </div>
    <div class="fixbox"></div>
    <div class="top_nav">
       <div class="w">
        <div class="l logo"><a href="#"><img width="183px" height="83px"  src="images/logo1.png" alt="logo" /></a></div>
          <div class="l nav">
            <a href="#">首页</a>
            <a href="UploadFlie.aspx">3D定制</a>
            <a href="ProductInfo.aspx?ProductKind=Kind_PhotoBook">照片书</a>
            <a href="ProductInfo.aspx?ProductKind=Kind_MuralPainting">墙画</a>
            <a href="ProductInfo.aspx?ProductKind=Kind_TXu">T恤</a>
            <a href="ProductInfo.aspx?ProductKind=Kind_Computer">电脑</a>
            <a href="javsscript:;">更多..</a>
          </div>
          <div class="r serch">
            <div class="input">
                <asp:TextBox ID="serchbox" runat="server" width="250px" Height="28px"></asp:TextBox></div>
                <span class="tuserch"></span>
          </div>
        </div>
    </div>
           <div class="head_slide">
                <div class="bimg">

                </div>
           </div>
    <div class="buying">
        <div class="w text"><p>DIY</p></div>
        <div class="w nav" style="height:40px;line-height:40px">
            <a href="UploadFlie.aspx">3D定制</a>
            <a href="ProductInfo.aspx?ProductKind=Kind_PhotoBook">照片书</a>
            <a href="ProductInfo.aspx?ProductKind=Kind_MuralPainting">墙画</a>
            <a href="ProductInfo.aspx?ProductKind=Kind_TXu">T恤</a>
            <a href="ProductInfo.aspx?ProductKind=Kind_Computer">电脑</a>
        </div>
        <div class="good_list">
                <div class="box1">
                    <a href="UploadFlie.aspx">
                        <div class="buy-icon zhizao">
                            
                        </div>
                        <p>3D定制</p>
                        <span>¥99元起</span>
                    </a>
                </div>
                <div class="box1">
                    <a href="ProductInfo.aspx?ProductKind=Kind_PhotoBook">
                        <div class="buy-icon photobook">
                        </div>
                        <p>照片书</p>
                        <span>¥19元起</span>
                    </a>
                </div>
                <div class="box1">
                    <a href="ProductInfo.aspx?ProductKind=Kind_MuralPainting">
                        <div class="buy-icon qianghua">
                        </div>
                         <p>墙画</p>
                         <span>¥29元起</span>
                    </a>
                </div>
                <div class="box1">
                    <a href="ProductInfo.aspx?ProductKind=Kind_TXu">
                        <div class="buy-icon Txue">
                            
                        </div>
                        <p>T恤</p>
                            <span>¥59元起</span>
                    </a>
                </div>
                <div class="box1">
                    <a href="ProductInfo.aspx?ProductKind=Kind_Computer">
                        <div class="buy-icon pc">
                            
                        </div>
                        <p>高性能主机</p>
                            <span>¥3999元起</span>
                    </a>
                </div>
                <div class="box1">
                    <a href="#">
                        <div class="buy-icon more">
                           
                        </div>
                         <span>更多</span>
                    </a>
                </div>
        </div>
    </div>
    <div class="footer">
         <div class="ioio">
            <span>
            <a href="#">关于我们</a>
            <a href="#">联系我们</a>
            <a href="#">友情链接</a>
            </span>
            <p>Copyright © 2018 xxx 版权所有 </p>
        </div>
    </div>
    </form>
</body>
</html>
