using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class AddHote : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void hbtn_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection();
        cn.ConnectionString = "Data Source=DESKTOP-LJJR5B0\\HERMAN;Initial Catalog=db_travel;Integrated Security=True";
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cn;
        cmd.CommandText = "insert into Hotel values(@HotelName,@City,@Details,@Price,@Images)";
        cmd.Parameters.AddWithValue("@HotelName", hname.Text);
        cmd.Parameters.AddWithValue("@City", hcity.Text);
        cmd.Parameters.AddWithValue("@Details", hdetail.Text);
        cmd.Parameters.AddWithValue("@Price", hprice.Text);


        if (fuphoto3.HasFile)
        {
            string PUrl = @"~\pic\" + fuphoto3.FileName;   //上传图片保存路径
            fuphoto3.SaveAs(Server.MapPath(PUrl));  //保存文件
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
    }
}