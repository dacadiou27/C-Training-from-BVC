using System;

namespace M2_L23_Learning_Activity_1_Broken_Change
{
    class Program
    {
		static int GetQuarters(int cents)
		{
			int remainder = cents % 25;
			int quarters = (cents - remainder) / 25; // need parenthesis
			return quarters;
		}

		static int GetDimes(int cents)
		{
			int remainder = cents % 10; //wrong varialbes
			int dimes = (cents - remainder) / 10; //missing calculation on # of dimes
			return dimes;
		}

		static int GetNickels(int cents)
		{
			int remainder = cents % 5; // wrong operator & variable
			int nickels = (cents- remainder) / 5; //wrong variables
			return nickels;
		}

		static int GetPennies(int cents)
		{

			return cents; //wrong variable
		}

		static void Main(string[] args)
		{
			int cents;
			Console.WriteLine("How much change do you need? ");
			cents = int.Parse(Console.ReadLine());

			int quarters = GetQuarters(cents);
			cents -= quarters * 25;
			int dimes = GetDimes(cents);
			cents -= dimes * 10;
			int nickels = GetNickels(cents);
			cents -= nickels * 5; // misplaced statement
			int pennies = GetPennies(cents);
			//cents -= nickels * 5;
			cents -= pennies * 1;

			Console.WriteLine("Quarters: " + quarters);
			Console.WriteLine("Dimes: " + dimes);
			Console.WriteLine("Nickels: " + nickels);
			Console.WriteLine("Pennies: " + pennies);

			Console.Read();
		}
	}
}
