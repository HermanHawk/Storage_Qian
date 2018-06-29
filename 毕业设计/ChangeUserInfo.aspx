<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangeUserInfo.aspx.cs" Inherits="ChangeUserInfo" %>

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
            <asp:Panel ID="Panel1" runat="server" >
            <asp:Panel ID="Panel2" runat="server" >
               <div class="userph">
                  <asp:Image ID="userImage" runat="server" Height="150px" Width="150px" />
               </div>
            </asp:Panel>
            <div class="changetext">
             头像：<asp:FileUpload ID="FupUserPhoto" runat="server" Height="30px" Width="200px" />
             <asp:Panel ID="Panel3" runat="server" >
             </asp:Panel>
            </div>
            <div class="changetext">
                <asp:Label ID="Label1" runat="server" Text="账号："></asp:Label>
                <asp:Label ID="lblTelephone" runat="server" Text="Label"></asp:Label>
            </div>
            <div class="changetext">
                <asp:Label ID="Label2" runat="server" Text="用户名："></asp:Label>
                <asp:TextBox ID="txtUserName" runat="server" Height="20px" Width="170px"></asp:TextBox>
            </div>
            <div class="changetext">
                <asp:Label ID="Label3" runat="server" Text="邮  箱："></asp:Label>
                <asp:TextBox ID="txtUserEmail" runat="server" Height="20px" Width="180px"></asp:TextBox>
            </div>
            <div class="changetext">
                <asp:Button ID="btnChangeUserinfo" runat="server" Height="30px" OnClick="btnChangeUserinfo_Click" Text="确认修改" Width="150px" />
                <asp:LinkButton ID="lbtChangePaymentCode" runat="server" PostBackUrl="~/ChangePaymentCode.aspx" style="color:#2489d4">修改支付密码</asp:LinkButton>
            </div>
        </asp:Panel>
       </div>
     </div> 
    </form>
</body>
</html>
