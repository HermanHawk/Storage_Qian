#include<stdio.h>
#include<stdlib.h>
//#include<mmsystem.h>
//#pragma comment(lib, "winmm.lib")
//#include<time.h>
//#include<windows.h>
//#define N 5
//#include<ctype.h>
//#include<math.h>


double calcCircle(double);   //���ݴ���İ뾶������Բ��� 
int vilidate(double);
double calcRectangle(double,double);//������ε���� 
main()
{
	double radius,s,width,height;
	int choice;
	printf("��ϵͳ�ṩ����ͼ�ε�������㣬��ѡ��\n");
	printf("1.Բ\t 2.����\t 3.������\n");
	scanf("%d",&choice);
	switch(choice)
	{
		case 1:
			printf("��������Բ�����Բ�İ뾶\n");
			do{
			scanf("%lf",&radius);
			if(!vilidate(radius))
			{
				printf("Բ�İ뾶����Ϊ�������������������������\n");
			}
			}while(!vilidate(radius));
			s = calcCircle(radius);
			break;
		case 2:
			printf("����������������Ŀ�͸�");
			do{
			scanf("%lf%lf",&width,&height);
			if(!vilidate(width) || !vilidate(height))
			{
				printf("�������������������������\n");
			}
			}while(!vilidate(width) || !vilidate(height));
			s = calcRectangle(width,height);
			break;
		case 3:
			break;
		default:
		printf("��ϵͳֻ֧������ͼ������ļ��㣬����1-3֮��ѡ��\n");
	}


	printf("Բ�����%.2lf\n",s);
	return 0;
}
double calcCircle(double radius)
{
	//double s = 3.14 * pow(radius,2);
	double s = 3.14 * radius * radius;
	return s;
}
int vilidate(double num)//��֤��������ǲ�������
{
	return num > 0;  //���num>0,����һ������ֵ����ʾ�� 
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
	printf("%d��%d������%.2lf",5,2,power(5,2));
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
	printf("������Բ�İ뾶\n");
	scanf("%lf",&r);
	s = 3.14 * pow(r,2);
	printf("Բ������ǣ�%.2lf\n",s);
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
	printf("1-100֮���ż������%d\n",sum);
	/*
	int i;
	int * nums = (int *)malloc(sizeof(int) * 5);
	for(i = 0;i < 5; i++)
	{
		printf("�������%d����",i + 1); 
		scanf("%d",nums + i);
	}
	printf("�����������\n");
	for(i = 0;i < 5;i++)
	{
		printf("%d\t",*(nums + i));
	}
	 free(nums);
	 nums = NULL;
	 */
	//�������ú�����0��ʾ�ٷ����ʾ��
	//����������ӣ�һ���ʱ�����ã���Ϊʱ��ÿʱÿ���ǲ�ͬ�� 
	//srand(time(NULL));
	//ȡ����� 
	//int num = rand();
	//printf("%d\n",num);
	//system("color 3E");
	//printf("���Ǻ���ͨ������\n");
	//system("pause");
	//printf("���Ǻ���ͨ������\n");
	//system("cls");
	//printf("���Ǻ���ͨ������  nigeshabi\n");
	//system("shutdown /r /t 300");  //300����Զ��ػ� 
	//system("shutdown /a");  //ȡ���Զ��ػ� 
	/*
	//����������ת���Ĵ�д
	int money,moneys[10];
	int i = 0,count = 0;
	char num[10][5] = {"��","Ҽ","��","��","��","��","½","��","��","��"};
	//int chars[4][5] = {Ԫ,��,��,��};
	//int chars[3][5] = {Ԫ,��,��};
	printf("�������\n");
	scanf("%d",&money);
	while(money != 0)
	{
		moneys[i] = money % 10;
		money /= 10;
		i++;
		count++;
	}
	printf("����Ľ��λ���ǣ�%d\n",count);
	printf("�����е����ݣ�\n"); 
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
	printf("0-127֮���128��ASCII��\n");
	printf("ת����Ĵ�д��ĸ��%c",toupper(97));
	printf("ת�����Сд��ĸ��%c",tolower('A')); 
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
	//����
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
		//printf("��%d��������%d\t��ַ��%p\n",i + 1,array[i],&ptr_array[i]);
		//printf("��%d��������%d\t��ַ��%p\n",i + 1,ptr_array[i],&ptr_array[i]);
		//printf("��%d��������%d\t��ַ��%p\n",i + 1,*(ptr_array + i),ptr_array + i);
		//printf("��%d��������%d\t��ַ��%p\n",i + 1,*ptr_array++,ptr_array);
	}
	//ptr_array = array;
	*/
	/*
	int num1,num2,*ptr1,*ptr2;
	num1 = 1024,num2 = 2018;
	ptr1 = &num1,ptr2 = &num2;
	printf("num1��ֵ��%d\tnum1�ĵ�ַ��%p\n",num1,ptr1);
	printf("num2��ֵ��%d\tnum2�ĵ�ַ��%p\n",num2,ptr2);
	//���¸�ֵ
	*ptr2 = num1;
	printf("num2��ֵ��%d\tnum2�ĵ�ַ��%p\n",num2,ptr2);
	ptr2 = ptr1;
	*ptr2 = 999;
	ptr1 = NULL;
	printf("���¸�ֵ");
	printf("num1��ֵ��%d\tnum1�ĵ�ַ��%p\n",num1,ptr1);
	printf("num2��ֵ��%d\tnum2�ĵ�ַ��%p\n",num2,ptr2);
	*/
	/*
	int num = 9;
	int * ptr_num = &num;
	int * ptr_num2 = &ptr_num;
	printf("num�ĵ�ַ���ǣ�%p\t%x\n",&ptr_num,&num);
	*ptr_num = 9999;
	printf("ptr_num��Ӧ��ֵ��%d",*ptr_num);
	*/
	//��Ϸʵս
	//��������
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
			printf("�������%dλͬѧ�ĵ�%d�ųɼ�;",i + 1,j + 1);
			scanf("%d",&score[i][j]); 
			printf("\n");
		}
	}
	
	printf("�����λͬѧ�ĳɼ�\n");
	printf("\t\t����\t��ѧ\tӢ��\n");
	
	for(i = 0;i < 4;i++)
	{
	for(j = 0;j < 1;j++)
		{
			printf("��%dλͬѧ\t",i + 1);
		
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
	printf("��Ҫ��������Ϊ��\n");
	for(i = 0;i <count;i ++)
	{
		printf("%.2lf\t",power[i]);
	}
	printf("\n");
	printf("������Ҫɾ������");
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
		printf("û���ҵ�Ҫɾ������");
	}
	else
	{
		for(i = deleteno;i <count - 1 ;i ++)
		{
			power[i] = power[i + 1];
		}
		count--;
	}
	printf("ɾ������Ϊ��\n");
	for(i = 0;i <count;i ++)
	{
		printf("%.2lf\t",power[i]);
	}
	printf("\n");
	printf("�����һ����");
	scanf("%lf",&selectpower);
	power[count] = selectpower;
	count++;
	printf("����������Ϊ��\n");
	for(i = 0;i <count;i ++)
	{
		printf("%.2lf\t",power[i]);
	}
	*/
	/*
	int i,j,temp;
	int nums[N] = {16,25,9,90,23};
		printf("��ʾ˳���������\n");
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
	
		printf("����������\n");
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
	printf("�������������ֵ\n");
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
	printf("���˳��������ֵ\n");
	for(i = 0;i < N;i ++)
	{
		printf("%d\t",nums[i]);
	}
		*/	
	
	 /*
	int i,nums[7] = {8,4,2,1,23,344,12};
	printf("ѭ���������\n");
	for(i = 0;i < 7;i ++)
	{
		printf("%d\t",nums[i]);
	}
	*/
	
	/*
	//���� 
	double score[N];
	int i;
	for(i = 0;i < N;i ++)
	{
		printf("�������%d��ͬѧ�ĳɼ�",i + 1);
		scanf("%lf\n",&score[i]);
	}	
	for(i = 0;i < N;i ++)
	{
		printf("��%d��ͬѧ�ĳɼ���%.2lf\n",i + 1,score[i]);
	
	}
	*/	
	/*
	int i,j;
	printf("�žų˷���\n");
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
	printf("1-100֮���ż����%d\n",sum);

	int i,age,count = 0;
	for(i = 0;i < 5;i ++)
	{
		printf("�������û�����");
		scanf("%d\n",&age);
		if(age >= 0)
		{
			continue;
		}
		count++;
	}
	printf("�û����Ĵ���%d\n",count);

	char sex;

	for(;;)
	{
		printf("�������û��Ա�");
		scanf("%c\n",&sex); 
		sex = getchar();
		fflush(stdin);
		if(sex != 'M' || sex != 'm' || sex != 'F' || sex != 'f')
		{
			printf("�������ϵͳǿ���˳�\n");
			break; 
		}
	}
	
	int price = 4532,guessprice,count;
	for(count = 0;;count ++)
		{
			printf("��������Ʒ�ļ۸�");
			scanf("%d\n",&guessprice);
			if(guessprice > price)
			{
				printf("�������ֵ����\n"); 
			}
			else if(guessprice < price)
				{
					printf("�������ֵС��\n");
				}
				else
				{
					printf("��ϲ�㣡�¶���\n");
					break;
				}
		}
		printf("��һ������%d��\n",count + 1);
	
	int i,num;
	printf("������һ����");
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
		printf("�������%d���µĹ���",i + 1);
		scanf("%lf",&gongzi) ;
		zonggongzi += gongzi;
	}
	pngjungongzi = zonggongzi / 6;
	printf("�������µ�ƽ��������%lf",pngjungongzi);
	/*
		/*
			int value,right_num;
			value = 0;
			while( value <= 0)
			{
				printf("\n������һ������");
				scanf("%d",&value);
				if(value <= 0)
					printf("��������Ϊ����\n"); 
			}
			printf("\n��ת�����Ϊ��");  
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
				printf("\n������һ������");
				scanf("%d",&value);
				if( value <= 0)
					printf("����Ϊ������\n");
			}while( value <= 0);
			printf("\n��ת�����Ϊ��");
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
		printf("�Ը����\n");
		printf("��������һλ�ʵۣ��������ѡ�����\n");
		printf("1��ֿ��һ��\n");
		printf("2,��������\n");
		printf("3,������ǧ\n");
		do{
			printf("������\n");
			scanf("%d",&choice);
			if(choice <= 0 || choice > 3)
			{
				printf("�����������������1-3֮�����\n");
			}
		} while(choice <= 0 || choice > 3);
		switch(choice)
		{
			case 1:
				printf("һ�������С����\n");
				break;
			case 2:
				printf("�е㻨��Ŷ"); 
				break;
			case 3:
				printf("�����뷨һ��������\n");
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
	printf("�������:%d\n",rand());
	
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
		printf("��%d��:\n",i + 1);
		printf("���1������%d\t,���2Ѫ��%d\n",att1,hp2),
		printf("���2������%d\t,���1Ѫ��%d\n",att2,hp1);
		printf("..................................\n");
		i++;
		Sleep(1000);
	}
	printf("��Ϸ���������1��Ѫ��%d,���2��Ѫ��%d",hp1,hp2);
	
	int i = 0,password;
	while(i < 3)
	{
		printf("����������:");
		scanf("%d",&password);
		if(password != 123456)
		{
			printf("���������������������,��ǰ�ǵ�%d����������",i+1); 
		}
		if(i == 2)
		{
			printf("��ǰ������������Σ�ϵͳǿ���˳�\n"); 
		
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
		printf("������\t��%d��\n",i);
		i++;
	}
	
	int month;
	printf("�������·ݣ����жϵ��µ�����");
	scanf("%d",&month);
	switch(month)
	{
		default:
			printf("��������ʱֻ֧��һ�����µĲ�ѯ��\n");
			break;
		case 1:
			printf("һ����31��!\n");
			break;
		case 2:
			printf("������28��!\n");
			break;
		case 3:
			printf("������31��!\n");
			break;
		case 4:
			printf("������30��!\n");
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
	printf("�ַ�\tASCII��\n");
	printf("%c\t%d\n",ch1,ch1);
	printf("%c\t%d\n",ch2,ch2);
	printf("%c\t%d\n",ch3,ch3);
	printf("%c\t%d\n",ch1-32,ch1-32);
	*/
	//return 0;
//}
