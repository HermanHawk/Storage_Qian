using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    class Program
    {
        static void Main(string[] args)
        {
            //多态之抽象类
            //求圆和矩形的面积和周长
            //Shape sh = new circle(6);
            Shape sh = new rectangle(5, 6);
            double per = sh.perimeter();
            double ar =  sh.area();
            Console.WriteLine("图形的面积是{0}，周长是{1}",ar,per);
        }
    }
}
