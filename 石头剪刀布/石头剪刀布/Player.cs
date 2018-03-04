using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 石头剪刀布
{
    class Player
    {
        //玩家需要返回数字用来提供计算
        public int PlayerNumber(string str)
        {
            int num = 0;
            switch(str)
            {
                case "石头": num = 1; break;
                case "剪刀": num = 2; break;
                case "布": num = 3; break;

            }
            return num;
        }
    }
}
