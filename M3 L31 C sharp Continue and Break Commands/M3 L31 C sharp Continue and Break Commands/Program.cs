using System;

namespace M3_L31_C_sharp_Continue_and_Break_Commands
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            while (j<10) 
            {
                j++; // 3 prevent the infite loop
                // Console.Write(" "); // 2 allow to oberce infinte loop
                //if (j % 2 == 0) continue; // 4 create the table only for odd numbers (when true while lopp not executed)
                //if (j == 1 || j == 4 || j == 7 ) continue; // 5 create the table only for selected numbers (number listed are excluded)
                //if (j == 1 || j == 4 || j == 7) break; // 6 loop stop righ away because of 1
                if ( j == 4 || j == 7) break; // 7 loop stop at 4 because but periodic table of 1/2/3 willb e created
                //if (j == 5) break; // 1 stop the ineer loop as soon j == 5
                //if (j == 5) continue; //2  swill create infinity loop j++ will never be executed
                int i = 1;
                while (i <= 10)
                {
                    Console.Write(i*j + " ");
                    i++;
                }
                //j++; // to be move up to avais infinite loop
                Console.WriteLine();
            }

               Console.Read();
        }
    }
}
