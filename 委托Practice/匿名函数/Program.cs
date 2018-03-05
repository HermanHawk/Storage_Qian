using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 匿名函数
{

    //public delegate string DelStr(string name);
    public delegate void DelStr(string name);
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "abCDefG", "HIJklmN", "OpqRst", "uvwXyz" };
            //ProStr(names,delegate(string name)
            //{
            //    return name.ToUpper();
            //});
            //for (int i = 0; i < names.Length; i++)
            //{
            //     Console.WriteLine(names[i]);
            //}
            //Console.ReadKey();



            //DelStr del = delegate(string name)
            //{
            //    Console.WriteLine("你好" + name);
            //};
            //lamda表达式
            DelStr del = (string name) => { Console.WriteLine("你好" + name); };
            del("herman");
            Console.ReadKey();

        }

       //public static void ProStr(string[] names,DelStr del)
       // {
       //     for (int i = 0; i < names.Length; i++)
       //     {
       //         names[i] = del(names[i]);
                
       //     }
       // }

    }
}
