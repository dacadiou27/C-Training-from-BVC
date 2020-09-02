using System;

namespace M5_L53_Recursive_EX_Inclass
{

    /*
     
                   *
                 * *
               * * *
             * * * *
           * * * * *
           
     */
    class Pattern
    {
        private int _lines;
        public Pattern(int n)
        {
            _lines = n;
            DisplayTriangle(_lines);
        }
        public void DisplaySpace(int n)
        {
            if (n == 0) return;
            Console.Write("  ");
            DisplaySpace(n - 1);
        }
        public void DisplayTriangle(int n)
        {
            if (n == 0) return;
            //Console.Write("* ");

            DisplayTriangle(n - 1);
            DisplaySpace(_lines - n);
            DisplayLine(n);
            Console.WriteLine();
        }
        public void DisplayLine(int n)
        {
            if (n == 0) return;
            Console.Write("* ");
            DisplayLine(n - 1);
        }
    }


    class Program
    {
        static void Main()
        {
            Pattern obj = new Pattern(15);
            Console.Read();
        }
    }


}