using System;

namespace M3_L32_For_LA2_Printing_Pyramids
{
    class Program
    {
        public static void PyramidsPrint(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; i <= (n - j); j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
        public static void PyramidsPrintinclass(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; i <= (n - j); j++)
                {
                    Console.Write("  ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0,4}", i * j);
                }
                Console.WriteLine();
            }
        }

        public static void PyramidsPrintinclassletter(int n)
        {
            char letter = 'A';
            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; i <= (n - j); j++)
                {
                    Console.Write("  ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0,4}", letter);
                }
                letter++;
                Console.WriteLine();
            }
        }

        public static void PyramidsNumberPrint(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; i <= (n - j); j++)
                {
                    Console.Write("  ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0,2}", j);
                }
                for (int j = 1; j <= (i - 1); j++)
                {
                    Console.Write("{0,2}", i - j);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Provide Pyramid Height :");
            int n = int.Parse(Console.ReadLine());

            PyramidsPrint(n);
            PyramidsNumberPrint(n);
            PyramidsPrintinclass(n);
            PyramidsPrintinclassletter(n);
            Console.Read();
        }
    }
}
