<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddPlace.aspx.cs" Inherits="AddPlace" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            text-align: center;
        }
        .auto-style4 {
            text-align: left;
        }
        .auto-style6 {
            text-align: right;
            height: 24px;
        }
        .auto-style7 {
            text-align: left;
            height: 24px;
        }
        .auto-style8 {
            text-align: right;
            height: 127px;
        }
        .auto-style9 {
            text-align: left;
            height: 127px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height:auto;width:50%;margin:0 auto; line-height: 80px;">
        <br />
        <p style="margin:0 auto;font-size:36px;">添加景点</p>
        <br />
        <table class="auto-style2">
            <tr>
                <td class="auto-style6" style="text-align: center">景点名字：</td>
               
                <td class="auto-style7">
                    <asp:TextBox ID="pname" runat="server" Height="35px" Width="350px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">所属城市：</td>
                <td class="auto-style4">
                    <asp:TextBox ID="pcity" runat="server" Height="35px" Width="350px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">门票价格：</td>
                <td class="auto-style4">
                    <asp:TextBox ID="pprice" runat="server" Height="35px" Width="350px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8" style="text-align: center">景点介绍：</td>
                <td class="auto-style9">
                    <asp:TextBox ID="pdetail" runat="server" Height="150px" TextMode="MultiLine" Width="350px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">景点照片：</td>
                <td class="auto-style4">
                    <asp:FileUpload ID="fuphoto1" runat="server" Height="35px" Width="350px" />
                    <br />
                     <asp:FileUpload ID="fuphoto2" runat="server" Height="35px" Width="350px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="2">
                    <asp:Button ID="pbtn" runat="server" Height="32px" OnClick="pbtn_Click" Text="提交" Width="85px" />
                </td>
            </tr>
            </table>
        <br />
        <br />
     
    </div>
</asp:Content>

