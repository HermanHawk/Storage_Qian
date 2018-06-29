using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChangeUserInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!IsPostBack)
        {
            string telephone = Session["telephone"].ToString();
            string name = Session["name"].ToString();
            string email = Session["email"].ToString();
            string photoPath = Session["photoPath"].ToString();
            this.lblTelephone.Text = telephone;
            txtUserName.Text = name;
            txtUserEmail.Text = email;
            userImage.ImageUrl = photoPath;
        }





    }

    protected void btnChangeUserinfo_Click(object sender, EventArgs e)
    {
        Literal lit = new Literal();
        if(txtUserName.Text.Trim() != "" && txtUserEmail.Text.Trim()!= "")
        {
        string sql = "update UserInfo set Name=@userName,Email=@userEmail,userPhoto=@userImage where Telephone = @usertel"; 
        
        //SqlParameter[] pms = new SqlParameter[5]; 
          SqlParameter usertel = new SqlParameter("@usertel", SqlDbType.VarChar, 50) { Value = lblTelephone.Text };
          SqlParameter userNameUpdate = new SqlParameter("@userName", SqlDbType.NVarChar, 50) { Value = txtUserName.Text.Trim() };
          SqlParameter userEmailUpdate = new SqlParameter("@userEmail", SqlDbType.NVarChar, 50) { Value = txtUserEmail.Text.Trim() }; 
         SqlParameter userPhoto = null;                 
        if(FupUserPhoto.HasFile)
        {
            //\images\userImages
            string pUrl = @"~\images\userImages\" + FupUserPhoto.FileName;  //上传图片保存路径
            FupUserPhoto.SaveAs(Server.MapPath(pUrl));                      //保存文件
            userPhoto = new SqlParameter("@userImage", SqlDbType.NVarChar, 50) { Value = pUrl };
        }
        else
        {
            userPhoto = new SqlParameter("@userImage", SqlDbType.NVarChar, 50) { Value = Session["photoPath"].ToString() };
        }
        SqlParameter[] pms = new SqlParameter[] { usertel, userNameUpdate, userEmailUpdate, userPhoto };
         //pms = {usertel,userName,userEmail,userPhoto};
        int count = SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pms);
       
        if (count > 0)
        {
            //CientScript.RegisterStartupScript(this.GetType(), "Key", "<script>alert('修改成功!'); </script>");
            lit.Text = "<script language='javascript'>window.alert('修改成功！')</script>";
            txtUserName.Text = (userNameUpdate.Value).ToString();
            txtUserEmail.Text = (userEmailUpdate.Value).ToString();
            userImage.ImageUrl =(userPhoto.Value).ToString();
            

        }
        else
        {
            //ClientScript.RegisterStartupScript(this.GetType(), "Key", "<script>alert('修改失败!');</script>");
            lit.Text = "<script language='javascript'>window.alert('修改失败！')</script>";
        }
       
        //Literal lit = new Literal();
        //    lit.Text = "<script language='javascript'>window.alert('登录失败！')</script>";
        //    Page.Controls.Add(lit);
        }
        else
        {
            lit.Text = "<script language='javascript'>window.alert('不能赋空值！')</script>";
        }
        Page.Controls.Add(lit);
       

        
    


    }
}