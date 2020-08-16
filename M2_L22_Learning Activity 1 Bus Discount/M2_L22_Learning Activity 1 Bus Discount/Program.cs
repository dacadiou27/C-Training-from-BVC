<<<<<<< HEAD
﻿using System;

namespace M2_L22_Learning_Activity_1_Bus_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old is the passenger?");
            int age = int.Parse(Console.ReadLine());

            if (age <= 5)
                 Console.WriteLine("Your ride is free!");
            else if (age >5 && age <= 17)
                Console.WriteLine("Your pass will cost $80.");
            else 
            {
                
                Console.WriteLine("Are you a city employee? Y/N");
                string option = Console.ReadLine();
                bool employee = false;

                if (option == "Y" || option == "y") //Any incorrect answer will default to not be a city employee
                    employee = true;

                Console.WriteLine("What is the income's passenger?");
                int income = int.Parse(Console.ReadLine());

                if (age>=65 && income<=30000 && !employee)
                    Console.WriteLine("Your pass will cost $70.");

                else if (age >= 18 && income <= 15000)
                    Console.WriteLine("Your pass will cost $30.");

                else if (employee) // need to be after the 2 other categories --> less restrictive tha the previous 2 categories
                    Console.WriteLine("Your pass will cost $50.");
                
                else Console.WriteLine("Your pass will cost $100."); //the less restrictive
            }

            Console.Read();

        }
    }
}
=======
﻿using System;

namespace M2_L22_Learning_Activity_1_Bus_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old is the passenger?");
            int age = int.Parse(Console.ReadLine());

            if (age <= 5)
                 Console.WriteLine("Your ride is free!");
            else if (age >5 && age <= 17)
                Console.WriteLine("Your pass will cost $80.");
            else 
            {
                
                Console.WriteLine("Are you a city employee? Y/N");
                string option = Console.ReadLine();
                bool employee = false;

                if (option == "Y" || option == "y") //Any incorrect answer will default to not be a city employee
                    employee = true;

                Console.WriteLine("What is the income's passenger?");
                int income = int.Parse(Console.ReadLine());

                if (age>=65 && income<=30000 && !employee)
                    Console.WriteLine("Your pass will cost $70.");

                else if (age >= 18 && income <= 15000)
                    Console.WriteLine("Your pass will cost $30.");

                else if (employee) // need to be after the 2 other categories --> less restrictive tha the previous 2 categories
                    Console.WriteLine("Your pass will cost $50.");
                
                else Console.WriteLine("Your pass will cost $100."); //the less restrictive
            }

            Console.Read();

        }
    }
}
>>>>>>> 12f237521d9c77152b306cb7848623a27454fa0f
