using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
public partial class UploadFlie : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Button1.Attributes["onclick"] = "return checkform();";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int count = 0;
        if (FileUpload1.HasFile)
        {

            DirectoryInfo info = new DirectoryInfo(Server.MapPath(@"~/Unityimages"));
            count = info.GetFiles().Length;
            string upPath = "Unityimages/";  //上传文件路径
            int upLength = 5;        //上传文件大小
            string upFileType = "|image/bmp|image/x-png|image/pjpeg|image/gif|image/png|image/jpeg|";

            string fileContentType = FileUpload1.PostedFile.ContentType;    //文件类型

            if (upFileType.IndexOf(fileContentType.ToLower()) > 0)
            {
                string name = FileUpload1.PostedFile.FileName;                  // 客户端文件路径

                FileInfo file = new FileInfo(name);

               // string fileName = DateTime.Now.ToString("yyyyMMddhhmmssfff") + file.Extension; // 文件名称，当前时间（yyyyMMddhhmmssfff）
                string fileName = "sss"+(count+1).ToString()+file.Extension; 
                string webFilePath = Server.MapPath(upPath) + fileName;        // 服务器端文件路径

                string FilePath = upPath + fileName;   //页面中使用的路径

                if (!File.Exists(webFilePath))
                {
                    if ((FileUpload1.FileBytes.Length / (1024 * 1024)) > upLength)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "upfileOK", "alert('大小超出 " + upLength + " M的限制，请处理后再上传！');", true);
                        return;
                    }

                    try
                    {
                        FileUpload1.SaveAs(webFilePath);                                // 使用 SaveAs 方法保存文件


                        ClientScript.RegisterStartupScript(this.GetType(), "upfileOK", "alert('提示：文件上传成功');", true);
                    }
                    catch (Exception ex)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "upfileOK", "alert('提示：文件上传失败" + ex.Message + "');", true);
                    }
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "upfileOK", "alert('提示：文件已经存在，请重命名后上传');", true);
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "upfileOK", "alert('提示：文件类型不符" + fileContentType + "');", true);
            }
        }
    }
}