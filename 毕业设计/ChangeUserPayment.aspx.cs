using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChangeUserPayment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnChangePaymentCode_Click(object sender, EventArgs e)
    {

        /*
             * 1.采集用户输入
             * 2.验证两次输入的新密码
             * 3.更新密码
             */

        
        string pwd1 = txtPwdOne.Text;
        string pwd2 = txtPwdTwo.Text;
        string telephone = Session["telephone"].ToString();
        Literal lit = new Literal();

        if (pwd1 == pwd2)
        {
            if (pwd1 != "")
            {
                //修改密码
                if (UpdatePassword(telephone, pwd1))
                {
                    lit.Text = "<script language='javascript'>window.alert('修改成功！')</script>";
                }
                else
                {
                    lit.Text = "<script language='javascript'>window.alert('修改失败！')</script>";
                }
            }
            else
            {
                lit.Text = "<script language='javascript'>window.alert('密码不能为空！')</script>";
            }
        }
        else
        {
            lit.Text = "<script language='javascript'>window.alert('两次输入不一致！')</script>";
        }
        Page.Controls.Add(lit);


    }

    private bool UpdatePassword(string UserTel, string newPwd)
    {
        string sql = "update UserInfo set paymentCode = @password where Telephone = @UserTelephone";
        //update UserInfo set paymentCode = 1111 where Telephone = 13380326666
        SqlParameter[] pms = new SqlParameter[] { 
                             new SqlParameter("@UserTelephone", SqlDbType.VarChar, 50) { Value = UserTel },
                             new SqlParameter("@password", SqlDbType.NVarChar, 50) { Value = newPwd }
        };
        int r = SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pms);
        return r > 0;
    }
}