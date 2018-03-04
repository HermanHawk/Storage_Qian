using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 石头剪刀布
{
    class Conputer
    {
        public string fist
        {
            get;
            set;
        }
        public int CompurerNumber()
        {
            Random r = new Random();
            int num = r.Next(1, 4);
            switch(num)
            {
                case 1: this.fist = "石头"; break;
                case 2: this.fist = "剪刀"; break;
                case 3: this.fist = "布"; break;
            }
            return num;
        }

      

    }
}
