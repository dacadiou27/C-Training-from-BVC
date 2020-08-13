using System;

namespace M3_L33_Jagged_Array_inClass_exercise
{
    class Program
    {
        public static void Populate(int[] a) 
        {
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(0, 101);
                Console.Write(string.Format("{0:0.0}", a[i]) + ", ");
            }
            Console.WriteLine("\b\b ");
        }

        public static int[] ArrayInput() 
        {

            Random r = new Random();
            int n = r.Next(5,11);
            
            int[] a = new int[n];

            Populate(a);
            return a;
        }

        static double ComputeSum(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("How many row do you want:");
            int r = int.Parse(Console.ReadLine());

            int[][] jA= new int[r][];

            for (int i = 0; i < r; i++) 
            {
                jA[i] = ArrayInput();
            }
            for (int i = 0; i < r; i++)
            {
                Console.WriteLine("Sum: {0}, Row : {1} ",  ComputeSum(jA[i]), i + 1);
            }
            Console.Read();

        }
    }
}
