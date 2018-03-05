<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Trip.aspx.cs" Inherits="Trip" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="所有出行信息列表如下，提供机票购买服务"></asp:Label><br />
    <marquee style="text-align:center" width="700px" ><asp:Label ID="Label5" runat="server" Text="您也可以订购我们的全套服务，景点导游酒店住宿以及航班机票全程为您服务。"></asp:Label></marquee>
    <br />
       
    <br />
    <asp:Label ID="Label1" runat="server" Text="起始站"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
        <asp:ListItem>北京</asp:ListItem>
        <asp:ListItem>上海</asp:ListItem>
        <asp:ListItem>广州</asp:ListItem>
        <asp:ListItem>深圳</asp:ListItem>
        <asp:ListItem>西安</asp:ListItem>
        <asp:ListItem>兰州</asp:ListItem>
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Text="终点站"></asp:Label>
    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True">
        <asp:ListItem>北京</asp:ListItem>
        <asp:ListItem>上海</asp:ListItem>
        <asp:ListItem>广州</asp:ListItem>
        <asp:ListItem>深圳</asp:ListItem>
        <asp:ListItem>西安</asp:ListItem>
        <asp:ListItem>兰州</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=DESKTOP-LJJR5B0\HERMAN;Initial Catalog=db_travel;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Traffic] WHERE (([sSta] = @sSta) AND ([eSta] = @eSta))" DeleteCommand="DELETE FROM Traffic WHERE (ID = @ID)" UpdateCommand="UPDATE Traffic SET tPrice = @tPrice, allPrice = @allPrice  WHERE (ID = @ID)">
        <DeleteParameters>
            <asp:Parameter Name="ID" />
        </DeleteParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList1" Name="sSta" PropertyName="SelectedValue" Type="String" />
            <asp:ControlParameter ControlID="DropDownList2" Name="eSta" PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="tPrice" />
            <asp:Parameter Name="allPrice" />
            <asp:Parameter Name="ID" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <div style="margin:0 auto;width:1300px; height:700px" >
    &nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataKeyNames="ID" DataSourceID="SqlDataSource1" GridLines="Horizontal" Height="200px" Width="1200px">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="sSta" HeaderText="起始站" SortExpression="sSta" />
                <asp:BoundField DataField="eSta" HeaderText="终点站" SortExpression="eSta" />
                <asp:BoundField DataField="ID" HeaderText="航班号" SortExpression="ID" />
                <asp:BoundField DataField="tPrice" HeaderText="航班票价" SortExpression="tPrice" />
                <asp:BoundField DataField="allPrice" HeaderText="全程团购" SortExpression="allPrice" />
                <asp:TemplateField HeaderText="航班订购">
                    <ItemTemplate>
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# string.Format("~/TrainIndent.aspx?tID={0}&st={1}&en={2}&pr={3}",Eval("ID"),Eval("sSta"),Eval("eSta"),Eval("tPrice")) %>' Text="订购"></asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="全套服务订购">
                    <ItemTemplate>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# string.Format("~/AllIndent.aspx?start={0}&end={1}&pri={2}&tID={3}",Eval("sSta"),Eval("eSta"),Eval("allPrice"),Eval("ID")) %>' Text="订购"></asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#487575" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#275353" />
        </asp:GridView>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/AddTraffic .aspx">添加航班及团购信息</asp:HyperLink>
        </div>
    <br />
    
    <br />
</asp:Content>

