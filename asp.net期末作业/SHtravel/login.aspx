<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <br/> <br/> <br/> <br/> <br/>

    <div style="width: 500px; height: 300px; margin: 0px auto 0px auto; border: 1px solid #0033CC">
        <div style="width:500px;height:60px;background-color:white;text-align:center;font-size:24px;text-decoration:underline;line-height:30px;">用户登录</div>
        <div style="width:460px;height:170px;background-color:lightblue;line-height:30px;text-align:left;padding-left:40px;font-size:24px;">&nbsp;　<br /> &nbsp;&nbsp;&nbsp; 帐号：<asp:TextBox ID="txtTelephone" runat="server"></asp:TextBox>
            <br />
            &nbsp;&nbsp;&nbsp;
            密码：<asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp; 是否保存：<asp:DropDownList ID="dpExpires" runat="server">
                <asp:ListItem Value="0">不保存</asp:ListItem>
                <asp:ListItem Value="1">保存一天</asp:ListItem>
                <asp:ListItem Value="30">保存一月</asp:ListItem>
                <asp:ListItem Value="365">保存一年</asp:ListItem>
            </asp:DropDownList>  
        </div>
        <div style="width:500px;height:65px; background-color:lightblue;text-align:center;line-height:40px;">
            <asp:Button ID="btnzhuce" runat="server" PostBackUrl="~/register.aspx" Text="注册" Width="60px" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnLogin" runat="server" Text="登录" Width="60px" OnClick="btnLogin_Click" />
        </div>
    </div>
    
      
        <br />&nbsp;<br />
        <br />
        <br />
        <br />
        <br/> <br/> <br/>
</asp:Content>

