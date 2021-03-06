<<<<<<< HEAD
﻿using System;

namespace M3_L31_Learning_Activity_2_Vending_Machine
{
    class Program
    {
		static int TakeValidIntInput()
		{
			int n;
			while (!int.TryParse(Console.ReadLine(), out n))
			{
				Console.WriteLine("Incorrect input! Please try again:");
			}
			return n;
		}

		static int PayAmount(double total)
		{
			int selection;
			double amount = 0;
			while (total > 0)
			{
				Console.Clear();
				Console.WriteLine("Your current due is : $" + total);
				Console.WriteLine("Please enter one coin at a time:\n");
				Console.WriteLine("Select 1 to pay $1.00");
				Console.WriteLine("Select 2 to pay $0.50");
				Console.WriteLine("Select 3 to pay $0.25");
				Console.WriteLine("Select 4 to pay $0.10");
				Console.WriteLine("Select 5 to pay $0.05");
				Console.WriteLine("Select 6 to pay $0.01");
				Console.WriteLine("Select 0 for returning to the Main Menu.");
				selection = TakeValidIntInput();
				if (selection == 0) return 0;
				else 
				if (selection == 1) amount = 1.0;
				else if (selection == 2) amount = 0.5;
				else if (selection == 3) amount = 0.25;
				else if (selection == 4) amount = 0.10;
				else if (selection == 5) amount = 0.05;
				else if (selection == 6) amount = 0.01;
				if (total < amount)
				{
					Console.WriteLine("The system does not support overpayment! \nPlease select a lower amount.");
					Console.WriteLine("Press any key to continue...");
					Console.Read();
				}
				else
				{
					total = Math.Round(total- amount,2);
				}
			}
			return 1;
		}

		static void Main(string[] args)
		{
			int choice;
			char c;
			do
			{
				Console.Clear();
				Console.WriteLine("Select an item from the following:\n");
				Console.WriteLine("Select 1 to purchase a Can Coke for $1.75");
				Console.WriteLine("Select 2 to purchase a Juice pack for $2.35");
				Console.WriteLine("Select 3 to purchase a Water bottle for $1.25");
				Console.WriteLine("Select 4 for the exit.");

				choice = TakeValidIntInput();
				if (choice == 4) break;

				switch (choice)
				{
					case 1:
						if (PayAmount(1.75) == 1)
							Console.WriteLine("You have successfully paid for the Can Coke. Thank you.");
						else
							Console.WriteLine("You have canceled the purchase!");
						break;
					case 2:
						if (PayAmount(2.35) == 1)
							Console.WriteLine("You have successfully paid for the Juice pack. Thank you.");
						else
							Console.WriteLine("You have canceled the purchase!");
						break;
					case 3:
						if (PayAmount(1.25) == 1)
							Console.WriteLine("You have successfully paid for the Water bottle. Thank you.");
						else
							Console.WriteLine("You have canceled the purchase!");
						break;
					default:
						break;
				}
				Console.Write("\nDo you want to buy again? (y/n): ");
				c = char.Parse(Console.ReadLine());
			} while (c == 'y' || c == 'Y');
		}
	}
}
=======
﻿using System;

namespace M3_L31_Learning_Activity_2_Vending_Machine
{
    class Program
    {
		static int TakeValidIntInput()
		{
			int n;
			while (!int.TryParse(Console.ReadLine(), out n))
			{
				Console.WriteLine("Incorrect input! Please try again:");
			}
			return n;
		}

		static int PayAmount(double total)
		{
			int selection;
			double amount = 0;
			while (total > 0)
			{
				Console.Clear();
				Console.WriteLine("Your current due is : $" + total);
				Console.WriteLine("Please enter one coin at a time:\n");
				Console.WriteLine("Select 1 to pay $1.00");
				Console.WriteLine("Select 2 to pay $0.50");
				Console.WriteLine("Select 3 to pay $0.25");
				Console.WriteLine("Select 4 to pay $0.10");
				Console.WriteLine("Select 5 to pay $0.05");
				Console.WriteLine("Select 6 to pay $0.01");
				Console.WriteLine("Select 0 for returning to the Main Menu.");
				selection = TakeValidIntInput();
				if (selection == 0) return 0;
				else 
				if (selection == 1) amount = 1.0;
				else if (selection == 2) amount = 0.5;
				else if (selection == 3) amount = 0.25;
				else if (selection == 4) amount = 0.10;
				else if (selection == 5) amount = 0.05;
				else if (selection == 6) amount = 0.01;
				if (total < amount)
				{
					Console.WriteLine("The system does not support overpayment! \nPlease select a lower amount.");
					Console.WriteLine("Press any key to continue...");
					Console.Read();
				}
				else
				{
					total = Math.Round(total- amount,2);
				}
			}
			return 1;
		}

		static void Main(string[] args)
		{
			int choice;
			char c;
			do
			{
				Console.Clear();
				Console.WriteLine("Select an item from the following:\n");
				Console.WriteLine("Select 1 to purchase a Can Coke for $1.75");
				Console.WriteLine("Select 2 to purchase a Juice pack for $2.35");
				Console.WriteLine("Select 3 to purchase a Water bottle for $1.25");
				Console.WriteLine("Select 4 for the exit.");

				choice = TakeValidIntInput();
				if (choice == 4) break;

				switch (choice)
				{
					case 1:
						if (PayAmount(1.75) == 1)
							Console.WriteLine("You have successfully paid for the Can Coke. Thank you.");
						else
							Console.WriteLine("You have canceled the purchase!");
						break;
					case 2:
						if (PayAmount(2.35) == 1)
							Console.WriteLine("You have successfully paid for the Juice pack. Thank you.");
						else
							Console.WriteLine("You have canceled the purchase!");
						break;
					case 3:
						if (PayAmount(1.25) == 1)
							Console.WriteLine("You have successfully paid for the Water bottle. Thank you.");
						else
							Console.WriteLine("You have canceled the purchase!");
						break;
					default:
						break;
				}
				Console.Write("\nDo you want to buy again? (y/n): ");
				c = char.Parse(Console.ReadLine());
			} while (c == 'y' || c == 'Y');
		}
	}
}
>>>>>>> 12f237521d9c77152b306cb7848623a27454fa0f
