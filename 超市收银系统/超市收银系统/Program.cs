using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    class Program
    {
        static void Main(string[] args)
        {
            SupperMarket sm = new SupperMarket();
            sm.ShowPros();
            sm.AskBuying();
            Console.ReadKey();
        }
    }
}
