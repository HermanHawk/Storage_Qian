using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
public partial class home : System.Web.UI.Page
{
   

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["telephone"] != null)
            {
                //this.hplUserinfo.Text = "欢迎用户" + Session["UserName"];
                //前台<%= Session["UserName"]%>
                this.hplUserinfo.Text = "欢迎用户:" + Session["telephone"].ToString();
                this.userLoginShow.Visible = false;
                this.userRegister.Visible = false;
                this.lbtnLogout.Visible = true;

                string sql1 = "select count(*) from ShoppingCart where spUserTel = @spUserTel";

                SqlParameter[] pms1 = new SqlParameter[] { 
                             new SqlParameter("@spUserTel", SqlDbType.VarChar,50) { Value = Session["telephone"].ToString() }};
                int count = (int)SqlHelper.ExecuteScalar(sql1, CommandType.Text, pms1);
                lblSpCount.Text = count.ToString();
                lblSpDescribe.Text="你的购物车中有" + count + "件商品，欢迎继续购物！";
            }
            else
            {
                this.hplUserinfo.Text = null;
                this.lbtnLogout.Visible = false;
            }

            
        }
    }
    protected void lbtnLogout_Click(object sender, EventArgs e)
    {
        Session["telephone"] = null;
        this.hplUserinfo.Text = null;
        this.lbtnLogout.Visible = false;
        this.userLoginShow.Visible = true;
        this.userRegister.Visible = true;
        lblSpCount.Text = "0";
        lblSpDescribe.Text = "你的购物车还没有商品，快去挑选吧！";
        
    }
}