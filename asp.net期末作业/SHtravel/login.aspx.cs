using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            if (Response.Cookies["txtTelephone"] != null)
                txtTelephone.Text = Request.Cookies["txtTelephone"].Value;
        }

    }

    bool UserLogin()  //登录检查
    {
        SqlConnection cn = new SqlConnection();
        //cn.ConnectionString = "Data Source=.;Initial Catalog=db_travel;Integrated Security=True";
        //cn.ConnectionString = "Data Source=DESKTOP-LJJR5B0\\HERMAN;Initial Catalog=db_travel;Integrated Security=True ";
        cn.ConnectionString = "Data Source=DESKTOP-LJJR5B0\\HERMAN;Initial Catalog=db_travel;Integrated Security=True";
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cn;
        cmd.CommandText = "select * from Users where Telephone=@Tel and Pwd=@UPwd";
        cmd.Parameters.AddWithValue("@Tel", txtTelephone.Text);
        cmd.Parameters.AddWithValue("@UPwd", txtPassword.Text);
        cn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.HasRows)
        {
            dr.Close();
            cn.Close();
            return true;
        }
        else
        {
            dr.Close();
            cn.Close();
            return false;
        }
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {

        // if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text))
        if (UserLogin())
        {//登录成功 
            Session["txtTelephone"] = txtTelephone.Text;
            Response.Cookies["txtTelephone"].Value = txtTelephone.Text;
            Response.Cookies["txtTelephone"].Expires = DateTime.Now.AddDays(int.Parse(dpExpires.SelectedValue));
            Response.Redirect("Default2.aspx");
        }
        else
        { //登录失败
            Literal lit = new Literal();
            lit.Text = "<script language='javascript'>window.alert('登录失败！')</script>";
            Page.Controls.Add(lit);
        }

    }
}