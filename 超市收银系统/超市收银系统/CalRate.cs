using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    class CalRate:CalFather
    {
        /// <summary>
        /// 打折类
        /// </summary>
        /// <param name="price">打折前的价格</param>
        /// <returns>打折后的价格</returns>

        public double Rate
        {
            get;
            set;
        }
        public CalRate(double rate)
        {
            this.Rate = rate;
        }
        public override double GetTotalMoney(double price)
        {
            return price * this.Rate;
        }
    }
}
