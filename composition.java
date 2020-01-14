package oops;
import java.util.*;
class Gear
{
	int num;
	void set_number(int a)
	{
		num=a;
	}
}
class wheel
{
	String direction;
	void set_direction(String direction)
	{
		this.direction=direction;
	}
}
public class vehicle {
 private Gear g;
 wheel w;
 vehicle()
 {
	 this.g=new Gear();
	 w=new wheel();
 }
 void set_gearspeed()
 {
	 g.set_number(4);
 }
 void set_wheeldirection()
 {
	 w.set_direction("left");
 }
}
public class vehicle_driver {
	public static void main(String Args[])
	{
		vehicle obj=new vehicle();
	}
}
