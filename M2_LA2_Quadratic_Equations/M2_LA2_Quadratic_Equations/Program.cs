using System;

namespace M2_LA2_Quadratic_Equations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide parametr a :");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Provide parametr b :");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Provide parametr c :");
            float c = float.Parse(Console.ReadLine());

            float discriminant = b*b-4*a*c;

            if (discriminant >= 0 ) 
            {
                if (discriminant > 0)
                {
                    Console.WriteLine("There are two real roots.");
                    double posx = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                    double negx = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                    Console.WriteLine("The real roots are:");
                    Console.WriteLine("r1 = {0} ", posx);
                    Console.WriteLine("r2  {0} ", negx);
                }
                else
                {
                    Console.WriteLine("There is one real root.");
                    float root1 = -b / (2 * a);
                    Console.WriteLine("The real root is r = {0}", root1);
                    
                }
            }
            else 
            {
                Console.WriteLine("There are no real roots.");
            }

            Console.Read();

        }
    }
}
