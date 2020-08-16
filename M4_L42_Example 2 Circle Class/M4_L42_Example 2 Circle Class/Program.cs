using System;

namespace Programming_Fundamentals
{
    public class Circle
    {
        //private fields
        private double _centreX = 0.0;
        private double _centreY = 0.0;
        private double _radius = 0.0;


        //public properties by encapsulating the fields
        public double CentreX { get => _centreX; set => _centreX = value; }
        public double CentreY { get => _centreY; set => _centreY = value; }
        public double Radius { get => _radius; set => _radius = value; }


        //overloaded constructor methods
        public Circle() //Default Constructor
        {
            CentreX = CentreY = Radius = 0.0;
        }
        public Circle(double x, double y, double r) // Constructor with parameters
        {
            CentreX = x;
            CentreY = y;
            Radius = r;
        }


        public void DisplayCircleParams()
        {
            Console.Write("{0}, Centre=({1},{2}), Radius={3}\n", (this.GetType() + " Hash Code:" + this.GetHashCode()), CentreX, CentreY, Radius);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Circle();  // object initialization using default constructor
            var c2 = new Circle(1, 2, 3);   // object initialization using parameterized constructor
            var c3 = new Circle { CentreX = 1, CentreY = 2, Radius = 3 };   // initialization using object initializers
            var c4 = new Circle();
            c4.CentreX = 1; // initialization by accessing field values
            c4.CentreY = 2;
            c4.Radius = 3;

            c1.DisplayCircleParams();
            c2.DisplayCircleParams();
            c3.DisplayCircleParams();
            c4.DisplayCircleParams();
            Console.Read();

        }
    }
}