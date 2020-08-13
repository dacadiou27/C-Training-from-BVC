using System;

namespace M2_L24_Example_1_Day_of_the_Week
{
    class Program
    {
		public enum Days
		{
			Monday = 1,
			Tuesday = 2,
			Wednesday = 3,
			Thursday = 4,
			Friday = 5,
			Saturday = 6,
			Sunday = 7
		};

		static void Main(string[] args)
		{
			Console.WriteLine("Day of the Week!");
			Console.WriteLine("Please enter a number (between 1 to 7)\n");

			//Days day;
			//Enum.TryParse(Console.ReadLine(), out day);

			Days day = (Days)Enum.Parse(typeof(Days), Console.ReadLine());

			Console.WriteLine("Your selection is " + day);

			day = (Days)((int)day % 7) + 1;

			Console.WriteLine("The next day is " + day);

			/*
			Console.Write("Your selection is: ");
			switch (day)
			{
				case Days.Monday:
					Console.WriteLine("Monday");
					break;
				case Days.Tuesday:
					Console.WriteLine("Tuesday");
					break;
				case Days.Thursday:
					Console.WriteLine("Thursday");
					break;
				case Days.Friday:
					Console.WriteLine("Friday");
					break;
				case Days.Saturday:
					Console.WriteLine("Saturday");
					break;
				case Days.Sunday:
					Console.WriteLine("Sunday");
					break;
				default:
					Console.WriteLine("Invalid selection\nPlease try again in the next run!");
					break;
			}
			*/

			Console.Read();


			/*Console.WriteLine("Welcome to the digital drink fountain machine!");
			Console.WriteLine("What drink would you like? \n");
			Console.WriteLine(" 1 - Pepsi");
			Console.WriteLine(" 2 - 7up");
			Console.WriteLine(" 3 - Root Beer");
			Console.WriteLine(" 4 - Water");
			int selection;
			selection = int.Parse(Console.ReadLine());

			Console.Write("Your selection is: ");
			switch (selection)
			{
				case 1:
					Console.WriteLine("Pepsi");
					break;
				case 2:
					Console.WriteLine("7up");
					break;
				case 3:
					Console.WriteLine("Root Beer");
					break;
				case 4:
					Console.WriteLine("Water");
					break;
				default:
					Console.WriteLine("Invalid selection\nPlease try again in the next run!");
					break;
			}

			Console.Write("Thank you for visiting us.");
			Console.Read();*/
		}
	}
}
