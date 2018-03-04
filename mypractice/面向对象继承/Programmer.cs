using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象继承
{
    class Programmer:person
    {
        private int _workYear;

        public int WorkYear
        {
            get { return _workYear; }
            set { _workYear = value; }
        }
        public Programmer(string name, int age, char gender, int workYear)
            : base(name, age, gender)
        {
            this.WorkYear = workYear;
        }
        public void Hobby()
        {
            Console.WriteLine("我是一名程序员，我叫{0},我是{1}生我今年{2}岁，我的工作年限是{3}",this.Name,this.Gender,this.Age,this.WorkYear);
        }



        ///里氏转换
        ///1.子类可以赋值给父类
        ///2.如果父类中装的是子类对象，那么可以将这个父类强转为子类对象
        ///  例如：student s = new student()
        ///        person p = s.
        ///        (2)
        ///        student ss = (student)p
        ///经常使用的两个方法
        ///（1）is
        ///(2) as
        ///例如
        ///        if(p is student)
        ///        {
        ///         student ss = (student)p;
        ///         (可以调用ss的函数)
        ///         }
        ///         else
        ///         {
        ///         console.writeline("转换失败");
        ///         }
        /// 第二种as的方法
        ///         student t  = p as student;    如果转换失败，返回null
        ///         





    }
}
