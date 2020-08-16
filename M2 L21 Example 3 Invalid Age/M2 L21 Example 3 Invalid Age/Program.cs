<<<<<<< HEAD
﻿using System;

namespace M2_L21_Example_3_Invalid_Age
{
    class Program
    {
		static void Main(string[] args) // Example of mixed/complex-if-else Statement
		{
			string name;
			int age;
			bool validAge = false;
			Console.WriteLine("Enter your username: ");
			name = Console.ReadLine();
			if (name == "Mahbub")
			{
				Console.WriteLine("Hi Mahbub!");
				Console.WriteLine("Enter your age: ");
				validAge = int.TryParse(Console.ReadLine(), out age);// retur true if valid int or false if invalid int // out is use to bypass value
				if (validAge)
				{
					Console.WriteLine("{0}, your registered age is: {1}. Thank you for your input.", name, age);
				}
				else
				{
					Console.WriteLine("Invalid Input. Please enter valid age in your next attempt.");
				}
			}
			else if (name.Length == 0)
			{
				Console.WriteLine("No username was entered.");
			}
			else
			{
				Console.WriteLine("The user {0}, has not been registered.", name);
			}
			Console.Read();
		}
	}
}
=======
﻿using System;

namespace M2_L21_Example_3_Invalid_Age
{
    class Program
    {
		static void Main(string[] args) // Example of mixed/complex-if-else Statement
		{
			string name;
			int age;
			bool validAge = false;
			Console.WriteLine("Enter your username: ");
			name = Console.ReadLine();
			if (name == "Mahbub")
			{
				Console.WriteLine("Hi Mahbub!");
				Console.WriteLine("Enter your age: ");
				validAge = int.TryParse(Console.ReadLine(), out age);// retur true if valid int or false if invalid int // out is use to bypass value
				if (validAge)
				{
					Console.WriteLine("{0}, your registered age is: {1}. Thank you for your input.", name, age);
				}
				else
				{
					Console.WriteLine("Invalid Input. Please enter valid age in your next attempt.");
				}
			}
			else if (name.Length == 0)
			{
				Console.WriteLine("No username was entered.");
			}
			else
			{
				Console.WriteLine("The user {0}, has not been registered.", name);
			}
			Console.Read();
		}
	}
}
>>>>>>> 12f237521d9c77152b306cb7848623a27454fa0f
