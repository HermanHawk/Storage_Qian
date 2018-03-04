using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    class cangku
    {
        List<List<ProductFather>> list = new List<List<ProductFather>>();
        

        /// <summary>
        /// 展示货物
        /// </summary>
        public void ShowPros()
        {
            foreach (var item in list)
            {
                Console.WriteLine("我们超市有" + item[0].Name + "有" + item.Count  + "个" + "每个" + item[0].Price + "元" );
               // Console.WriteLine("我们超市有{0}，每个{1}元，有{2}个",item[0].Name,item[0].Price,item.Count);
            }
        }

        public cangku()
        {
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
        }

        #region 进货
        /// <summary>
        /// 进货
        /// </summary>
        /// <param name="ProType">货物的类型</param>
        /// <param name="count">进货的数量</param>
        public void GetPros(string ProType, int count)
        {
            for (int i = 0; i < count; i++)
            {
                switch (ProType)
                {
                    case "Acer": list[0].Add(new Acer(Guid.NewGuid().ToString(), 4000, "宏碁笔记本"));
                        break;
                    case "Samsung": list[1].Add(new Samsung(Guid.NewGuid().ToString(), 3699, "oneplus"));
                        break;
                    case "Banner": list[2].Add(new Banner(Guid.NewGuid().ToString(), 2.5, "好甜好好吃的香蕉"));
                        break;
                    case "JiangYou": list[3].Add(new JiangYou(Guid.NewGuid().ToString(), 6.5, "炒菜不能缺的酱油"));
                        break;
                }
            }


        }
        #endregion


        /// <summary>
        /// 取货
        /// </summary>
        /// <param name="ProType">货物的类型</param>
        /// <param name="count">取货的总数量</param>
        /// <returns>返回数组</returns>
        public ProductFather[] QuPros(string ProType,int count)
        {
            ProductFather[] pros = new ProductFather[count];
            for (int i = 0; i < count; i++)
            {
                switch(ProType)
                {
                    case "Acer":
                        pros[i] = list[0][0];
                        list[0].RemoveAt(0);
                        break;
                    case "oneplus":
                        pros[i] = list[1][0];
                        list[1].RemoveAt(0);
                        break;
                    case "Banner": 
                        pros[i] = list[2][0];
                        list[2].RemoveAt(0);
                        break;
                    case "JiangYou": 
                        pros[i] = list[3][0];
                        list[3].RemoveAt(0);
                        break;
                }
                
            }
            return pros;
        }
    }

}
