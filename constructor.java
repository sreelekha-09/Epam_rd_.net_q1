package oops;
import java.util.*;
public class constructor {
	int a;
	int b;
	String c;
 constructor()
 {
	 System.out.println("constructor called");
 }
 constructor(int a ,int b)
 {
	 this("name");
	 this.a=a;
	 this.b=b;
 }
 constructor(String c)
 {
	 this.c=c;
 }
 public static void main(String gARgs[])
 {
	 constructor c=new constructor();
	 constructor c1=new constructor(23,67);
			 
 }
}
