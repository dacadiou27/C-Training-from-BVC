using System;
using System.ComponentModel.DataAnnotations;

namespace M3_L33_Multidimentional_Array_in_C
{
    class Program
    {
        public static void PopulateArray(int[] x) 
        {
            Random r = new Random();
            for (int i = 0; i <= x.Length-1; i++)
            {
                x[i] = r.Next(1, 101);
            }
        }

        public static void PopulateArray(int[,] x)
        {
            Random r = new Random();
            for (int i = 0; i < x.GetLength(0) ; i++)
            {
                for(int j=0;j < x.GetLength(1) ; j++) 
                { 
                    x[i,j] = r.Next(1, 101);
                }
            }
        }

        public static void PopulateArrayChart(int[,] x)
        {
            Random r = new Random();
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    //x[i, j] = (int)Math.Pow(i + 1, j);//r.Next(1, 101);
                    x[i, j] = i * j;
                }
            }
        }

        public static void DiplayArray(int[] x)
        {
            for (int i = 0; i < x.Length-1; i++)
            {
                Console.Write(x[i] + " ");
            }
        }

        public static void DiplayArray(int[,] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++) 
                { 
                    Console.Write(String.Format("{0,4}", x[i,j]));
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[] x = new int[10];

            //int[,] y = new int[2,20];

            //Late initialization
            int[,] y;
            Console.WriteLine("How many rows:");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("How many column:");
            int c = int.Parse(Console.ReadLine());
            y = new int[r, c];

            //int[,]q ={1 ,2 ,3 };

            //int[,]p={{1,2},{3,4},{5,6}};

            //PopulateArray(x);

            //PopulateArray(y);
            PopulateArrayChart(y);

            //DiplayArray(x);

            DiplayArray(y);

            // Two-dimensional array. row & column
            //int[,] a2D = new int[,] { { 1, 1 }, { 2, 4 }, { 3, 9 }, { 4, 16 } };
            //Console.WriteLine(a2D.GetLength(0) + "--> Dim 0");
            //Console.WriteLine(a2D.GetLength(1) + "--> Dim 1");
            //Console.WriteLine(a2D.Rank+ "--> return number of dimention"); // return number of dimention

            // 3-dimensional array. page & row & column
            // 4-dimensional array. book & page & row & column

            Console.Read();
        }
    }
}
