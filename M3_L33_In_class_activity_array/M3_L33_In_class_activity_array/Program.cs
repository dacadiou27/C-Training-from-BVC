using System;

namespace M3_L33_In_class_activity_array
{
    class Program
    {
        public static void PopulateArray(int[,] x)
        {
            Random r = new Random();
            for (int i = 0; i < x.GetLength(0)-1; i++)
            {
                for (int j = 0; j < x.GetLength(1)-1; j++)
                {
                    x[i, j] = r.Next(0, 11);
                }
            }
        }


        public static void DisplayArray(int[,] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0,4}", x[i, j]));
                }
                Console.WriteLine();
            }
        }

        public static void SumRows(int[,] x)
        {
            int sum; 
            for (int i = 0; i < x.GetLength(0)-1; i++)
            {
                sum = 0;
                for (int j = 0; j < x.GetLength(1)-1; j++)
                {
                    sum += x[i, j];
                }
                x[i, x.GetLength(0)-1] = sum;
                //Console.WriteLine();
            }
        }

        public static void SumColumns(int[,] x)
        {
            int sum;
            for (int j = 0; j < x.GetLength(1) - 1; j++)
            {
                sum = 0;
                for (int i = 0; i < x.GetLength(0) - 1; i++)
                {
                    sum += x[i, j];
                }
                x[x.GetLength(1) - 1, j] = sum;
                //Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            //Write a C# program that displays only primes from a 2D array. Your program’s inputs are the array size and a random seed.
            //Your program should determine prime elements and display them in their corresponding positions. Non-prime elements should be shown as ‘- -’.

            Console.WriteLine("Enter the number of rows / column of your Array: ");
            int r = int.Parse(Console.ReadLine());

            int[,] x = new int[r+1, r+1];

            PopulateArray(x);
            Console.WriteLine();
            DisplayArray(x);
            Console.WriteLine();
            SumRows(x);
            //DisplayArray(x);
            Console.WriteLine();
            SumColumns(x);
            DisplayArray(x);
            Console.Read();

        }
    }
}
