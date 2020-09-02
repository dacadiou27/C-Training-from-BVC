using System;
using System.Transactions;

namespace M5_L53_Recursive_LA1_Print_Letter
{
    class Program
    {
        static public char Letter ='A';
        static public void PrintChar(int n)
        {
            int i = 0;

            if (i == n) return;

            else
            {
                Console.Write(Letter + " ");
                Letter++;
                i++;
                PrintChar(n-1);
            }
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Enter how many letter of the alphabet you want to be written :");
            int n = int.Parse(Console.ReadLine());
            PrintChar(n);

            Console.Read();


        }
    }
}
