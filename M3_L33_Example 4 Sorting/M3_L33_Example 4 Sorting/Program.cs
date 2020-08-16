using System;
using System.Security.Cryptography.X509Certificates;

namespace M3_L33_Example_4_Sorting
{
	class Program
	{
		static void SortArray(float[] a)
		{
			int i, j, minIndex;
			float min;
			for (i = 0; i < a.Length - 1; i++)
			{
				min = a[i];
				minIndex = i;
				for (j = i + 1; j < a.Length; j++)
				{
					if (min > a[j])
					{
						min = a[j];
						minIndex = j;
					}
				}
				a[minIndex] = a[i];
				a[i] = min;
			}
		}

		static int findSmallestIndex(float[] x, int start) {

			float min = x[start];
			int minIndex = start;

			for (int i = start; start <= x.Length-1; i++) {
				if (min > x[i])
				{
					min = x[i];
					minIndex = i;
				}
			}
			return minIndex;
		}
		static void SortDany(float[] x)
		{ 
			int i,j;
			int currentMinIndex;
			float t;
			for (i = 0; i < x.Length-1; i++) {
				currentMinIndex = findSmallestIndex(x, i);
				t = x[i];
				x[i] = x[currentMinIndex];
				x[currentMinIndex] = t;
			}
		
		}
			static void ShowArray(float[] a)
		{
			int i;
			for (i = 0; i < a.Length; i++)
			{
				if (i % 30 == 0) Console.WriteLine();
				Console.Write(string.Format("{0:0.0}", a[i]) + " ");
			}
		}
		public static void Main()
		{
			float[] a;

			Random r = new Random((int)DateTime.Now.Ticks);
			Console.WriteLine("Enter Array Size: ");
			int n = int.Parse(Console.ReadLine());
			a = new float[n];

			for (int i = 0; i < n; i++)
			{
				a[i] = (float)r.NextDouble() * 100.0f;  // NextDouble() returns double value in range 0.0 to 1.0.
			}

			Console.Write("Elements of the array: ");
			ShowArray(a);
			//SortDany(a);
			SortArray(a);

			Console.Write("\nThe elements of the sorted array are: ");

			ShowArray(a);

			Console.Read();

		}
	}
}
