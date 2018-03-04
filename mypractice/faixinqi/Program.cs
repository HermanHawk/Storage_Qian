using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faixinqi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 返回数组中最长的字符串
            //返回数组中最长的字符串
            //string[] names = { "林肯", "丘吉尔", "吧啦吧啦" };
            //string max = GetLongest(names);
            //Console.WriteLine(max); 
            #endregion

            //求整数数组的平均值，保留两位数字   
            int[] numbers = { 1, 2, 7 };
            double d =Convert.ToDouble(GetAvg(numbers).ToString("0.00"));
            Console.WriteLine(d);



        }
               /// <summary>
               /// 饭后字符串数组中的最长字符
               /// </summary>
               /// <param name="s">调用的数组</param>
               /// <returns>返回的最长的字符</returns>
        //public static string GetLongest(string[] s)
        //{
        //    string max = s[0];
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if(s[i].Length > max.Length)
        //        {
        //            max = s[i];
        //        }
                
        //    }
        //    return max;
        //}

        public static double GetAvg(int[] nums)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                
            }
            return sum / nums.Length;
        }

    }
}
