using System;
using System.Xml.Schema;

namespace M3_L33_Jagged_Array_in_C
{
    class Program
    {
        static void DisplayMulti(int[,] x) 
        {
            int i, j;
            for (i = 0; i < x.GetLength(0); i++) 
            {
                for (j = 0; j < x.GetLength(1); j++)
                { 
                    Console.Write(x[i, j] + " ");
                }
            Console.WriteLine();
            }
        
        }

        static void DisplayMulti(int[][] x)
        {
            int i, j;
            for (i = 0; i < x.GetLength(0); i++)
            {
                for (j = 0; j < x[i].GetLength(0); j++)
                {
                    Console.Write(x[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] x = { {1,2,3},{2,2,2 },{3,3,3} }; // mutidimentional array declaration
            int[][] z = { new[]{ 1, 2 }, new[]{ 2, 2, 2,2 }, new[]{ 3, 3, 3 ,3,3,3} }; // Jagged array declaration

            Console.WriteLine("Content of 2D array :");
            DisplayMulti(x);
            Console.WriteLine("Content of 2D Jagged array :");
            DisplayMulti(z);

            //int[,] y; // no memory allocated

            ///int[][] jA;// no memory allocated

            //int[][] jag2D = new int[4][];// partial memory allocation

            //ja2D[0] = new int[1]; //first row with one element
            //ja2D[1] = new int[5]; //second row with 5 elements
            //ja2D[2] = new int[7]; //second row with 7 elements

            Console.Read();
        }
    }
}
