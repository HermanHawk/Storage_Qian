using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RecoverPassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["telephone"] != null)
            {
                txtTel.Text = Session["telephone"].ToString();
            }
        }
    }

    protected void btnNext_Click(object sender, EventArgs e)
    {



        if (txtTel.Text.Trim() != "")
        {
            string password = txtPwd.Text.Trim();
            string rightCode = Session["Code"].ToString();
            Session["userTelephone"] = txtTel.Text.Trim();
            if (password == rightCode)
            {
                Response.Redirect("RecoverPwdEmail.aspx");
            }
            else
            {
                Literal lit = new Literal();
                lit.Text = "<script language='javascript'>window.alert('验证码错误！')</script>";
                Page.Controls.Add(lit);
            }
        }
        else
        {
            Literal lit = new Literal();
            lit.Text = "<script language='javascript'>window.alert('账号不能为空！')</script>";
            Page.Controls.Add(lit);

        }



    }

    protected void txtPwd_TextChanged(object sender, EventArgs e)
    {

    }
}