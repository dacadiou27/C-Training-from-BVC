using System;

namespace M5_L53_Recursive_LA2_Print_Series
{

    class Program
    {
        static public int Sum=0;
        
        //1+x+x2+x3+x4+ ... xn= sum
        static int Power(int n, ref int x)
        {
            if (n == 0) return 1;
            else return x * Power(n - 1, ref x);
        }

        static void DoSum(int n, ref int x)
        {
            if (n == -1) return;
            else  DoSum(n - 1, ref x);
            //Console.Write(n + " ");
            Sum += Power(n, ref x);
            Console.Write(Power(n, ref x) + "+");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many arguments you want in your sum exp serie :");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter x value :");
            int x = int.Parse(Console.ReadLine());

            DoSum(n, ref x);

            Console.Write("\b="+ Sum);

            Console.Read();


        }
    }
}
