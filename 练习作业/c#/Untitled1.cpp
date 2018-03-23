#include"stdio.h"
main()
{
	int a,b,c;
	for(a=1;a<7;a++)
		for(b=0;b<7;b++)
			for(c=1;c<7;c++)
				if(a*7*7+b*7+c==c*9*9+b*9+a)
				{
					printf("这个特殊三位数是：");
					printf("%d%d%d(7)=(%d%d%d(9)=%d(10)\n",
					a,b,c,c,b,a,a*7*7+b*7+c);
				}
 } 
