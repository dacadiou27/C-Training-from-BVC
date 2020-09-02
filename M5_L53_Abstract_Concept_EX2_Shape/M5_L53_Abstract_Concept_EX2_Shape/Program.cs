using System;

namespace M5_L53_Abstract_Concept_EX2_Shape
{
	public abstract class Shape
	{
		public abstract double area(); //no method detail for the area because it s 100% depending on the shape itself --> abstract method (& class)
	}
	public class Square : Shape
	{
		private int side;
		public Square(int s) { side = s; }
		public override double area() { return side * side; }
	}

	public class Circle : Shape
	{
		private int radius;
		public Circle(int r) { radius = r; }
		public override double area()
		{
			return System.Math.PI * radius * radius;
		}
	}
	class ShapeTest
	{
		static void Main(string[] args)
		{
			Shape sq = new Square(10); // run time polym
			Shape c = new Circle(5); // run time polym
			System.Console.WriteLine("Area of square= " + sq.area());
			System.Console.WriteLine("Area of circle= " + c.area());
			Console.Read();
		}
	}
}
