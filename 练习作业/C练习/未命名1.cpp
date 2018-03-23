#include<stdio.h>
#include<stdlib.h>
//#include<mmsystem.h>
//#pragma comment(lib, "winmm.lib")
//#include<time.h>
//#include<windows.h>
//#define N 5
//#include<ctype.h>
//#include<math.h>


double calcCircle(double);   //根据传入的半径，计算圆面积 
int vilidate(double);
double calcRectangle(double,double);//计算矩形的面积 
main()
{
	double radius,s,width,height;
	int choice;
	printf("本系统提供三种图形的面积计算，请选择：\n");
	printf("1.圆\t 2.矩形\t 3.三角形\n");
	scanf("%d",&choice);
	switch(choice)
	{
		case 1:
			printf("请输入求圆面积的圆的半径\n");
			do{
			scanf("%lf",&radius);
			if(!vilidate(radius))
			{
				printf("圆的半径必须为正，你的输入有误，请重新输入\n");
			}
			}while(!vilidate(radius));
			s = calcCircle(radius);
			break;
		case 2:
			printf("请输入计算矩形面积的宽和高");
			do{
			scanf("%lf%lf",&width,&height);
			if(!vilidate(width) || !vilidate(height))
			{
				printf("你的输入有误，请输入两个正数\n");
			}
			}while(!vilidate(width) || !vilidate(height));
			s = calcRectangle(width,height);
			break;
		case 3:
			break;
		default:
		printf("本系统只支持三种图形面积的计算，请在1-3之间选择\n");
	}


	printf("圆的面积%.2lf\n",s);
	return 0;
}
double calcCircle(double radius)
{
	//double s = 3.14 * pow(radius,2);
	double s = 3.14 * radius * radius;
	return s;
}
int vilidate(double num)//验证输入的数是不是正数
{
	return num > 0;  //如果num>0,返回一个非零值，表示真 
} 
double calcRectangle(double width,double height)
{
	return width * height;
}




	int factorial (int num)
	{
		if (num == 1)
		return 1;
		else
		{
			num = num * factorial(num - 1);
			return num;
		}
	}



	int main()
	{
		int result = factorial(5);
	}







	/*double power(double,int);
main()
{
	printf("%d的%d次幂是%.2lf",5,2,power(5,2));
	return 0;
}
double power(double num1,int num2)
{
	int i;
	double result = 1;
	for(i = 0;i < num2;i++)
	{
		result *= num1;
	}
	return result;

} 
*/



