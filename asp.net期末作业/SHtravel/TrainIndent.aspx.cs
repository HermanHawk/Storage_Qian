using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class TrainIndent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection();
        //cn.ConnectionString = "Data Source=.;Initial Catalog=Car;User ID=sa;Password=123456";
        cn.ConnectionString = "Data Source=DESKTOP-LJJR5B0\\HERMAN;Initial Catalog=db_travel;Integrated Security=True";
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cn;
        cmd.CommandText = "insert into TrafficIndent values(@ID,@sSta,@eSta,@tPrice)";
        cmd.Parameters.AddWithValue("@ID", Request.QueryString["tID"]);
        cmd.Parameters.AddWithValue("@sSta", Request.QueryString["st"]);
        cmd.Parameters.AddWithValue("@eSta", Request.QueryString["en"]);
        cmd.Parameters.AddWithValue("@tPrice", Request.QueryString["pr"]);
        SqlCommand cmd1 = new SqlCommand();
        cmd1.Connection = cn;
        cmd1.CommandText = "select * from TrafficIndent where ID='" + Request.QueryString["tID"] + "' ";





        cn.Open();

        SqlDataReader dr = cmd1.ExecuteReader();



        Literal lit1 = new Literal();



        if (dr.HasRows)
        {

            lit1.Text = "<script>alert('购物车已有该商品，请勿重复购买!')</script>";
            Page.Controls.Add(lit1);
            cn.Close();
            dr.Close();

        }
        else
        {
            dr.Close();
            cmd.ExecuteNonQuery();
            lit1.Text = "<script>alert('加入购物车成功!')</script>";
            Page.Controls.Add(lit1);
            cn.Close();

        }
    }
}