using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome to China这个字符串中每个单词出现的次数
            string str = "Welcome to China";
            Dictionary<char, int> dic = new Dictionary<char, int>();
            str = str.ToUpper();                   //全部转换成大写，达到判断时不区分大小写的效果。
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] == ' ')
                {
                    continue;
                }
                if(dic.ContainsKey(str[i]))
                {
                    dic[str[i]]++;
                }
                else
                {
                    dic[str[i]] = 1;
                }
                
            }
            foreach (KeyValuePair<char,int> item in dic)
            {
                Console.WriteLine("字母{0}出现的次数是{1}",item.Key,item.Value);
                
            }


        }
    }
}