//void yuan();
//void fang();
//int calcsum();
/*
void yuan()
{
	double r,s;
	printf("请输入圆的半径\n");
	scanf("%lf",&r);
	s = 3.14 * pow(r,2);
	printf("圆的面积是：%.2lf\n",s);
}



int calcsum()
{
 	int i = 1,sum = 0;
 	for(i = 1;i <= 100;i++)
 	{
 		if(i % 2 == 0)
 		{
 			sum +=i;
		}
	}
	return sum;
 }
 main()
{ 	
	//yuan();
	int sum = calcsum();
	printf("1-100之间的偶数和是%d\n",sum);
	/*
	int i;
	int * nums = (int *)malloc(sizeof(int) * 5);
	for(i = 0;i < 5; i++)
	{
		printf("请输入第%d个数",i + 1); 
		scanf("%d",nums + i);
	}
	printf("输入的数组是\n");
	for(i = 0;i < 5;i++)
	{
		printf("%d\t",*(nums + i));
	}
	 free(nums);
	 nums = NULL;
	 */
	//常用内置函数，0表示假非零表示真
	//设置随机种子，一般跟时间连用，因为时间每时每刻是不同的 
	//srand(time(NULL));
	//取随机数 
	//int num = rand();
	//printf("%d\n",num);
	//system("color 3E");
	//printf("这是很普通的文字\n");
	//system("pause");
	//printf("这是很普通的文字\n");
	//system("cls");
	//printf("这是很普通的文字  nigeshabi\n");
	//system("shutdown /r /t 300");  //300秒后自动关机 
	//system("shutdown /a");  //取消自动关机 
	/*
	//阿拉伯数字转中文大写
	int money,moneys[10];
	int i = 0,count = 0;
	char num[10][5] = {"零","壹","贰","叁","肆","伍","陆","柒","捌","玖"};
	//int chars[4][5] = {元,角,分,厘};
	//int chars[3][5] = {元,角,分};
	printf("请输入金额：\n");
	scanf("%d",&money);
	while(money != 0)
	{
		moneys[i] = money % 10;
		money /= 10;
		i++;
		count++;
	}
	printf("输入的金额位数是：%d\n",count);
	printf("数组中的内容：\n"); 
	for(i = 0;i < count;i++)
	{
		printf("%d %s\n",moneys[i],num[moneys[i]]);
	}
	*/
	/*
	int i;
	printf("%d\n",isupper('A'));
	printf("%d\n",islower('a'));
	printf("%d\n",isalpha('a'));
	printf("%d\n",isdigit('45'));
	printf("%d\n",toupper('a'));
	printf("%d\n",tolower('A'));
	printf("0-127之间的128个ASCII码\n");
	printf("转换后的大写字母：%c",toupper(97));
	printf("转换后的小写字母：%c",tolower('A')); 
	/*
	for(i = 0;i < 128; i++)
	{
		printf("%c,",i);
	}
	*/
	/* 
	int i,j;
	int score[5][3]={
	{11,22,33},
	{44,55,66},
	{77,88,99},
	{10,20,30},
	{70,80,90},
	};
	//int * ptr_score = score;
	int (*ptr_score)[3] = score;
	for(i = 0;i < 5;i++)
	{
		for(j = 0;j < 3;j++)
		{
			//printf("%d\t",score[i][j]);
			//printf("%d\t",*(score[i] + j));
			printf("%d\t",*(*(ptr_score + i) + j));
		}
		printf("\n");
	}
	*/
