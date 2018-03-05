using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        SqlConnection cn = new SqlConnection();
        cn.ConnectionString = "Data Source=DESKTOP-LJJR5B0\\HERMAN;Initial Catalog=db_travel;Integrated Security=True";
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cn;
        cmd.CommandText = "insert into Users values(@UserName,@Pwd,@Telephone,@Images)";
        
        cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
        cmd.Parameters.AddWithValue("@Pwd",txtPwd.Text);
        cmd.Parameters.AddWithValue("@Telephone", txtTelephone.Text);
    

        if (fuPhoto.HasFile)
        {
            string PUrl = @"~\pic\" + fuPhoto.FileName;   //上传图片保存路径
            fuPhoto.SaveAs(Server.MapPath(PUrl));  //保存文件
            cmd.Parameters.AddWithValue("@Images", PUrl);
        }
        else
        {
            cmd.Parameters.AddWithValue("@Images", "");
        }
        cn.Open();
        int r = cmd.ExecuteNonQuery();
        cn.Close();
        Literal lit = new Literal();
        if (r > 0)
        {
            lit.Text = "<script>alert('添加成功!')</script>";
            Page.Controls.Add(lit);

        }
        //SqlConnection cn = new SqlConnection();
        //cn.ConnectionString = "Data Source=.;Initial Catalog=db_travel;Integrated Security=True";
        ////cn.ConnectionString = "Data Source=DESKTOP-LJJR5B0\\HERMAN;Initial Catalog=db_travel;Integrated Security=True ";
        //SqlCommand cmd = new SqlCommand();
        //cmd.Connection = cn;

        ////cmd.CommandText = "insert into Users values(@tl,@nm,@pwd,@purl,'0')";
        ////cmd.Parameters.AddWithValue("@tl", txtTelephone.Text);
        ////cmd.Parameters.AddWithValue("@nm", txtUserName.Text);
        ////cmd.Parameters.AddWithValue("@pwd", txtPwd.Text);
        

        //cmd.CommandText = "insert into Users (Telephone,UserName,Pwd,Image) values(' " + txtTelephone.Text + " ' , ' " + txtUserName.Text + " ' , ' " + txtPwd.Text + " ')";     
       
        //cmd.CommandText = "select * from Users where Telephone='" + txtTelephone.Text.Trim() + "'";
        //cn.Open();
        //cmd.ExecuteScalar();
       
        //Literal id = new Literal();      
        //if (cmd.ExecuteScalar() != null)
        //{
        //    id.Text = "<script>alert('用户ID已存在!')</script>";
          
        //}
        //cn.Close();
        //Page.Controls.Add(id);
        //if (fuPhoto.HasFile)
        //{
        //    string PUrl = @"~\images\" + fuPhoto.FileName;   //上传图片保存路径
        //    fuPhoto.SaveAs(Server.MapPath(PUrl));  //保存文件
        //    cmd.Parameters.AddWithValue("@purl", PUrl);
        //}
        //else
        //{
        //    cmd.Parameters.AddWithValue("@purl", "");
        //}

        //cn.Open();
        //int r = cmd.ExecuteNonQuery();    //执行命令，返回影响记录行数，如果执行失败返回0。
        //cn.Close();

        ////弹出提示框
        //Literal lit = new Literal();
        //if (r > 0)
        //{
        //    lit.Text = "<script>alert('注册成功!')</script>";
        //    Response.Redirect("login.aspx");
        //}
        //else
        //{
        //    lit.Text = "<script>alert('注册失败!')</script>";
        //}
        //Page.Controls.Add(lit);
        //cn.Close();
    }
}