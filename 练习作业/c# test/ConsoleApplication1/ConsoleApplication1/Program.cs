using System;                             //用于导入命名空间
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program      //program程序
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("欢迎使用c#");   //console代表系统控制台，即字符界面的输入和输出。
            Child child = new Child();
            child.Add(3, 7);
            
        }
    }
}