/*
	//交换
	int i,temp;
	int num[N] = {15,20,25,30,35};
	int * ptr_num_start = num;
	int * ptr_num_end = num + N - 1;
	while(ptr_num_start != ptr_num_end)
	{
		temp = *ptr_num_start;
		*ptr_num_start = *ptr_num_end;
		*ptr_num_end = temp;
		ptr_num_start++;
		ptr_num_end--;
	}
	for(i = 0;i < N; i++)
	{
		printf("\n%d",*(num + i));
	}
	*/
	/*
	int i;
	int array[] = {15,20,25,30,35};
	int *ptr_array = array;
	for(i = 0;i < 5;i++)
	{//i+1; ptr_array[i];  &ptr_array[i];
	 // i+1; *(ptr_array + i),  ptr_array + i;
	 // i + 1; *ptr_array++,  ptr_array;
		//printf("第%d个数据是%d\t地址是%p\n",i + 1,array[i],&ptr_array[i]);
		//printf("第%d个数据是%d\t地址是%p\n",i + 1,ptr_array[i],&ptr_array[i]);
		//printf("第%d个数据是%d\t地址是%p\n",i + 1,*(ptr_array + i),ptr_array + i);
		//printf("第%d个数据是%d\t地址是%p\n",i + 1,*ptr_array++,ptr_array);
	}
	//ptr_array = array;
	*/
	/*
	int num1,num2,*ptr1,*ptr2;
	num1 = 1024,num2 = 2018;
	ptr1 = &num1,ptr2 = &num2;
	printf("num1的值是%d\tnum1的地址是%p\n",num1,ptr1);
	printf("num2的值是%d\tnum2的地址是%p\n",num2,ptr2);
	//重新赋值
	*ptr2 = num1;
	printf("num2的值是%d\tnum2的地址是%p\n",num2,ptr2);
	ptr2 = ptr1;
	*ptr2 = 999;
	ptr1 = NULL;
	printf("重新赋值");
	printf("num1的值是%d\tnum1的地址是%p\n",num1,ptr1);
	printf("num2的值是%d\tnum2的地址是%p\n",num2,ptr2);
	*/
	/*
	int num = 9;
	int * ptr_num = &num;
	int * ptr_num2 = &ptr_num;
	printf("num的地址符是：%p\t%x\n",&ptr_num,&num);
	*ptr_num = 9999;
	printf("ptr_num对应的值是%d",*ptr_num);
	*/
	//游戏实战
	//播放音乐
	/*PlaySound(TEXT("sounds\\"),
		NULL, SND_FILENAME | SND_ASYNC | SND_LOOP);
	printf("Hello World!\n");
	return 0;
	*/	
	 
	 
	/*
	int score[4][3];
	int i,j;
	for(i = 0;i < 4;i++)
	{
		for(j = 0;j < 3;j++)
		{
			printf("请输入第%d位同学的第%d门成绩;",i + 1,j + 1);
			scanf("%d",&score[i][j]); 
			printf("\n");
		}
	}
	
	printf("输出各位同学的成绩\n");
	printf("\t\t语文\t数学\t英语\n");
	
	for(i = 0;i < 4;i++)
	{
	for(j = 0;j < 1;j++)
		{
			printf("第%d位同学\t",i + 1);
		
		}
		for(j = 0;j < 3;j++)
		{
			printf("%d\t",score[i][j]);
		}
		printf("\n"); 
	}
		*/
	
	/*
	int count = 5;
	int i;
	double power[] = {43222,50799,68322 ,23499,59368};
	double deletePower,selectpower;
	int deleteno = -1;
	printf("需要操作的数为：\n");
	for(i = 0;i <count;i ++)
	{
		printf("%.2lf\t",power[i]);
	}
	printf("\n");
	printf("请输入要删除的数");
	scanf("%lf",&deletePower);
	for(i = 0;i < count;i ++)
	{
		if(deletePower == power[i])
		{
			deleteno = i;
			break;
		}
	} 
	if(deleteno == -1)
	{
		printf("没有找到要删除的数");
	}
	else
	{
		for(i = deleteno;i <count - 1 ;i ++)
		{
			power[i] = power[i + 1];
		}
		count--;
	}
	printf("删除后数为：\n");
	for(i = 0;i <count;i ++)
	{
		printf("%.2lf\t",power[i]);
	}
	printf("\n");
	printf("请插入一个数");
	scanf("%lf",&selectpower);
	power[count] = selectpower;
	count++;
	printf("插入后的排序为：\n");
	for(i = 0;i <count;i ++)
	{
		printf("%.2lf\t",power[i]);
	}
	*/
	/*
	int i,j,temp;
	int nums[N] = {16,25,9,90,23};
		printf("显示顺序排序的数\n");
		for(j = 0;j < N;j i++)
	{
		printf("%d\t",nums[j]);
	} 
		printf("\n");
	for(j = 0;j < N/2;j ++)
		{
			temp = nums[j];
			nums[j] = nums[N - j - 1];
			nums[N - j - 1] = temp;
		}
	
		printf("逆序后的数是\n");
	for(j = 0;j < N;j ++)
	{
		printf("%d\t",nums[j]);
	} 
	*/ 
	/*	for(i = 0;i < N - 1;i ++)
	{
		for(j = 0;j < N - i - 1;j ++)
		{
			if(nums[j] < nums[j + 1])
			{
				temp = nums[j];
				nums[j] = nums[j + 1];
				nums[j + 1] = temp;
			}
		}
	}
	printf("输出逆序排序后的值\n");
	for(i = 0;i < N;i ++)
	{
		printf("%d\t",nums[i]);
	}
		for(i = 0;i < N - 1;i ++)
	{
		for(j = 0;j < N - i - 1;j ++)
		{
			if(nums[j] > nums[j + 1])
			{
				temp = nums[j];
				nums[j] = nums[j + 1];
				nums[j + 1] = temp;
			}
		}
	}
	printf("输出顺序排序后的值\n");
	for(i = 0;i < N;i ++)
	{
		printf("%d\t",nums[i]);
	}
		*/	
	
	 /*
	int i,nums[7] = {8,4,2,1,23,344,12};
	printf("循环输出数组\n");
	for(i = 0;i < 7;i ++)
	{
		printf("%d\t",nums[i]);
	}
	*/
	
	/*
	//数组 
	double score[N];
	int i;
	for(i = 0;i < N;i ++)
	{
		printf("请输入第%d个同学的成绩",i + 1);
		scanf("%lf\n",&score[i]);
	}	
	for(i = 0;i < N;i ++)
	{
		printf("第%d个同学的成绩是%.2lf\n",i + 1,score[i]);
	
	}
	*/	
	/*
	int i,j;
	printf("九九乘法表\n");
	for(i=1;i<=9;i++)
	{
		for(j=1;j<=9;j++)
			printf("%d * %d =%d\t",i,j,i*j);
		printf("\n");
		
	}
		*/
		
		
		/*
 
	int i,j;
	for(i = 0;i <4;i ++)
	{
		
		for(j = 0;j <= 2-i; j++)
	    {
	    printf(" ");
	    }
		for(j = 0;j <=2 * i;j ++)
		{	
		printf("*");
		}
		printf("\n");
	}
	
	for(i = 4;i < 7;i ++)
	{
		for(j = 0;j <= i-4;j ++)
		{
		printf(" ");
		}
		for(j = 0;j <= 12-2 * i;j ++)
		{
		printf("*");
		}
		printf("\n");
	}
	
	*/
