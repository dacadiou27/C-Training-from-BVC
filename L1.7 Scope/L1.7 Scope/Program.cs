using System;

namespace L1._7_Scope
{
    public class GlocalVar 
    {
        public static int x = 13;// Global varialble availalble to all the classes
        public static int y = 100; //don;t forget the public keyword
    }
    class Test
    {
        int x; //"Local to the Test class" keyword static not mandatory not in main class (where main function is)
        public void Display(int y) 
        {
            Console.WriteLine(x * y);
            Console.WriteLine(GlocalVar.x); //access from the Globalvar class
        }
    }
    class Program
        {
        // any variable or function in the main class should have static or const keyword
        const float PI = 3.14159f;
        static int x = 7;//"Local to the Program class"
        static void Dispay(int val)
        {
            Console.WriteLine(PI);
            Console.WriteLine(x);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(Program.x); //variable x from the class
            Console.WriteLine(GlocalVar.x); //access from the Globalvar class
            
            int x = 1;
            Console.WriteLine(x);//local variable
            if (x == 1) {
            
            }

        }
    }
}
