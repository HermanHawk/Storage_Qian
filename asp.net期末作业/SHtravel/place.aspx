<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="place.aspx.cs" Inherits="place" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 27px;
        }
        .auto-style4 {
            width: 40%;
            height: 41px;
        }
        .auto-style5 {
            width: 40%;
            height: 99px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div style="height:auto;width:80%;margin:0 auto">

    <p>
        &nbsp;</p>
        <p>
        <asp:Label ID="Label1" runat="server" Text="城市选择" Font-Bold="True" Font-Names="Adobe 楷体 Std R" Font-Size="X-Large" Height="50px" Width="125px"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Font-Bold="True" Font-Names="Adobe 楷体 Std R" Font-Size="X-Large" Height="30px" Width="99px">
            <asp:ListItem>北京</asp:ListItem>
            <asp:ListItem>上海</asp:ListItem>
            <asp:ListItem>广州</asp:ListItem>
            <asp:ListItem>深圳</asp:ListItem>
            <asp:ListItem>西安</asp:ListItem>
            <asp:ListItem>兰州</asp:ListItem>
        </asp:DropDownList>
    </p>
        <p>
        <br />
    </p>
    <p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=DESKTOP-LJJR5B0\HERMAN;Initial Catalog=db_travel;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Place] WHERE ([City] = @City)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="City" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </p>
        <p>
            &nbsp;</p>
    <p>
    </p>
    <p>
        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1">
            <ItemTemplate>
                <br />
                <table class="auto-style2">
                    <tr>
                        <td class="auto-style3" rowspan="5" style="width: 600px; height: 600px;">
                            <asp:Image ID="Image3" runat="server" Height="600px" ImageUrl='<%# Eval("Images1") %>' Width="600px" />
                        </td>
                        <td class="auto-style4" style="height: 100px; width: 40%;">
                            <br />
                            <br />
                            <br />
                            景点：<asp:Label ID="PlaceNameLabel" runat="server" Text='<%# Eval("PlaceName") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 40%; height: 100px;">
                            <br />
                            城市：<asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5" style="height: 100px; width: 40%">
                            <br />
                            门票：<asp:Label ID="priceLabel" runat="server" Text='<%# Eval("price") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 40%; height: 200px;">
                            <br />
                            简介：<asp:Label ID="detailsLabel" runat="server" Text='<%# Eval("details") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 40%; height: 100px;">
                            <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/Hotel.aspx">酒店查询</asp:HyperLink>
                            <br />
                            <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/AddPlace.aspx">添加景点</asp:HyperLink>
                        </td>
                    </tr>
                </table>
                <br />
<br />
            </ItemTemplate>
        </asp:DataList>
    </p>
    <p>
    </p>
        </div>



    </asp:Content>

