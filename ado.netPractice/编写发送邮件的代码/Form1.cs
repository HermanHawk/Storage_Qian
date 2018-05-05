using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 编写发送邮件的代码
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //发送邮件的基本步骤
        private void button1_Click(object sender, EventArgs e)
        {
            //1.创建一个邮件对象
            MailMessage mailObject = new MailMessage();
            //设置发件人
            mailObject.From = new MailAddress("13380326046@163.com");
            //设置收件人
            mailObject.To.Add(new MailAddress("1625835052@qq.com"));
            //设置主题
            mailObject.SubjectEncoding = Encoding.UTF8;
            mailObject.Subject = "找回密码";

            mailObject.BodyEncoding = Encoding.UTF8;
            mailObject.Body = "这是一条重要信息，请注意查收";

            //2.创建一个发送邮件的对象
            //指定smtp服务地址
            //SmtpClient smtpClient = new SmtpClient("ip地址",端口号);
            SmtpClient smtpClient = new SmtpClient("smtp.163.com");
            //smtpClient.UseDefaultCredentials = true;
            smtpClient.Credentials = new NetworkCredential("13380326046", "q16258");
            smtpClient.Send(mailObject);
            MessageBox.Show("ok");

        }
    }
}
