<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddHote.aspx.cs" Inherits="AddHote" %>

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
        .auto-style5 {
            text-align: right;
            width: 251px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:60%;height:auto;margin:0 auto;">
        <p style="margin:0 auto;font-size:36px">&nbsp;</p>
        <p style="margin:0 auto;font-size:36px">添加酒店</p>
        <p style="margin:0 auto;font-size:36px">&nbsp;</p>

        <table class="auto-style2">
            <tr>
                <td class="auto-style5" style="line-height: 80px">酒店名字：</td>
                <td class="auto-style4" style="line-height: 80px">
                    <asp:TextBox ID="hname" runat="server" Height="35px" Width="350px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5" style="line-height: 80px">所属城市：</td>
                <td class="auto-style4" style="line-height: 80px">
                    <asp:TextBox ID="hcity" runat="server" Height="35px" Width="350px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5" style="line-height: 80px">价格：</td>
                <td class="auto-style4" style="line-height: 80px">
                    <asp:TextBox ID="hprice" runat="server" Height="35px" Width="350px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5" style="line-height: 80px">酒店介绍：</td>
                <td class="auto-style4" style="line-height: 80px">
                    <asp:TextBox ID="hdetail" runat="server" Height="141px" TextMode="MultiLine" Width="350px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5" style="line-height: 80px">酒店照片：</td>
                <td class="auto-style4" style="line-height: 80px">
                    <asp:FileUpload ID="fuphoto3" runat="server" Height="35px" Width="350px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="2" style="line-height: 80px">
                    <asp:Button ID="hbtn" runat="server" Height="35px" OnClick="hbtn_Click" Text="提交" Width="86px" />
                </td>
            </tr>
        </table>

        <br />


    </div>
</asp:Content>

