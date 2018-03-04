using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fangfa
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 练习1
            //Console.WriteLine("请输入一个数字");
            //string input = Console.ReadLine();
            //int num = GetNumber(input);
            //Console.WriteLine(num);

            //int[] nums = {1,2,3,4,5,6,7,8,9};
            //int[] outs = GetMaxMinSunAvg(nums);
            //Console.WriteLine("最大值是{0}最小值是{1}总和是{2}平均值是{3}\n",outs[0],outs[1],outs[2],outs[3]); 
            #endregion

            //两个数之间的数的和
            //输入两个数字
            Console.WriteLine("请输入第一个数");
            string strNumOne = Console.ReadLine();
            int numberOne = BeNum(strNumOne);
            Console.WriteLine("请输入第二个数");
            string strNumTwo = Console.ReadLine();
            int numberTwo = BeNum(strNumTwo);
            //第一个数字必须比第二个数字小
            JudgeNumber(ref numberOne, ref numberTwo);
            //求和
            int sum = GetNum(numberOne, numberTwo);
            Console.WriteLine(sum);


        }

        //public static  int GetNumber(string input)
        //{
        //    while(true)
        //    {
        //        try
        //        {
        //            int num = Convert.ToInt32(input);
        //            return num;
        //        }
        //        catch
        //        {
        //            Console.WriteLine("输入有误，请重新输入");
        //            input = Console.ReadLine();
        //        }
        //    }

        //public static int[] GetMaxMinSunAvg(int[] nums)
        //{
        //    int[] rets = new int[4];
        //    rets[0] = nums[0];
        //    rets[1] = nums[0];
        //    rets[2] = 0;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if(rets[0] < nums[i])
        //        {
        //            rets[0] = nums[i];
        //        }
        //        if(rets[1] > nums[i])
        //        {
        //            rets[1] = nums[i];
        //        }

        //        rets[2] += nums[i];
        //    }
        //    rets[3] = rets[2] / nums.Length;
        //    return rets;
        //  }
        /// <summary>
        /// 将字符串转换成数字
        /// </summary>
        /// <param name="s">输入的字符串</param>
        /// <returns>由字符串转换过来的数字</returns>
        public static int BeNum(string s)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(s);
                    return number;
                }
                catch
                {
                    Console.WriteLine("输入有误，请重新输入");
                    s = Console.ReadLine();
                }
            }
        }
        /// <summary>
        /// 确认第一个数必须小于第二个数
        /// </summary>
        /// <param name="n1">第一个数</param>
        /// <param name="n2">第二个数</param>
        public static void JudgeNumber(ref int n1, ref int n2)
        {
            while (true)
            {
                if (n1 < n2)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("你的输入有误，请重新输入第一个数字");
                    n1 = BeNum(Console.ReadLine());
                    Console.WriteLine("请输入第二个数字");
                    n2 = BeNum(Console.ReadLine());
                }
            }
        }
            /// <summary>
            /// 求两个数字的和
            /// </summary>
            /// <param name="n1">第一个数</param>
            /// <param name="n2">第二个数</param>
            /// <returns>返回的和</returns>
        public static int GetNum(int n1, int n2)
        {
            int sum = 0;
            for (int i = n1; i <= n2; i++)
            {
                sum += i;
            }
            return sum;
        }



    }
}
