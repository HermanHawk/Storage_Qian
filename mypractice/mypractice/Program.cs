using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mypractice
{             
  
    
		//public enum Gender
        //{
        //    男,
        //    女
        //}
        //public enum Season
        //{
        //    春,
        //    夏,
        //    秋,
        //    冬
        //}
                    
        //public enum QQState
        //{
        //    OnLine = 1,
        //    offLine,
        //    Leave,
        //    Busy,
        //    QMe
        //} 

        //public struct Student
        //{
        //    public string _name;
        //    public  int _age;
        //    public char _gender;
        //}

    class Program
    {
       
                       
        static void Main(string[] args)
        {


            #region try_catch的应用
            //int number = 0;

            //Console.WriteLine("请输入一个数字，来求他的二倍");
            //try
            //{
            //    number = Convert.ToInt32(Console.ReadLine());
            //}
            //catch
            //{
            //    Console.WriteLine("你的输入有误，不能参与运算，只能输入纯数字");
            //    b = false;
            //}
            //if (b)
            //{
            //    Console.WriteLine(number * 2);
            //}    
            #endregion

            #region switch case的使用
            //bool b = true;
            //int salary = 5000;
            //Console.WriteLine("请输入评定的星级");
            //string level = Console.ReadLine();
            //switch (level)
            //{
            //    case "A":
            //        salary += 500;
            //        break;
            //    case "B":
            //        salary += 200;
            //        break;
            //    case "C":
            //        break;
            //    case "D":
            //        salary -= 200;
            //        break;
            //    case "E":
            //        salary -= 500;
            //        break;
            //    default:
            //        Console.WriteLine("你的输入有误，请重新输入");
            //        b = false;
            //        break;
            //}
            //if (b)
            //{
            //    Console.WriteLine("你的工资是{0}", salary);
            //} 
            #endregion

            #region 年份的判断
            //Console.WriteLine("请输入年份");
            //try
            //{
            //    int year = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("请输入月份");
            //    try
            //    {
            //        int month = Convert.ToInt32(Console.ReadLine());

            //        switch (month)
            //        {
            //            case 1:
            //                Console.WriteLine("这月有31天");
            //                break;
            //            case 2:
            //                if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
            //                {
            //                    Console.WriteLine("今年是闰年，这月29天");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("今年不是闰年，这月只有28天");
            //                }
            //                break;
            //            case 3:
            //                Console.WriteLine("这月有31天");
            //                break;
            //            case 4:
            //                Console.WriteLine("这月有30天");
            //                break;
            //            case 5:
            //                Console.WriteLine("这月有31天");
            //                break;
            //            case 6:
            //                Console.WriteLine("这月有30天");
            //                break;
            //            case 7:
            //                Console.WriteLine("这月有31天");
            //                break;
            //            case 8:
            //                Console.WriteLine("这月有31天");
            //                break;
            //            case 9:
            //                Console.WriteLine("这月有30天");
            //                break;
            //            case 10:
            //                Console.WriteLine("这月有31天");
            //                break;
            //            case 11:
            //                Console.WriteLine("这月有30天");
            //                break;
            //            case 12:
            //                Console.WriteLine("这月有31天");
            //                break;
            //            default:
            //                Console.WriteLine("请输入1-12之间的数字");
            //                break;
            //        }
            //    }//月份的括弧
            //    catch
            //    {
            //        Console.WriteLine("请输入正确的月份");
            //    }
            //}//年的try括号
            //catch
            //{
            //    Console.WriteLine("你的输入有误，重新输入年份");

            //}

            #endregion

            #region 循环输入一个数字，我们输入他的二倍，当输入q时程序退出
            //string input = "";
            //while (input != "q")
            //{
            //    Console.WriteLine("请输入一个数字，我们来输出它的二倍");
            //    input = Console.ReadLine();
            //    if (input != "q")
            //    {
            //        try
            //        {
            //            int inputNum = Convert.ToInt32(input);
            //            Console.WriteLine("{0}的二倍是{1}", inputNum, inputNum * 2);
            //        }
            //        catch
            //        {
            //            Console.WriteLine("你的输入不能转换成整数，请重新输入");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("程序结束，正常退出");
            //    }
            //} 
            #endregion

            #region for循环和随机数
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("幼稚{0}",i+1);
            //}

            //求100-999之间的水仙花数
            //for (int i = 100; i <=999; i++)
            //{
            //    int bNum = i / 100;
            //    int sNum = i % 100 / 10;
            //    int gNum = i % 10;
            //    int number =bNum * bNum * bNum + sNum * sNum *sNum + gNum * gNum * gNum; 
            //    if(number ==  i)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        Console.Write("{0}*{1}={2}\t",i,j,i*j);   
            //    }
            //    Console.WriteLine();
            //}

            //求1-100  之间的素数

            //for (int i = 2; i <= 100; i++)
            //{
            //    bool b = true;
            //    for (int j = 2; j <= i - 1; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            b = false;
            //            break;
            //        }
            //    }
            //    if (b)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            ///
            //while (true)
            //{
            //    Random r = new Random();
            //    int rNum = r.Next(1, 11);     //左闭有开区间
            //    Console.WriteLine(rNum);
            //    Console.ReadKey();

            //}


            //for循环的倒叙，输入Forr连按两次table键。
            //for (int i = length - 1; i >= 0; i--)
            //{

            //} 
            #endregion

            #region int.TryParse
            //int number = Convert.ToInt32("123");
            //int number1 = int.Parse("123");

            //int number3 = 0;
            //bool b = int.TryParse("123", out number3);
            //Console.WriteLine(b);
            //Console.WriteLine(number3);

            //int number4 = 999;
            //bool c = int.TryParse("123abc", out number4);
            //Console.WriteLine(c);
            //Console.WriteLine(number4); 
            #endregion


            #region 枚举
            //Gender gender = Gender.男;
            //Season s = Season.春;
            //Console.WriteLine(gender);
            //Console.WriteLine(s); 
            #endregion

            #region 将枚举类型强转为int类型
            //QQState state = QQState.OnLine;
            //int number = (int)state;
            //Console.WriteLine(number);
            //Console.WriteLine((int)QQState.offLine);
            //Console.WriteLine((int)QQState.Leave);
            //Console.WriteLine((int)QQState.Busy);
            //Console.WriteLine((int)QQState.QMe); 
            #endregion

            #region 将int类型强转为枚举类型。如果枚举类型少于转换数字所指数量，则直接输出要转换的数字
            //int number1 = 3;
            //int number2 = 8;
            //QQState state1 = (QQState)number1;
            //QQState state2 = (QQState)number2;
            //Console.WriteLine(state1);
            //Console.WriteLine(state2); 
            #endregion

           
            #region 枚举的练习

             //将字符串类型强转为枚举类型。
            //string s = "888888";
            //QQState state = (QQState)Enum.Parse(typeof(QQState), s);
            //Console.WriteLine(s); 


            //Console.WriteLine("请输入你的qq状态 1-OnLine, 2-OffLine, 3-Leave, 4-Busy,  5-QMe");
            //string input = Console.ReadLine();
            //QQState output;
            //switch (input)
            //{
            //    case "1":


            //    case "2":

            //    case "3":

            //    case "4":

            //    case "5": output = (QQState)Enum.Parse(typeof(QQState), input);
            //        Console.WriteLine("你选择的在线状态是{0}", output);
            //        break;
            //    default:
            //        Console.WriteLine("你的输入有误，请重新输入");
            //        break;
            } 
            #endregion

            //冒泡排序
            //int[] nums ={9,8,7,6,5,4,3,2,1}; 
           

            
            

    

        }
    }
}
