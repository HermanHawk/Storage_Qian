<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UploadFlie.aspx.cs" Inherits="UploadFlie" %>
<!--#include file="WebDemo.html" -->
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
         <script type="text/javascript">
             function checkform() {
                 var strs = document.getElementById("FileUpload1").value;
                 if (strs == "") {
                     alert("请选择要上传的图片!");
                     return false;
                 }

                 var n1 = strs.lastIndexOf('.') + 1;
                 var fileExt = strs.substring(n1, n1 + 3).toLowerCase()
                 if (fileExt != "jpg" && fileExt != "bmp" && fileExt != "png") {
                     alert('目前系统仅支持jpg、bmp、png后缀图片上传!');
                     return false;
                 }

             }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" />
    
    </div>
    </form>
</body>
</html>
