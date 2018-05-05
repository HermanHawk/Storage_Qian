<%@ WebHandler Language="C#" Class="Picture" %>

using System;
using System.Web;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Web.SessionState;
using System.IO;

public class Picture : IHttpHandler, IRequiresSessionState 
// 要使用session必须实现该接口,记得要导入System.Web.SessionState命名空间  
{
    
    public void ProcessRequest (HttpContext context) {
        
        Random r = new Random();
        string str = string.Empty;
        for (int i = 0; i < 5; i++)
        {
            int rNumber = r.Next(0, 10);
            str += rNumber;
        }

        context.Session["Code"] = str; //将字符串保存到Session中，以便需要时进行验证
        //创建GDI对象
        Bitmap bmp = new Bitmap(120, 30);
        Graphics g = Graphics.FromImage(bmp);


        g.Clear(Color.White);  //清除整个绘图面并以指定背景色填充
        
        
        try
        {
            for (int i = 0; i < 5; i++)
            {
                Point p = new Point(i * 20, 0);
                string[] fonts = { "微软雅黑", "宋体", "黑体", "隶书", "仿宋" };
                Color[] colors = { Color.Purple, Color.Blue, Color.Black, Color.Red, Color.Green };
                g.DrawString(str[i].ToString(), new Font(fonts[r.Next(0, 5)], 20, FontStyle.Bold), new SolidBrush(colors[r.Next(0, 5)]), p);

            }

            for (int i = 0; i < 15; i++)
            {
                Point p1 = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                Point p2 = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                g.DrawLine(new Pen(Brushes.Green), p1, p2);
            }

            for (int i = 0; i < 300; i++)
            {
                Point p = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                bmp.SetPixel(p.X, p.Y, Color.Black);
            }

            MemoryStream ms = new MemoryStream();   
            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            context.Response.ClearContent();    //清除缓冲区流中的所有内容输出
            
            
            
        context.Response.ContentType = "image/Gif";    //获取或设置输出流的Http MIME类型
            context.Response.BinaryWrite(ms.ToArray());    //将一个二进制字符串写入Http输出流 
            
        }
        finally
        {
            g.Dispose();
            bmp.Dispose();
        }
            
             
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}