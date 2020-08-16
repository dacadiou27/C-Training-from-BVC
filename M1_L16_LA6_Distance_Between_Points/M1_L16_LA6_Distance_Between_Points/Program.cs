using System;

namespace M1_L16_LA6_Distance_Between_Points
{
    class Program
    {
        public static void Collect(ref float x1, ref float x2, ref float y1, ref float y2, ref float z1, ref float z2)
        {

            Console.WriteLine("x1 value ?");
            x1 = float.Parse(Console.ReadLine());

            Console.WriteLine("y1 value ?");
            y1 = float.Parse(Console.ReadLine());

            Console.WriteLine("z1 value ?");
            z1 = float.Parse(Console.ReadLine());

            Console.WriteLine("x2 value ?");
            x2 = float.Parse(Console.ReadLine());

            Console.WriteLine("y2 value ?");
            y2 = float.Parse(Console.ReadLine());

            Console.WriteLine("z2 value ?");
            z2 = float.Parse(Console.ReadLine());
        }

        public static float Distance(ref float x1, ref float x2, ref float y1, ref float y2, ref float z1, ref float z2)
        {
            float d;
            d = (float)Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            return d;
        }
        static void Main(string[] args)
        {
            float x1 = 0;
            float x2 = 0;
            float y1 = 0;
            float y2 = 0;
            float z1 = 0;
            float z2 = 0;
            float zerro = 0;

            Collect(ref x1, ref x2, ref y1, ref y2, ref z1, ref z2);
            Console.WriteLine("La distance between the 2 point is {0}.", string.Format("{0:0.00}", Distance(ref x1, ref x2, ref y1, ref y2, ref z1, ref z2)));
            Console.WriteLine("La distance from the origin for the fist point is {0}.", string.Format("{0:0.00}", Distance(ref x1, ref zerro, ref y1, ref zerro, ref z1, ref zerro)));
            Console.WriteLine("La distance from the origin for the second point is {0}.", string.Format("{0:0.00}", Distance(ref zerro, ref x2, ref zerro, ref y2, ref zerro, ref z2)));
            Console.ReadLine();
        }
    }
}
