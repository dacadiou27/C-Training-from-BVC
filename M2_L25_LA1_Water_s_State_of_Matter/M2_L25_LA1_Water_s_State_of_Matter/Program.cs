using System;

namespace M2_L25_LA1_Water_s_State_of_Matter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What temperature are you studying the water's state?");
            int temp = int.Parse(Console.ReadLine());

            // solution using single line Ternary (?) operator
            //string status = temp < 0 ? "ice" : "other";
            //string other  = temp <100 ? "liquid" : "vapor";
            //(temp < 100 ? "liquid" : "vapor")

            string status = temp < 0 ? "ice" : (temp < 100 ? "liquid" : "vapor");

            Console.WriteLine("The water's state is {0} !", status);

            // solution using conditional if statements
            /*
            if (temp < 0)
                Console.WriteLine("The water's state is ice!");
            else if (temp >= 0 && temp <100)
                Console.WriteLine("The water's state is liquid!");
            else 
                Console.WriteLine("The water's state is vapor!");
            */

            Console.Read();
        }
    }
}
