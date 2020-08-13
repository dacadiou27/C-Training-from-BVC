using System;
using System.Runtime.ConstrainedExecution;
using System.Transactions;

namespace M2_LA21_Example_5_Match_Name_in_All_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            string refname = "dany";    //DANY/Dany/dAny/etc...
            Console.WriteLine("Enter a Name :");
            string inputName = Console.ReadLine();

            if (refname == inputName.ToLower())
            {
                Console.WriteLine("Name matched!");
                Console.WriteLine("Welcome " + char.ToUpper(refname[0]) + refname.Substring(1));
            }
            else 
            {
                Console.WriteLine("The input is not a match!");
            }
        }
    }
}
