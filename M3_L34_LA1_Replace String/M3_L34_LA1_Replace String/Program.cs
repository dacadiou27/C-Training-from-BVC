using System;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;

namespace M3_L34_LA1_Replace_String
{
    class Program
    {
        public static string MultilineInput() {
            Console.WriteLine("Enter your multiline entry:");
            string input="";
            string sentence;
            do {
                sentence = Console.ReadLine();
                input += sentence +"\n";
            }while (sentence.Length > 0);
        return input;
        }

        public static string ReplaceString(string s)
        {
            Console.WriteLine("Enter string to replace:");
            string stg1 = Console.ReadLine();
            //string stg1 = "Alex";
            Console.WriteLine("Enter string to replace by:");
            string stg2 = Console.ReadLine();
            //string stg2 = "Dany";

            return s = s.Replace(stg1, stg2);

        }

        static void Main(string[] args)
        {

           string s = MultilineInput();
           // string s = "Alex is a good student. Programming is fun for Alex.\n"
           //      + "David, Susan, and Alex are good at C# programming.\n"
           //      + "Alex is ambitious to create his/her career in Software Development.\n";
           //Console.WriteLine(s);
           string sNew = ReplaceString(s);
           Console.WriteLine();
           Console.WriteLine(sNew);
           Console.Read();
        }
    }
}
