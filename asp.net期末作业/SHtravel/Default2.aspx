<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server"> 
    <!--<meta http-equiv="Content-Type" content="text/html;charset=UTF-8"/>   -->
<title>北上广深西安图片轮播切换代码 </title>
<link rel="stylesheet"  type="text/css" href="css/StyleSheet.css"/>
   

    <style type="text/css">
    .auto-style2 {
        width: 100%;
    }
</style>
   

    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:100%;height:auto;">
<div id="left" style="width:20%; height:700px; background-color:#6cea9f; float:left " >

    <asp:Panel ID="Panel1" runat="server" Height="100%" Width="100%" Font-Overline="False" Font-Size="Large">         
                 
             <br />
                  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=DESKTOP-LJJR5B0\HERMAN;Initial Catalog=db_travel;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [UserName], [Telephone], [Images] FROM [Users] WHERE ([Telephone] = @Telephone)" UpdateCommand="UPDATE Users SET UserName = @UserName,  Images = @Images">
                      <SelectParameters>
                          <asp:SessionParameter DefaultValue="txtTelephone" Name="Telephone" SessionField="txtTelephone" Type="String" />
                      </SelectParameters>
                      <UpdateParameters>
                          <asp:Parameter Name="UserName" />
                          <asp:Parameter Name="Images" />
                      </UpdateParameters>
             </asp:SqlDataSource>
        <asp:DetailsView ID="DetailsView1" runat="server" Height="127px" Width="178px" AutoGenerateRows="False" DataKeyNames="Telephone" DataSourceID="SqlDataSource1" HorizontalAlign="Center" OnItemUpdating="DetailsView1_ItemUpdating">
            <Fields>
                <asp:TemplateField SortExpression="Images">
                    <EditItemTemplate>
                        <asp:FileUpload ID="fuPhoto" runat="server" />
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Images") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Image ID="Image3" runat="server" Height="100px" ImageAlign="Left" ImageUrl='<%# Eval("Images") %>' Width="100px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="UserName" HeaderText="姓名：" SortExpression="UserName" />
                <asp:BoundField DataField="Telephone" HeaderText="号码：" ReadOnly="True" SortExpression="Telephone" />
                <asp:TemplateField ShowHeader="False">
                    <EditItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" OnClientClick="return confirm(&quot;确定修改个人信息？&quot;)" Text="更新"></asp:LinkButton>
                        &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消"></asp:LinkButton>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="修改个人信息"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Fields>
             </asp:DetailsView>
                  <br />
             <br />
             <br />
             <br />
             <table class="auto-style2" style="font-size: x-large">
                 <tr>
                     <td style="text-align: center">
                         <asp:Label ID="Label1" runat="server" Text="我的订单管理"></asp:Label>
                         <br />
                     </td>
                 </tr>
                 <tr>
                     <td style="text-align: center">
                         <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/Hindent.aspx" Font-Underline="True" ForeColor="Red">酒店服务订单</asp:HyperLink>
                     </td>
                 </tr>
                 <tr>
                     <td style="text-align: center">
                         <asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/Tindent.aspx" Font-Underline="True" ForeColor="Red">航班服务订单</asp:HyperLink>
                     </td>
                 </tr>
                 <tr>
                     <td style="text-align: center">
                         <asp:HyperLink ID="HyperLink9" runat="server" NavigateUrl="~/Aindent.aspx" Font-Overline="False" Font-Underline="True" ForeColor="Red">全套团购订单</asp:HyperLink>
                     </td>
                 </tr>
             </table>
             <br />
    </asp:Panel>

 </div>


<div class="demo" style="width: 80%; height:700px; text-align: center; float:right">
	<a class="control prev"></a><a class="control next abs"></a><!--自定义按钮，移动端可不写-->
	<div class="slider" style="width: 100%; height: 100%;"><!--主体结构，请用此类名调用插件，此类名可自定义-->
		<ul style="width: 100%; height: 100%">
			<li style="width: 100%; height: 100%"><a href=""><img src="images/1.jpg" alt="北京欢迎你"  width:100%; height:100%/></a></li>
			<li style="width: 100%; height: 100%"><a href=""><img src="images/2.jpg" alt="上海欢迎你"  width:100%  height:100%/></a></li>
			<li style="width: 100%; height: 100%"><a href=""><img src="images/3.jpg" alt="广州欢迎你"  width:100%; height:100%/></a></li>
			<li style="width: 100%; height: 100%"><a href=""><img src="images/4.jpg" alt="深圳欢迎你"  width:100%; height:100%/></a></li>
			<li style="width: 100%; height: 100%"><a href=""><img src="images/5.jpg" alt="西安欢迎你"  width:100%; height:100%/></a></li>
		</ul>
	</div>
        </div>
<script type="text/jscript" src="js/jquery.min.js"></script>
<script type="text/jscript" src="js/YuxiSlider.jQuery.min.js"></script>
<script type="text/jscript">
    $(".slider").YuxiSlider({
        width: "100%", //容器宽度
        height: 700, //容器高度
        control: $('.control'), //绑定控制按钮
        during: 1500, //间隔2秒自动滑动
        speed: 800, //移动速度0.8秒
        mousewheel: true, //是否开启鼠标滚轮控制
        direkey: true //是否开启左右箭头方向控制
    });
</script>
        联系我们&nbsp; |&nbsp; 加入我们</div>

</asp:Content>

