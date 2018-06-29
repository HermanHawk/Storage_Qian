using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChangePaymentCode : System.Web.UI.Page
{
    private static string checkCode = "";
    //private static string userEmail = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
            string telephone = Session["telephone"].ToString();
            lblUserTelphone.Text = telephone;
            string email = Session["email"].ToString();
            lblEmail.Text = email;
            //userEmail = email;
            //string randomCode = txtRandomCode.Text.Trim();
            //string emailCode = txtEmailCode.Text.Trim();


            //string telephone = Session["telephone"].ToString();
            //string name = Session["name"].ToString();
            //string email = Session["email"].ToString();
            //string photoPath = Session["photoPath"].ToString();
            //this.lblTelephone.Text = telephone;
            //txtUserName.Text = name;
            //txtUserEmail.Text = email;
            //userImage.ImageUrl = photoPath;

           
        }

    }
    protected void btnGetEmailCode_Click(object sender, EventArgs e)
    {

        string password = txtRandomCode.Text.Trim();
        string rightCode = Session["Code"].ToString();
        if (password == rightCode)
        {
            //Response.Redirect("RecoverPwdEmail.aspx");
            GetEmail();
        }
        else
        {
            Literal lit = new Literal();
            lit.Text = "<script language='javascript'>window.alert('验证码错误！')</script>";
            Page.Controls.Add(lit);
        }
        


    }

    private void GetEmail()
    {
        //1.创建一个邮件对象
        MailMessage mailObject = new MailMessage();
        //设置发件人
        mailObject.From = new MailAddress("1625835052@qq.com");
        //设置收件人
        mailObject.To.Add(new MailAddress(lblEmail.Text));
        //设置主题
        mailObject.SubjectEncoding = Encoding.UTF8;
        mailObject.Subject = "修改支付密码验证码";

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
        smtpClient.Credentials = new NetworkCredential("1625835052@qq.com", "第三方登录密码");       //此处应为第三方登录密码，由于上次GitHub所以删掉，会影响此功能的正常实现。
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
        if(txtRandomCode.Text.Trim() != "" && txtEmailCode.Text.Trim() != "")
        {
            string valPassword = txtEmailCode.Text.Trim();
            if (valPassword == checkCode)
            {
                Response.Redirect("ChangeUserPayment.aspx");
            }
            else
            {
                Literal lit = new Literal();
                lit.Text = "<script language='javascript'>window.alert('邮箱验证码错误！')</script>";
                Page.Controls.Add(lit);
            }

        }
        else
        {
            Literal lit = new Literal();
            lit.Text = "<script language='javascript'>window.alert('请输入验证码！')</script>";
            Page.Controls.Add(lit);
        }


        
    }
}