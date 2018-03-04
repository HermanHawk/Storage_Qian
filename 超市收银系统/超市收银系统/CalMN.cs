using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    /// <summary>
    /// 买M送N
    /// </summary>
    class CalMN:CalFather
    {
        public double M
        {
            get;
            set;
        }
        public double N
        {
            get;
            set;
        }

        public CalMN(double m,double n)
        {
            this.M = m;
            this.N = n;
        }
        public override double GetTotalMoney(double price)
        {
            if(price >= this.M)
            {
                return price - (int)(price / this.M) * this.N;
            }
            else
            {
                return price;
            }
        }
    }
}
