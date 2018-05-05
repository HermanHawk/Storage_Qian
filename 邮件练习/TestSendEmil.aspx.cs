using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestSendEmil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {



        //1.创建一个邮件对象
        MailMessage mailObject = new MailMessage();
        //设置发件人
        mailObject.From = new MailAddress("1625835052@qq.com");
        //设置收件人
        mailObject.To.Add(new MailAddress("13380326046@163.com"));
        //设置主题
        mailObject.SubjectEncoding = Encoding.UTF8;
        mailObject.Subject = "test";

        mailObject.BodyEncoding = Encoding.UTF8;
        mailObject.Body = "hello world";

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
        smtpClient.Credentials = new NetworkCredential("1625835052@qq.com", "emrvozznsoxpbeeb");
        smtpClient.Send(mailObject);
        Literal lit = new Literal();
        lit.Text = "<script language='javascript'>window.alert('ok！')</script>";
        Page.Controls.Add(lit);




        //SmtpClient smtpClient = new SmtpClient();        

        //smtpClient.EnableSsl = true;        

        //smtpClient.UseDefaultCredentials = false;        

        //smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;//指定电子邮件发送方式        

        //smtpClient.Host = smtpServer; //指定SMTP服务器        

        //smtpClient.Credentials = new System.Net.NetworkCredential(userFrom, userPassword);//用户名和授权码

        // // 发送邮件设置        

        //MailMessage mailMessage = new MailMessage(userFrom, MailTo); // 发送人和收件人        

        //mailMessage.Subject = mailSubject;//主题        

        //mailMessage.Body = “内容”;        

        //mailMessage.BodyEncoding = Encoding.UTF8;//正文编码        

        //mailMessage.IsBodyHtml = true;//设置为HTML格式        

        //mailMessage.Priority = MailPriority.Low;//优先级


    }
}