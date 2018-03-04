using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace 序列化和反序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 序列化
            //person p = new person();
            //p.Age = 19;
            //p.Gender = '男';
            //p.Name = "herman";

            //using (FileStream FsWriter = new FileStream(@"C:\Users\Herman\Desktop\c#_practice\mypractice\newFout.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(FsWriter, p);
            //}
            //Console.WriteLine("序列化成功");
            //Console.ReadKey(); 
            #endregion

            person p;
            using(FileStream fsReader = new FileStream(@"C:\Users\Herman\Desktop\c#_practice\mypractice\newFout.txt",FileMode.OpenOrCreate,FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                p = (person)bf.Deserialize(fsReader);
            }
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            Console.WriteLine(p.Gender);
            Console.ReadKey();
        }
    }

    [Serializable]
    public class person
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
            set { _age = value; }
        }

        private char _gender;

        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
    }

}
