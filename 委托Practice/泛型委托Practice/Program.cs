using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型委托Practice
{

    //public delegate int DelCompare(object o1,object o2);
    public delegate int DelCompare<T>(T t1, T t2);
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int max = GetMax<int>(nums, (int n1, int n2) =>
            {
                return n1 - n2;
            });
            Console.WriteLine(max);
        }  

        public static T GetMax<T>(T[] nums,DelCompare<T> del)
        {
            T max = nums[0];
            for (int i = 0; i < nums.Length ; i++)
            {
                if(del(max,nums[i]) < 0)
                {
                    max = nums[i];
                }
                
            }
            return max;
        }

    }
}
