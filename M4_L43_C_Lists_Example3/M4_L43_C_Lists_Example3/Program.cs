﻿using System;
using System.Collections.Generic;

namespace M4_L43_C_Lists_Example3
{
	class Program
	{
		static void DisplayList(List<int> myList, string ListName)
		{
			myList.Sort();
			Console.Write("\nElements of {0}: ", ListName);
			foreach (var item in myList)
			{
				Console.Write(item + " ");
			}
		}
		static void Main(string[] args)
		{
			List<int> oddList = new List<int>();
			List<int> evenList = new List<int>();
			
			string command;
			do
			{
				Console.WriteLine("\nEnter a command: ");
				command = Console.ReadLine();
				command = command.ToLower();
				while (command.Contains("  ")) command = command.Replace("  ", " "); //replaces multiple spaces
				command = command.Trim();   // to remove single whitespaces from start & end.
				var split = command.Split(null);
				if (split.Length == 1)
				{
					if (split[0] == "exit") break;
					else if (split[0] == "display")
					{
						DisplayList(oddList, "Odd-List");
						DisplayList(evenList, "Even-List");
					}
				}
				else if (split.Length == 0) continue;
				else if (split[0] == "add")
				{
					for (int i = 1; i < split.Length; i++)
					{
						int val = int.Parse(split[i]);
						if (val % 2 == 0)
						{
							evenList.Add(val);
						}
						else
						{
							oddList.Add(val);
						}
					}
				}
				else if (split[0] == "delete")
				{
					for (int i = 1; i < split.Length; i++)
					{
						int val = int.Parse(split[i]);
						if (val % 2 == 0)
						{
							evenList.Remove(val);
						}
						else
						{
							oddList.Remove(val);
						}
					}
				}
				else
				{
					Console.WriteLine("Unknown command! \nPlease enter command in correct format...");
				}
			} while (true); // not sure that i understand what is equal to true?
		}
	}
}
