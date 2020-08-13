using System;

namespace M3_L33_Example3
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
					Console.Write(string.Format("{0,5}", a[i, j]) + " "); //0-parameter 3-width
				}
				Console.WriteLine();
			}
		}
		static int[,] GetMatrixMultiplication(int[,] a, int[,] b) //return an 2D integer array
		{
			int[,] c = new int[a.GetLength(0), b.GetLength(1)];
			for (int i = 0; i < a.GetLength(0); i++)
			{
				for (int j = 0; j < b.GetLength(1); j++)
				{
					c[i, j] = 0;
					for (int k = 0; k < a.GetLength(1); k++)
					{
						c[i, j] += a[i, k] * b[k, j];
					}
				}
			}
			return c;
		}
		public static void Main()
		{
			int[,] a, b, c;
			int m, n;
			Console.WriteLine("Enter Array Size \'m\': ");
			m = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter Array Size \'n\': ");
			n = int.Parse(Console.ReadLine());
			a = new int[m, n];
			b = new int[n, m];
			Console.WriteLine("Enter Random Seed Number: ");
			int seed = int.Parse(Console.ReadLine());
			Populate(a, seed);
			Populate(b, seed);
			Console.WriteLine("Array Elements of \'A\': ");
			ShowArray(a);
			Console.WriteLine("\nArray Elements of \'B\': ");
			ShowArray(b);
			Console.WriteLine("\nMultiplication Matrix \'C=AxB\': ");
			c = GetMatrixMultiplication(a, b);
			ShowArray(c);
			Console.Read();
		}
	}
}
