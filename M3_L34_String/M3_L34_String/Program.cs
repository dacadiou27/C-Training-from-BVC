using System;

namespace M3_L34_String
{
    class Program
    {
        //-----------Part of Example 3------------------
        static string SortString(string str1)
        {
            char[] cstr1 = str1.ToCharArray();
            Array.Sort(cstr1);
            string sortedStr1 = new string(cstr1);
            return sortedStr1;
        }

        static void Main(string[] args)
        {
			//-----------Example 0------------------
			//String is a class and a string data type --> they reference to the same thing!
			//String s = "Dany Cadiou"; ;
			//Console.WriteLine(s);
			//Console.WriteLine(s[0]);

			//char[] ca = s.ToCharArray();

			//char[] ca2 = { 'D', 'a', 'n', 'y' };
			//Console.WriteLine(ca2);

			//s[0] = 'A'; //impossible because string are read only

			//string substr = s.Substring(5, 6);
			//Console.WriteLine(substr);
			//Console.Read();

			//-----------Example 1------------------
			//Console.WriteLine("Enter a string: ");
			//string str1 = Console.ReadLine();
			//Console.WriteLine("Enter another string: ");
			//string str2 = Console.ReadLine();
			//string resultStr = str1 + str2;
			//Console.WriteLine(str1 + "+" + str2 + "=" + resultStr);

			//Console.Read();


			//-----------Example 2------------------
			/*Console.WriteLine("Enter a string: ");
			string str1 = Console.ReadLine();
			Console.WriteLine("Enter a search string: ");
			string str2 = Console.ReadLine();

			string[] words = str1.Split(' ');   // replace whole word only
			////string[] words = str1.Split(null);   // split at any king of white space character (new line ...)
			for (int i = 0; i < words.Length; i++)
			{
				////if (str2.CompareTo(words[i]) == 0) // do not if the word that we are looking for is follow by a "."
				if (words[i].Contains(str2))
				{
					words[i] = str2.ToUpper();
				}
			}
			str1 = string.Join(" ", words); // re join all the work with the capitalize character
			Console.WriteLine(str1);
			/*
			/*
			string[] words = str1.Split(' ');	// replace whole word in reversed!
			for (int i = 0; i < words.Length; i++)
			{
				if (str2.CompareTo(words[i]) == 0)
				{
					char [] str2a = str2.ToUpper().ToCharArray();
					Array.Reverse(str2a);
					words[i] = string.Join("",str2a);
					//words[i] = new string(str2a);
				}
			}
			str1 = string.Join(" ", words);
			Console.WriteLine(str1);
			*/
			/*
			int pos = str1.IndexOf(str2);	// replace substring's first occurrence
			if ( pos!= -1)
			{
				str1 = str1.Substring(0, pos) + str2.ToUpper() + str1.Substring(pos + str2.Length);
			}
			Console.WriteLine(str1);
			*/
			/*
			int pos = str1.LastIndexOf(str2);	// replace substring's last occurrence
			if (pos != -1)
			{
				str1 = str1.Substring(0, pos) + str2.ToUpper() + str1.Substring(pos + str2.Length);
			}
			Console.WriteLine(str1);
			*/
			/*
			str1 = str1.Replace(str2, str2.ToUpper());	// replace all occurrences
			Console.WriteLine(str1);
			*/
			//Console.Read();

			//-----------Example 3------------------
			Console.WriteLine("Enter first string: ");
			string str1 = Console.ReadLine();
			Console.WriteLine("Enter second string: ");
			string str2 = Console.ReadLine();
			if (SortString(str1) == SortString(str2))
			{
				Console.WriteLine("The two input strings are permutations of each other.");
			}
			else
			{
				Console.WriteLine("The first string is not a permutation of the second.");
			}
			Console.Read();
		}
	}
}
