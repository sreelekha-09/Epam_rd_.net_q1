package oops;
import java.util.*;
public class mobile {
	mobile()
	{
		System.out.println("mobile constructor");
	}
	void mobile_display()
	{
		System.out.println("mobile");
	}
}
class samsung extends mobile
{
	samsung()
	{
		System.out.println("samsung constructor");
	}
	void samsung_display()
	{
		System.out.println("samsung");
	}
}
class samsung_j7 extends samsung
{
	samsung_j7()
	{
		System.out.println("samsung j7 constructor");
	}
	void samsung_j7_display()
	{
		System.out.println("Samsung j7");
	}
}
class nokia extends mobile
{
	nokia()
	{
		System.out.println("nokia constructor");
	}
	void nokia_display()
	{
		System.out.println("nokia");
	}
}
public class mob_test {
public static void main(String ARgs[])
{
	samsung_j7 obj1=new samsung_j7();
	obj1.samsung_j7_display();
	obj1.samsung_display();
	obj1.mobile_display();
	nokia obj2=new nokia();
	obj2.nokia_display();
	obj2.mobile_display();
}
}
