<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangePaymentCode.aspx.cs" Inherits="ChangePaymentCode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="StyleSheet.css" type="text/css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="header">
       <div class="md">
           <div class ="top"><a href="#"><img src="images/logo.png" alt="logo" /></a></div>
       </div>
    </div>
      <div class="frame">
         <div class="cbox tebox">
            <div class="changetext">
              <asp:Label ID="Label1" runat="server" Text="修改支付密码" style="color:black"></asp:Label>
            </div>
            <div class="changetext">
              账号：<asp:Label ID="lblUserTelphone" runat="server" Text="Label"></asp:Label>
            </div>
             <div class="changetext">
               <asp:Label ID="Label4" runat="server" Text="邮箱："></asp:Label>
               <asp:Label ID="lblEmail" runat="server" Text="Label"></asp:Label>
             </div>
             <div class="changetext">
               请输入验证码：<asp:TextBox ID="txtRandomCode" runat="server"></asp:TextBox>
             </div>
             <div class="changetext">
               <img src="ImageValue.ashx" id="vimg" alt="校验码" onclick="changeCode()" class="cimg" />
             </div>
            <script type="text/javascript">
                function changeCode() {
                    var imgNode = document.getElementById("vimg");
                    //handler/WaterMark.ashx
                    imgNode.src = "ImageValue.ashx?t=" + (new Date()).valueOf();  // 这里加个时间的参数是为了防止浏览器缓存的问题     
                }
            </script>
            <div class="changetext">
               <asp:Label ID="Label3" runat="server" Text="请输入邮箱随机码："></asp:Label>
               <asp:TextBox ID="txtEmailCode" runat="server"></asp:TextBox>
            </div>
            <div class="changetext">
               <asp:Button ID="btnGetEmailCode" runat="server" Text="获取验证码：" OnClick="btnGetEmailCode_Click" />
               <asp:Button ID="btnNext" runat="server" Text="下一步" OnClick="btnNext_Click" />
            </div>
        </div>
       </div>
    </form>
</body>
</html>
