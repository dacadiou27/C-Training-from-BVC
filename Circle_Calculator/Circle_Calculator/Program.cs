<<<<<<< HEAD
﻿using System;
using System.Reflection.Metadata.Ecma335;

namespace Circle_Calculator
{
    class Program
    {

        const double PI = 3.14;
        static double Circumference(double myRadius)
        {
            double C;
            C = 2 * PI * myRadius;
            //Console.WriteLine(C);
            return C;
        }

        static double Area(double myRadius)
        {
            double A;
            A = PI * myRadius * myRadius;
            //Console.WriteLine(A);
            return A;
        }

        static void Main(string[] args)
        {
            double myRadius;
            Console.WriteLine("Could you please write a radius?");
            myRadius = double.Parse(Console.ReadLine());

            Console.WriteLine("The circumference of you circle will be " + Circumference(myRadius));
            Console.WriteLine("The area of you circle will be " + Area(myRadius));
            //Or
            Console.WriteLine("For a radus of {0} the circumference of you circle will be {1} and the area will be {2}",myRadius,string.Format({"0:0.00"}, Circumference(myRadius)), string.Format({"0:0.00"}, Area(myRadius)));
            Console.ReadLine();
        }
    }
}
=======
﻿using System;
using System.Reflection.Metadata.Ecma335;

namespace Circle_Calculator
{
    class Program
    {

        const double PI = 3.14;
        static double Circumference(double myRadius)
        {
            double C;
            C = 2 * PI * myRadius;
            //Console.WriteLine(C);
            return C;
        }

        static double Area(double myRadius)
        {
            double A;
            A = PI * myRadius * myRadius;
            //Console.WriteLine(A);
            return A;
        }

        static void Main(string[] args)
        {
            double myRadius;
            Console.WriteLine("Could you please write a radius?");
            myRadius = double.Parse(Console.ReadLine());

            Console.WriteLine("The circumference of you circle will be " + Circumference(myRadius));
            Console.WriteLine("The area of you circle will be " + Area(myRadius));
            //Or
            Console.WriteLine("For a radus of {0} the circumference of you circle will be {1} and the area will be {2}",myRadius,string.Format({"0:0.00"}, Circumference(myRadius)), string.Format({"0:0.00"}, Area(myRadius)));
            Console.ReadLine();
        }
    }
}
>>>>>>> 12f237521d9c77152b306cb7848623a27454fa0f
