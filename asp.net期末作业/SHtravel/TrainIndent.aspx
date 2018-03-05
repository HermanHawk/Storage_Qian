<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TrainIndent.aspx.cs" Inherits="TrainIndent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            width: 97%;
        }
        .auto-style4 {
            width: 135px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div  style="margin:0 auto;width:500px">
    <p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=DESKTOP-LJJR5B0\HERMAN;Initial Catalog=db_travel;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [sSta], [eSta], [tPrice], [ID] FROM [Traffic] WHERE ([ID] = @ID)">
            <SelectParameters>
                <asp:QueryStringParameter Name="ID" QueryStringField="tID" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" Width="500px">
            <ItemTemplate>
                <br />
                <table class="auto-style2">
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label1" runat="server" Text="起始站："></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="sStaLabel" runat="server" Text='<%# Eval("sSta") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label2" runat="server" Text="终点站："></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="eStaLabel" runat="server" Text='<%# Eval("eSta") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label3" runat="server" Text=" 票价："></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="tPriceLabel" runat="server" Text='<%# Eval("tPrice") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label4" runat="server" Text="航班号："></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Button ID="Button1" runat="server" Height="27px" OnClick="Button1_Click1" Text="确认购买" Width="107px" />
                        </td>
                        <td>
                            <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/Tindent.aspx">订单查询</asp:HyperLink>
                        </td>
                    </tr>
                </table>
<br />
            </ItemTemplate>
        </asp:DataList>
    </p>
        </div>
</asp:Content>

