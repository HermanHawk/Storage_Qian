<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductInfo.aspx.cs" Inherits="ProductInfo" %>

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
        <asp:DataList ID="DataListT_shirt" runat="server" DataKeyField="T_shirtID" DataSourceID="dsT_shirt" HorizontalAlign="Center" RepeatColumns="4" RepeatDirection="Horizontal">
            <ItemTemplate>
         <div class="book" >
                <a href ='<%# string.Format("ProductJoinCar.aspx?T_shirtID={0}",Eval("T_shirtID")) %>'>
                <asp:Image ID="ImageT_shirt" runat="server" Height="200px" ImageUrl='<%# Eval("T_shirtImages") %>' Width="200px" />
                </a>
            <div class="botext">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# string.Format("ProductJoinCar.aspx?T_shirtID={0}",Eval("T_shirtID")) %>' Text='<%# Eval("T_shirtDescribe")+"("+Eval("T_shirtPrice","{0:C}")+")" %>'></asp:HyperLink>
            </div>
                </ItemTemplate>
          </asp:DataList>
       </div>
         <asp:SqlDataSource ID="dsT_shirt" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" SelectCommand="SELECT * FROM [T_shirtInfo]"></asp:SqlDataSource>
         <asp:DataList ID="DataListPhotoBook" runat="server" DataSourceID="dsPhotoBook" DataKeyField="PhotoBookID" HorizontalAlign="Center" RepeatColumns="4" RepeatDirection="Horizontal">
            <ItemTemplate>
        

         <div class="book">
                 <a href ='<%# string.Format("ProductJoinCar.aspx?PhotoBookID={0}",Eval("PhotoBookID")) %>'>
          <div class="bookp">
                <asp:Image ID="ImagePhotoBook" runat="server" Height="200px" ImageUrl='<%# Eval("PhotoBookImages") %>' Width="150px"  />
           </div>
                </a>
             <div class="botext">
                <asp:HyperLink ID="HyperLink2" style="color:#445274" runat="server" NavigateUrl='<%# string.Format("ProductJoinCar.aspx?PhotoBookID={0}",Eval("PhotoBookID")) %>' Text='<%# Eval("PhotoBookDescribe")+"(￥99~139)" %>'></asp:HyperLink>
            </div>
            </ItemTemplate>
           </asp:DataList>
      
     
        <asp:SqlDataSource ID="dsPhotoBook" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" SelectCommand="SELECT * FROM [PhotoBooks]"></asp:SqlDataSource>
        <asp:DataList ID="DataListMuralPainting" runat="server" DataSourceID="dsMuralPainting" DataKeyField="MuralPaintingID" HorizontalAlign="Center" RepeatColumns="4" RepeatDirection="Horizontal">
            <ItemTemplate>
             <div class="book">
                <a href ='<%# string.Format("ProductJoinCar.aspx?MuralPaintingID={0}",Eval("MuralPaintingID")) %>'> 
                <div class="bookp" style="padding-top:10px;">
                   <asp:Image ID="ImageMuralPainting" runat="server" Height="180px" Width="150px" ImageUrl='<%# Eval("MuralPaintingImages") %>'  />
                 </div>
                    </a>
                  <div class="botext">
                      <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl='<%# string.Format("ProductJoinCar.aspx?MuralPaintingID={0}",Eval("MuralPaintingID")) %>' Text='<%# Eval("MuralPaintingDescribe")+"("+Eval("MuralPaintingPrice","{0:C}")+")" %>'></asp:HyperLink>
                   </div>
                      </ItemTemplate>
                </asp:DataList>
               <asp:SqlDataSource ID="dsMuralPainting" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" SelectCommand="SELECT * FROM [MuralPaintings]"></asp:SqlDataSource>
       
      <div class="w">
         <div class="tab3">
           <asp:DataList ID="DataListComputer" runat="server" HorizontalAlign="Center" RepeatColumns="4" RepeatDirection="Horizontal" DataSourceID="dsComputer">
            <ItemTemplate>
                <a href ='<%# string.Format("ProductJoinCar.aspx?HostID={0}",Eval("HostID")) %>'>
                  <asp:Image ID="Image1" runat="server" Height="200px" ImageUrl='<%# Eval("Images") %>' Width="200px" />
                </a>
                <span><asp:HyperLink ID="HyperLink4" runat="server" Text='<%# Eval("Name")+"("+ Eval("Cpu")+Eval("MainBoard")+")"+"("+Eval("Price","{0:C}")+")" %>' NavigateUrl='<%# string.Format("ProductJoinCar.aspx?HostID={0}",Eval("HostID")) %>'></asp:HyperLink></span>
            </ItemTemplate>
          </asp:DataList>
           <asp:SqlDataSource ID="dsComputer" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" SelectCommand="SELECT * FROM [PC_Host]"></asp:SqlDataSource>
         </div>
          <div class="tab3">
            <asp:DataList ID="DataListPC_CPU" runat="server" DataSourceID="dsPC_CPU" HorizontalAlign="Center" RepeatColumns="4" RepeatDirection="Horizontal">
            <ItemTemplate>
                <a href ='<%# string.Format("ProductJoinCar.aspx?CpuID={0}",Eval("CpuID")) %>'>
                <asp:Image ID="Image2" runat="server" Height="200px" ImageUrl='<%# Eval("Images") %>' Width="200px" />
                <span><asp:HyperLink ID="HyperLink5" runat="server" Text='<%# Eval("Name")+"("+Eval("Brand")+Eval("Model")+")"+"("+Eval("Price","{0:C}")+")" %>' NavigateUrl='<%# string.Format("ProductJoinCar.aspx?CpuID={0}",Eval("CpuID")) %>'></asp:HyperLink></span>
            </ItemTemplate>
           </asp:DataList>
           <asp:SqlDataSource ID="dsPC_CPU" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" SelectCommand="SELECT * FROM [PC_Cpu]"></asp:SqlDataSource>
          </div>
          <div class="tab3">
              <asp:DataList ID="DataListMemory" runat="server" DataSourceID="dsMemory" HorizontalAlign="Center" RepeatColumns="4" RepeatDirection="Horizontal">
            <ItemTemplate>
                <a href ='<%# string.Format("ProductJoinCar.aspx?MemoryID={0}",Eval("MemoryID")) %>'>
                   <asp:Image ID="Image3" runat="server" Height="200px" ImageUrl='<%# Eval("Images") %>' Width="200px" />
                </a>
                <span><asp:HyperLink ID="HyperLink6" runat="server" Text='<%# Eval("Name")+"("+Eval("Brand")+Eval("Series")+")"+"("+Eval("Price","{0:C}")+")" %>' NavigateUrl='<%# string.Format("ProductJoinCar.aspx?MemoryID={0}",Eval("MemoryID")) %>'></asp:HyperLink></span>
            </ItemTemplate>
          </asp:DataList>
          <asp:SqlDataSource ID="dsMemory" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" SelectCommand="SELECT * FROM [PC_Memory]"></asp:SqlDataSource>
         </div> 
          <div class="tab3">
              <asp:DataList ID="DataListGraphics" runat="server" DataSourceID="dsGraphics" HorizontalAlign="Center" RepeatColumns="4" RepeatDirection="Horizontal">
              <ItemTemplate>
                <a href ='<%# string.Format("ProductJoinCar.aspx?GraphicsID={0}",Eval("GraphicsID")) %>'>
                <asp:Image ID="Image4" runat="server" Height="300px" ImageUrl='<%# Eval("Images") %>' Width="300px" />
                </a>
                <asp:HyperLink ID="HyperLink7" runat="server" Text='<%# Eval("Name")+"("+Eval("Brand")+Eval("Model")+")"+"("+Eval("Price","{0:C}")+")" %>' NavigateUrl='<%# string.Format("ProductJoinCar.aspx?GraphicsID={0}",Eval("GraphicsID")) %>'></asp:HyperLink>
            </ItemTemplate>
          </asp:DataList>
          <asp:SqlDataSource ID="dsGraphics" runat="server" ConnectionString="<%$ ConnectionStrings:DIY_ShopConnectionString %>" SelectCommand="SELECT * FROM [PC_Graphics]"></asp:SqlDataSource>
         </div>
        </div>
    </form>
</body>
</html>
