<<<<<<< HEAD
﻿using System;

namespace M2_L21_Example_4_Detect_Uppercase
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a character:");
            char c;
            bool flag= char.TryParse(Console.ReadLine(),out c);
            
            if (flag == true)  // Can be wrote if (flag) it assume success to be true
            {
                if (char.IsUpper(c))
                // if (c >= 'A' && c <= 'Z') //compare the ASCII value of between capital A & Z --> capital letter ckeck
                // if (c >= 'a' && c <= 'z') //compare the ASCII value of between small a & z --> none capital letter ckeck
                // if (c >= '0' && c <= '9') //compare the ASCII value of between 0 & 9 --> digit check  
                // if (c >= '*'|| c <= '-' || c <= '/' || c <= '%' || c <= '+') //compare the ASCII value for symbol --> symbol check  
                {
                    Console.WriteLine(c + " is in Uppercase letters!");
                }
                else 
                {
                    Console.WriteLine(c + " is not Uppercase letters!");
                }
            }
            else
            {
                Console.WriteLine("Error in input!");
            }

            //Console.WriteLine(c);
            Console.Read();
        }
    }
}
=======
﻿using System;

namespace M2_L21_Example_4_Detect_Uppercase
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a character:");
            char c;
            bool flag= char.TryParse(Console.ReadLine(),out c);
            
            if (flag == true)  // Can be wrote if (flag) it assume success to be true
            {
                if (char.IsUpper(c))
                // if (c >= 'A' && c <= 'Z') //compare the ASCII value of between capital A & Z --> capital letter ckeck
                // if (c >= 'a' && c <= 'z') //compare the ASCII value of between small a & z --> none capital letter ckeck
                // if (c >= '0' && c <= '9') //compare the ASCII value of between 0 & 9 --> digit check  
                // if (c >= '*'|| c <= '-' || c <= '/' || c <= '%' || c <= '+') //compare the ASCII value for symbol --> symbol check  
                {
                    Console.WriteLine(c + " is in Uppercase letters!");
                }
                else 
                {
                    Console.WriteLine(c + " is not Uppercase letters!");
                }
            }
            else
            {
                Console.WriteLine("Error in input!");
            }

            //Console.WriteLine(c);
            Console.Read();
        }
    }
}
>>>>>>> 12f237521d9c77152b306cb7848623a27454fa0f
