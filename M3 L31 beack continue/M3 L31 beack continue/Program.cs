<<<<<<< HEAD
﻿using System;

namespace M3_L31_beack_continue
{
    class Program
    {
        static int Prime(int n)
        {
            int i = 2;
            if (n == 1) return 0;
            while (i <=Math.Sqrt (n))
            {
                if (n % i == 0) return 0;
                i++;
            }
            return 1;
        }

        static int RandomNumber ()
        {
            Random obj = new Random();
            int j = obj.Next(1, 101);
            return j;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number of of prime numbers that you want to find : ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            //while (count <= n)
            do
            {
                int number = RandomNumber();

                if (Prime(number) == 0) 
                //if (number%2==0 ) // for odd numbers
                {
                    continue;
                }
                count++;
                Console.WriteLine("This is the {0} number - {1} was prime.",count, number );
                
            } while (count < n) ;

                Console.Read();

        }
    }
}
=======
﻿using System;

namespace M3_L31_beack_continue
{
    class Program
    {
        static int Prime(int n)
        {
            int i = 2;
            if (n == 1) return 0;
            while (i <=Math.Sqrt (n))
            {
                if (n % i == 0) return 0;
                i++;
            }
            return 1;
        }

        static int RandomNumber ()
        {
            Random obj = new Random();
            int j = obj.Next(1, 101);
            return j;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number of of prime numbers that you want to find : ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            //while (count <= n)
            do
            {
                int number = RandomNumber();

                if (Prime(number) == 0) 
                //if (number%2==0 ) // for odd numbers
                {
                    continue;
                }
                count++;
                Console.WriteLine("This is the {0} number - {1} was prime.",count, number );
                
            } while (count < n) ;

                Console.Read();

        }
    }
}
>>>>>>> 12f237521d9c77152b306cb7848623a27454fa0f
