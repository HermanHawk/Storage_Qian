using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    class SupperMarket
    {
        cangku ck = new cangku();


        /// <summary>
        /// 创建超市对象的时候，给仓库的货架上导入货物
        /// </summary>
        public SupperMarket()
        {
            ck.GetPros("Acer", 100);
            ck.GetPros("SamSung", 100);
            ck.GetPros("JiangYou", 100);
            ck.GetPros("Banner", 100);
        }

        public void AskBuying()
        {
            Console.WriteLine("欢迎光临，请问您有什么需要？");
            Console.WriteLine("我们有宏碁笔记本，一加手机，香蕉和酱油，请输入Acer、Banner、JiangYou、oneplus");
            string inputType = Console.ReadLine();
            Console.WriteLine("请问您要多少");
            int inputCount = Convert.ToInt32(Console.ReadLine());
            ProductFather[] pros = ck.QuPros(inputType, inputCount);
            double price = GetMoney(pros);
            Console.WriteLine("您一共需要支付{0}元",price);
            Console.WriteLine("请选择你的打折方式1.不打折-----2.打九折----3.打八五折----4.买300送50-------5.买500送100");
            string input = Console.ReadLine();
            CalFather cal = GetCal(input);
            double money = cal.GetTotalMoney(price);
            Console.WriteLine("您实际应付{0}元",money);
            Console.WriteLine("以下是你的购物信息");
            foreach (var item in pros)
            {
                Console.WriteLine("您的货物名称是" + item.Name +"他的价格是" + item.Price + "他的编号是" + item.ID);
            }

        }


        public CalFather GetCal(string input)
        {
            CalFather cal = null;
            switch(input)
            {
                case "1" :
                    cal = new CalNormal();
                    break;
                case "2":
                    cal = new CalRate(0.9);
                    break;
                case "3":
                    cal = new CalRate(0.85);
                    break;
                case "4":
                    cal = new CalMN(300, 50);
                    break;
                case "5":
                    cal = new CalMN(500, 100);
                    break;
            }
            return cal;
        }

        public double GetMoney(ProductFather[] pros)
        {
            double realMoney = 0;
            for (int i = 0; i < pros.Length; i++)
            {
                realMoney += pros[i].Price ;
            }
            return realMoney;
        }

        public void ShowPros()
        {
            ck.ShowPros();
        }

    }
}
