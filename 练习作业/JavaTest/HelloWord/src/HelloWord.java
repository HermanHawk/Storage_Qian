import java.util.Scanner;

public class HelloWord {
	public static void main(String[] args) {
		int num = 10,num1 = 8;
		int result = num++,result1= ++num1;
		System.out.println(result);
		System.out.println(result1);
		System.out.println(result);
		System.out.println(result1);
		System.out.println(num);
		System.out.println(num1);
		System.out.println(num);
		System.out.println(num1);
		/*Scanner input = new Scanner(System.in);
		System.out.println("请输入圆的半径");
		double radius = input.nextDouble();
		double area = 3.14 * radius * radius;
		System.out.println("圆的面积是" + area);
		/*
		double milkPrice = 0;
		 * System.out.println(milkPrice);
		System.out.println(Integer.MAX_VALUE);
		System.out.println(Integer.MIN_VALUE);
		*/
	}
}
