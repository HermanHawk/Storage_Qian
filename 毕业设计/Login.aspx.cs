using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            if(Request.Cookies["UserTel"] != null)
            {
                loginname.Text = Request.Cookies["UserTel"].Value;
            }
        }
        
    }
    protected void btndenglu_Click(object sender, EventArgs e)
    {

        #region 正常验证
        //string sql = "select count(*) from UserInfo where Telephone = @LoginTelephone and Pwd = @LoginPassword";
        //SqlParameter[] pms = new SqlParameter[] { 
        //                                new SqlParameter("@LoginTelephone", SqlDbType.VarChar, 50) { Value = loginname.Text.Trim() },
        //                                new SqlParameter("@LoginPassword", SqlDbType.NVarChar, 50) { Value = password.Text }
        //            };
        //int count = (int)SqlHelper.ExecuteScalar(sql,System.Data.CommandType.Text, pms);
        //if (count > 0)
        //{
        //    //"登录成功",转首页
        //    Response.Redirect("home.aspx");
        //}
        //else
        //{
        //    //"登录失败"
        //    Literal lit = new Literal();
        //    lit.Text = "<script language='javascript'>window.alert('登录失败！')</script>";
        //    Page.Controls.Add(lit);
        //} 
        #endregion



        #region 验证登录
        string LoginPassword = password.Text;
        string sql = "select * from UserInfo where Telephone = @LoginTelephone";
       // string name = "";
        SqlParameter[] pms = new SqlParameter[] { 
                                        new SqlParameter("@LoginTelephone", SqlDbType.VarChar, 50) { Value = loginname.Text.Trim() }};

        string sql2 = "select count(*) from AdminInfo where AdminTelephone = @AdminTelephone and AdminPassword = @AdminPassword";
        SqlParameter[] pms2 = new SqlParameter[] { 
                                     new SqlParameter("@AdminTelephone", SqlDbType.VarChar, 50) { Value = loginname.Text.Trim() },
                                      new SqlParameter("@AdminPassword", SqlDbType.NVarChar, 50) { Value = password.Text }};

        int r = (int)SqlHelper.Login_customized(sql, System.Data.CommandType.Text, LoginPassword, pms);
        Literal lit = new Literal();
        if (r == 0)
        {
            //"登录成功",转首页
            Response.Cookies["UserTel"].Value = loginname.Text.Trim();
            Response.Cookies["UserPwd"].Value = LoginPassword;
            Session["telephone"] = loginname.Text.Trim();
            //Session["UserName"] = name;
            //lit.Text = "<script language='javascript'>window.alert("+name+")</script>";
            Response.Redirect("home.aspx");
        }
        else if (r == 1)
        {
            //"登录失败"
            //Literal lit = new Literal();
            lit.Text = "<script language='javascript'>window.alert('密码出错！')</script>";
           // Page.Controls.Add(lit);
        }
        else if (r == 2)
        {
            //"用户名出错"
            //Literal lit = new Literal();


            //lit.Text = "<script language='javascript'>window.alert('用户名不存在！')</script>";
            //(int)SqlHelper.Login_customized(sql2, CommandType.Text,LoginPassword, pms2);
            int count = (int)SqlHelper.ExecuteScalar(sql2, System.Data.CommandType.Text, pms2);
            if(count > 0)
            {
                Session["telephone"] = loginname.Text.Trim();
                Response.Redirect("AdminProductManage.aspx");
            }
            else
            {
                lit.Text = "<script language='javascript'>window.alert('用户名不存在！')</script>";
            }




            //Page.Controls.Add(lit);
        }
        else if (r == -1)
        {
            //"系统出错"
           // Literal lit = new Literal();
            lit.Text = "<script language='javascript'>window.alert('登录验证出错！')</script>";
            //Page.Controls.Add(lit);
        }
        Page.Controls.Add(lit);
        #endregion




    }
}
