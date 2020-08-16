using System;

namespace M5_L51_Reference_inheritance_Basic
{

	// Constructor calls in Inheritance
	class BaseClass
	{
		public BaseClass()
		{
			Console.WriteLine("Base Class Default Constructor");
		}

		public BaseClass(int id)
		{
			Console.WriteLine("Base Class Parameterize Constructor ",);
		}
	}
	class SubClass : BaseClass
	{

		//public SubClass()   // explicit constructor call
		//{
		//	Console.WriteLine("Derived Class Default Constructor");
		//}

		 SubClass() : base()    
		{
			Console.WriteLine("Derived Class Default Base Constructor");
		}

		//public SubClass(int id)    // explicit constructor call
		//{
		//	Console.WriteLine("Derived Class Parameterize Constructor");
		//}
		public SubClass(int id) : base(id)    // explicit constructor call // added ":base (id)" --> the contructor form the base class with and argument will be called instead of the default constructor
		{
			Console.WriteLine("Derived Class Parameterize Base Constructor");
		}
	}

	class Program
    {
        static void Main(string[] args)
        {
			SubClass obj = new SubClass(7);

			Console.ReadLine();
        }
    }
}
