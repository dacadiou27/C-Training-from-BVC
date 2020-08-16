<<<<<<< HEAD
﻿using System;

class MainClass
{

    static int MaxMin(ref int min, int x, int y, int z)
    {
        int max;

        if (x > y)
        {
            max = x;
            min = y;
        }
        else
        {
            max = y;
            min = x;
        }

        if (max > z)
        {
            if (z < min) min = z;
            return max;
        }
        return z;
    }


    public static void Main(string[] args)
    {

        int x, y, z;
        int max, min = 0;

        // Creare a random class object using the Ramdom Method
        Random robj = new Random();

        // Set the vlaue randomly between 1 and 1000
        x = robj.Next(1, 1000);
        y = robj.Next(1, 1000);
        z = robj.Next(1, 1000);

        Console.WriteLine("x=={0}, y=={1},z=={2}", x, y, z);

        max = MaxMin(ref min, x, y, z);

        Console.WriteLine("Maximun of the 3 is {0}, Minimum of the 3 is {1}", max, min);

        Console.ReadLine();
    }
=======
﻿using System;

class MainClass
{

    static int MaxMin(ref int min, int x, int y, int z)
    {
        int max;

        if (x > y)
        {
            max = x;
            min = y;
        }
        else
        {
            max = y;
            min = x;
        }

        if (max > z)
        {
            if (z < min) min = z;
            return max;
        }
        return z;
    }


    public static void Main(string[] args)
    {

        int x, y, z;
        int max, min = 0;

        // Creare a random class object using the Ramdom Method
        Random robj = new Random();

        // Set the vlaue randomly between 1 and 1000
        x = robj.Next(1, 1000);
        y = robj.Next(1, 1000);
        z = robj.Next(1, 1000);

        Console.WriteLine("x=={0}, y=={1},z=={2}", x, y, z);

        max = MaxMin(ref min, x, y, z);

        Console.WriteLine("Maximun of the 3 is {0}, Minimum of the 3 is {1}", max, min);

        Console.ReadLine();
    }
>>>>>>> 12f237521d9c77152b306cb7848623a27454fa0f
}