using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    class Program
    {
        static void Main(string[] args)
        {
            //真的鸭子靠脚丫游泳，木头鸭子不会游泳，橡皮鸭子飘着游泳
            ISwimmingable sw = new XpDuck();//new RealDuck();
            sw.Swimming();
            Console.ReadKey();

        }
    }

    public class RealDuck:ISwimmingable
    {

        public void Swimming()
        {
            Console.WriteLine("真的鸭子靠脚丫游泳");
        }
    }
    
    public class WoolDuck
    {

    }

    public class XpDuck:ISwimmingable
    {

        public void Swimming()
        {
            Console.WriteLine("橡皮鸭子飘着游泳");
        }
    }

    public interface ISwimmingable
    {
        void Swimming();
    }

}
