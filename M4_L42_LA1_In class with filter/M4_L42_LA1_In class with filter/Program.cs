using System;

namespace M4_L42_LA1_In_class_with_filter
{
    public class InputOdds
    {
        //private field definition
        private int _x;

        //test field
        private int OddCheck(int val) {
            if (val % 2 != 0) return val;
            else return val += 1;
        }

        //public properties by encapsulating the fields
        //public int X { get => _x; set => _x = OddCheck(value); }
       

        public InputOdds() //Default Constructor
        {
            X = -998;
        }
        public InputOdds(int x) // Constructor with parameters
        {
            X = x ;
        }
              
        // The display method
        public void DisplayOdds()
        {
            Console.WriteLine("\nthe number is " + X);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {   // ToDo: Instatiation object using default constructor and initialize fields by accessing them
            var x1 = new InputOdds();
            // ToDo: object initialization using parameterized constructor
            var x2 = new InputOdds(26);
            // ToDo: initialization using object initializers
            var x3 = new InputOdds() { X=24 };
            // initialization by accessing field values
            var x4 = new InputOdds();
            x4.X = 22;

            x1.DisplayOdds();
            x2.DisplayOdds();
            x3.DisplayOdds();
            x4.DisplayOdds();

            Console.Read();
        }
    }
}
