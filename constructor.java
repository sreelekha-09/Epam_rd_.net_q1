package oops;
import java.util.*;
public class constructor {
	int a;
	int b;
	String c;
	double d;
 constructor()
 {
	 System.out.println("constructor called");
 }
public constructor(int a ,int b)
 {
	 this("name");
	 this.a=a;
	 this.b=b;
 }
 constructor(String c)
 {
	 this.c=c;
 }
protected constructor(double d)
 {
	 this.d=d;
 }
 public static void main(String gARgs[])
 {
	 constructor c=new constructor();
	 constructor c1=new constructor(23,67);
			 
 }
}
public class cons extends constructor {
	public static void main(String Args[])
	{
		constructor obj=new constructor(89.2);
		
	}
}

public class cons_public {
public static void main(String Args[])
{
	constructor o=new constructor(4,6);
}
}
