<<<<<<< HEAD
﻿using System;

namespace DegreetoRadian
{
    class Program
    {
        const double FACTOR = Math.PI / 180;
        static void DegreeToRadian(double degree) { 
            Console.WriteLine("\"<{0}> degree is <{1}> radian\"", degree,string.Format("{0:0.000000}",degree * FACTOR));
        }

        static void Main(string[] args)
        {
            DegreeToRadian(1);
            Console.ReadLine();

        }
    }
}
=======
﻿using System;

namespace DegreetoRadian
{
    class Program
    {
        const double FACTOR = Math.PI / 180;
        static void DegreeToRadian(double degree) { 
            Console.WriteLine("\"<{0}> degree is <{1}> radian\"", degree,string.Format("{0:0.000000}",degree * FACTOR));
        }

        static void Main(string[] args)
        {
            DegreeToRadian(1);
            Console.ReadLine();

        }
    }
}
>>>>>>> 12f237521d9c77152b306cb7848623a27454fa0f
