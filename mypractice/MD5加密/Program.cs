using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MD5加密
{
    class Program
    {
        static void Main(string[] args)
        {
            // 202cb962ac59075b964b07152d234b70
            // 202cb962ac5975b964b7152d234b70
            // 202CB962AC5975B964B7152D234B70
            // 202CB962AC59075B964B07152D234B70
            Console.WriteLine("请输入要加密的字符");
            string input = Console.ReadLine();
            string s = GetMD5(input);
            Console.WriteLine(s);
            Console.ReadKey();
        }


        public static string GetMD5(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] byffer = Encoding.Default.GetBytes(str);
            byte[] getByffer = md5.ComputeHash(byffer);
            //return Encoding.Default.GetString(getByffer);
            string strNew = " ";
            for (int i = 0; i < getByffer.Length; i++)
            {
                strNew += getByffer[i].ToString("x2");
            }
            return strNew;

        }
    }
}
