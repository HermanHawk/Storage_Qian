using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        string userTelephone = null;
        string userName = null;
        string userEmail = null;
        string userPhotoPath = null;
        if (Session["telephone"] != null)
        {

            userTelephone = Session["telephone"].ToString();
            this.lblUserTel.Text = userTelephone;
        }

        string sql = "select * from UserInfo where Telephone = @LoginTelephone";
        SqlParameter[] pms = new SqlParameter[] { 
                             new SqlParameter("@LoginTelephone", SqlDbType.VarChar, 50) { Value = userTelephone }};
        using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text, pms))
        {
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    userName = reader.GetString(1);
                    lblUserName.Text = userName;
                    Session["name"] = userName;
                    userEmail = reader.GetString(3);
                    lblUserEmail.Text = userEmail;
                    Session["email"] = userEmail;
                    //Image.ImageUrl = ds.Tables[0].Rows[0]["studentPic"].ToString();
                    //sdr.IsDBNull(7) ? null : sdr.GetString(7);
                    userPhotoPath =  reader.IsDBNull(4) ? null : reader.GetString(4);
                    if (userPhotoPath != null)
                    {
                        userPhoto.ImageUrl = userPhotoPath;
                    }
                    else
                    {
                        //\images\userImages\CommonUserPhoto.gif
                        //userPhoto.ImageUrl = @"~/images/userImages/CommonUserPhoto.gif";
                        userPhotoPath = @"~/images/userImages/CommonUserPhoto.gif";
                        userPhoto.ImageUrl = userPhotoPath;
                        //userPhoto.ImageUrl = @"~/images/user/"
                    }
                    Session["photoPath"] = userPhotoPath;
                }
            }
        }

        


        //Literal lit = new Literal();
        //if (r == 0)
        //{
        //    //"登录成功",转首页
        //    Response.Cookies["UserTel"].Value = loginname.Text.Trim();
        //    Response.Cookies["UserPwd"].Value = LoginPassword;
        //    Session["UserName"] = loginname.Text.Trim();
        //    //Session["UserName"] = name;
        //    //lit.Text = "<script language='javascript'>window.alert("+name+")</script>";
        //    Response.Redirect("home.aspx");
        //}



    }

}