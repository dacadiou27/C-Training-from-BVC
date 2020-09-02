using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace M5_L53_Recursive_EX2_Fabonacci
{
    class Program
    {
        static int Fiboloop(int n)
        {
            //0 1 1 2 3 5 8 13 21 ....
            if (n == 1) return 0;
            else if (n == 2 || n==3) return 1;
            int prev = 0;
            int current = 1;
            int i = 2;
            int temp;
            while (i < n)
            {
                temp = current;
                current = current + prev;
                prev = temp;
                i++;
            }
            return current;
        }

        static int RecFibo(int n)
        {
            //0 1 1 2 3 5 8 13 21 ....
            if (n <=1) return n;
            return RecFibo(n - 1) + RecFibo(n-2);
        }


        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.Write(Fiboloop(i)+ " ");
            }

            Console.WriteLine();

            for (int i = 0; i < 20; i++)
            {
                Console.Write(RecFibo(i) + " ");
            }
            Console.Read();
        }
    }
}
