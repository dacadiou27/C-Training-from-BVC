using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace M5_L53_Recursive_LA3_Print_Sums
{
    class Program
    { 
        static public string Space = "";
        public static void PrintList(List<int> x)
        {
            foreach (var item in x)
            {
                Console.Write(string.Format("{0,4}",item));
            }
            Space = Space + "  ";
        }

        public static void SumList(List<int> x)
        {


            if (x.Count >= 1)
            {
                Console.Write(Space);
                PrintList(x); 
            }
            Console.WriteLine();

            List<int> sumList = new List<int>();
            for(int i=0;i<x.Count-1;i++)
            {
                sumList.Add(x[i] + x[i + 1]);
            }

            if (sumList.Count >= 1)
            {
                
                SumList(sumList);
                Console.WriteLine();
                
            }
        }

                
        static void Main(string[] args)
        {
            List<int> x = new List<int>() {1,3,5,2,4};
            SumList(x);
            Console.Read();
        }
    }
}
