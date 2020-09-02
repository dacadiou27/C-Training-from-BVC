using System;

namespace _5_L53_Recursive_EX1_Factorial
{
    class Program
    {
        static int Factorial(int n)
        {
            int fact = 1;
            for (int i = 2; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        static int RecFactorial(int n)
            // Recursive function have to have a if statement
        {
            // None recursive run
            if(n==1)
            {
               return 1;
            }
            //recursive run
            else
            {
                return RecFactorial(n-1)* RecFactorial(n);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Factorial of {0} is {1} from factorial function", n, Factorial(n));
            Console.WriteLine("Factorial of {0} is {1} from recfactorial function", n, Factorial(n));
            Console.Read();
        }
    }
}
