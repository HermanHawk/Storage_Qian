using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    class CalNormal:CalFather
    {            
        /// <summary>
        /// 不打折，该多少钱就多少钱
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public override double GetTotalMoney(double price)
        {
            return price;
        }
    }
}
