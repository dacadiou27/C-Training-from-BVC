using System;

namespace M3_L34_LA1_Replace_String_Solution
{
    class Program
    {
        public static string MultilineInput()
        {
            Console.WriteLine("Enter your multiline entry:");
            string input = "";
            string sentence;
            do
            {
                sentence = Console.ReadLine();
                input += sentence + "\n";
            } while (sentence.Length > 0);
            return input;
        }
        public static string ReplaceString(string s)
        {
            Console.WriteLine("Enter string to replace:");
            //string stg1 = Console.ReadLine();
            string stg1 = "Alex";
            Console.WriteLine("Enter string to replace by:");
            //string stg2 = Console.ReadLine();
            string stg2 = "Dany";

            //return s = s.Replace(stg1, stg2); // Method 1 simple but issue

            //Dany's Method
            /*
            //string[] words = s.Split(' ');  // separed base on space
            //string[] words = s.Split(null); // separed base white space
            for (int i = 0; i < words.Length; i++) {
                Console.WriteLine(words[i]);
                //if (words[i].Contains(stg1)) { // blindly replace
                //if (words[i]==stg1) { // look for exact match. "Alex." will be excluded fro example
                        //words[i] = stg2;
                        words[i]=words[i].Remove(0, stg1.Length);
                    words[i]=words[i].Insert(0, stg2);
                    Console.WriteLine("chaged to : " + words[i]);
                    Console.WriteLine();
                }   
            }
            return string.Join(" ", words);
            */

            //method 2

            string[] lines = s.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = ReplaceStringLines(lines[i], stg1, stg2);
            }
            return s = String.Join("\n", lines);

        }

        public static string ReplaceStringLines(string lines, string stg1, string stg2)
        {
            string[] words = lines.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
                if (words[i].Contains(stg1))
                {
                    if (words[i].Length == stg1.Length)
                    {
                        words[i] = stg2;
                    }
                    else if (words[i].IndexOf(stg1) == 0)
                    {
                        if (words[i][stg1.Length] == '.' || words[i][stg1.Length] == ',') 
                        {
                            words[i] = words[i].Replace(stg1, stg2); 
                        }
                    }
                }
                
            }
           return lines = String.Join(" ", words);
        }

        static void Main(string[] args)
        {

            //string s = MultilineInput();
            string s = "Alex is a good student. Programming is fun for Alex.\n"
                 + "David, Susan, and Alex are good at C# programming.\n"
                 + "Alex is ambitious to create his/her career in Software Development.\n";
            Console.WriteLine(s);
            string sNew = ReplaceString(s);
            Console.WriteLine();
            Console.WriteLine(sNew);
            Console.Read();
        }
    }
}
