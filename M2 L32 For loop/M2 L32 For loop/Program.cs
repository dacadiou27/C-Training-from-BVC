using System;
using System.Runtime.InteropServices;

namespace M2_L32_For_loop
{
    class Program
    {

        static int SumFirstNNN(int n) 
        {
            int sum = 0;
            for (int i=1;i<n ;i++ )
            {
                sum = sum + i;
            }
            return sum;
        }

        static int Fibonnaci(int n) 
        {
            // 1 1 2 3 5 8 13 21
            int current = 1;
            int prev = 0;
            int temp;

            for (int i = 1; i < n; i++)
            {
                
                temp = current;
                current = prev + current;
                
                prev = temp;

            }
            return current;

        }

        static void Main(string[] args)
        {
            //Example 1: Triangular Number
            /*
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int triangular;

            Console.WriteLine("First N  triangular numbers are : ");
            for ( int i = 1; i <= n; i++)
            {
                triangular = SumFirstNNN(i);
                Console.Write(triangular + ",");
            }
            Console.Write("\b."); // remove 2 caracracter and add a .
            */

            //Example 2: Fibonnaci
            /*
            Console.WriteLine("Enter Fibonacci index N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                Console.Write(Fibonnaci(i) + ", ");
            }
            Console.Write("\b\b.");
            */

            //Example 3: loops
            // Outter loop manage # of rows
            // Iner loop manage # of column
            //      i=1 i=2 i=3 i=4 i=5
            //  j=1   1   2   3   4   5 
            //  j=2   1   2   3   4   5 
            //  j=3   1   2   3   4   5 
            //  j=4   1   2   3   4   5 
            //  j=5   1   2   3   4   5 

            int n = 5;
            for (int i=1; i<=n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write('1' + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("{0,3}",(i*j)); // {parameter,width}
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int k = 1;
            n = 5;
            for (int i = 1; i <= n; i++)
            {
                
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("{0,3}", (k)); // {parameter,width}
                    k++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            n = 5;
            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= n; j++)
                {
                    Console.Write("{0,3}", (j-1)*n+i); // {parameter,width}
                    
                }
                Console.WriteLine();
                k++;
            }
            Console.WriteLine();

            n = 5;
            for (int i = 1; i <= n; i++) 
            {
                for (int j= 1; j<=i;j++) 
                {
                    Console.Write("{0,3}", i);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
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
                    if (j%2==0) 
                        Console.Write(" 0 ");
                    else
                        Console.Write(" 1 ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; i <= j; j--)
                {
                    if (j % 2 == 0)
                        Console.Write(" 0 ");
                    else
                        Console.Write(" 1 ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if ((i+j) % 2 == 0)
                        Console.Write(" * ");
                    else
                        Console.Write(" $ ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if ((i + j) % 2 == 0)
                        Console.Write(" 1 ");
                    else
                        Console.Write(" 0 ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            n = 5;
            for (int i=1;i<=n;i++) 
            {
                for (  int z = 1; z<=(n-i); z++)
                {
                    Console.Write("   ");
                }
                for (int j = 1; j <= i; j++) 
                {
 
                    Console.Write("{0,3}",i);
                }
                Console.WriteLine();
            }
            Console.Read();

            //int i;
            //Console.Write(" Output of while loop ! ");
            //i = 1;
            //while (i <= 10) 
            //{
            //Console.Write(i + " ");
            //   i++;
            //}

            //Console.Write("\nOutput of a for loop ! ");
            //for (   initializer-optional-  ;   condition    ;  increment/decrement-optional-     )
            //;
            //for (i = 1; i <= 10;i++)
            //{
            //   Console.Write(i + " ");
            //}

            Console.Read();
        }
    }
}