/*
	int i,sum = 0;
	for(i = 0;i <=100;i ++)
	{
		if(i % 2 !=0)
		{
			continue;
		}
		sum +=i; 
	}
	printf("1-100之间的偶数和%d\n",sum);

	int i,age,count = 0;
	for(i = 0;i < 5;i ++)
	{
		printf("请输入用户年龄");
		scanf("%d\n",&age);
		if(age >= 0)
		{
			continue;
		}
		count++;
	}
	printf("用户输错的次数%d\n",count);

	char sex;

	for(;;)
	{
		printf("请输入用户性别");
		scanf("%c\n",&sex); 
		sex = getchar();
		fflush(stdin);
		if(sex != 'M' || sex != 'm' || sex != 'F' || sex != 'f')
		{
			printf("输入错误，系统强制退出\n");
			break; 
		}
	}
	
	int price = 4532,guessprice,count;
	for(count = 0;;count ++)
		{
			printf("请输入商品的价格");
			scanf("%d\n",&guessprice);
			if(guessprice > price)
			{
				printf("你输入的值大了\n"); 
			}
			else if(guessprice < price)
				{
					printf("你输入的值小了\n");
				}
				else
				{
					printf("恭喜你！猜对了\n");
					break;
				}
		}
		printf("你一共猜了%d次\n",count + 1);
	
	int i,num;
	printf("请输入一个数");
	scanf("%d",&num); 
	for(i = 0;i < num;i ++)
	{
		printf("%d + %d = %d",i,num - i,num);
		if(i % 2 == 0)
		{
			printf("\t");
		}
		else
		{
			printf("\n");
		}
	}
	
	int i;
	double gongzi,zonggongzi = 0,pngjungongzi;
	for(i = 0;i < 6;i++)
	{
		printf("请输入第%d个月的工资",i + 1);
		scanf("%lf",&gongzi) ;
		zonggongzi += gongzi;
	}
	pngjungongzi = zonggongzi / 6;
	printf("这六个月的平均工资是%lf",pngjungongzi);
	/*
		/*
			int value,right_num;
			value = 0;
			while( value <= 0)
			{
				printf("\n请输入一个数：");
				scanf("%d",&value);
				if(value <= 0)
					printf("该数必须为正数\n"); 
			}
			printf("\n反转后的数为：");  
			while(value != 0)
			{
				right_num = value % 10;
				printf("%d",right_num);
				value = value / 10;	
			} 
			printf("\n");
		*/
		/*
			int value,right_num;
			value = 0;
			do
			{
				printf("\n请输入一个数：");
				scanf("%d",&value);
				if( value <= 0)
					printf("必须为正数！\n");
			}while( value <= 0);
			printf("\n反转后的数为：");
			do
			{
				right_num = value % 10;
				printf("%d",right_num);
				value = value / 10;	
			} while( value != 0);
			printf("\n");
		*/
	/*
	int i = 12345;
	printf("%d\n",i / 10);
	printf("%d\n",i / 100);
	printf("%d\n",i / 1000);
	
	while(1)
	{
		int choice;
		printf("性格测试\n");
		printf("假如你是一位皇帝，你会怎样选择伴侣\n");
		printf("1、挚爱一人\n");
		printf("2,两个以上\n");
		printf("3,佳丽三千\n");
		do{
			printf("请输入\n");
			scanf("%d",&choice);
			if(choice <= 0 || choice > 3)
			{
				printf("你的输入有误，请输入1-3之间的数\n");
			}
		} while(choice <= 0 || choice > 3);
		switch(choice)
		{
			case 1:
				printf("一定是你的小公举\n");
				break;
			case 2:
				printf("有点花心哦"); 
				break;
			case 3:
				printf("和我想法一样，嘻嘻\n");
				break;
		}
	}
/*
	int a=1,b=10;
	do
	{
		b -= a;
		a++;	
	} 
	while(b -- < 0);
	printf("%d\n",b);

	int i = 0;
	while(i<10)
	{
		printf("%d\n",i);
		i++;
	}

	srand(time(NULL));
	printf("随机数字:%d\n",rand());
	
	int hp1=100,hp2=100;
	int att1,att2;
	int i=  0;
	while(hp1 >0 && hp2>0)
	{
		att1 = rand() % 11 + 5;
		att2 = rand() % 11 + 5;
		hp1 -= att2;
		hp2 -= att1;
		printf("...................................\n");
		printf("第%d轮:\n",i + 1);
		printf("玩家1攻击力%d\t,玩家2血量%d\n",att1,hp2),
		printf("玩家2攻击力%d\t,玩家1血量%d\n",att2,hp1);
		printf("..................................\n");
		i++;
		Sleep(1000);
	}
	printf("游戏结束，玩家1的血量%d,玩家2的血量%d",hp1,hp2);
	
	int i = 0,password;
	while(i < 3)
	{
		printf("请输入密码:");
		scanf("%d",&password);
		if(password != 123456)
		{
			printf("密码输入错误，请重新输入,当前是第%d次输入密码",i+1); 
		}
		if(i == 2)
		{
			printf("当前密码已输错三次，系统强制退出\n"); 
		
		}
		i++;
	} 

		

	
	int i=1,sum=0;
	while(i <= 100)
	{
		sum += i;
		i++;
	}
	printf("%d\n",sum);
	
	int i = 1;
	while (i <= 10)
	{
		printf("啦啦啦\t第%d遍\n",i);
		i++;
	}
	
	int month;
	printf("请输入月份，来判断当月的天数");
	scanf("%d",&month);
	switch(month)
	{
		default:
			printf("本程序暂时只支持一到四月的查询！\n");
			break;
		case 1:
			printf("一月有31天!\n");
			break;
		case 2:
			printf("二月有28天!\n");
			break;
		case 3:
			printf("三月有31天!\n");
			break;
		case 4:
			printf("四月有30天!\n");
			break;
			 
	 } 
	
	int num = 10;
	int result = --num < 20 && num++ > 11;
	printf("result=%d\t num=%d\n",result,num);
	
	printf("%d",sizeof(long long));
	
	printf("5>8? %d\n",5>9);
	printf("6<9? %d\n",6<9);
	
	int num = 8;
	printf("%d\n",num%=5);
	
	double num2 = 6;
	int num3 = (int)num2;
	printf("%d\n",num3);

	int num1=1;
	num1 += 5;
	printf("%d\n",num1);

	char ch1 = 'a';
	char ch2 = 'A';
	char ch3 = ' ';
	printf("字符\tASCII码\n");
	printf("%c\t%d\n",ch1,ch1);
	printf("%c\t%d\n",ch2,ch2);
	printf("%c\t%d\n",ch3,ch3);
	printf("%c\t%d\n",ch1-32,ch1-32);
	*/
	//return 0;
//}
