using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArryList集合
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 练习1
            // ArrayList list = new ArrayList();
            // list.Add("Herman");
            // list.Add('男');
            // list.Add(222);                                        //集合中单个添加对象
            // list.AddRange(new int[]{ 1, 2, 3, 4, 5, 6, 7});       //及合中添加数组，集合等集合。
            //// list.AddRange(list);
            //// list.Remove("Herman");                                //移除指定的字符
            // list.Insert(0,'男');                                    //插入

            // bool b = list.Contains("Herman");                       //判断集合中是否包含某对象，返回bool
            // Console.WriteLine(b);


            // for (int i = 0; i < list.Count; i++)
            // {
            //     Console.WriteLine(list[i]);

            // }

            ///集合的长度问题
            ///count实际包含的长度
            ///capcity集合中可以包含的长度
            ///当count超过capcity的时候，集合就会想内存中申请多开辟一杯的空间，来保证集合的长度一直够用。
            /// 
            #endregion

            #region ArrayList练习
            //在一个长度为10的集合中，随机的存入0-9个数，并且不重复
            //ArrayList list = new ArrayList();
            //Random r = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    int rNum = r.Next(0, 10);
            //    if(!list.Contains(rNum))
            //    {
            //        list.Add(rNum);
            //    }
            //    else
            //    {
            //        i--;
            //    }
            //}
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //} 
            #endregion

            //List泛型集合
            /*
             List可以和数组互相转换
             * 长度任意
             * 类型确定了不能任意
             */

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.AddRange(new int[]{9,6,3,8,5,7,4});
            int[] nums = list.ToArray();
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
