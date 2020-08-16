<<<<<<< HEAD
﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace M3_L33_LA1
{
    class Program
    {
        public static void PopulateArray(int[,] x) 
        {
            Random r = new Random();
            for (int i = 0; i < x.GetLength(0); i++) 
            {
                for (int j = 0; j < x.GetLength(1); j++) 
                {
                    x[i, j] = r.Next(0, 11);
                }
            }
        }


        public static void DisplayArray(int[,] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0,4}",x[i, j]));
                }
                Console.WriteLine();
            }
        }

        public static void Primetest(int[,] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    int n, k, m;
                    int flag=0;
                    n = x[i, j];
                    m = n / 2;
                    for (k = 2; k <= m; k++)
                    {
                        if (n % k == 0) 
                        {
                            flag = 1;
                            break;
                        }
                        else flag = 0;
                    }
                    if (flag == 0) Console.Write(string.Format("{0,4}", x[i, j]));
                    else Console.Write("  --");                   
                }
             Console.WriteLine();   
            }
            
        }

        static void Main(string[] args)
        {
            //Write a C# program that displays only primes from a 2D array. Your program’s inputs are the array size and a random seed.
            //Your program should determine prime elements and display them in their corresponding positions. Non-prime elements should be shown as ‘- -’.

            Console.WriteLine("Enter the number of rows of your Array: ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of columns of your Array: ");
            int c = int.Parse(Console.ReadLine());

            int[,] x = new int[r,c];

            PopulateArray(x);
            Console.WriteLine();
            DisplayArray(x);
            Console.WriteLine();
            Primetest(x);
            
            Console.Read();
        }
    }
}
=======
﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace M3_L33_LA1
{
    class Program
    {
        public static void PopulateArray(int[,] x) 
        {
            Random r = new Random();
            for (int i = 0; i < x.GetLength(0); i++) 
            {
                for (int j = 0; j < x.GetLength(1); j++) 
                {
                    x[i, j] = r.Next(0, 11);
                }
            }
        }


        public static void DisplayArray(int[,] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0,4}",x[i, j]));
                }
                Console.WriteLine();
            }
        }

        public static void Primetest(int[,] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    int n, k, m;
                    int flag=0;
                    n = x[i, j];
                    m = n / 2;
                    for (k = 2; k <= m; k++)
                    {
                        if (n % k == 0) 
                        {
                            flag = 1;
                            break;
                        }
                        else flag = 0;
                    }
                    if (flag == 0) Console.Write(string.Format("{0,4}", x[i, j]));
                    else Console.Write("  --");                   
                }
             Console.WriteLine();   
            }
            
        }

        static void Main(string[] args)
        {
            //Write a C# program that displays only primes from a 2D array. Your program’s inputs are the array size and a random seed.
            //Your program should determine prime elements and display them in their corresponding positions. Non-prime elements should be shown as ‘- -’.

            Console.WriteLine("Enter the number of rows of your Array: ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of columns of your Array: ");
            int c = int.Parse(Console.ReadLine());

            int[,] x = new int[r,c];

            PopulateArray(x);
            Console.WriteLine();
            DisplayArray(x);
            Console.WriteLine();
            Primetest(x);
            
            Console.Read();
        }
    }
}
>>>>>>> 12f237521d9c77152b306cb7848623a27454fa0f
