using System;


namespace HelloWorld_DC                     // Package name
{ 
    class Program                           // Class name
    {  
       /* 
        * This a multiple line comment
        * test
        */
        static int  Display(int val)
        {
            return val * val;
        }


        static void Main(string[] args)     // Start Method --> Displaying message in console retrun no output "void"
            
        {
            Console.WriteLine("Hello Dany Cadiou!");    // this is a statement which uses a Method called "WriteLine" fron the Class "Console"
            
            Console.Write("You are having fun.");       // this is a statement which uses a Method called "Write" fron the Class "Console"
            
            Console.Write("It is time to go for Diner!!!");

            Console.Write("Square of 5 is" + Display(5));
            
            Console.Read();                             // this is a statement which uses a Method called "Read" fron the Class "Console" one character - here stop program from exiting

            //int input=Console.Read();                             // this is a statement which uses a Method called "Read" fron the Class "Console" first character and strore it as its ASCII value

            //string input=Console.ReadLine();                         // this is a statement which uses a Method called "Read" fron the Class "Console" one characted at the full line

            //Console.Wrtite(input);
        }
    }
}
