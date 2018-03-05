<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Aindent.aspx.cs" Inherits="Aindent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 179px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div  style="margin:0 auto;width:500px">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=DESKTOP-LJJR5B0\HERMAN;Initial Catalog=db_travel;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [AllService]"></asp:SqlDataSource>
    <br />
    团购订单查询<br />
        <br />
    <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" Width="500px">
        <ItemTemplate>
            <table class="auto-style2">
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label1" runat="server" Text="始发站："></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="allSstaLabel" runat="server" Text='<%# Eval("allSsta") %>' />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label2" runat="server" Text="终点站"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="allEstaLabel" runat="server" Text='<%# Eval("allEsta") %>' />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label3" runat="server" Text="团购价："></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="allPriceLabel" runat="server" Text='<%# Eval("allPrice") %>' />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label4" runat="server" Text="行程号："></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                    </td>
                </tr>
            </table>
            <br />
        </ItemTemplate>
    </asp:DataList>
        </div>
</asp:Content>

