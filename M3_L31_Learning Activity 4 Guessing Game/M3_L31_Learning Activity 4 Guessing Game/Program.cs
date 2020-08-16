using System;

namespace M3_L31_Learning_Activity_4_Guessing_Game
{
    class Program
    {

        public static int SelectNumber() 
        {
            Random obj = new Random();
            int n = obj.Next(1, 101);
            return n;
        }

        public static int ValidIntegerInput()
        {
            Console.Write("Guess : ");
            int x;
            while (int.TryParse(Console.ReadLine(), out x) == false)
            {
                Console.WriteLine("Enter an Integer correctly: ");
            }
            return x;
        }

        public static char ValidYesNoInput()
        {
            Console.WriteLine("Do you want to play again? [Y/N]");
            char c;

            while (char.TryParse(Console.ReadLine(), out c) == false || !(c == 'y' || c == 'Y' || c == 'n' || c == 'N'))
            {
                Console.WriteLine("Enter a valid choice: ");
            }
            return c;
        }

        static void Main(string[] args)
        {
                       
            int i,n,g;
            char answer;

            do
            {
                i = 1;
                n = SelectNumber();
                Console.WriteLine("The number to guess is between 1 & 100 included!");
                Console.WriteLine("Please Enter a number between 1 and 100 (inclusive)");
                g = ValidIntegerInput();

                do
                {
                    if (n>g)
                    {
                        Console.WriteLine("Higher!");
                        g = ValidIntegerInput();
                    }
                    else if (n<g)
                    {
                        Console.WriteLine("Lower!");
                        g = ValidIntegerInput();
                    }
                    i++;

                } while (g > n || g < n );

            Console.Write("Congratulation! Good guess! You used {0} guesses.",i);
            
            answer = ValidYesNoInput();

            } while (answer == 'Y' || answer == 'y');

            Console.Write("Thank you for playing!");

            Console.Read();

        }
    }
}
