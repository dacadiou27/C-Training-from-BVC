using System;

namespace M2_L25_Ternary_Operator_examples
{
    class Program
    {
        static int FindMaximun(int x, int y, int z )
        {
            return (x > y ? x : y) > z ? (x > y ? x : y) : z;
        }

        static void Main(string[] args)
        {
            int x, y,z,max;
            Console.WriteLine("Enter fisrt value : ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second value : ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third value : ");
            z = int.Parse(Console.ReadLine());

            max =FindMaximun(x, y, z);
            Console.WriteLine("Hightest : " + max);


            //max = x > y ? x : y;
            //max = max > z ? max : z;
            //max = (x > y ? x : y) > z ? (x > y ? x : y) : z; // replaced max with line above & ()
            //Console.WriteLine("Hightest : " + max);

            /*
            if (x > y)
            {
                if (x > z)
                    max = x;
                else
                    max = z;
            }
            else 
            {
                if (y > z)
                    max = y;
                else
                    max = z;
            }
            Console.WriteLine("Hightest : " + max);
            */


            //int max =FindMaximun(x, y);
            //Console.WriteLine("Hightest : " + max);

            /*
             *             // with ternary oparator "?"
            int max = x > y ?  x : y;
            Console.WriteLine("Hightest : " + max);

             */

            // 9 line of code without the ternary operator
            /*if (x > y)
            {
                Console.WriteLine("Hightest : "+x );
            }
            else 
            {
                Console.WriteLine("Hightest : " + y);
            }
            return;
            */
        }
    }
}
