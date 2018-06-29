using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RecoverPwdEmail : System.Web.UI.Page
{


    private static string checkCode = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        string telephone = Session["userTelephone"].ToString();
        string sql = "select Email from UserInfo where Telephone = @ValTelephone";
        SqlParameter[] pms = new SqlParameter[] { 
                             new SqlParameter("@ValTelephone", SqlDbType.VarChar, 50) { Value = telephone }};
        //lblEmail.Text =(string)SqlHelper.ExecuteScalar(sql, CommandType.Text, pms);
        lblEmail.Text = (SqlHelper.ExecuteScalar(sql, CommandType.Text, pms)).ToString(); 

        //string LoginPassword = password.Text;
        //string sql = "select * from UserInfo where Telephone = @LoginTelephone";
        //SqlParameter[] pms = new SqlParameter[] { 
        //                                new SqlParameter("@LoginTelephone", SqlDbType.VarChar, 50) { Value = loginname.Text.Trim() }};
        //int r = (int)SqlHelper.Login_customized(sql, System.Data.CommandType.Text, LoginPassword, pms);
    }
    protected void btnGetCode_Click(object sender, EventArgs e)
    {


        //1.创建一个邮件对象
        MailMessage mailObject = new MailMessage();
        //设置发件人
        mailObject.From = new MailAddress("1625835052@qq.com");
        //设置收件人
        mailObject.To.Add(new MailAddress(lblEmail.Text));
        //设置主题
        mailObject.SubjectEncoding = Encoding.UTF8;
        mailObject.Subject = "修改密码验证码";

        mailObject.BodyEncoding = Encoding.UTF8;

        string valCode = GetRandomNumber();
        //checkCode = valCode;

        mailObject.Body = valCode;

        mailObject.IsBodyHtml = true;

        mailObject.Priority = MailPriority.Low;            //优先级

        //2.创建一个发送邮件的对象
        //指定smtp服务地址
        //SmtpClient smtpClient = new SmtpClient("ip地址",端口号);
        SmtpClient smtpClient = new SmtpClient("smtp.qq.com");
        //smtpClient.UseDefaultCredentials = true;
        smtpClient.EnableSsl = true;                      //是否使用安全套接字层（ssl）加密连接
        smtpClient.UseDefaultCredentials = false;
        smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network; //电子邮件通过网络发送到smtp服务器
        //smtpClient.Host = smtpServer;
        smtpClient.Credentials = new NetworkCredential("1625835052@qq.com", "第三方登录密码");   //此处应该填写第三方登录密码，因为上传GitHub所以把密码删掉了，所以导致此功能应该不可用。
        smtpClient.Send(mailObject);
        Literal lit = new Literal();
        lit.Text = "<script language='javascript'>window.alert('邮件已发送，请注意查收！')</script>";
        Page.Controls.Add(lit);
        


    }

    private static string GetRandomNumber()
    {
        string valCode = string.Empty;
        Random r = new Random();
        for (int i = 0; i < 5; i++)
        {
            int rNumber = r.Next(0, 10);
            valCode += rNumber;
        }
        checkCode = valCode;
        return valCode;
    }


    
    protected void btnNext_Click(object sender, EventArgs e)
    {

        if (txtInputEmail.Text.Trim() != "")
        {
            string valPassword = txtInputEmail.Text.Trim();
            if (valPassword == checkCode)
            {
                Response.Redirect("ChangePassword.aspx");
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
            lit.Text = "<script language='javascript'>window.alert('验证码不能为空！')</script>";
            Page.Controls.Add(lit);
        }


    }
}