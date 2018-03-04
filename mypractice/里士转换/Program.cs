using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里士转换
{
    class Program
    {
        static void Main(string[] args)
        {
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


            person[] per = new person[10];
            Random r = new Random();
            for (int i = 0; i < per.Length; i++)
            {
                int rNum = r.Next(1, 4);
                switch(rNum)
                {
                    case 1:
                        per[i] = new Student();
                        break;
                    case 2:
                        per[i] = new Teacher();
                        break;
                    case 3:
                        per[i] = new person();
                        break;
                }
                
            }


            for (int i = 0; i < per.Length; i++)
            {
                if(per[i] is Student)
                {
                    ((Student)per[i]).StudentSayhello();
                }    
                else if(per[i] is Teacher)
                {
                    ((Teacher)per[i]).TeachSayhello();
                }
                else
                {
                    per[i].PeopleSayhello();
                }
                
            }

        }
    }
}
