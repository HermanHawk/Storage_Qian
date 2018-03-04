using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maopaopaixu
{
    //public enum Gender
    //{
    //    男,
    //    女
    //}
    // public struct Student
    // {
    //     public string _name;
    //     public int _age;
    //     public Gender _gender;
    // }
    class Program
    {
        static void Main(string[] args)
        {
            #region 结构和冒泡排序
            //    Student stu1;
            //    stu1._name = "萧平章";
            //    stu1._age = 22;
            //    stu1._gender = Gender.男;
            //    Student stu2;
            //    stu2._name = "艾丽娅";
            //    stu2._age = 20;
            //    stu2._gender = Gender.女;
            //    Console.WriteLine("{0},{1}",stu1._name, stu2._name);

            //int[] nums = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            //升序
            // Array.Sort(nums);
            //反转
            //Array.Reverse(nums);
            //for (int i = 0; i < nums.Length - 1; i++)
            //{
            //    for (int j = 0; j < nums.Length - i - 1; j++)
            //    {
            //        if(nums[j] > nums[j+1])
            //        {
            //            int temp = nums[j];
            //            nums[j] = nums[j + 1];
            //            nums[j + 1] = temp;
            //        }

            //    }

            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);

            //} 
            #endregion

            int maxNum = Program.GetMax(3, 5);
            Console.WriteLine(maxNum);



        }
        /// <summary>
        /// 求两个数的最大值
        /// </summary>
        /// <param name="n1">第一个数</param>
        /// <param name="n2">第二个数</param>
        /// <returns>返回最大值</returns>
        public static int GetMax(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }



    }
}
