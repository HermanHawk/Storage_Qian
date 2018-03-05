using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class HotelIndent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection();
        //cn.ConnectionString = "Data Source=.;Initial Catalog=db_travel;User ID=sa;Password=123456";
        cn.ConnectionString = "Data Source=DESKTOP-LJJR5B0\\HERMAN;Initial Catalog=db_travel;Integrated Security=True";
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cn;
        cmd.CommandText = "insert into HotelIndent values(@HotelName,@City,@Price)";
        cmd.Parameters.AddWithValue("@HotelName",Request.QueryString["HName"]);
        cmd.Parameters.AddWithValue("@City", Request.QueryString["CLabel"]);
        cmd.Parameters.AddWithValue("@Price", Request.QueryString["PLabel"]);
        SqlCommand cmd1 = new SqlCommand();
        cmd1.Connection = cn;
        cmd1.CommandText = "select * from HotelIndent where HotelName='" + Request.QueryString["HName"] + "' ";





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