<<<<<<< HEAD
﻿using System;

namespace M3_L33_Example_2
{
	class Program
	{
		static void Populate(int[,] a, int seed)
		{
			Random r = new Random(seed);
			for (int i = 0; i < a.GetLength(0); i++)
			{
				for (int j = 0; j < a.GetLength(1); j++)
				{
					a[i, j] = r.Next(1, 10);
				}
			}
		}
		static void ShowArray(int[,] a)
		{
			int i, j;
			for (i = 0; i < a.GetLength(0); i++)
			{
				for (j = 0; j < a.GetLength(1); j++)
				{
					Console.Write(string.Format("{0,3}", a[i, j]) + " ");   // 0-parameter 3-width
				}
				Console.WriteLine();
			}
		}
		static int FindSumBoundary(int[,] a)
		{
			int sum = 0;
			for (int i = 0; i < a.GetLength(0); i++)
			{
				sum += a[i, 0] + a[i, a.GetLength(1) - 1];  // sums the first and last column
			}
			for (int j = 1; j < a.GetLength(1) - 1; j++)
			{
				sum += a[0, j] + a[a.GetLength(0) - 1, j];  // sums the first and last row
			}
			return sum;
		}
		public static void Main()
		{
			int[,] a;
			int m, n;
			Console.WriteLine("Enter Array Size \'m\': ");
			m = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter Array Size \'n\': ");
			n = int.Parse(Console.ReadLine());
			a = new int[m, n];
			Console.WriteLine("Enter Random Seed Number: ");
			int seed = int.Parse(Console.ReadLine());
			Populate(a, seed);
			Console.WriteLine("Array Elements: ");
			ShowArray(a);
			Console.WriteLine("The summation of boundary elements is: " + FindSumBoundary(a));
			Console.Read();
		}
	}
}
=======
﻿using System;

namespace M3_L33_Example_2
{
	class Program
	{
		static void Populate(int[,] a, int seed)
		{
			Random r = new Random(seed);
			for (int i = 0; i < a.GetLength(0); i++)
			{
				for (int j = 0; j < a.GetLength(1); j++)
				{
					a[i, j] = r.Next(1, 10);
				}
			}
		}
		static void ShowArray(int[,] a)
		{
			int i, j;
			for (i = 0; i < a.GetLength(0); i++)
			{
				for (j = 0; j < a.GetLength(1); j++)
				{
					Console.Write(string.Format("{0,3}", a[i, j]) + " ");   // 0-parameter 3-width
				}
				Console.WriteLine();
			}
		}
		static int FindSumBoundary(int[,] a)
		{
			int sum = 0;
			for (int i = 0; i < a.GetLength(0); i++)
			{
				sum += a[i, 0] + a[i, a.GetLength(1) - 1];  // sums the first and last column
			}
			for (int j = 1; j < a.GetLength(1) - 1; j++)
			{
				sum += a[0, j] + a[a.GetLength(0) - 1, j];  // sums the first and last row
			}
			return sum;
		}
		public static void Main()
		{
			int[,] a;
			int m, n;
			Console.WriteLine("Enter Array Size \'m\': ");
			m = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter Array Size \'n\': ");
			n = int.Parse(Console.ReadLine());
			a = new int[m, n];
			Console.WriteLine("Enter Random Seed Number: ");
			int seed = int.Parse(Console.ReadLine());
			Populate(a, seed);
			Console.WriteLine("Array Elements: ");
			ShowArray(a);
			Console.WriteLine("The summation of boundary elements is: " + FindSumBoundary(a));
			Console.Read();
		}
	}
}
>>>>>>> 12f237521d9c77152b306cb7848623a27454fa0f
