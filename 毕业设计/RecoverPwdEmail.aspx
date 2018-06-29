<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RecoverPwdEmail.aspx.cs" Inherits="RecoverPwdEmail" %>

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
        <asp:Label ID="Label1" runat="server" Text="请用以下邮箱进行验证"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="邮箱："></asp:Label>
        <asp:Label ID="lblEmail" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="Label3" runat="server" Text="验证码:"></asp:Label>
        <asp:TextBox ID="txtInputEmail" runat="server"></asp:TextBox>
        <asp:Button ID="btnGetCode" runat="server" OnClick="btnGetCode_Click" Text="获取验证码" />
        <asp:Button ID="btnNext" runat="server" OnClick="btnNext_Click" Text="下一步" />
        </div>
       </div>
    </div>
    </form>
</body>
</html>
