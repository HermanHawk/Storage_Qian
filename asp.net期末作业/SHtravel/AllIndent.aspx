<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AllIndent.aspx.cs" Inherits="AllIndebt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 135px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div  style="margin:0 auto;width:500px">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=DESKTOP-LJJR5B0\HERMAN;Initial Catalog=db_travel;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [sSta], [eSta], [allPrice], [ID] FROM [Traffic] WHERE ([ID] = @ID)">
        <SelectParameters>
            <asp:QueryStringParameter Name="ID" QueryStringField="tID" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" Width="600px">
        <ItemTemplate>
            <br />
            <table class="auto-style2">
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label1" runat="server" Text="行程号："></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label2" runat="server" Text="始发站："></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="sStaLabel" runat="server" Text='<%# Eval("sSta") %>' />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label3" runat="server" Text="终点站："></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="eStaLabel" runat="server" Text='<%# Eval("eSta") %>' />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label4" runat="server" Text="总额："></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="allPriceLabel" runat="server" Text='<%# Eval("allPrice") %>' />
                    </td>
                </tr>
            </table>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="确认购买" />
            &nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/Aindent.aspx">订单查询</asp:HyperLink>
<br />
        </ItemTemplate>
    </asp:DataList>
    <br />
        </div>
</asp:Content>

