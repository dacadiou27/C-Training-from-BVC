using System;

namespace Programming_Fundamentals
{   // Declaring a Class
    public class Rectangle
    {
        private double _width;
        private double _height;

        private double SecurityCheck(double val) // private properties to check the input value for the field
        {
            if (val >=0)
            {
                return val;
            }
            else return 0;
        }

        //the following are properties created from the private fields (Alt +Enter)
        //public double Width { get => _width; set => _width = value ; }
        //public double Width { get => _width; set => _width = value > 0 ? value:0; } // applied filtereing if value is >0 use value , if not set value to 0
        public double Width { get => _width; set => _width = SecurityCheck(value); } // call the funciton to do the check instead of the conditional statement 
        //public double Height { get => _height; set => _height = value; }
        public double Height { get => _height; set => _height = SecurityCheck(value); }
        // The following statements define Constructor method.
        public Rectangle(double w, double h)
        {
            Width = w;
            Height = h;
        }

        public double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var r = new Rectangle(3, 2);
            Console.WriteLine(r.GetArea()); // calling GetArea() method of the object
            Console.Read();
        }
    }
}