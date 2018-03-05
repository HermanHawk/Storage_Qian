using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class AddPlace : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void pbtn_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection();
        cn.ConnectionString = "Data Source=DESKTOP-LJJR5B0\\HERMAN;Initial Catalog=db_travel;Integrated Security=True";
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cn;
        cmd.CommandText = "insert into Place values(@PlanceName,@details,@City,@Price,@Images1,@Images2)";
        cmd.Parameters.AddWithValue("@PlanceName", pname.Text);
        cmd.Parameters.AddWithValue("@details", pdetail.Text);
        cmd.Parameters.AddWithValue("@City", pcity.Text);
        cmd.Parameters.AddWithValue("@Price", pprice.Text);
      

        if (fuphoto1.HasFile)
        {
            string PUrl = @"~\pic\" + fuphoto1.FileName;   //上传图片保存路径
            fuphoto1.SaveAs(Server.MapPath(PUrl));  //保存文件
            cmd.Parameters.AddWithValue("@Images1", PUrl);
        }
        else
        {
            cmd.Parameters.AddWithValue("@Images1", "");
        }

            if (fuphoto2.HasFile)
            {
                string PUrl = @"~\pic\" + fuphoto2.FileName;   //上传图片保存路径
                fuphoto2.SaveAs(Server.MapPath(PUrl));  //保存文件
                cmd.Parameters.AddWithValue("@Images2", PUrl);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Images2", "");
            }
            cn.Open();
             int r=cmd.ExecuteNonQuery();
            cn.Close();
            Literal lit = new Literal();
            if (r > 0)
            {
                lit.Text = "<script>alert('添加成功!')</script>";
                Page.Controls.Add(lit);
 
            }
        

    }
}