<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangeUserPayment.aspx.cs" Inherits="ChangeUserPayment" %>

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
             <div class="changetext">
                    <asp:Label ID="Label1" runat="server" Text="重置支付密码"></asp:Label>
             </div>
             <div class="changetext">
                    <asp:Label ID="Label2" runat="server" Text="输入密码："></asp:Label>
                    <asp:TextBox ID="txtPwdOne" runat="server"></asp:TextBox>
             </div>
             <div class="changetext">
                    <asp:Label ID="Label3" runat="server" Text="请重新输入"></asp:Label>
                    <asp:TextBox ID="txtPwdTwo" runat="server"></asp:TextBox>
            </div>
             <div class="changetext">
                    <asp:Button ID="btnChangePaymentCode" runat="server" OnClick="btnChangePaymentCode_Click" Text="提交" />
            </div>
        </div>
      </div>
    </form>
</body>
</html>
