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



    protected void tbtn_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection();
        cn.ConnectionString = "Data Source=DESKTOP-LJJR5B0\\HERMAN;Initial Catalog=db_travel;Integrated Security=True";
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cn;
        cmd.CommandText = "insert into Traffic values(@sSta,@eSta,@tPrice,@allPrice,@ID)";
        cmd.Parameters.AddWithValue("@sSta", tstart.Text);
        cmd.Parameters.AddWithValue("@eSta", tend.Text);
        cmd.Parameters.AddWithValue("@tPrice", tprice.Text);
        cmd.Parameters.AddWithValue("@allPrice", aprice.Text);
        cmd.Parameters.AddWithValue("@ID", aID.Text);
      


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