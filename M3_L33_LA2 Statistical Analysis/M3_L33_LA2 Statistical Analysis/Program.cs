using System;
using System.ComponentModel;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;

namespace M3_L33_LA_Show_Frequency_Histogram_from_an_Integer_Array
{
    class Program
    {
        public static void Display(int[] x)
        {
            Console.WriteLine("Element of the Array : ");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }
        }

        public static void Frequency(int[] x, int[] h)
        {
            int value;
            int freq = 0;
            for (int i = 0; i < x.Length; i++)
            {
                value = x[i];
                freq = h[value];
                h[value] = freq + 1;
            }
        }

        public static float Average(int[] x) 
        {
            float sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum = sum+ x[i];
            }

            return sum / x.Length;
        }

        public static int Mode(int[] h)
        {
            int max = h[0];
            for (int i = 1; i < h.Length; i++)
            {
                if (max < h[i])
                {
                    max = h[i];
                }
            }
            return max;
        }

        public static void Histogram(int[] h)
        {
            Console.WriteLine("START");

            for (int i = 0; i < h.Length; i++)
            {
                int n = h[i];

                for (int j = 0; j < n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("END");
        }


        public static void Median(int[] x) 
        {
            Array.Sort(x);
            Display(x);
            Console.Write("sorted");

            if (x.Length % 2 == 0)
            {
                float m = (x[x.Length / 2 ] + x[(x.Length +1)/ 2]) / 2;
                Console.WriteLine("\nThe Median is : {0}", m);
            }
            else 
            {
                Console.WriteLine("\nThe Median is : {0}", x[(x.Length + 1)/2]);
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Random Seed: ");
            int s = int.Parse(Console.ReadLine());

            int[] x = new int[n];

            Random r = new Random(s);
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = r.Next(0, 5);
            }

            Display(x);

            int[] histogram = new int[5];

            Frequency(x, histogram);

            Console.WriteLine("\nPrint of histogram Array : ");

            Display(histogram);

            Console.WriteLine("\nPrint of histogram  : ");

            Histogram(histogram);

            Console.WriteLine("\nAverage  :  {0}", Average(x));

            Console.WriteLine("\nMode  :  {0}", Mode(x));

            Median(x);
            
            Console.Read();

            

        }
    }
}
