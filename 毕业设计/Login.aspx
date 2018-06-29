<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" type="text/css" rel="stylesheet" />
    <script src="https://code.jquery.com/jquery-3.2.1.min.js" type="text/javascript"></script> 
    <script src="index.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="top">
         <div class=" logo">
            <a href=" #"><img src="images/logo.png" alt="logo"/></a>
            <b>欢迎登录</b>   
         </div>
         <div class="r-tishi"><span></span>登录页面</div>
    </div>
    <div class="k"><span>依据《网络安全法》，为保障您的账户安全和正常使用，请尽快完成手机号验证！将更有利于保护您的个人隐私</span></div>
    <div class="content">
       <div class="w">
         <div class="denglu">
            <span class="s-tishi">商城不会以任何理由要求你转帐汇款，谨防诈骗</span>
            <span class="zhanghao">账号登录</span>
            <div class="loginbox">
               <div class="m loginform">
                   <asp:Label ID="logintou" runat="server" Height="40px" Width="40px" 
                       class="l-icon  loginn"></asp:Label>
                   <asp:TextBox ID="loginname" runat="server" Width="250px" class="text loginname" 
                       BorderStyle="None" value="请输入手机号码" ></asp:TextBox>
                </div>
               <div class="m pwdform">
                   <asp:Label ID="loginpass" runat="server" Height="40px" Width="40px" 
                       class="l-icon loginp" ></asp:Label>
                   <asp:TextBox ID="password" runat="server" Width="250px" class=" text password" 
                       TextMode="Password" ></asp:TextBox>
                </div>
               <a id="forgetpwd" href="RecoverPassword.aspx">忘记密码</a>
               <div class="btndenglu">
                   <asp:Button ID="btndenglu" runat="server" BackColor="#E4393C" ForeColor="White" 
                       Height="36px" Text="登  录" Width="306px" Font-Size="16px" class="btnd" OnClick="btndenglu_Click" />
               </div>
               <div class="regist"><a href="register.aspx">立即注册<span></span></a></div>
            </div>
         </div>
       </div>
     </div>
    <div class="footer">
        <div class="md">
          <ul>
            <a href="#">关于我们</a>
            <span>|</span>
            <a href="#">联系我们</a>
            <span>|</span>
            <a href="#">友情链接</a>
          </ul>
            <p>Copyright © 2018 xxx 版权所有 </p>
        </div>
    </div>
    </form>
</body>
</html>
