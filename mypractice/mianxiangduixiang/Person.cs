using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mianxiangduixiang
{
    class Person
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {

                if (value < 0 || value > 150)
                {
                    value = 0;
                }
                _age = value;
                
            }
        }
        private char _gender;
        public char Gender
        {
            get
            {
                if (_gender != '男' && _gender != '女')
                {
                    _gender = '男';
                }

                return _gender;
            }
            set { _gender = value; }
        }

        public void CHLSS()
        {
            Console.WriteLine("我是{0}今年{1}岁，我是{2}生", this.Name, this.Age, this.Gender);
        }

    }
}
