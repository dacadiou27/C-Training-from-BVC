using System;

namespace M3_L32_For_LA1_Estimating_Pi
{
    class Program
    {
        public static long MatchTerms(long n)
        {
            long preTerm = ComputePi(n);
            while (preTerm != ComputePi(++n))
            {
                return n;
            }
            return n;
        }

        public static long ComputePi(long n)
        {
            long denominator;
            long Pi = 0;

            for (int i = 1; i <= n; i++)
            {
                denominator = 2 * i - 1;

                if (i % 2 != 0)
                    Pi = Pi + 4 / denominator;
                else
                    Pi = Pi - 4 / denominator;
                //Console.WriteLine((Pi));
            }
            return Pi;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Number of terms of the equation :");
            long n = long.Parse(Console.ReadLine());

            MatchTerms(n);

            Console.WriteLine("Pi = {0}", ComputePi(n));



            Console.Read();
        }
    }
}
