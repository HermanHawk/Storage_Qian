using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 构造函数
{
    class student
    {



        public student(string name,int age,char gender)
        {
            this._name = name;
            this._age = age;
            this._gender = gender;
        }



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
            set { _age = value; }
        }
        private char _gender;

        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        
        
       
      
        public void GzHanshu()
        {
            Console.WriteLine("我是{0}我今年{1}我是{2}生",this.Name,this.Age,this.Gender);
        }
       
    }
}
