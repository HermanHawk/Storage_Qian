using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托Practice
{

    public delegate void SayHello(string name);
    class Program
    {
       
   
        static void Main(string[] args)          
        {
            //SayHello say = SayHiEnglish;//new SayHello(SayHiChinese);
            //say("张三");
            Test("Herman Hawk", SayHiEnglish);
            Console.ReadKey();
        }

       
        public static void Test(string name,SayHello say)
        {
            say(name);
        }
        public static void SayHiChinese(string name)
        {
            Console.WriteLine("你好" + name);
        }
        public static void SayHiEnglish(string name)
        {
            Console.WriteLine("Hello" + name);
        }
    }
}
