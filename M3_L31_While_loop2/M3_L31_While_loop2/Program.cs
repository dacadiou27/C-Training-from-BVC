using System;

namespace M3_L31_While_loop2
{
    class Program
    {

        public static int ValidIntegerInput() 
        {
            Console.WriteLine("Enter an Integer : ");
            int x;
            //bool flag = int.TryParse(Console.ReadLine(), out x);
            while (int.TryParse(Console.ReadLine(), out x) == false)
            {
                Console.WriteLine("Enter an Integer correctly: ");
            }
            Console.WriteLine("The input is {0}", x);
            return x;
        }

        public static char ValidYesNoInput()
        {
            Console.WriteLine("Enter a choice (Y/N) : ");
            char c;
            
            while (char.TryParse(Console.ReadLine(), out c) == false || !(c=='y' || c == 'Y' || c == 'n' || c == 'N'))
            {
                Console.WriteLine("Enter a valid choice: ");
            }
            Console.WriteLine("The choice is {0}", c);
            return c;
        }

        public static int ComputeFactorial(int n)
        {
            int fact = 1;

            while (n > 1)
            {
                fact = fact * n;
                n--;
            }
            return fact;
        }

        static void Main(string[] args)
        {
            //string s = Console.ReadLine();
            //int x = ValidIntegerInput();

            int n;
            char c;
            int fact;

            do
            {
                n = ValidIntegerInput();
                //Console.WriteLine(" Do something ...");
                fact = ComputeFactorial(n);
                Console.WriteLine(" factorial of {0} is {1}",n,fact);
                c = ValidYesNoInput();
            } while (c=='Y' || c=='y');

            Console.Read();
        }
    }
}
