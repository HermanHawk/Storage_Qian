using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CheckCode : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {


        //判断验证码是否输入正确  
        string code = txtCode.Text.Trim().ToUpper();//将输入的字母都转化成大写然后作比较  
        string rightCode = Session["Code"].ToString();
        if (code != rightCode)
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('验证码输入错误！');</script>");//提示错误保证后面背景不变白  

            return;
        }  



    }
}