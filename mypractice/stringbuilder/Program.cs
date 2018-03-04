using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            #region stringbuilder
            //Stopwatch sw = new Stopwatch();
            ////string str = null;
            //StringBuilder sb = new StringBuilder();
            //sw.Start();
            //for (int i = 0; i < 100000; i++)
            //{
            //   // str += i;
            //    sb.Append(i);
            //}
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);
            //Console.WriteLine(sb.ToString()); 
            #endregion

            #region Equals比较
            //Console.WriteLine("请输入你喜欢的课程");
            //string lessonOne = Console.ReadLine();
            //Console.WriteLine("请输入你喜欢的其他书");
            //string lessonTwo = Console.ReadLine();
            //// 比较两个字符串不区分大小写
            //if(lessonOne.Equals(lessonTwo,StringComparison.OrdinalIgnoreCase))
            //{
            //    Console.WriteLine("你输入的两本书相同");
            //}
            //else
            //{
            //    Console.WriteLine("你输入的两本书不同");
            //} 
            #endregion

            #region 字符串的分割
            //字符串的分割
            //Console.WriteLine("请输入年月日，中间用—分开");
            //string s = Console.ReadLine();
            //string[] date = s.Split(new char[] { '_'}, StringSplitOptions.None);
            //Console.WriteLine("你输入的是{0}年{1}月{2}日",date[0],date[1],date[2]); 
            #endregion

            #region 字符串的替换
            //字符串的替换
            //string str = "有些需要和谐的字比如老美";
            //if (str.Contains("美"))
            //{
            //    str = str.Replace("美", "*");
            //}
            //Console.WriteLine(str); 
            #endregion

            #region 字符串的截取
            //字符串的截取
            //string str = "今天天气好晴朗，处处好风光";
            //str = str.Substring(1, 2);
            //Console.WriteLine(str); 
            #endregion

            #region 字符串的开始与结尾
            //字符串的开始与结尾
            //startwith判断是不是以这个开始  endwith判断是不是以这个结束
            //string str = "今天天气好晴朗，处处好风光";
            //if(str.StartsWith("今天"))
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是");
            //} 
            #endregion

            #region 字符在第一次和最后一次出现的索引
            //字符在第一次和最后一次出现的索引。
            //string str = "今天天气好晴朗，处处好风光";
            //int index = str.IndexOf('天');
            //int indexTwo = str.LastIndexOf('天');
            //Console.WriteLine(indexTwo);
            //Console.WriteLine(index); 
            #endregion

            #region 字符串中间添加隔开符
            //string[] anmes = { "张三", "李四", "王五", "赵六" };
            //string strNew = string.Join("|", "张三", "李四", "王五", "赵六");
            //Console.WriteLine(strNew); 
            #endregion

            #region 读取文本添加分割符输出
            /*
                平凡的世界|路遥
                红楼梦|曹雪芹
                童年·我的大学·...|高尔基
                看见|柴静
              */
            /*
             * 思路：1.分割成字符串
             *       2.读取位数
             *       3.中间用|隔开
             */
            //string path = @"C:\Users\Herman\Desktop\c#_practice\mypractice\1.txt";
            //string[] contents = File.ReadAllLines(path, Encoding.Default);
            /*
            平凡的世界   路遥
            红楼梦       曹雪芹
            童年·我的大学·在人间    高尔基
            看见         柴静
             */
            // Console.ReadKey();

            //for (int i = 0; i < contents.Length; i++)
            //{
            //    /* 平凡的世界  
            //     * 路遥
            //     */
            //    string[] strNew = contents[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //    //if (strNew[0].Length >= 10)
            //    //{
            //    //    strNew[0] = strNew[0].Substring(0, 8) + "...";
            //    //}
            //    //Console.WriteLine(strNew[0] + "|" + strNew[1]);
            //    //Console.WriteLine("{0}|{1}",strNew[0],strNew[1] );
            //   Console.WriteLine((strNew[0].Length >= 10 ? strNew[0].Substring(0, 8) + "..." : strNew[0] )+ "|" + strNew[1]);
            //  // Console.WriteLine(strNew[0].Length >= 10 ? strNew[0].Substring(0, 8) + "..." : strNew[0] + "|" + strNew[1]);
            //} 
            #endregion

            //找出文本中e出现的位置
            string str = "fwekfpoaigrooerioifojvnseeeenfvnaleeeflancvjee";
            int index = str.IndexOf('e');
            Console.WriteLine("第一次出现e的下标是{0}",index);
            int count = 1;
            while(index != -1)
            {
                index = str.IndexOf('e', index + 1);
                count++;
                if (index == -1)
                {
                    break;
                }
                Console.WriteLine("第{0}次出现e的下标是{1}",count,index);
                
                
            }
            
        }
    }
}
