using System;

namespace M3_L32_For_LA4_Summation_of_a_Series
{
    class Program
    {
        public static double Fact(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }

            return fact;
        }

        public static double Equation(int n, ref double x)
        {

            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int denominator = 2 * i - 1;

                if (i % 2 != 0)
                    sum = sum + Math.Pow(x, (double)denominator) / Fact(denominator);
                else
                    sum = sum - Math.Pow(x, (double)denominator) / Fact(denominator);
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Number of Terms :");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("X value :");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Result : ");
            Console.WriteLine(String.Format("{0:0.00}", Equation(n, ref x)));

            Console.Read();

        }
    }
}
