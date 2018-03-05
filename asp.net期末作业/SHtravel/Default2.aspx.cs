using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls; 
public partial class Default2 : System.Web.UI.Page
{


  
    protected void Page_Load(object sender, EventArgs e)
    {
       
     
    }


    protected void DetailsView1_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
    {
        FileUpload f = (FileUpload)DetailsView1.FindControl("fuPhoto");
        Image img = (Image)DetailsView1.FindControl("Image3");
        if (f.HasFile)
        {
            string PUrl = @"~\pic\" + f.FileName;   //上传图片保存路径
            f.SaveAs(Server.MapPath(PUrl));  //保存文件
            SqlDataSource1.UpdateParameters["Images"].DefaultValue = PUrl;  //设置photourl的参数值
        }
        else
        {
            SqlDataSource1.UpdateParameters["Images"].DefaultValue = img.ImageUrl;  //设置photourl的参数值
        }
    }
}
       