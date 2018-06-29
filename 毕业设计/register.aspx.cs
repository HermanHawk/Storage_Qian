using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnagree_Click(object sender, EventArgs e)
    {
        string sql = "insert into UserInfo values(@Telephone,@Name,@Pwd,@Email,@userPhoto,@paymentCode)";
        string sql2 = "select count(*) from AdminInfo where AdminTelephone=@AdminTelephone";
        string sql1 = "select count(*) from UserInfo where Telephone=@userTel";
        SqlParameter[] pms =  new SqlParameter[] { 
                              new SqlParameter("@Telephone", SqlDbType.VarChar, 50) { Value = Txtph.Text.Trim() },
                              new SqlParameter("@Name", SqlDbType.NVarChar, 50) { Value = Txtname.Text },
                              new SqlParameter("@Pwd", SqlDbType.NVarChar, 50) { Value = Txtpwd.Text },
                              new SqlParameter("@Email", SqlDbType.NVarChar, 50) { Value = Txtemail.Text },
                              new SqlParameter("@userPhoto", SqlDbType.NVarChar, 50) { Value = "" },
                              new SqlParameter("@paymentCode", SqlDbType.NVarChar, 50) { Value = "" }
                   };
        SqlParameter[] pms1 = new SqlParameter[]{
            new SqlParameter("userTel",SqlDbType.VarChar,50){Value = Txtph.Text.Trim()}
        };
        SqlParameter[] pms2 = new SqlParameter[]{
            new SqlParameter("AdminTelephone",SqlDbType.VarChar,50){Value = Txtph.Text.Trim()}
        };
        int count1 = (int)SqlHelper.ExecuteScalar(sql1, CommandType.Text, pms1);
        Literal lit = new Literal();
        if (count1 > 0)
        {
            lit.Text = "<script>alert('已存在该账号的用户!')</script>";
        }
        else
        {
            int count2 = (int)SqlHelper.ExecuteScalar(sql2, CommandType.Text, pms2);

            if (count2 > 0)
            {
                lit.Text = "<script>alert('已存在该账号的用户!')</script>";
            }
            else
            {
                int count = SqlHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, pms);
                if (count > 0)
                {
                    //"注册成功",转首页
                    //Response.Redirect("Login.aspx");

                    lit.Text = "<script>alert('添加成功!')</script>";
                    //Page.Controls.Add(lit);
                    //"注册成功",转首页
                    //Response.Redirect("Login.aspx");
                }
                else
                {
                    //"注册失败"
                    // Literal lit = new Literal();
                    lit.Text = "<script>alert('添加失败!')</script>";

                }
            }
        }
        Page.Controls.Add(lit);

    }
}