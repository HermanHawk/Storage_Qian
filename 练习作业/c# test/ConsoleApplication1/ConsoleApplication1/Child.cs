using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Child
    {
        public void Add(int n1, int n2)
        {
            
            int num = n1 + n2;
            Console.WriteLine("和是" + num);
        }
    }
}
