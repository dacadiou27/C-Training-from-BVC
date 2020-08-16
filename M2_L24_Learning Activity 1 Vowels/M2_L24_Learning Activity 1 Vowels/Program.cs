<<<<<<< HEAD
﻿using System;

namespace M2_L24_Learning_Activity_1_Vowels
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a lowercase letter from the english alphabet");

            char letter;   
            bool charac= char.TryParse(Console.ReadLine(),out letter);

            if (charac)
            {
                letter = char.ToLower(letter);
                switch(letter)
                {
                    case 'a':
                        Console.Write("The letter entered is the vowel 'a'");
                    break;
                    case 'e':
                        Console.Write("The letter entered is the vowel'e'");
                    break;
                    case 'i':
                        Console.Write("The letter entered is the vowel'i'");
                    break;
                    case 'o':
                        Console.Write("The letter entered is the vowel'o'");
                    break;
                    case 'u':
                        Console.Write("The letter entered is the vowel 'u'");
                    break;
                    case 'y':
                        Console.Write("The letter entered is 'y', this is sometimes only a vowel!");
                    break;
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'f':
                    case 'g':
                    case 'h':
                    case 'j':
                    case 'k':
                    case 'l':
                    case 'm':
                    case 'n':
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                    case 't':
                    case 'v':
                    case 'w':
                    case 'x':
                    case 'z':
                        Console.Write("The letter entered is a lower case consonant!");
                    break;
                    default:
                        Console.Write("The letter is not a lower case letter or a letter at all!!!");
                    break;
                
                }


            }
            else { 
                    Console.Write("What has been entered is not a character!");
            }
            Console.Read();
        }
    }
}
=======
﻿using System;

namespace M2_L24_Learning_Activity_1_Vowels
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a lowercase letter from the english alphabet");

            char letter;   
            bool charac= char.TryParse(Console.ReadLine(),out letter);

            if (charac)
            {
                letter = char.ToLower(letter);
                switch(letter)
                {
                    case 'a':
                        Console.Write("The letter entered is the vowel 'a'");
                    break;
                    case 'e':
                        Console.Write("The letter entered is the vowel'e'");
                    break;
                    case 'i':
                        Console.Write("The letter entered is the vowel'i'");
                    break;
                    case 'o':
                        Console.Write("The letter entered is the vowel'o'");
                    break;
                    case 'u':
                        Console.Write("The letter entered is the vowel 'u'");
                    break;
                    case 'y':
                        Console.Write("The letter entered is 'y', this is sometimes only a vowel!");
                    break;
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'f':
                    case 'g':
                    case 'h':
                    case 'j':
                    case 'k':
                    case 'l':
                    case 'm':
                    case 'n':
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                    case 't':
                    case 'v':
                    case 'w':
                    case 'x':
                    case 'z':
                        Console.Write("The letter entered is a lower case consonant!");
                    break;
                    default:
                        Console.Write("The letter is not a lower case letter or a letter at all!!!");
                    break;
                
                }


            }
            else { 
                    Console.Write("What has been entered is not a character!");
            }
            Console.Read();
        }
    }
}
>>>>>>> 12f237521d9c77152b306cb7848623a27454fa0f
