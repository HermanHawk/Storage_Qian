<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminProductManage.aspx.cs" Inherits="AdminProductManage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="index.css" type="text/css" rel="stylesheet" />
<script src="https://code.jquery.com/jquery-3.2.1.min.js" type="text/javascript"></script> 
<script src="index.js" type="text/javascript"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div class="header">
      <div class="w">
          <span class="l toptext">管理员页面</span>
        <div class="r login">
         <ul>
            <li><a href ="UserOrder.aspx">我的订单</a></li>
            <li><a href="#">帮助</a></li>
            <li><a href="home.aspx">返回首页</a></li>
         </ul>
       </div>
     </div>
    </div>
       <div class="w" style="font-size:14px;padding-bottom:50px;">
         <div class="n_box">
          <span class="top_n">用户：<asp:Label ID="lblUserTel" runat="server" Text="Label"></asp:Label></span>
          <span class="top_n">姓名：<asp:Label ID="lblUserName" runat="server" Text="Label"></asp:Label></span>
          <span class="top_n">邮箱：<asp:Label ID="lbluserEmail" runat="server" Text="Label"></asp:Label></span>
          <span class="top_n"><a id="adminRegister" runat="server" href="AdminRegister.aspx">添加管理员</a></span>
         </div>
         <div class="ad_nav">
          <ul>
              <li class="ad_a"><a>商品管理</a></li>
              <li class="ad_b"><a>订单管理</a></li>
              <li class="ad_c"><a>账单管理</a></li>
              <li class="ad_d"><a>日营业额</a></li>
          </ul>
      </div>
          <div class="ad_pc" >
           <div class="ad_tb">
            <asp:Panel ID="PanelProducts" runat="server">
             商品种类：<br /><asp:DropDownList ID="dplProducts" runat="server" OnSelectedIndexChanged="dplProducts_SelectedIndexChanged">
                <asp:ListItem Value="-1">请选择</asp:ListItem>
                <asp:ListItem Value="0">T恤</asp:ListItem>
                <asp:ListItem Value="1">照片书</asp:ListItem>
                <asp:ListItem Value="2">墙画</asp:ListItem>
             </asp:DropDownList>
            商品名称：<asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
            <br />
            商品大小：<asp:DropDownList ID="dplProductSize" runat="server">
                <asp:ListItem Value="6">6寸</asp:ListItem>
                <asp:ListItem Value="8">8寸</asp:ListItem>
                <asp:ListItem Value="10">10寸</asp:ListItem>
                <asp:ListItem Value="16">16寸</asp:ListItem>
                <asp:ListItem Value="18">18寸</asp:ListItem>
                <asp:ListItem Value="20">20寸</asp:ListItem>
            </asp:DropDownList>
            <br />
            商品价格：<asp:TextBox ID="txtProductPrice" runat="server" Width="166px"></asp:TextBox>
            <br />
            商品描述：<asp:TextBox ID="txtProductDescribe" runat="server" Width="168px"></asp:TextBox>
            <br />
            商品颜色：<asp:TextBox ID="txtProductColor" runat="server" Width="170px"></asp:TextBox>
            <br />
            商品图片：<asp:FileUpload ID="fupProducts" runat="server" />
            <asp:Button ID="btnJoinProducts" runat="server" OnClick="btnJoinProducts_Click" Text="添加" />
        </asp:Panel>
       </div>
          <div class="ad_tb">
           <asp:Panel ID="PanelPC_Host" runat="server">
            添加主机：<br /> 名称：<asp:TextBox ID="txtHostName" runat="server"></asp:TextBox>
            <span>CPU：<asp:TextBox ID="txtHostCPU" runat="server"></asp:TextBox></span>
            <br />
            <span>主板：<asp:TextBox ID="txtHostMainBoard" runat="server"></asp:TextBox></span>

            <span>散热器：<asp:TextBox ID="txtHostCooler" runat="server"></asp:TextBox></span>
            <br />
            <span>硬盘：<asp:TextBox ID="txtHostHardDisk" runat="server"></asp:TextBox></span>

            <span>内存：<asp:TextBox ID="txtHostMemory" runat="server"></asp:TextBox></span>
             <br />
            <span>显卡：<asp:TextBox ID="txtHostGraphics" runat="server"></asp:TextBox></span>
           
            <span>电源：<asp:TextBox ID="txtHostPower" runat="server"></asp:TextBox></span>
             <br />
            <span>机箱：<asp:TextBox ID="txtHostComputerCase" runat="server"></asp:TextBox></span>

            <span>价格：<asp:TextBox ID="txtHostPrice" runat="server"></asp:TextBox></span>
             <br />
            <span>图片：<asp:FileUpload ID="fupHostImage" runat="server" /></span>

            <asp:Button ID="btnJoinHost" runat="server" OnClick="btnJoinHost_Click" Text="添加" />
           </asp:Panel>
         </div>
         <div class="ad_tb">
           <asp:Panel ID="PC_Graphics" runat="server">
            添加显卡：<br /> 名称：<asp:TextBox ID="txtGraphicsName" runat="server"></asp:TextBox>
            
            品牌：<asp:TextBox ID="txtGraphicsBrand" runat="server"></asp:TextBox>
            <br />
            型号：<asp:TextBox ID="txtGraphicsModel" runat="server"></asp:TextBox>
          
            频率：<asp:TextBox ID="txtGraphicsFrequency" runat="server"></asp:TextBox>
            <br />
            特性：<asp:TextBox ID="txtGraphicsCharacter" runat="server"></asp:TextBox>
           
            价格：<asp:TextBox ID="txtGraphicsPrice" runat="server"></asp:TextBox>
            <br />
            图片：<asp:FileUpload ID="fupGraphicsImages" runat="server" />
          
            <asp:Button ID="btnJoinGraphics" runat="server" OnClick="btnJoinGraphics_Click" Text="添加" />
            </asp:Panel>
         </div>
           <div class="ad_tb">
            <asp:Panel ID="PanelPC_CPU" runat="server">
            添加CPU：<br /> 品牌：<asp:TextBox ID="txtCpuBrand" runat="server"></asp:TextBox>
            
            型号：<asp:TextBox ID="txtCpuModel" runat="server"></asp:TextBox>
            <br />
            系列：<asp:TextBox ID="txtCpuSeries" runat="server"></asp:TextBox>
         
            名称：<asp:TextBox ID="txtCpuName" runat="server"></asp:TextBox>
            <br />
            价格：<asp:TextBox ID="txtCpuPrice" runat="server"></asp:TextBox>
           
            图片：<asp:FileUpload ID="fupCpuImages" runat="server" />
            <br />
            <asp:Button ID="btnJoinCpu" runat="server" OnClick="btnJoinCpu_Click" Text="添加" />
           </asp:Panel>
          </div>
          <div class="ad_tb">
            <asp:Panel ID="PC_Memory" runat="server">
            添加内存条：<br /> 品牌：<asp:TextBox ID="txtMemoryBrand" runat="server"></asp:TextBox>
         
            系列：<asp:TextBox ID="txtMemorySeries" runat="server"></asp:TextBox>
            <br />
            速度：<asp:TextBox ID="txtMemorySpeed" runat="server"></asp:TextBox>
        
            容量：<asp:TextBox ID="txtMemoryCapacity" runat="server"></asp:TextBox>
            <br />
            名称：<asp:TextBox ID="txtMemoryName" runat="server"></asp:TextBox>
          
            价格：<asp:TextBox ID="txtMemoryPrice" runat="server"></asp:TextBox>
            <br />
            图片：<asp:FileUpload ID="fupMemoryImages" runat="server" />
           
            <asp:Button ID="btnJoinMemory" runat="server" OnClick="btnJoinMemory_Click" Text="添加" />
        </asp:Panel>
       </div>
        <h3>管理T恤</h3>
        <asp:GridView ID="gvT_shirt" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="T_shirtID" DataSourceID="dsT_shirt" OnRowUpdating="gvT_shirt_RowUpdating1" Width="990px" HorizontalAlign="Center" >
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:TemplateField HeaderText="图片" SortExpression="T_shirtImages">
                    <EditItemTemplate>
                        <asp:Image ID="ImgUPdateT_shirt" runat="server" ImageUrl='<%# Eval("T_shirtImages") %>' Height="100px" Width="100px" />
                        <br />
                        <asp:FileUpload ID="fupUpdateT_shirt" runat="server" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("T_shirtImages") %>' Height="100px" Width="100px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="T_shirtName" HeaderText="名称" SortExpression="T_shirtName" />
                <asp:BoundField DataField="T_shirtColor" HeaderText="颜色" SortExpression="T_shirtColor" />
                <asp:BoundField DataField="T_shirtDescribe" HeaderText="描述" SortExpression="T_shirtDescribe" />
                <asp:BoundField DataField="T_shirtPrice" HeaderText="单价" SortExpression="T_shirtPrice" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="dsT_shirt" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" SelectCommand="SELECT * FROM [T_shirtInfo]" UpdateCommand="UPDATE T_shirtInfo SET T_shirtPrice = @T_shirtPrice, T_shirtDescribe = @T_shirtDescribe, T_shirtColor = @T_shirtColor, T_shirtImages = @T_shirtImages, T_shirtName = @T_shirtName FROM T_shirtInfo INNER JOIN Product_TShirt ON T_shirtInfo.T_shirtID = Product_TShirt.Product_TShirtFromID WHERE (T_shirtInfo.T_shirtID = @T_shirtID)">
            <UpdateParameters>
                <asp:Parameter Name="T_shirtPrice" />
                <asp:Parameter Name="T_shirtDescribe" />
                <asp:Parameter Name="T_shirtColor" />
                <asp:Parameter Name="T_shirtImages" />
                <asp:Parameter Name="T_shirtName" />
                <asp:Parameter Name="T_shirtID" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <h3>管理照片书</h3>
        <asp:GridView ID="gvPhotoBook" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="dsPhotoBook" OnRowUpdating="gvPhotoBook_RowUpdating" DataKeyNames="PhotoBookID,Product_PhotoBookID" Width="990px" HorizontalAlign="Center">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:TemplateField HeaderText="图片" SortExpression="PhotoBookImages">
                    <EditItemTemplate>
                        <asp:Image ID="imgUpdatePhotoBook" runat="server" ImageUrl='<%# Eval("PhotoBookImages") %>' Width="100px" Height="100px" />
                        <br />
                        <asp:FileUpload ID="fupUpdatePhotoBook" runat="server" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("PhotoBookImages") %>' Width="100px" Height="100px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="PhotoBookName" HeaderText="名称" SortExpression="PhotoBookName" />
                <asp:BoundField DataField="PhotoBookDescribe" HeaderText="简介" SortExpression="PhotoBookDescribe" />
                <asp:BoundField DataField="PhotoBookColor" HeaderText="颜色" SortExpression="PhotoBookColor" />
                <asp:BoundField DataField="Product_PhotoBookSize" HeaderText="尺寸" SortExpression="Product_PhotoBookSize" />
                <asp:BoundField DataField="Product_PhotoBookPrice" HeaderText="单价" SortExpression="Product_PhotoBookPrice" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="dsPhotoBook" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" SelectCommand="SELECT PhotoBooks.*, Product_PhotoBooks.* FROM Product_PhotoBooks INNER JOIN PhotoBooks ON Product_PhotoBooks.Product_PhotoBookFromID = PhotoBooks.PhotoBookID" UpdateCommand="UPDATE PhotoBooks SET PhotoBookName = @PhotoBookName, PhotoBookDescribe = @PhotoBookDescribe, PhotoBookColor = @PhotoBookColor, PhotoBookImages = @PhotoBookImages WHERE (PhotoBookID = @PhotoBookID)">
            <UpdateParameters>
                <asp:Parameter Name="PhotoBookName" />
                <asp:Parameter Name="PhotoBookDescribe" />
                <asp:Parameter Name="PhotoBookColor" />
                <asp:Parameter Name="PhotoBookImages" />
                <asp:Parameter Name="PhotoBookID" />
            </UpdateParameters>
        </asp:SqlDataSource>
         <h3>管理画板</h3>
        <asp:GridView ID="gvMuralPainting" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="dsMuralPainting" OnRowUpdating="gvMuralPainting_RowUpdating" DataKeyNames="MuralPaintingID" Width="990px">
            <Columns>
                <asp:TemplateField ShowHeader="False">
                    <EditItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="更新"></asp:LinkButton>
                        <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消"></asp:LinkButton>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="编辑"></asp:LinkButton>
                        <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Delete" OnClientClick="return confirm(&quot;确实要删除吗?&quot;)" Text="删除"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="图片" SortExpression="MuralPaintingImages">
                    <EditItemTemplate>
                        <asp:Image ID="imgUpdateMuralPainting" runat="server" Height="200px" ImageUrl='<%# Eval("MuralPaintingImages") %>' Width="150px" />
                        <br />
                        <asp:FileUpload ID="fupUpdateMuralPainting" runat="server" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("MuralPaintingImages") %>' Width="100px" Height="100px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="MuralPaintingName" HeaderText="名称" SortExpression="MuralPaintingName" />
                <asp:BoundField DataField="MuralPaintingDescribe" HeaderText="简介" SortExpression="MuralPaintingDescribe" />
                <asp:BoundField DataField="MuralPaintingColor" HeaderText="颜色" SortExpression="MuralPaintingColor" />
                <asp:BoundField DataField="MuralPaintingSize" HeaderText="尺寸" SortExpression="MuralPaintingSize" />
                <asp:BoundField DataField="MuralPaintingPrice" HeaderText="价格" SortExpression="MuralPaintingPrice" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="dsMuralPainting" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" DeleteCommand="DELETE FROM MuralPaintings WHERE (MuralPaintingID = @MuralPaintingID)" SelectCommand="SELECT * FROM [MuralPaintings]" UpdateCommand="UPDATE MuralPaintings SET MuralPaintingName = @MuralPaintingName, MuralPaintingDescribe = @MuralPaintingDescribe, MuralPaintingColor = @MuralPaintingColor, MuralPaintingImages = @MuralPaintingImages, MuralPaintingSize = @MuralPaintingSize, MuralPaintingPrice = @MuralPaintingPrice WHERE (MuralPaintingID = @MuralPaintingID)">
            <DeleteParameters>
                <asp:Parameter Name="MuralPaintingID" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="MuralPaintingName" />
                <asp:Parameter Name="MuralPaintingDescribe" />
                <asp:Parameter Name="MuralPaintingColor" />
                <asp:Parameter Name="MuralPaintingImages" />
                <asp:Parameter Name="MuralPaintingSize" />
                <asp:Parameter Name="MuralPaintingPrice" />
                <asp:Parameter Name="MuralPaintingID" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <h3>管理主机</h3>
        <asp:GridView ID="gvPC_Host" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="dsPC_Host" OnRowUpdating="gvPC_Host_RowUpdating" DataKeyNames="HostID" Width="990px">
            <Columns>
                <asp:TemplateField ShowHeader="False">
                    <EditItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="更新"></asp:LinkButton>
                       <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消"></asp:LinkButton>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="编辑"></asp:LinkButton>
                        <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Delete" OnClientClick="return confirm(&quot;确实要删除吗?&quot;)" Text="删除"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="图片" SortExpression="Images">
                    <EditItemTemplate>
                        <asp:Image ID="imgUpdatePC_Host" runat="server" ImageUrl='<%# Eval("Images") %>' />
                        <br />
                        <asp:FileUpload ID="fupUpdatePC_Host" runat="server" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Images") %>' Width="100px" Height="100px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Name" HeaderText="名称" SortExpression="Name" />
                <asp:BoundField DataField="Cpu" HeaderText="Cpu" SortExpression="Cpu" />
                <asp:BoundField DataField="MainBoard" HeaderText="主板" SortExpression="MainBoard" />
                <asp:BoundField DataField="Cooler" HeaderText="散热器" SortExpression="Cooler" />
                <asp:BoundField DataField="HardDisk" HeaderText="硬盘" SortExpression="HardDisk" />
                <asp:BoundField DataField="Memory" HeaderText="内存条" SortExpression="Memory" />
                <asp:BoundField DataField="Graphics" HeaderText="显卡" SortExpression="Graphics" />
                <asp:BoundField DataField="Power" HeaderText="电源" SortExpression="Power" />
                <asp:BoundField DataField="ComputerCase" HeaderText="机箱" SortExpression="ComputerCase" />
                <asp:BoundField DataField="Price" HeaderText="价格" SortExpression="Price" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="dsPC_Host" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" DeleteCommand="DELETE FROM PC_Host WHERE (HostID = @HostID)" SelectCommand="SELECT * FROM [PC_Host]" UpdateCommand="UPDATE PC_Host SET Name = @Name, Cpu = @Cpu, MainBoard = @MainBoard, Cooler = @Cooler, HardDisk = @HardDisk, Memory = @Memory, Graphics = @Graphics, Power = @Power, ComputerCase = @ComputerCase, Price = @Price, Images = @Images WHERE (HostID = @HostID)">
            <DeleteParameters>
                <asp:Parameter Name="HostID" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="Name" />
                <asp:Parameter Name="Cpu" />
                <asp:Parameter Name="MainBoard" />
                <asp:Parameter Name="Cooler" />
                <asp:Parameter Name="HardDisk" />
                <asp:Parameter Name="Memory" />
                <asp:Parameter Name="Graphics" />
                <asp:Parameter Name="Power" />
                <asp:Parameter Name="ComputerCase" />
                <asp:Parameter Name="Price" />
                <asp:Parameter Name="Images" />
                <asp:Parameter Name="HostID" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <h3>管理CPU</h3>
        <asp:GridView ID="gvPC_CPU" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="dsPC_CPU" OnRowUpdating="gvPC_CPU_RowUpdating" DataKeyNames="CpuID" Width="990px">
            <Columns>
                <asp:TemplateField ShowHeader="False">
                    <EditItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="更新"></asp:LinkButton>
                        &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消"></asp:LinkButton>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="编辑"></asp:LinkButton>
                        &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Delete" OnClientClick="return confirm(&quot;确实要删除吗?&quot;)" Text="删除"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="图片" SortExpression="Images">
                    <EditItemTemplate>
                        <asp:Image ID="imgUpdatePC_CPU" runat="server" ImageUrl='<%# Eval("Images") %>' />
                        <asp:FileUpload ID="fupUpdatePC_CPU" runat="server" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Images") %>' Width="100px" Height="100px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Name" HeaderText="名称" SortExpression="Name" />
                <asp:BoundField DataField="Brand" HeaderText="品牌" SortExpression="Brand" />
                <asp:BoundField DataField="Model" HeaderText="型号" SortExpression="Model" />
                <asp:BoundField DataField="Series" HeaderText="系列" SortExpression="Series" />
                <asp:BoundField DataField="Price" HeaderText="价格" SortExpression="Price" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="dsPC_CPU" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" DeleteCommand="DELETE FROM PC_Cpu WHERE (CpuID = @CpuID)" SelectCommand="SELECT * FROM [PC_Cpu]" UpdateCommand="UPDATE PC_Cpu SET Brand = @Brand, Model = @Model, Series = @Series, Name = @Name, Price = @Price, Images = @Images WHERE (CpuID = @CpuID)">
            <DeleteParameters>
                <asp:Parameter Name="CpuID" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="Brand" />
                <asp:Parameter Name="Model" />
                <asp:Parameter Name="Series" />
                <asp:Parameter Name="Name" />
                <asp:Parameter Name="Price" />
                <asp:Parameter Name="Images" />
                <asp:Parameter Name="CpuID" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <h3>管理显卡</h3>
        <asp:GridView ID="gvGraphics" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="dsGraphics" OnRowUpdating="gvGraphics_RowUpdating" DataKeyNames="GraphicsID" Width="990px">
            <Columns>
                <asp:TemplateField ShowHeader="False">
                    <EditItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="更新"></asp:LinkButton>
                       <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消"></asp:LinkButton>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="编辑"></asp:LinkButton>
                        <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Delete" OnClientClick="return confirm(&quot;确实要删除吗?&quot;)" Text="删除"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="图片" SortExpression="Images">
                    <EditItemTemplate>
                        <asp:Image ID="imgUpdatePC_Graphics" runat="server" ImageUrl='<%# Eval("Images") %>' />
                        <br />
                        <asp:FileUpload ID="fupUpdatePC_Graphics" runat="server" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Images") %>' Width="100px" Height="100px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Name" HeaderText="名称" SortExpression="Name" />
                <asp:BoundField DataField="Brand" HeaderText="品牌" SortExpression="Brand" />
                <asp:BoundField DataField="Model" HeaderText="型号" SortExpression="Model" />
                <asp:BoundField DataField="Frequency" HeaderText="频率" SortExpression="Frequency" />
                <asp:BoundField DataField="Character" HeaderText="特性" SortExpression="Character" />
                <asp:BoundField DataField="Price" HeaderText="价格" SortExpression="Price" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="dsGraphics" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" DeleteCommand="DELETE FROM PC_Graphics WHERE (GraphicsID = @GraphicsID)" SelectCommand="SELECT * FROM [PC_Graphics]" UpdateCommand="UPDATE PC_Graphics SET Name = @Name, Brand = @Brand, Model = @Model, Frequency = @Frequency, Character = @Character, Price = @Price, Images = @Images WHERE (GraphicsID = @GraphicsID)">
            <DeleteParameters>
                <asp:Parameter Name="GraphicsID" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="Name" />
                <asp:Parameter Name="Brand" />
                <asp:Parameter Name="Model" />
                <asp:Parameter Name="Frequency" />
                <asp:Parameter Name="Character" />
                <asp:Parameter Name="Price" />
                <asp:Parameter Name="Images" />
                <asp:Parameter Name="GraphicsID" />
            </UpdateParameters>
        </asp:SqlDataSource>
         <h3>管理内存条</h3>
        <asp:GridView ID="gvMemory" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="dsMemory" OnRowUpdating="gvMemory_RowUpdating" DataKeyNames="MemoryID" Width="990px">
            <Columns>
                <asp:TemplateField ShowHeader="False">
                    <EditItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="更新"></asp:LinkButton>
                        <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消"></asp:LinkButton>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="编辑"></asp:LinkButton>
                        <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Delete" OnClientClick="return confirm(&quot;确实要删除吗?&quot;)" Text="删除"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="图片" SortExpression="Images">
                    <EditItemTemplate>
                        <asp:Image ID="imgPC_Memory" runat="server" ImageUrl='<%# Eval("Images") %>' />
                        
                        <asp:FileUpload ID="fupUpdatePC_Memory" runat="server" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Images") %>' Width="100px" Height="100px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Name" HeaderText="名称" SortExpression="Name" />
                <asp:BoundField DataField="Brand" HeaderText="品牌" SortExpression="Brand" />
                <asp:BoundField DataField="Series" HeaderText="系列" SortExpression="Series" />
                <asp:BoundField DataField="Speed" HeaderText="速度" SortExpression="Speed" />
                <asp:BoundField DataField="Capacity" HeaderText="容量" SortExpression="Capacity" />
                <asp:BoundField DataField="Price" HeaderText="价格" SortExpression="Price" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="dsMemory" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" DeleteCommand="DELETE FROM PC_Memory WHERE (MemoryID = @MemoryID)" SelectCommand="SELECT * FROM [PC_Memory]" UpdateCommand="UPDATE PC_Memory SET Brand = @Brand, Series = @Series, Speed = @Speed, Capacity = @Capacity, Name = @Name, Images = @Images, Price = @Price WHERE (MemoryID = @MemoryID)">
            <DeleteParameters>
                <asp:Parameter Name="MemoryID" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="Brand" />
                <asp:Parameter Name="Series" />
                <asp:Parameter Name="Speed" />
                <asp:Parameter Name="Capacity" />
                <asp:Parameter Name="Name" />
                <asp:Parameter Name="Images" />
                <asp:Parameter Name="Price" />
                <asp:Parameter Name="MemoryID" />
            </UpdateParameters>
        </asp:SqlDataSource>
       </div>
        
       <div class="ad_dingdan">
         <h3>管理用户订单</h3>
        <asp:GridView ID="gvOrders" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="OrderID,orderItemID" DataSourceID="dsOrders" Width="990px">
            <Columns>
                <asp:BoundField DataField="OrderID" HeaderText="订单编号" ReadOnly="True" SortExpression="OrderID" />
                <asp:BoundField DataField="userName" HeaderText="用户名" SortExpression="userName" />
                <asp:BoundField DataField="UserTel" HeaderText="联系电话" SortExpression="UserTel" />
                <asp:BoundField DataField="UserAddress" HeaderText="用户地址" SortExpression="UserAddress" />
                <asp:ImageField DataImageUrlField="ProductImages" HeaderText="订单样品" SortExpression="ProductImages" >
                   <ControlStyle Height="100px" Width="100px" />
                </asp:ImageField>
                <asp:ImageField DataImageUrlField="ProductDiv" HeaderText="用户定制DIY" SortExpression="ProductDiv" >
                    <ControlStyle Height="100px" Width="100px" />
                </asp:ImageField>
                <asp:BoundField DataField="ProductID" HeaderText="商品编号" SortExpression="ProductID" />
                <asp:BoundField DataField="ProductName" HeaderText="商品名称" SortExpression="ProductName" />
                <asp:BoundField DataField="amount" HeaderText="数量" SortExpression="amount" />
                <asp:BoundField DataField="orderPrice" HeaderText="单价" SortExpression="orderPrice" />
                <asp:BoundField DataField="orderSumPrice" HeaderText="总额" SortExpression="orderSumPrice" />
                <asp:BoundField DataField="ProductSize" HeaderText="大小或尺寸" SortExpression="ProductSize" />
                <asp:BoundField DataField="orderDate" HeaderText="订单日期" SortExpression="orderDate" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="dsOrders" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" SelectCommand="SELECT Orders.*, OrderItems.* FROM OrderItems INNER JOIN Orders ON OrderItems.OrderID = Orders.OrderID"></asp:SqlDataSource>
      </div>
        <div class="ad_zhangdan">
          <h3>管理账单</h3>
        <asp:GridView ID="gvBill" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="dsBill" Width="990px">
            <Columns>
                <asp:BoundField DataField="年" HeaderText="年" ReadOnly="True" SortExpression="年" />
                <asp:BoundField DataField="月" HeaderText="月" ReadOnly="True" SortExpression="月" />
                <asp:BoundField DataField="日" HeaderText="日" ReadOnly="True" SortExpression="日" />
                <asp:BoundField DataField="订单进账" HeaderText="订单进账" SortExpression="订单进账" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="dsBill" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" SelectCommand="SELECT  YEAR(Orders.orderDate) AS 年, MONTH(Orders.orderDate) AS 月, DAY(Orders.orderDate) AS 日, 
                   OrderItems.orderSumPrice AS 订单进账
FROM      OrderItems INNER JOIN
                   Orders ON OrderItems.orderID = Orders.OrderID
ORDER BY Orders.orderDate DESC"></asp:SqlDataSource>
       </div>
       <div class="ad_yingyee">
        <h3>管理营业额</h3>
        <asp:GridView ID="GvTurnover" runat="server" AutoGenerateColumns="False" DataSourceID="dsTurnover" Width="990px">
            <Columns>
                <asp:BoundField DataField="日营业额" HeaderText="日营业额" ReadOnly="True" SortExpression="日营业额" />
                <asp:BoundField DataField="日期" HeaderText="日期" ReadOnly="True" SortExpression="日期" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="dsTurnover" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" SelectCommand="SELECT SUM(OrderItems.orderSumPrice) AS 日营业额, CONVERT (nvarchar(10), Orders.orderDate, 120) AS 日期 
FROM OrderItems INNER JOIN Orders ON OrderItems.OrderID = Orders.OrderID
GROUP BY CONVERT (nvarchar(10), Orders.orderDate, 120)
ORDER BY 日期 DESC

"></asp:SqlDataSource>
     </div>
    </div>
    </form>
</body>
</html>
