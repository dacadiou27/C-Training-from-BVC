using System;
using System.Linq;

namespace M3_L35_Foreach
{
    class Program
    {
        public static bool Perfect(int val) {
            int sum = 0;


            //for (int i = 1; i <= val/2; i++) 
            //{
            //    if (val % i == 0) {
            //        sum = sum + i;
            //    }    
            //}

            //-- convertion using foreach loop--
            foreach (var i in Enumerable.Range(1,val/2+1))
            {
                if (val % i == 0)
                {
                    sum = sum + i;
                }
            }



            if (val == sum) return true;
            return false;
        } 

        static void Main(string[] args)
        {
            /*
            //--Introduciton--
            //int[] x = new int[] { 1, 2, 3, 5, 7, 11, 13, 17, 19 };
            int[] x = { 1, 2, 3, 5, 7, 11, 13, 17, 19 };  // both writtings are valid

            for (int i = 0; i < x.Length; i++) 
            {
                Console.Write(x[i] + " ");
            }

            Console.WriteLine();

            int i = 0;// if you want to use an index you will have to declare it outside of the loop and incremente it manualy inside
            foreach (var item in x) // doesn't use the index // var is use when you want to inffer a data type bases on the data collection (more flexible)
            {
                Console.Write(item + " ");
                i++;
            }
            Console.Read();
            */

            //--Example 1--

            //for (int i = 1; i <= 100; i++) 
            //{
            //    if (Perfect(i)) Console.Write(i + " ");
            //}
            //-- convertion using foreach loop--


            //foreach (var i in Enumerable.Range(2, 100))  // Enumerable.Range(2, 100) create an array staring at 2 and finish at 100
            //{
            //    if (Perfect(i)) Console.Write(i + " ");
            //}

            int[] arr = new int[] { 2, 4, 6, 12, 18, 25, 28, 40, 60, 71, 496, 789, 5000, 8128, 1622 };
            foreach (var item in arr)
            {
                if (Perfect(item)) Console.Write(item + " ");
            }

            Console.Read();

        }
    }
}
