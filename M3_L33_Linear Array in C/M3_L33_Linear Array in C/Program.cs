using Microsoft.VisualBasic.CompilerServices;
using System;

namespace M3_L33_Linear_Array_in_C
{
    class Program
    {

        public static void Display(int x)
        {
            x = x * 2;
            Console.WriteLine("y inside the function is  {0}",x);
        }

        public static void Display(int [] x) { // 2 function with the same name "overloading" / the system will chose the functoin compatible with the data type array vs integer here

            //x[0] = 100;
            Console.WriteLine("Inside the function Array Values are as follow : ");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            } 
        }

        static void Main(string[] args)
        {
            
            
            int [] x = new int [100];
            Random r = new Random(1);

            for (int i=0; i<100; i++) { 
            x [i]=r.Next(1, 101);
             }
            Display(x);
            Array.Sort(x);
            Console.WriteLine(" \n Sorted array: ");
            Display(x);

            Array.Reverse(x);
            Console.WriteLine(" \n Reversed array: ");
            Display(x);

            //Array.Clear(myArray, startIndex, lastIndex);
            Array.Clear(x, 0, 10);
            Console.WriteLine(" \n Cleared first 10 values of the  array: ");
            Display(x);

            //Console.WriteLine("Inside Main Array Values are as follow : ");
            //for (int i = 0; i < x.Length; i++)
            //{
            //    Console.Write(x[i] + " ");
            //}

            //int y = 3;
            //Display(y);
            //Console.WriteLine("y inside the main is {0}",y);


            int[] myArray = new int[7];
            string[] studentsName = new string[3] { "David", "Olivia", "Jackson" }; // initialize size and gives values
            double[] battingScores = { 50.5, 99.25, 200.0, 75.6 };// initialize values

            Console.Read();
        }
    }
}
