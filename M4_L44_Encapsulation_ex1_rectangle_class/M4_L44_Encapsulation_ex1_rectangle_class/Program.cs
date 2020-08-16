using System;

namespace M4_L44_Encapsulation_ex1_rectangle_class
{
	// Declaring a Class
	public class Rectangle
	{
		// Declaring fields
		private double _width;
		// The following code will define a property with a private field.
		public double Width
		{
			get
			{
				return _width;
			}
			set
			{
				if (value > 0)
					_width = value;
			}
		}
		private double _height;
		public double Height
		{
			get
			{
				return _height;
			}
			set
			{
				if (value > 0)
					_height = value;
			}
		}
		// Declaring a method
		public double GetArea()
		{
			return Width * Height;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Rectangle r = new Rectangle();
			// Here, instance r of the class (called object) is created.
			// You may think of r as a variable (object) of the class.
			r.Width = 5;    // here, we are accessing a field of the r object
			r.Height = 4;	// if set to negative number it will return 0
			Console.WriteLine(r.GetArea()); // calling GetArea() method of the object

			Console.Read();
		}
	}
}
