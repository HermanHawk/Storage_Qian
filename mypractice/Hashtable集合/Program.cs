using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hashtable ht = new Hashtable();
            //ht.Add(1, "Herman");
            //ht.Add(2, '男');
            //ht.Add(3, 20000m);
            //ht.Add(false, "错误的");
            //ht.Add("abc", "cba");

            //foreach (var item in ht.Keys)
            //{
            //    Console.WriteLine(ht[item]);
                
            //}

            int[] nums = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
                
            //}

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }


           
        }
    }
}
