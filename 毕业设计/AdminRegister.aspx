<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminRegister.aspx.cs" Inherits="AdminRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="StyleSheet.css" type="text/css" rel="stylesheet" />
    <script src="https://code.jquery.com/jquery-3.2.1.min.js" type="text/javascript"></script> 
    <script src="index.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <div class="header">
       <div class="md">
           <div class ="top"><a href="#"><img src="images/logo.png" alt="logo" /></a></div>
       </div>
    </div>
    <div class="frame">
        <div class="cbox tebox">
           <h1>创建管理员帐户</h1>
           <div class="box id-box">
              <h3>您的姓名</h3>
              <asp:TextBox ID="Txtname" runat="server" Height="28px"  class="textbox" value="可输入中文或者英文或者数字,限8个字符"
                   onkeyup="value=value.replace(/[^\a-\z\A-\Z0-9\u4E00-\u9FA5]/g,'')" onpaste="value=value.replace(/[^\a-\z\A-\Z0-9\u4E00-\u9FA5]/g,'')" 
                  oncontextmenu = "value=value.replace(/[^\a-\z\A-\Z0-9\u4E00-\u9FA5]/g,'')" 
                  maxlength="8"></asp:TextBox>
               <asp:Label ID="tnl" runat="server" ForeColor="#CC0000" Text="用户名不能为空！" class=
                   ></asp:Label>
           </div>
           <div class="box  ph-box">
              <h3>手机号码</h3>
              <asp:TextBox ID="Txtph" runat="server" Height="28px" class="textbox" value="请输入正确电话号码" ></asp:TextBox>
               <asp:Label ID="phl" runat="server" ForeColor="#CC0000" Text="手机号不能为空！" class="lbl"></asp:Label>
               
           </div>
           <div class="box em-box">
               <h3>电子邮箱（可选）</h3>
              <asp:TextBox ID="Txtemail" runat="server" Height="28px" class="embox"></asp:TextBox>
           </div>
           <div class="box pw-box">
               <h3>密码</h3>
              <asp:TextBox ID="Txtpwd" runat="server" Height="28px" class="textbox" value="可以输入数字或者字母,不能少于6数字" 
                  onKeyUp="value=value.replace(/[^\d|chun]/g,'')"></asp:TextBox>
               <asp:Label ID="pwdl" runat="server" ForeColor="#CC0000" Text="密码不能为空！" class="lbl"></asp:Label>
           </div>
           <div class="btn-box">
               
               <asp:RadioButton ID="RadioButton1" runat="server" Text="我已阅读并同意网站使用条件及隐私条款" />
               <br />
               <br />
               <asp:Button ID="btnagree" runat="server" Text="注册" BackColor="#E4393C" 
                   ForeColor="White" Height="32px" Width="100%" BorderColor="White" 
                   BorderStyle="None" class="btnagree" OnClick="btnagree_Click"/>   
           </div>
           <div class="re-box">
               <span >已有账号？<a href="Login.aspx">登录</a></span>
           </div>
        </div>
    </div>
    <div class="foot">
         <div class="m-foot"">
         <ul id="foot-ul">
           <li><a href="#">使用条件</a></li>
           <li><a href="#">隐私声明</a></li>
           <li><a href="#">帮助</a></li>
         </ul>
         <span>版权所有 © 2018，xxx公司或其关联公司 </span>
         </div>
    </div>
    </div>
    </form>
</body>
</html>
