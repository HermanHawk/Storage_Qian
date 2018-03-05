<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server"> 
    <!--<meta http-equiv="Content-Type" content="text/html;charset=UTF-8"/>   -->
<title>北上广深西安图片轮播切换代码 </title>
<link rel="stylesheet"  type="text/css" href="css/StyleSheet.css"/>
   

    <style type="text/css">
        .auto-style2 {
            text-align: center;
        }
    </style>
   

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:100%;height:auto;">
<div id="left" style="width:20%; height:700px; background-color:#6cea9f; float:left " >

    <asp:Panel ID="Panel1" runat="server" Height="100%" Width="100%" Font-Overline="False" Font-Size="Large">         
                  <br />
                  <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Adobe 楷体 Std R" Font-Size="X-Large" Font-Underline="True" ForeColor="Red" Height="40px" Text="公告栏" Width="50%"></asp:Label>
                  <br />
                  <br />
        
                  <asp:Label ID="Label3" runat="server" Text=" 由于深圳台风来袭，为了广大用户的安全考虑，本站有关深圳地区的服务暂停三天，给大家带来的不便，还望谅解！" Font-Size="Large" Font-Strikeout="False" Font-Underline="True" ForeColor="Blue"></asp:Label>           
                 
             <br />
                  <br />
                 <asp:Label ID="Label2" runat="server" Font-Size="Large" Text="2017年6月23日"></asp:Label>       

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

