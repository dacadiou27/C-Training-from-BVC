<<<<<<< HEAD
﻿using System;

namespace M3_L31_While_loop
{
    class Program
    {

		static int ValidIntegerInput(string msg) 
		{
			Console.WriteLine(msg);
			int n;
			while (!int.TryParse(Console.ReadLine(), out n))
			{
				Console.WriteLine("please enter an integer in valid format! \n Try again!");
			}
			return n;
		}


		static int Factorial(int n)
		{
			//n(n-1)(n-2).............1
			//5!= 5*4*3*2
			int fact = 1;

			while (n > 1)
			{
				fact = fact * n;
				n = n - 1;
				//n--;
			}
			return fact;
		}
		static void Main(string[] args)
		{
			/* int i = 0;
			while (i < 25)
			{
				Console.Write(i/5+1 + " ");
				i++;

				int i = 0;
				while (i < 25)
				{
					Console.WriteLine(i / 5 + 1 + " ");
					i++;

				}
			}
			*/

			// 5
			// 4 5
			// 3 4 5
			// 2 3 4 5
			// 1 2 3 4 5

			int i, j, n;
			n = 5;
			i = 1;
			j = 1;

			while (j <= n) {
				i = 1;
				while (i <= j)
				{
					Console.Write(n - j + i + " ");
					i++;
				}
				Console.WriteLine();
				j++;
			}


			// 5 4 3 2 1
			// 5 4 3 2
			// 5 4 3
			// 5 4
			// 5

			int a = 1, b = 1;
			
			while (a <=5)
			{ 
				int c = 5;
				while (c-a+1 >= 1)
					{
						Console.Write( c + " ");
						c--;
					}
				Console.WriteLine(" ");
				a++;
			}


			// 5 5 5 5 5
			// 4 4 4 4
			// 3 3 3
			// 2 2
			// 1 

			int d = 5;
			int f = 1;
			
			while (d >= 1) 
			{
				int e = 5;
				while (e-f >= 0)
				{
					Console.Write( d + " ");
					e--;
					
				}
				f++;
				Console.WriteLine( " ");
				d--;
			}

			// 5
			// 4 4 
			// 3 3 3
			// 2 2 2 2
			// 1 1 1 1 1

			i = 5;
			
			while (i >= 1)
			{
			j = 1;
				while (j<=6-i)
				{
					Console.Write(i);
					j++;
					
				}

				Console.WriteLine();
				i--;
			}


			Console.Read();

			/*int n;
			n = ValidIntegerInput("Emter a number");
			Console.WriteLine("Factotrial of " + n + " is " + Factorial(n));

			Console.Read();
			/*

			/*int x1, x2;
			x1 = ValidIntegerInput("Enter fist value: ");

			x2 = ValidIntegerInput("Enter second value: ");

			x1 = x2 + x1;

			Console.WriteLine("The summation is :"+ (x1 + x2));

			Console.Read();
			*/

			/*int countup = 0;
			while (countup <= 50)
			{
				Console.WriteLine(countup);
				countup= countup+5;
			}

			Console.Read();
			*/
		}
	}
}
=======
﻿using System;

namespace M3_L31_While_loop
{
    class Program
    {

		static int ValidIntegerInput(string msg) 
		{
			Console.WriteLine(msg);
			int n;
			while (!int.TryParse(Console.ReadLine(), out n))
			{
				Console.WriteLine("please enter an integer in valid format! \n Try again!");
			}
			return n;
		}


		static int Factorial(int n)
		{
			//n(n-1)(n-2).............1
			//5!= 5*4*3*2
			int fact = 1;

			while (n > 1)
			{
				fact = fact * n;
				n = n - 1;
				//n--;
			}
			return fact;
		}
		static void Main(string[] args)
		{
			/* int i = 0;
			while (i < 25)
			{
				Console.Write(i/5+1 + " ");
				i++;

				int i = 0;
				while (i < 25)
				{
					Console.WriteLine(i / 5 + 1 + " ");
					i++;

				}
			}
			*/

			// 5
			// 4 5
			// 3 4 5
			// 2 3 4 5
			// 1 2 3 4 5

			int i, j, n;
			n = 5;
			i = 1;
			j = 1;

			while (j <= n) {
				i = 1;
				while (i <= j)
				{
					Console.Write(n - j + i + " ");
					i++;
				}
				Console.WriteLine();
				j++;
			}


			// 5 4 3 2 1
			// 5 4 3 2
			// 5 4 3
			// 5 4
			// 5

			int a = 1, b = 1;
			
			while (a <=5)
			{ 
				int c = 5;
				while (c-a+1 >= 1)
					{
						Console.Write( c + " ");
						c--;
					}
				Console.WriteLine(" ");
				a++;
			}


			// 5 5 5 5 5
			// 4 4 4 4
			// 3 3 3
			// 2 2
			// 1 

			int d = 5;
			int f = 1;
			
			while (d >= 1) 
			{
				int e = 5;
				while (e-f >= 0)
				{
					Console.Write( d + " ");
					e--;
					
				}
				f++;
				Console.WriteLine( " ");
				d--;
			}

			// 5
			// 4 4 
			// 3 3 3
			// 2 2 2 2
			// 1 1 1 1 1

			i = 5;
			
			while (i >= 1)
			{
			j = 1;
				while (j<=6-i)
				{
					Console.Write(i);
					j++;
					
				}

				Console.WriteLine();
				i--;
			}


			Console.Read();

			/*int n;
			n = ValidIntegerInput("Emter a number");
			Console.WriteLine("Factotrial of " + n + " is " + Factorial(n));

			Console.Read();
			/*

			/*int x1, x2;
			x1 = ValidIntegerInput("Enter fist value: ");

			x2 = ValidIntegerInput("Enter second value: ");

			x1 = x2 + x1;

			Console.WriteLine("The summation is :"+ (x1 + x2));

			Console.Read();
			*/

			/*int countup = 0;
			while (countup <= 50)
			{
				Console.WriteLine(countup);
				countup= countup+5;
			}

			Console.Read();
			*/
		}
	}
}
>>>>>>> 12f237521d9c77152b306cb7848623a27454fa0f
