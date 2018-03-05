<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="HotelIndent.aspx.cs" Inherits="HotelIndent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
        .auto-style5 {
            width: 250px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div  style="margin:0 auto;width:500px">
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=DESKTOP-LJJR5B0\HERMAN;Initial Catalog=db_travel;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Hotel] WHERE ([HotelName] = @HotelName)">
        <SelectParameters>
            <asp:QueryStringParameter Name="HotelName" QueryStringField="HName" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" Width="600px">
        <ItemTemplate>
            <table class="auto-style2">
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label1" runat="server" Text="酒店名称"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="HotelNameLabel" runat="server" Text='<%# Eval("HotelName") %>' />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label2" runat="server" Text="所在城市："></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label3" runat="server" Text="酒店价格："></asp:Label>
                        &nbsp; </td>
                    <td>
                        <asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("Price") %>' />
                    </td>
                </tr>
            </table>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="确认购买" Width="84px" />
            &nbsp;
            <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/Hindent.aspx">订单查询</asp:HyperLink>
<br />
            <br />
        </ItemTemplate>
    </asp:DataList>
        </div>
</asp:Content>

