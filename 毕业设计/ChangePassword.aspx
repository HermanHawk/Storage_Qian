<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="ChangePassword" %>

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
            <div class="cbox">
               <asp:Label ID="Label3" runat="server" Text="设置新密码" class="lb"></asp:Label>
               <asp:Label ID="Label1" runat="server" Text="输入新密码：" class="lb"></asp:Label>
               <asp:TextBox ID="txtNewPwdOne" runat="server" Height="25px" Width="200px"></asp:TextBox>
               <asp:Label ID="Label2" runat="server" Text="请重新输入：" class="lb"></asp:Label>
               <asp:TextBox ID="txtNewPwdTwo" runat="server" Height="25px" Width="200px"></asp:TextBox>
               <asp:Button ID="btnChange" runat="server" OnClick="btnChange_Click" Text="提交" BackColor="#CC3300" ForeColor="White" />
               <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx" style="margin-left:10px">去登录</asp:HyperLink>
           </div>
        </div>
    </div>
    </form>
</body>
</html>
