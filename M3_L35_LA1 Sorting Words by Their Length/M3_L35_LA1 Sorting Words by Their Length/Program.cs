using System;
using System.Globalization;
using System.Linq;

namespace M3_L35_LA1_Sorting_Words_by_Their_Length
{
    class Program
    {

        public static void Sort(string[] words) 
        {
            string temp;
            /*
            for (int i = 0; i < words.Length; i++) 
            {
                for (int j = i + 1; j < words.Length; j++) 
                {
                    if (string.Compare(words[i], words[j]) > 0) 
                    {
                        temp = words[i];
                        words[i] = words[j];
                        words[j] = temp;
                    }
                }
            }
            */
            foreach(var i in Enumerable.Range(0,words.Length))
            //for (int i = 0; i < words.Length; i++)
            {
                foreach (var j in Enumerable.Range(i, words.Length-(i+1)))
                //for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i].Length > words[j].Length)
                    {
                        temp = words[i];
                        words[i] = words[j];
                        words[j] = temp;
                    }
                    else if (words[i].Length == words[j].Length)
                    {
                        if (string.Compare(words[i], words[j]) > 0)
                        {
                            temp = words[i];
                            words[i] = words[j];
                            words[j] = temp;
                        }
                    } 
                }
            }
        }

        static void Main(string[] args)
        {
            string str = "Alex karin and khan is good with programming";

            string[] words = str.Split(" ");

            Sort(words);

            foreach (var item in words)
            {
                Console.WriteLine(item + " ");
            }

            Console.Read();
        }
    }
}
