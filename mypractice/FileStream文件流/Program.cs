using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream文件流
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 先定义创建对象
             * 读取成字符数组，之前先创建字符数组，并且设定每次读取的字符数量
             * 把读取到的字符数组装换成字符串
             * 关闭流
             * 释放流所占用的内存资源
             */

            #region 文件的读
            ///文件的读
            //FileStream fsRead = new FileStream(@"C:\Users\Herman\Desktop\c#_practice\mypractice\FilestreamPractice.txt", FileMode.OpenOrCreate, FileAccess.Read);
            ////字符数组以及每次读取的大小
            //byte[] byffer = new byte[1024 * 1024];
            ////读取到的字节数
            //int fs = fsRead.Read(byffer, 0, byffer.Length);
            ////把字节数组转成字符串
            //string s = Encoding.Default.GetString(byffer, 0, fs);
            ////关闭流
            //fsRead.Close();
            ////释放流资源
            //fsRead.Dispose();
            ////打印字符串
            //Console.WriteLine(s); 
            #endregion



            #region 文件的写入
            ///文件的写入
            ///使用using会自动帮我们释放流所占用的空间
            //using (FileStream fsWrite = new FileStream(@"C:\Users\Herman\Desktop\c#_practice\mypractice\FilestreamPractice.txt",FileMode.OpenOrCreate,FileAccess.Write))
            //{
            //    //@"C:\Users\Herman\Desktop\c#_practice\mypractice\FilestreamPractice.txt"
            //    string str = "看我是怎样覆盖你的**";
            //    byte[] byffer = Encoding.Default.GetBytes(str);
            //    fsWrite.Write(byffer, 0, byffer.Length);

            //}
            //Console.WriteLine("写入成功"); 
            #endregion


            #region 多媒体文件的写入
            ////多媒体文件的写入
            //string source = @"C:\Users\Herman\Desktop\c#_practice\mypractice\FilestreamPractice.txt";
            //string target = @"C:\Users\Herman\Desktop\c#_practice\mypractice\newtwo.txt";
            //CopyFile(source,target);
            //Console.WriteLine("复制成功"); 
            #endregion


            //using(StreamReader sr = new StreamReader(@"C:\Users\Herman\Desktop\c#_practice\mypractice\FilestreamPractice.txt",Encoding.Default))
            //{
            //        while(!sr.EndOfStream)
            //        {
            //            Console.WriteLine(sr.ReadLine());
            //        }
            //}


            using(StreamWriter sw = new StreamWriter(@"C:\Users\Herman\Desktop\c#_practice\mypractice\newThree.txt",true))
            {
                sw.Write("天气好晴朗");
            }
            Console.WriteLine("ok");



        }

        //public static void CopyFile(string source,string target)
        //{
        //    //创建读取的流
        //    using (FileStream fsRead = new FileStream(source,FileMode.Open,FileAccess.Read))
        //    {     
        //        //创建写入的流
        //        using (FileStream fsWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write))
        //        {
        //            byte[] byffer = new byte[1024 * 1024 * 5];
        //            while (true)
        //            {
        //                int r = fsRead.Read(byffer, 0, byffer.Length);
        //                if (r == 0)
        //                {
        //                    break;
        //                }
        //                fsWrite.Write(byffer, 0, r);
        //            }
        //        }
        //    }
        //}




    }
}
