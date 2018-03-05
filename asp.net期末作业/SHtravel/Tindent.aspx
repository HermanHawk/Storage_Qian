<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Tindent.aspx.cs" Inherits="Tindent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div  style="margin:0 auto;width:500px">
    <p>
        &nbsp;</p>
    <p>
        航班订单查询</p>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=DESKTOP-LJJR5B0\HERMAN;Initial Catalog=db_travel;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [TrafficIndent]"></asp:SqlDataSource>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" Width="500px">
            <ItemTemplate>
                <br />
                <table class="auto-style2">
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="起始站"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="pSstaLabel" runat="server" Text='<%# Eval("pSsta") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="终点站"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="pEstaLabel" runat="server" Text='<%# Eval("pEsta") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="票价："></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="pTpriceLabel" runat="server" Text='<%# Eval("pTprice") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="航班号："></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                        </td>
                    </tr>
                </table>
<br />
            </ItemTemplate>
        </asp:DataList>
    </p>
        </div>
</asp:Content>

