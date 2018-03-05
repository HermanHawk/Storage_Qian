<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Hindent.aspx.cs" Inherits="Hindent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div  style="margin:0 auto;width:500px">
        <br />
    <asp:Label ID="Label1" runat="server" Text="酒店订单管理"></asp:Label>
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=DESKTOP-LJJR5B0\HERMAN;Initial Catalog=db_travel;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [HotelIndent]" DeleteCommand="DELETE FROM HotelIndent WHERE (HotelName = @HotelName)">
        <DeleteParameters>
            <asp:Parameter Name="HotelName" />
        </DeleteParameters>
        </asp:SqlDataSource>
    &nbsp;<asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="Telephone" DataSourceID="SqlDataSource2" Height="50px" Width="258px" HorizontalAlign="Center">
        <Fields>
            <asp:BoundField DataField="UserName" HeaderText="用户姓名：" SortExpression="UserName" />
            <asp:BoundField DataField="Telephone" HeaderText="用户账号：" ReadOnly="True" SortExpression="Telephone" />
        </Fields>
    </asp:DetailsView>
    <br />
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Data Source=DESKTOP-LJJR5B0\HERMAN;Initial Catalog=db_travel;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Users] WHERE ([Telephone] = @Telephone)">
        <SelectParameters>
            <asp:SessionParameter Name="Telephone" SessionField="txtTelephone" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" HorizontalAlign="Center">
        <ItemTemplate>
            <br />
<br />
            <table class="auto-style2">
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="酒店："></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="HotelNameLabel" runat="server" Text='<%# Eval("HotelName") %>' />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="城市："></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="HotelCityLabel" runat="server" Text='<%# Eval("HotelCity") %>' />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="价格："></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="HotelPriceLabel" runat="server" Text='<%# Eval("HotelPrice") %>' />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
    <br />
    <br />
    <br />
    <br />
    <br />
    

    </div>

</asp:Content>

