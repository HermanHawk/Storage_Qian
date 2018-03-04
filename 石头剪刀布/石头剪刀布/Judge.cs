using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 石头剪刀布
{
    class Judge
    {
        public enum Type
        {
            玩家win,
            电脑win,
            平局
        }
        public static Type GetType(int num1,int num2)
        {
              if((num1 - num2 == -1) || (num1 - num2) == 2)
              {
                  return Type.玩家win;
              }
              else if(num1 - num2 ==0)
              {
                  return Type.平局;
              }
              else
              {
                  return Type.电脑win;
              }
        }
   
  
    }
}
