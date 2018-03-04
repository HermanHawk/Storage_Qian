using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mianxiangduixiang
{
    class Program
    {
        static void Main(string[] args)
        {
            Person zsPerson = new Person();
            zsPerson.Name = "张三";
            zsPerson.Age = -22;
            zsPerson.Gender = '傻';
            zsPerson.CHLSS();
        }
    }
}
