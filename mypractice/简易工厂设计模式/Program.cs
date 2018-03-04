using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简易工厂设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你要生产的品牌");
            string brand = Console.ReadLine();
            NoteBook nb = getNoteBook(brand);
            nb.sayHello();
            Console.ReadKey();

        }
        public static NoteBook getNoteBook(string brand)
        {
            NoteBook nb = null;
            switch(brand)
            {
                case "Asus": nb = new Asus();
                    break;
                case "Lenovo": nb = new Lenovo();
                    break;
                case "acer": nb = new Acer();
                    break;
                default: Console.WriteLine("你的输入有误，请重新输入");
                    break;
            }
            return nb;
        }

    }

    public abstract class NoteBook
    {
        public abstract void sayHello();
    }

    public class Asus : NoteBook
    {
        public override void sayHello()
        {
            Console.WriteLine("我是华硕笔记本");
        }
    }
    public class Lenovo : NoteBook
    {

        public override void sayHello()
        {
            Console.WriteLine("我是联想笔记本");
        }
    }

    public class Acer : NoteBook
    {
        public override void sayHello()
        {
            Console.WriteLine("我是宏碁笔记本");
        }
    }


}
