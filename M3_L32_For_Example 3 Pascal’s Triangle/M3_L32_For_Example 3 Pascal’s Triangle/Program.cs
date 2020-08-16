using System;

namespace M3_L32_For_Example_3_Pascal_s_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("How many lines?");
            //int n = int.Parse(Console.ReadLine());
            int i, j;
            int n = 7;
            int prevTerm = 1;
             
            for (j = 1; j <= n ; j++)
            {
                for (i = 1; i <= (n-j); i++)
                {
                    Console.Write("  ");
                }
                for (i = 1; i <= j; i++) 
                {
                    if (i == 1 || i == j)
                    {
                        //Console.Write(String.Format("{0,4}", 1));
                        prevTerm = 1;
                       }

                    else
                    { 
                    //Console.Write(String.Format("{0,4}",  prevTerm ));
                    prevTerm= (j - i + 1) * prevTerm / (i - 1);
                    }
                    Console.Write(String.Format("{0,4}", prevTerm));
                }
                Console.WriteLine();
            }

            Console.Read();

        }
    }
}
