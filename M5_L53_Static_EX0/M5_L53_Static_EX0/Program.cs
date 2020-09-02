using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace M5_L53_Static_EX0
{

	public static class StaticClass
	{
	public static int x;
	static StaticClass()  // contructor in static class are private (cannot be access outside the class)
	{
			x = 10;
	}
	public static void Display() 
	{
		Console.WriteLine(x);
	}

}
	public class Shape2D
	{
		public double A { set; get; }
		public double B { set; get; }

		public static int Count { get; private set; } // can read but can not modified "read only"
		public Shape2D(double a)
		{
			A = a; B = 0;
			Count += 1;
		}
		public Shape2D(double a, double b):this(a)
		//public Shape2D(double a, double b)
		{
			//A = a; // not required be cause "a" is initalized by the other constructor by using "this(a)"
			B = b;
		}
		public double GetArea()
		{
			if (B == 0) return A * A;
			else return A * B;
		}
	}
	class Program
	{
		static void Display(List<Shape2D> x) 
		{
			int i = 0;
			foreach (var item in x)
			{
				i++;
				if (item.B == 0) { Console.WriteLine("{0}. Square object with area {1}.", i, item.GetArea()); }
				else Console.WriteLine("{0}. Rectangle object with area {1}.", i, item.GetArea());		
			}
		}
		static void Main(string[] args)
		{
			//StaticClass obj = new StaticClass(); // Cannot instanciate an object from a static class
			StaticClass.Display(); // you can access drirectly to a static methid from a static class without create an object of that class

			string input = null;
			List<Shape2D> allObjects = new List<Shape2D>();

			for (;;) //infinity loop
			{
				Console.Clear();
				Console.WriteLine("Please enter 1 for creating a square object.");
				Console.WriteLine("Please enter 2 for creating a rectangle object.");
				Console.WriteLine("Please enter 3 for display the object list.");
				Console.WriteLine("Please enter 4 for exit.");
				input = Console.ReadLine();

				if (input == "1") 
				{ 
					var sqr = new Shape2D(3);
					allObjects.Add(sqr);
					Console.WriteLine("Square object created!");
				}
				else if (input == "2")
				{ 
					var rect = new Shape2D(2, 5);
					allObjects.Add(rect);
					Console.WriteLine("Rectangle object created!");
				}
				else if (input == "3")
				{
					Display(allObjects);
				}
				else if (input == "4") break;

				Console.WriteLine("Number of object(s) created so far : " + Shape2D.Count);
				Console.Read();

				// Nedd to tape "space"  number to work?

			}

		}
	}
}
