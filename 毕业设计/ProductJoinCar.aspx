<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductJoinCar.aspx.cs" Inherits="ProductJoinCar" %>

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
      <span class="l toptext">欢迎来到DY商城!</span>
      <div class="r buycar">
         <span class="icon car"></span>购物车(<span id="shuliang">&nbsp 0 &nbsp</span>)
         <span id="buys">你的购物车还没有商品，快去挑选吧！</span>
      </div>
      <div class="r login">
         <ul>
            <li><a href ="UserOrder.aspx">我的订单</a></li>
            <li><a href="#">帮助</a></li>
            <li><a href="home.aspx">返回首页</a></li>
         </ul>
      </div>
     </div>
    </div>
    <div class="w">
       <div class="book2">
         <div class="mt">
        <asp:DataList ID="DataListT_shirtJoinCar" runat="server" DataKeyField="T_shirtID" DataSourceID="dsT_shirt" OnItemCommand="DataListT_shirtJoinCar_ItemCommand">
         <ItemTemplate>
            <div class="pic">
              <asp:Image ID="Image1" runat="server" Height="300px" ImageUrl='<%# Eval("T_shirtImages") %>' Width="300px" />
            </div>
             <div class="ttext">
               <asp:Label ID="T_shirtDescribeLabel" runat="server" Text='<%# Eval("T_shirtDescribe") %>' />
             </div>
             <div class="tprice">
                价格:<asp:Label ID="T_shirtPriceLabel" runat="server" Text='<%# Eval("T_shirtPrice")+"/件" %>' />
             </div>
             <div class="tradio">
                 <span>请选择大小：</span>
                <div class="lr">
                  <asp:RadioButtonList ID="rblT_shirtSize" runat="server" DataSourceID="dsT_shirtSize" DataTextField="Product_TShirtSize" DataValueField="Product_TShirtSize" RepeatDirection="Horizontal">
                  </asp:RadioButtonList>
                </div>
               </div>
                <asp:SqlDataSource ID="dsT_shirtSize" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" SelectCommand="SELECT Product_TShirtSize FROM Product_TShirt WHERE Product_TShirtFromID = @Product_TShirtFromID ">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="Product_TShirtFromID" QueryStringField="T_shirtID" />
                    </SelectParameters>
                </asp:SqlDataSource>
                购买数量：
                <asp:TextBox ID="txtAmount_TShirt" runat="server">1</asp:TextBox>
                <asp:LinkButton ID="lbtnJoinCar_TShirt" runat="server" CommandName="Buy" style="color:#c12828">加入购物车</asp:LinkButton>
                <asp:LinkButton ID="lbtnDIY_TShirt" runat="server" CommandName="DIY" style="color:#c12828;margin-left:10px" >DIY定制</asp:LinkButton>
           </ItemTemplate>
           </asp:DataList>
           <asp:SqlDataSource ID="dsT_shirt" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" SelectCommand="SELECT * FROM T_shirtInfo WHERE ([T_shirtID] = @T_shirtID)">
            <SelectParameters>
            <asp:QueryStringParameter Name="T_shirtID" QueryStringField="T_shirtID" />
            </SelectParameters>
        </asp:SqlDataSource>
       <asp:panel ID="PanelDiy" runat="server"  Visible="False">
           <div class="tdingzuo">
             <span>请上传自定义蓝图：</span>
             <asp:FileUpload ID="fupJoinCar" runat="server" Height="30px" Width="130px" />
             <span><asp:LinkButton ID="lbtCancel" runat="server" CommandName="Cancel" OnClick="lbtCancel_Click">取消</asp:LinkButton></span>
             <span><asp:LinkButton ID="lbtnDiyJoinCar" runat="server" OnClick="lbtnDiyJoinCar_Click" ForeColor="#CC3300">加入购物车</asp:LinkButton></span>
            </div>
         </asp:panel>
        </div>
      </div>
    </div>
      <div class="w">
        <asp:DataList ID="DataListPhotoBookJoinCar" runat="server" DataSourceID="dsPhotoBook" OnItemCommand="DataListPhotoBookJoinCar_ItemCommand">
            <ItemTemplate>
            <div class="book2">
               <div class="pic">
                  <asp:Image ID="Image2" runat="server" Height="350px" ImageUrl='<%# Eval("PhotoBookImages") %>' Width="230px" />
                <div class="thingtext">
                   <asp:Label ID="PhotoBookDescribeLabel" runat="server" Text='<%# Eval("PhotoBookDescribe") %>' />
                </div>
               </div>
                <div class="atext">
                   价格：<asp:Label ID="lblPhotoBook" runat="server" Text="99~139￥/件"></asp:Label>
                </div>
                <div class="btext">
                   <span>请选择大小：</span>
                  <div class="ar">
                   <asp:RadioButtonList ID="rbl_PhotoBook" runat="server" DataSourceID="dsPhotoBookPrice" DataTextField="Product_PhotoBookSize" DataValueField="Product_PhotoBookSize" RepeatDirection="Horizontal" AutoPostBack="True" OnSelectedIndexChanged="rbl_PhotoBook_SelectedIndexChanged">
                   </asp:RadioButtonList>
                  </div>
                </div>
                <asp:SqlDataSource ID="dsPhotoBookPrice" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" SelectCommand="SELECT Product_PhotoBookSize FROM Product_PhotoBooks WHERE Product_PhotoBookFromID = @Product_PhotoBookFromID ">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="Product_PhotoBookFromID" QueryStringField="PhotoBookID" />
                    </SelectParameters>
                </asp:SqlDataSource>
             <div class="mw">
                购买数量：
                <asp:TextBox ID="txtAmount_PhotoBook" runat="server">1</asp:TextBox>
                <asp:LinkButton ID="lbtnJoinCar_PhotoBook" runat="server" CommandName="Buy" style="color:#c12828">加入购物车</asp:LinkButton>
                <asp:LinkButton ID="lbtnDIY_PhotoBook" runat="server" CommandName="DIY" style="color:#c12828;margin-left:10px" >DIY定制</asp:LinkButton>
             </div>
            </div>
            </ItemTemplate>
        </asp:DataList>
     </div>
      <div class="w">
        <asp:SqlDataSource ID="dsPhotoBook" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" SelectCommand="SELECT * FROM PhotoBooks WHERE PhotoBookID = @PhotoBookID">
            <SelectParameters>
                <asp:QueryStringParameter Name="PhotoBookID" QueryStringField="PhotoBookID" />
            </SelectParameters>
        </asp:SqlDataSource>
       <div class="book2">
         <asp:DataList ID="DataListMuralPaintingJoinCar" runat="server" DataSourceID="dsMuralPainting" OnItemCommand="DataListMuralPaintingJoinCar_ItemCommand">
          
            <ItemTemplate>
             <div class="moo" style="margin-left:300px">
               <div class="pic">
                <asp:Image ID="Image3" runat="server" Height="200px" ImageUrl='<%# Eval("MuralPaintingImages") %>' Width="150px" />
               </div>
                <asp:Label ID="lblMuralPaintingDescribe" runat="server" Text='<%# Eval("MuralPaintingDescribe") %>' />
                <div class="atext">
                  价格:
                  <asp:Label ID="lblMuralPaintingPrice" runat="server" Text='<%# Eval("MuralPaintingPrice")+"/件" %>' />
                </div>
                尺寸:
                <asp:Label ID="lblMuralPaintingSize" runat="server" Text='<%# Eval("MuralPaintingSize") %>' />
                购买数量：
                <asp:TextBox ID="txtAmount_MuralPainting" runat="server">1</asp:TextBox>
                <asp:LinkButton ID="lbtnJoinCar_MuralPainting" runat="server" CommandName="Buy">加入购物车</asp:LinkButton>
                <asp:LinkButton ID="lbtn_DIY_MuralPainting" runat="server" CommandName="DIY">DIY定制</asp:LinkButton>
            </ItemTemplate>
         </asp:DataList>
         <asp:SqlDataSource ID="dsMuralPainting" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" SelectCommand="SELECT * FROM [MuralPaintings] WHERE ([MuralPaintingID] = @MuralPaintingID)">
            <SelectParameters>
                <asp:QueryStringParameter Name="MuralPaintingID" QueryStringField="MuralPaintingID" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        </div>
       </div>
      <div class="w">
        <div class="mt" >
        <asp:DataList ID="DataListPC_Host" runat="server" DataSourceID="dsPC_Host" OnItemCommand="DataListPC_Host_ItemCommand">
            <ItemTemplate>
                <asp:Image ID="ImagePC_Host" runat="server" Height="150px" ImageUrl='<%# Eval("Images") %>' Width="150px" />
                <br />
                名称:
                <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                <br />
                Cpu:
                <asp:Label ID="CpuLabel" runat="server" Text='<%# Eval("Cpu") %>' />
                <br />
                主板:
                <asp:Label ID="MainBoardLabel" runat="server" Text='<%# Eval("MainBoard") %>' />
                <br />
                散热器:
                <asp:Label ID="CoolerLabel" runat="server" Text='<%# Eval("Cooler") %>' />
                <br />
                硬盘:
                <asp:Label ID="HardDiskLabel" runat="server" Text='<%# Eval("HardDisk") %>' />
                <br />
                内存条:
                <asp:Label ID="MemoryLabel" runat="server" Text='<%# Eval("Memory") %>' />
               <br />
                显卡:
                <asp:Label ID="GraphicsLabel" runat="server" Text='<%# Eval("Graphics") %>' />
               <br />
                电源:
                <asp:Label ID="PowerLabel" runat="server" Text='<%# Eval("Power") %>' />
               <br />
                机箱:
                <asp:Label ID="ComputerCaseLabel" runat="server" Text='<%# Eval("ComputerCase") %>' />
               <br />
                价格:
                <asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("Price") %>' />
                <br />
                购买数量：
                <asp:TextBox ID="txtAmountPC_Host" runat="server">1</asp:TextBox>
               
                <asp:LinkButton ID="lbtnJoinCarPC_Host" runat="server" CommandName="Buy">加入购物车</asp:LinkButton>
            
            </ItemTemplate>
        </asp:DataList>
         </div>
       </div>
     <div class="w">
         <div class="mt">
        <asp:SqlDataSource ID="dsPC_Host" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" SelectCommand="SELECT * FROM [PC_Host] WHERE ([HostID] = @HostID)">
            <SelectParameters>
                <asp:QueryStringParameter Name="HostID" QueryStringField="HostID" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:DataList ID="DataListPC_CPU" runat="server" DataSourceID="dsPC_CPU" OnItemCommand="DataListPC_CPU_ItemCommand">
            <ItemTemplate>
                <asp:Image ID="ImagePC_CPU" runat="server" Height="200px" ImageUrl='<%# Eval("Images") %>' Width="150px" />
                <br />
                名称:
                <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                <br />
                品牌:
                <asp:Label ID="BrandLabel" runat="server" Text='<%# Eval("Brand") %>' />
                <br />
                型号:
                <asp:Label ID="ModelLabel" runat="server" Text='<%# Eval("Model") %>' />
               <br />
                系列:
                <asp:Label ID="SeriesLabel" runat="server" Text='<%# Eval("Series") %>' />
             <br />
                价格:
                <asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("Price") %>' />
              <br />
                购买数量：
                <asp:TextBox ID="txtAmountPC_Cpu" runat="server">1</asp:TextBox>
                <br />
                <asp:LinkButton ID="lbtnJoinCarPC_C" runat="server" CommandName="Buy">加入购物车</asp:LinkButton>

            </ItemTemplate>
        </asp:DataList>
      
        <asp:SqlDataSource ID="dsPC_CPU" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" SelectCommand="SELECT * FROM [PC_Cpu] WHERE ([CpuID] = @CpuID)">
            <SelectParameters>
                <asp:QueryStringParameter Name="CpuID" QueryStringField="CpuID" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
       </div>
     </div>
      <div class="w">
          <div class="mt">
        <asp:DataList ID="DataListMemory" runat="server" DataSourceID="dsMemory" OnItemCommand="DataListMemory_ItemCommand">
            <ItemTemplate>
                <asp:Image ID="ImageMemory" runat="server" Height="200px" ImageUrl='<%# Eval("Images") %>' Width="150px" />
                <br />
                名称:
                <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                <br />
                品牌:
                <asp:Label ID="BrandLabel" runat="server" Text='<%# Eval("Brand") %>' />
                <br />
                系列:
                <asp:Label ID="SeriesLabel" runat="server" Text='<%# Eval("Series") %>' />
                <br />
                速度:
                <asp:Label ID="SpeedLabel" runat="server" Text='<%# Eval("Speed") %>' />
                 <br />
                容量:
                <asp:Label ID="CapacityLabel" runat="server" Text='<%# Eval("Capacity") %>' />
                <br />
                价格:
                <asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("Price") %>' />
                <br />
                购买数量：<br /> 
                <asp:TextBox ID="txtAmountMemory" runat="server">1</asp:TextBox>
                 <br />
                <asp:LinkButton ID="lbtnJoinCarMemory" runat="server" CommandName="Buy">加入购物车</asp:LinkButton>

            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="dsMemory" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" SelectCommand="SELECT * FROM [PC_Memory] WHERE ([MemoryID] = @MemoryID)">
            <SelectParameters>
                <asp:QueryStringParameter Name="MemoryID" QueryStringField="MemoryID" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        </div>
     </div>
       <div class="w">
          <div class="mt">
        <asp:DataList ID="DataListGraphics" runat="server" DataSourceID="dsGraphics" OnItemCommand="DataListGraphics_ItemCommand">
            <ItemTemplate>
                <asp:Image ID="ImageGraphics" runat="server" Height="200px" ImageUrl='<%# Eval("Images") %>' Width="150px" />
                <br />
                名称:
                <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                 <br />
                品牌:
                <asp:Label ID="BrandLabel" runat="server" Text='<%# Eval("Brand") %>' />
                  <br />
                型号:
                <asp:Label ID="ModelLabel" runat="server" Text='<%# Eval("Model") %>' />
                <br />
                频率:
                <asp:Label ID="FrequencyLabel" runat="server" Text='<%# Eval("Frequency") %>' />
                 <br />
                特性:
                <asp:Label ID="CharacterLabel" runat="server" Text='<%# Eval("Character") %>' />
                 <br />
                价格:
                <asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("Price") %>' />
                 <br />
                购买数量：
                <asp:TextBox ID="txtAmountGraphics" runat="server">1</asp:TextBox>
         
                <asp:LinkButton ID="lbtnJoinCarGraphics" runat="server" CommandName="Buy">加入购物车</asp:LinkButton>
           
            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="dsGraphics" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" SelectCommand="SELECT * FROM [PC_Graphics] WHERE ([GraphicsID] = @GraphicsID)">
            <SelectParameters>
                <asp:QueryStringParameter Name="GraphicsID" QueryStringField="GraphicsID" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
      </div>
     </div>
    </form>
</body>
</html>
