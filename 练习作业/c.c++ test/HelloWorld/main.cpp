#include <iostream>
#include <cmath>
#include <iomanip>
#include <windows.h>
#include <vector>
#include <algorithm>   /*�㷨*/
using namespace std;
//string chatTo(const string&,const string&);
int main()
{
    /*
    string toName,centent,chatMsg;
    cout << "��Ҫ��˭˵";
    getline(cin,toName);
    cout << "��Ҫ˵������";
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
    string msg = "�� �����ĵĶ�" + toName + "˵" + centent;
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

/**���鲻��ʹ�����ô���*/


/*
int swap1(int, int);
int swap2(int*, int*);
int swap3(int&, int&);
int main()
{
    int num1 = 10, num2 = 5;
    swap1(num1,num2);
    cout << "ִ��swap1��Ľ����" << num1 << '\t' << num2 <<endl;
    swap2(&num1,&num2);
     cout << "ִ��swap2��Ľ����" << num1 << '\t' << num2 <<endl;
     swap3(num1,num2);
     cout << "ִ��swap3���ֵ�ǣ�" << num1 << '\t' << num2 << endl;
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
//delete ptr_int;    //�ͷ���new������ڴ档��new���ʹ�á�

/*
int num[5];
int * nums = new int[5];

delete[] nums;
cout << sizeof(num) << '\t' << sizeof(nums) << endl;
*/

/*********  �˴��Ƿָ��ߣ�������� *************/




/**
1.��������ֵ���ݵ��׵�ַ
2.Ҳ��ʾ����������͡�

void *ָ����һ���ڴ��ַ����ַָ���������ʲô���Ͳ���ȷ��
void* ����ָ��һ�������������ͱ��ָ��Ƚϣ���Ϊ������������������ֵ����һ��void *ָ�롣
*/

/*char ch = 'a';
char * ptr_ch = &ch;
cout << (void *) ptr_ch << '\t' << *ptr_ch << endl;    //void * ��������
*/

/**
vector ����ʹ�ó���
1.��ʼ��֪��Ԫ�ص�����
2.�����ݵ��������������Ƶ��
3.�����ɾ���������β��
*/
/*
vector<double> vec_double = {48.1, 28.7, 36.9, 18.6};
//�������в�������
vec_double.push_back(66.6);
for(int i = 0; i < vec_double.size(); i++)
    cout << vec_double[i] << endl;
//����ʹ�õ�����iterator
vector<double>::iterator it;     //�õ�����������
sort(vec_double.begin(),vec_double.end());         //����
reverse(vec_double.begin(),vec_double.end());      //����
for(it = vec_double.begin(); it != vec_double.end(); ++it)       //it++�ᵼ�»�������ӣ�Ч�ʲ��ߣ������ԴﵽЧ��
{
    cout << *it <<endl;
}
*/



/*
double money;
int count = 0;
for (int i = 0; i < 5; i ++)
{
    cout << "��������ҵ�ǰ�����ѽ�";
    cin >> money;
    if (money >= 5000)
        continue;
    count++;
}
cout << "����5000����������ǣ�" << count << endl;



/*
int a = 1,b = 10;
do
{
    b -= a;                 //b = 9
    a++;                    //a = 2
}while(b-- < 0);            //��ѭ�� b = 8
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
cout << boolalpha;            //�ý����true��false��ʾ�����û�л���0��1����ʾ
cout << "15 > 88 ��? " << (15 > 88) << endl;
cout << "16 < 99 ��" << (16 < 99) << endl;


/*
double attack1 = 250;
double attack2 = 279;
double attack3 = 398;
cout << left;                            //�������
cout << setfill('_');                    //�հ��ַ������    ����Ҫע��˴�ֻ���õ�����
cout << setw(8) << attack1               //setw��ʾ�ñ�����ռ�ַ����
     << setw(8) << attack2
     << setw(8) << attack3 << endl;


/*
int num;
char ch1,ch2,ch3;
cout << "�����룺";
cin >> num;
cin >> ch1 >> ch2 >>ch3;
                        //���ⷢ�֣��˴���������䣩��˫���Ŷ���
cout << num << '\t' << ch1 << '\t'  << ch2 << '\t' << ch3 << endl;


/*
//����cout����ʾ����
SetConsoleTitle("ʾ������˫����");                  //�ı�DOS����������
cout << fixed ;                                     //1.ǿ����С����ʾ
cout << setprecision(2);                            //2.������ʾ�ľ��ȣ���ʾС�������λ��
//���double ��������
double double_num = 100.0 / 3.0;
cout << double_num * 1000000 << endl;


/*
const float PI = 3.14f;
float radius = 2.5f;
float height = 4.0f;
//��Բ�������� ������˸�
double volume;
volume = PI * pow(radius,2) * height;
cout << "Բ���������:" << volume << endl;
*/


// return 0;
//}
