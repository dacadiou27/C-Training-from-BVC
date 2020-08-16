using System;

namespace M2_L22_Example_1_Detect_Character_Type
{
    class Program
    {
		static void Main(string[] args)
		{
			bool a = true;
			bool b = false;
			bool c = true;
			bool d = false;

			// Console.WriteLine(a && b || c && d);
			//Precedence from fisrt to last
			//()
			//!		NOT
			//&&	AND
			//||	OR

			int x = 1 ; //0001
			int y = 6 ; //0110
						//0000 result 0 with & 
						//0111 result 7 with |

			Console.WriteLine(x & y);
			Console.WriteLine(x | y);

			Console.Read();
		}

		/*
		 static void Main(string[] args)
		{

			Console.WriteLine("Exter a character");
			char c = (char)char.Parse(Console.ReadLine());

			if (char.IsUpper(c))
				Console.WriteLine("Upper Case character");
			else if (char.IsLower(c))
				Console.WriteLine("Lower Case character");
			else if (char.IsDigit(c))
				Console.WriteLine("Digit character");
			else
				Console.WriteLine("Other character");

			Console.Read();
		}
		/*

		/*
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to Tim's coffee shop!");
			Console.WriteLine("Would you like to order cofee? Y/N");
			string option;
			bool coffee = false;
			option = Console.ReadLine();
			if (option == "Y" || option == "y")
				coffee = true;
			Console.WriteLine("Would you like to order a donut?Y/N");
			bool donut = false;
			option = Console.ReadLine();
			if (option == "Y" || option == "y")
				donut = true;
			if (coffee && donut)
				Console.WriteLine("Great choice! You ordered a combo.");
			else if (!(coffee || donut))
				Console.WriteLine("You ordered nothing.");
			else
				Console.WriteLine("Excellent! You have placed one item order!");

			Console.Read();
		}	*/

	}
}
