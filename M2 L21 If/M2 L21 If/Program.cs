using System;

namespace M2_L21_If
{
    class Program
    {
        static void Main(string[] args) 

        {
            Console.WriteLine("Emter your name :");
            string name = Console.ReadLine();


            if (name.Length == 0)
            {
                Console.WriteLine("No username was entered.");
            }

            Console.WriteLine("Emter your age :");
            int age = int.Parse(Console.ReadLine());



            if (name == "Mahbub" || name == "Susan" || name == "Dany")
            {
                Console.WriteLine("Hi {0} !", name);
            }
            else
            {
                Console.WriteLine("The user {0} is not registered!", name);
                if (age <= 18)
                {
                    Console.WriteLine("You must be 18 years of age for the registration!");
                }
                else
                {
                    Console.WriteLine("Hi {0}, do you want to register?", name);
                }
            }
        } 
        

        /*static void Main(string[] args)
        {
            Console.WriteLine("Please enter mark: :");
            double mark = double.Parse(Console.ReadLine());

            if (mark >= 90)
            {
                Console.WriteLine("A+");
            }
            else if (mark >= 85 )
            {
                Console.WriteLine("A");
            }
            else if (mark >= 80 )
            {
                Console.WriteLine("A-");
            }
            else
            {
                Console.WriteLine("F");
            }


            /*if (mark >= 90)
            {
                Console.WriteLine("A+");
            }
             if (mark >= 85  && mark < 90)
            {
                Console.WriteLine("A");
            }
            if (mark >= 80 && mark < 85)
            {
                Console.WriteLine("A-");
            }
            if (mark < 80)
            {
                Console.WriteLine("F");
            }*/
        //Console.Read();

        // }


        /*
        static void Main(string[] args)
        {
            string a = "ABCD";
            string b = "AAAAAAAAAAAAAAAAAAAAAAAA";
            //bool c = true;
            //bool d = true;

            if (a.CompareTo(b) == 0)
            {
                Console.WriteLine("Strings are equal!");
            }
            else if (a.CompareTo(b) == 1)
            {
                Console.WriteLine("The first string is bigger than the second");

            }
            //else if (a.CompareTo(b) == -1)
            else
            {
                Console.WriteLine("The second string is bigger than the first");

            }
            Console.Read();
        }
        */

        }
}