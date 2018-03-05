<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <script type="text/javascript">
         function myClass(src, args) {
             if (args.Value > 0)
                 args.IsValid = true;
             else
                 args.IsValid = false;
         }

    </script>
   <p>
        &nbsp;</p>
<p>
        &nbsp;</p>
<p>
        &nbsp;</p>
<p>
        &nbsp;</p>
<p>
        &nbsp;</p>
    <h3>用户注册</h3>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ShowSummary="False" />
     <div style="border: 1px solid #000080; margin: 0px auto 0px auto; font-size: 12px; line-height: 30px; text-align: left; padding-top: 20px; padding-bottom: 20px; padding-left:70px; width: 400px;">
&nbsp;&nbsp;&nbsp; 姓名：<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtUserName" Display="Dynamic" ErrorMessage="姓名必填！" ForeColor="#FF3300" SetFocusOnError="True"></asp:RequiredFieldValidator>
        <br />
        &nbsp;&nbsp;&nbsp; 密码：<asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPwd" Display="Dynamic" ErrorMessage="密码必填！" ForeColor="#FF3300" SetFocusOnError="True"></asp:RequiredFieldValidator>
        &nbsp;<br />
        确认密码：<asp:TextBox ID="txtConfirm" runat="server" TextMode="Password"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPwd" ControlToValidate="txtConfirm" Display="Dynamic" ErrorMessage="两次密码输入必须一致！" ForeColor="#FF3300" SetFocusOnError="True"></asp:CompareValidator>
        <br />
       &nbsp;&nbsp;&nbsp;
       电话：<asp:TextBox ID="txtTelephone" runat="server" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtTelephone" Display="Dynamic" ErrorMessage="号码必填" ForeColor="#FF3300" SetFocusOnError="True"></asp:RequiredFieldValidator>
        <br />
        &nbsp;&nbsp;&nbsp; 照片：<asp:FileUpload ID="fuPhoto" runat="server" />
        <br />
        　　　　　<asp:Button ID="btnSubmit" runat="server" Text="注册" Width="80px" OnClick="btnSubmit_Click" />
    </div>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
<p>
        &nbsp;</p>
<p>
        &nbsp;</p>
<p>
        &nbsp;</p>
<p>
        &nbsp;</p>
<p>
        &nbsp;</p>
    <p>
        &nbsp;</p>

</asp:Content>

