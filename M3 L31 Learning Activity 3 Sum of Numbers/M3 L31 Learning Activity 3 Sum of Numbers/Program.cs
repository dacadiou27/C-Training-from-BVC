using System;
using System.Net.NetworkInformation;

namespace M3_L31_Learning_Activity_3_Sum_of_Numbers
{
    class Program
    {
        public static int ValidIntegerInput()
        {
            Console.WriteLine("Enter an Integer to be summed: ");
            Console.WriteLine("If the number 0 is entered, the total sum will be output!");
            int x;
            while (int.TryParse(Console.ReadLine(), out x) == false)
            {
                Console.WriteLine("Enter an Integer correctly: ");
            }
            return x;
        }
        public static int SumInt(ref int s , int n)
        {
            s = s + n;
            return s;

        }

        public static char ValidYesNoInput()
        {
            Console.WriteLine("Calculate another sum? [Y/N]");
            char c;

            while (char.TryParse(Console.ReadLine(), out c) == false)
            {
                Console.WriteLine("Enter a valid choice: ");
                
            }

            if (c != 'Y' && c != 'y' && c != 'N' && c != 'n')
            {
                c = ValidYesNoInput();
            }
                return c;

        }

        static void Main(string[] args)
        {
            int n = 0;
            int s = 0;
            char answer;
            
            do
            { 
            n = ValidIntegerInput();
            while (n != 0)
            {
                s = SumInt(ref s , n);
                n = ValidIntegerInput();
            }

            Console.WriteLine("You entered the number 0, the total sum is {0}",s);

            answer = ValidYesNoInput();
            }while (answer == 'Y' || answer == 'y');

            Console.WriteLine("Thank you for using this program! ");
            Console.Read();
        }
    }
}
