using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装箱和拆箱
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 25;
            //object o = n;            //将值类型转换为引用类型，装箱
            //int nTwo = (int)o;       //将引用类型转换为值类型，拆箱     
    

            /////装箱和拆箱必须要是继承关系才有可能发生装拆箱操作。
            /////
            //string s = "123";
            //int num = Convert.ToInt32(s);     //并没有发生装拆箱操作。

            ///键值对集合
            Dictionary<int, string> dc = new Dictionary<int, string>();
            dc.Add(1, "张三");
            dc.Add(2, "李四");
            dc.Add(3, "lalall");
            foreach (KeyValuePair<int,string> item in dc)
            {
                Console.WriteLine("{0}********{1}",item.Key,item.Value);
                
            }


        }
    }
}
