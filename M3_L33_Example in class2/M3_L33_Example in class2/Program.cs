using System;
using System.ComponentModel.DataAnnotations;

namespace M3_L33_Example_in_class2
{
    class Program
    {
        public static void PopulateArray(int[] x)
        {
            Random number = new Random();
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = number.Next(1,11);
            }

        }

        public static void Display (int[] x) 
        {
            Console.WriteLine("\nArray Values : ");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }
        }

        public static void SlideValues(int[] x)
        {
            Console.WriteLine("\n\n--Reformated Array Values--");
            int k = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == 0)
                {
                    k++;
                    for (int j = i; j < x.Length-k; j++)
                    {
                        x[x.Length-1] = 0;
                        x[j] = x[j + 1];
                        
                    }  
                }
            }

        }
        public static void Cleaning(int[] x) 
        {
            Console.WriteLine("\n\nEnter a number to eliminate from the array: ");
            int elim = int.Parse(Console.ReadLine());

            for (int i = 0; i < x.Length; i++)
            {
                if(x[i] == elim) x[i] = 0;
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] x = new int[n];

            PopulateArray(x);
            Display(x);
            Cleaning(x);
            Display(x);
            SlideValues(x);
            Display(x);


            Console.Read();
        }
    }
}
