<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Hotel.aspx.cs" Inherits="Hotel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            width: 74%;
        }
        .auto-style3 {
            width: 351px;
            height: 600px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height:auto;width:104%; margin:0 auto;">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=DESKTOP-LJJR5B0\HERMAN;Initial Catalog=db_travel;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Hotel] WHERE ([City] = @City2)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="City2" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="城市："></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
            <asp:ListItem>北京</asp:ListItem>
            <asp:ListItem>上海</asp:ListItem>
            <asp:ListItem>广州</asp:ListItem>
            <asp:ListItem>深圳</asp:ListItem>
            <asp:ListItem>西安</asp:ListItem>
            <asp:ListItem>兰州</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" Width="100%" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
            <ItemTemplate>
                <br />
                <table class="auto-style2">
                    <tr>
                        <td class="auto-style3" rowspan="5" style="width: 600px; height: 600px">
                            <asp:Image ID="Image3" runat="server" Height="600px" ImageUrl='<%# Eval("Images") %>' Width="600px" />
                        </td>
                        <td style="width: 40%; height: 100px">
                            <br />
                            <br />
                            酒店名称：<asp:Label ID="HotelNameLabel" runat="server" Text='<%# Eval("HotelName") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 40%; height: 100px">
                            <br />
                            所在城市：<asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 40%; height: 100px">
                            <br />
                            价格：<asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("Price") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 40%; height: 200px">
                            <br />
                            简介：<asp:Label ID="DetailsLabel" runat="server" Text='<%# Eval("Details") %>' />
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 40%; height: 100px">
                            <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl='~/Trip.aspx'>航班查询</asp:HyperLink>
                            <br />
                            <asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl='<%# string.Format("~/HotelIndent.aspx?HName={0}&CLabel={1}&PLabel={2}",Eval("HotelName"),Eval("City"),Eval("Price")) %>'>预约</asp:HyperLink>
                            <br />
                            <asp:HyperLink ID="HyperLink9" runat="server" NavigateUrl="~/AddHote.aspx">添加酒店</asp:HyperLink>
                        </td>
                    </tr>
                </table>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <br />
            </ItemTemplate>
        </asp:DataList>
        <br />
    </div>
    
</asp:Content>

