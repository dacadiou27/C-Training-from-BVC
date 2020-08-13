using System;

namespace M2_L32_For_loop_in_class
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 5;
            for ( int i = 1; i <= n; i++)
            {
                for (int  z = 1; z <= (n - i); z++)
                {
                    Console.Write("   ");
                }
                for (int  j = 1; j <= i; j++)
                {

                    Console.Write("{0,3}", j);
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            n = 5;
            for (int i = 1; i <= n; i++)
            {                
                for (int j = 1; j <= i; j++)
                {
                    if((j+i)%2==0)
                        Console.Write(" * ");
                    else
                        Console.Write(" $ ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            n = 8;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1 || j == i || i == n)
                        Console.Write(" * ");
                    else { 
                        
                        if (j % 2 == 0)
                            Console.Write(" 1 ");
                        else if (j % 2 == 1)
                            Console.Write(" 0 ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            n = 8;
            for (int i = 1; i <= n; i++)
            {
                for (int z = 1; z <= (n - i); z++)
                {
                    Console.Write("   ");
                }
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1 || j == i || i == n)
                        Console.Write(" * ");
                    else
                    {

                        if (j % 2 == 0)
                            Console.Write(" 1 ");
                        else if (j % 2 == 1)
                            Console.Write(" 0 ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            n = 8;
            for (int i = 1; i <= n; i++)
            {
                for (int z = 1; z <= (n - i); z++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {

                    Console.Write("{0,4}", j);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.Read();         
        }
    }
}
