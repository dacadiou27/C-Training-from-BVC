using System;

namespace M3_L33_Example_in_class
{
    class Program
    {
        public static bool TestPrime(int n)
            {
                int  i, m = 0;
                m = n / 2;
                for (i = 2; i <= m; i++)
                {
                    if (n % i == 0) return false;
                } 
                return true; 
            }

        public static void Populate(int[] x)
        {
            Random r = new Random();
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = r.Next(1,101);
            }
        }

            static void Main(string[] args)
        {
            int[] x = new int[100];
            Populate(x);
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (TestPrime(x[i]))
                {
                    sum += x[i];
                    Console.Write(x[i] + "+");
                }
            }

            Console.WriteLine("\b=" + sum);

            Console.Read();
        }
    }
}
