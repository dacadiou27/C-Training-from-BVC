using System;

namespace M5_L53_Static_EX1_Object_Counter
{
	public class Shape2D
	{   //private static int counter = 0;
		public static int counter;
		public double A { set; get; }
		public double B { set; get; }
		public double C { set; get; }
		public double D { private set; get; }
		static Shape2D()
		{
			counter = 0;
		}
		public Shape2D()
		{
			D = 0; counter++;
		}
		public Shape2D(double a):this()
		{
			A = a; D = 1; 
			//counter++;
		}
		public Shape2D(double a, double b) : this(a)
		{
			//A = a; B = b; D = 2;
			B = b; D++;
			//counter++;
		}
		public Shape2D(double a, double b, double c):this(a,b)
		{
			//A = a; B = b; C = c; D = 3;
			 C = c; D ++;
			//counter++;
		}
		public static void InformationAboutObjects()
		{
			Console.WriteLine("In this program, we have created {0} objects so far.", counter);
		}
		public static void f()
		{
			Console.WriteLine("Static method in action.");
			Console.WriteLine("Current Counter Value: " + counter);
		}
		public double GetArea()
		{
			double area = 0;
			if (D == 1)
				area = A * A;
			else if (D == 2)
				area = A * B;
			else if (D == 3)
			{
				var s = (A + B + C) / 2.0;
				area = Math.Sqrt(s * (s - A) * (s - B) * (s - C));
			}
			else
				area = -1;
			return area;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Shape2D.f();
			var sqr = new Shape2D(3);
			Shape2D.f();
			Console.WriteLine("Total Objects created so far is: " + Shape2D.counter);
			var rect = new Shape2D(2, 5);
			Console.WriteLine("Total Objects created so far is: " + Shape2D.counter);
			var tri = new Shape2D(3, 4, 5);
			Console.WriteLine("Total Objects created so far is: " + Shape2D.counter);
			var unknown = new Shape2D();
			Console.WriteLine("Total Objects created so far is: " + Shape2D.counter);
			Shape2D.InformationAboutObjects();

			Console.Read();
		}
	}
}
