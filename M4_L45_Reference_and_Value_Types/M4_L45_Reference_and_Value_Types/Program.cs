using Microsoft.VisualBasic.CompilerServices;
using System;

namespace M4_L45_Reference_and_Value_Types
{
    class Program
    {

        public static void Swap(int x, int y)
        {
            int t;
            t = x;
            x = y;
            y = t;
            Console.WriteLine("from swap function: Value of x={0} and value of y={1}", x, y);

        }

        public static void Swap(ref int x, ref int y)
        {
            int t;
            t = x;
            x = y;
            y = t;
            Console.WriteLine("from ref swap function: Value of x={0} and value of y={1}", x, y);

        }

        public static void Square(int[] a)
        {
            a[0] = a[0] * a[0];
            a[1] = a[1] * a[1];
        }

        public static void RefArray(ref int[] a)
        {
            a = new int[]{ 5,25};
        }

        //public static void ChangePin(ref int pin)
        //public static void ChangePin(out int pin) //use of out keyword - make variable not readable

        public static void ChangePin(in int pin) //use of in keyword - make the variable readable only (cannot change)
        {
            Console.WriteLine("Enter new pin");
            Console.WriteLine(pin) //can not be use with "out" keyword it is inpossible to access pin variable (not readable)
            //pin = int.Parse(Console.ReadLine()); // cannot with in key word
        }

        static void Main(string[] args)
        {
            int x=1;
            int y=7;

            Console.WriteLine("from main function before swap: Value of x={0} and value of y={1}", x, y);
            Swap(x, y);
            Console.WriteLine("from main function after swap: Value of x={0} and value of y={1}", x, y);
            Swap(ref x, ref y);
            Console.WriteLine("from main function after ref swap: Value of x={0} and value of y={1}", x, y);
            int[] a = {2,7};
            Console.WriteLine("from main function before Square : a[0] = {0} and a[1] ={1}", a[0], a[1]);
            Square(a);
            Console.WriteLine("from main function after Square : a[0] = {0} and a[1] ={1}", a[0], a[1]);
            RefArray(ref a);
            Console.WriteLine("from main function after RefArray : a[0] = {0} and a[1] ={1}", a[0], a[1]);

            int pin = 1234;
            string c;

            do {
                Console.WriteLine("EnterPin");
                int currentpin = int.Parse(Console.ReadLine());
                if (currentpin == pin)
                {
                    Console.WriteLine("Correct pin entered");
                    //ChangePin(ref pin);
                    //ChangePin(out pin); //nedd to chage the out keyword to make the variable not readable
                    ChangePin(in pin); //nedd to chage the in keyword to make the variable read only (not changes)
                }
                
                else 
                {
                    Console.WriteLine("Inorrect pin entered");
                }
                Console.WriteLine("Change Again?: Y/N");
                c = Console.ReadLine();
            } while ( c== "y" || c =="Y");

            Console.Read();
        }
    }
}
