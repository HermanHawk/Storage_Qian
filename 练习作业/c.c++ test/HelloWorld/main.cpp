#include <iostream>
#include <cmath>
#include <iomanip>
#include <windows.h>
#include <vector>
#include <algorithm>   /*算法*/
using namespace std;
//string chatTo(const string&,const string&);
int main()
{
    /*
    string toName,centent,chatMsg;
    cout << "你要给谁说";
    getline(cin,toName);
    cout << "你要说的内容";
    getline(cin,centent);
    chatMsg = chatTo(toName,centent);
    cout << endl << chatMsg << endl;
    */
    double num = 5 / 2;
    cout << num << endl;
    return 0;
}
/*
string chatTo(const string& toName,const string& centent)
{
    string msg = "※ 你悄悄的对" + toName + "说" + centent;
    return msg;
}

*/

/*
int& sum(int&);
int main()
{
    int num = 10;
    int& result = sum(num);
    sum(num) = 55;
    cout << "result=" << result << endl;
}
int& sum(int& num)
{
    num++;
    return num;
}*/

/**数组不能使用引用传递*/


/*
int swap1(int, int);
int swap2(int*, int*);
int swap3(int&, int&);
int main()
{
    int num1 = 10, num2 = 5;
    swap1(num1,num2);
    cout << "执行swap1后的结果是" << num1 << '\t' << num2 <<endl;
    swap2(&num1,&num2);
     cout << "执行swap2后的结果是" << num1 << '\t' << num2 <<endl;
     swap3(num1,num2);
     cout << "执行swap3后的值是：" << num1 << '\t' << num2 << endl;
    return 0;
}

int swap1(int num1,int num2)
{
    int temp;
    temp = num1;
    num1 = num2;
    num2 = temp;
}
int swap2(int* p1, int* p2)
{
    int temp;
    temp = *p1;
    *p1 = *p2;
    *p2 = temp;
}
int swap3(int& num1, int& num2)
{
    int temp;
    temp = num1;
    num1 = num2;
    num2 = temp;
}

*/



/*
int change(int num)
{
    num++;
    return num;
}
*/


/*
int array[] {11,22,33,44,55};
int * ptr_array = array;
for (int i = 0; i < 5; i++)
{
    cout << *(ptr_array + i) << endl;
}



//int * ptr_int = new int;
//delete ptr_int;    //释放有new分配的内存。与new配对使用。

/*
int num[5];
int * nums = new int[5];

delete[] nums;
cout << sizeof(num) << '\t' << sizeof(nums) << endl;
*/

/*********  此处是分割线，面向对象 *************/




/**
1.数组名的值数据的首地址
2.也表示这个数组类型。

void *指针存放一个内存地址，地址指向的内容是什么类型不能确定
void* 类型指针一般用来：拿来和别的指针比较，作为函数的输入和输出：赋值给另一个void *指针。
*/

/*char ch = 'a';
char * ptr_ch = &ch;
cout << (void *) ptr_ch << '\t' << *ptr_ch << endl;    //void * 任意类型
*/

/**
vector 建议使用场景
1.开始就知道元素的数量
2.对数据的索引和随机访问频繁
3.插入和删除大多数在尾端
*/
/*
vector<double> vec_double = {48.1, 28.7, 36.9, 18.6};
//向数组中插入数字
vec_double.push_back(66.6);
for(int i = 0; i < vec_double.size(); i++)
    cout << vec_double[i] << endl;
//遍历使用迭代器iterator
vector<double>::iterator it;     //得到迭代器对象
sort(vec_double.begin(),vec_double.end());         //排序
reverse(vec_double.begin(),vec_double.end());      //逆序
for(it = vec_double.begin(); it != vec_double.end(); ++it)       //it++会导致缓存的增加，效率不高，但可以达到效果
{
    cout << *it <<endl;
}
*/



/*
double money;
int count = 0;
for (int i = 0; i < 5; i ++)
{
    cout << "请输入玩家当前的消费金额：";
    cin >> money;
    if (money >= 5000)
        continue;
    count++;
}
cout << "低于5000的玩家数量是：" << count << endl;



/*
int a = 1,b = 10;
do
{
    b -= a;                 //b = 9
    a++;                    //a = 2
}while(b-- < 0);            //不循环 b = 8
cout << b << endl;


/*
int n = 0;
while(n++ <= 2);
cout << n << endl;


/*
int n = 0;
for(n = 0;n <= 2;n++);
cout << n << endl;


/*
bool flag = true;
cout << boolalpha;            //让结果用true和false显示，如果没有会用0和1来显示
cout << "15 > 88 吗? " << (15 > 88) << endl;
cout << "16 < 99 吗？" << (16 < 99) << endl;


/*
double attack1 = 250;
double attack2 = 279;
double attack3 = 398;
cout << left;                            //向左对齐
cout << setfill('_');                    //空白字符的填充    ！需要注意此处只能用单引号
cout << setw(8) << attack1               //setw表示该变量所占字符宽度
     << setw(8) << attack2
     << setw(8) << attack3 << endl;


/*
int num;
char ch1,ch2,ch3;
cout << "请输入：";
cin >> num;
cin >> ch1 >> ch2 >>ch3;
                        //意外发现，此处（下面语句）单双引号都行
cout << num << '\t' << ch1 << '\t'  << ch2 << '\t' << ch3 << endl;


/*
//控制cout的显示精度
SetConsoleTitle("示例：单双精度");                  //改变DOS窗户的名称
cout << fixed ;                                     //1.强制以小数显示
cout << setprecision(2);                            //2.控制显示的精度（表示小数点后两位）
//输出double 类型数据
double double_num = 100.0 / 3.0;
cout << double_num * 1000000 << endl;


/*
const float PI = 3.14f;
float radius = 2.5f;
float height = 4.0f;
//求圆柱体的面积 底面积乘高
double volume;
volume = PI * pow(radius,2) * height;
cout << "圆柱的面积是:" << volume << endl;
*/


// return 0;
//}
