<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserInfo.aspx.cs" Inherits="UserInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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
         <div class="userph">
           <asp:Image ID="userPhoto" runat="server" Height="150px"  Width="150px" />
         </div>
           <asp:Label ID="Label1" runat="server" Text="个人信息" class="changetext"></asp:Label>
          <div class="changetext">
             <asp:Label ID="Label2" runat="server" Text="用户名：" ></asp:Label>
             <asp:Label ID="lblUserName" runat="server" Text="Label"></asp:Label>
          </div>
          <div class="changetext">
             <asp:Label ID="Label4" runat="server" Text="账号："></asp:Label>
             <asp:Label ID="lblUserTel" runat="server" Text="Label"></asp:Label>
          </div>
          <div class="changetext">
           <asp:Label ID="Label6" runat="server" Text="邮箱：" ></asp:Label>
           <asp:Label ID="lblUserEmail" runat="server" Text="Label" ></asp:Label>
          </div>
           <asp:LinkButton ID="lbtChangeUserInfo" runat="server" PostBackUrl="~/ChangeUserInfo.aspx" class="changelb">修改个人信息</asp:LinkButton>
           <asp:LinkButton ID="lbtUserChangePwd" runat="server" PostBackUrl="~/RecoverPassword.aspx" class="changelb">修改密码</asp:LinkButton>
      </div>
    </div>
    </form>
</body>
</html>
