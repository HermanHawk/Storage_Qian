<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RecoverPassword.aspx.cs" Inherits="RecoverPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="StyleSheet.css" type="text/css" rel="stylesheet" />
    <title></title>
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
              <p>找回密码</p>
             <asp:Label ID="Label1" runat="server" Text="账户名：" class="lb"></asp:Label>
             <asp:TextBox ID="txtTel" runat="server" Height="25px" Width="300px" style="margin-bottom:10px"></asp:TextBox>
             <asp:Label ID="Label2" runat="server" Text="验证码："  class="lb"></asp:Label>
             <asp:TextBox ID="txtPwd" runat="server" Height="25px" OnTextChanged="txtPwd_TextChanged" Width="100px"></asp:TextBox>
             <img src="ImageValue.ashx" id="vimg" alt="校验码" onclick="changeCode()" class="cimg"/>
             <script  type="text/javascript">
            function changeCode() {
                var imgNode = document.getElementById("vimg");
                //handler/WaterMark.ashx
                imgNode.src = "ImageValue.ashx?t=" + (new Date()).valueOf();  // 这里加个时间的参数是为了防止浏览器缓存的问题     
            }
            </script>  
            <asp:Button ID="btnNext" runat="server" OnClick="btnNext_Click" Text="下一步" class="tn" Height="30px" Width="90px" BackColor="#CC3300" BorderStyle="Solid" ForeColor="White"/>
            <a href="Login.aspx" style="font-size:12px;color:#666;display:block;margin-left:10px" >返回登录</a>
        </div>
       </div>  
    </div>
    </form>
</body>
</html>
