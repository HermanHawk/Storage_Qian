<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddTraffic .aspx.cs" Inherits="AddHote" %>

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
            width: 492px;
        }
        .auto-style6 {
            text-align: right;
            width: 492px;
            height: 80px;
        }
        .auto-style7 {
            text-align: left;
            height: 80px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:80%;height:auto;margin:0 auto;">
        <p style="margin:0 auto;font-size:36px">&nbsp;</p>
        <p style="margin:0 auto;font-size:36px">&nbsp;</p>
        <p style="margin:0 auto;font-size:36px">添加航班及团购</p>
        <br />
        <br />

        <table class="auto-style2" style="float: none">
            <tr>
                <td class="auto-style6" style="line-height: 80px">起始城市：</td>
                <td class="auto-style7" style="line-height: 80px">
                    <asp:TextBox ID="tstart" runat="server" Height="35px" Width="350px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5" style="line-height: 80px">终点城市：</td>
                <td class="auto-style4" style="line-height: 80px">
                    <asp:TextBox ID="tend" runat="server" Height="35px" Width="350px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6" style="line-height: 80px">全程票价：</td>
                <td class="auto-style7" style="line-height: 80px">
                    <asp:TextBox ID="tprice" runat="server" Height="35px" Width="350px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6" style="line-height: 80px">团购票价：</td>
                <td class="auto-style7" style="line-height: 80px">
                    <asp:TextBox ID="aprice" runat="server" Height="35px" Width="350px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6" style="line-height: 80px">航班编号：</td>
                <td class="auto-style7" style="line-height: 80px">
                    <asp:TextBox ID="aID" runat="server" Height="35px" Width="350px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="2" style="line-height: 80px">
                    <asp:Button ID="tbtn" runat="server" Height="35px" OnClick="tbtn_Click" Text="提交" Width="86px" />
                    <br />
                    <br />
                </td>
            </tr>
        </table>

        <br />


    </div>
</asp:Content>

