using System;
using System.Collections.Generic;

namespace M4_L43_C_Lists_InClass_activity
{
	public class Person
	{   
		public string Name { get; set; }  // get help us to get the property and set help to set the property
		public string Phone { get; set; }
		public Person()
		{

		}
		public Person( string name, string phone)
		{
			Name = name;
			Phone = phone;
		}

		public void DisplayContact()
		{
			Console.WriteLine("Name : {0}, Phone number : {1}.", Name, Phone);
		}
	}

	class Program
	{
		static void DisplayAll(List<Person> ContactsList)
		{
			Console.WriteLine("Your phone number list is:\n");
			foreach (var Item in ContactsList)
			{
				Item.DisplayContact();
			}
		}

		static void Main(string[] args)
		{
			List<Person> ContactList = new List<Person>();
            string[] SpiltInput;

            do
            {
                Console.WriteLine("Please enter a command :");
                string Input = Console.ReadLine();

                //Process string
                Input = Input.ToLower();
                if (Input.Contains("  ")) Input.Replace("  ", " ");
                Input.Trim();

                //Convert/split String to Array as per a space character

                SpiltInput = Input.Split(' ');

                //Check of Array length is different of 0 to precess further
                if (SpiltInput.Length == 0) continue;

                else if (SpiltInput[0].CompareTo("display") == 0)
                {
                    DisplayAll(ContactList);
                    Console.WriteLine();
                }

                else if (SpiltInput[0].CompareTo("add") == 0) //“add <Name> <Number>” & if already exist append new phone number
                {
					string FindName = SpiltInput[1];
					Person ContactToFind = ContactList.Find(a => a.Name == FindName);

					if (ContactToFind == null)
					{
						ContactList.Add(new Person() { Name = SpiltInput[1], Phone = SpiltInput[2] });
					}
					else
					{
						string NumberToAdd = SpiltInput[2];
						string OldNumber = ContactToFind.Phone;
						string FinalNumbers = OldNumber + ", " + NumberToAdd;
						ContactToFind.Phone = FinalNumbers;
						
					}
					DisplayAll(ContactList);

				}

                else Console.WriteLine("Incorrect command! \nPlease enter a command such - add update delete find exit display- :  ");

            } while (SpiltInput[0].CompareTo("exit") != 0);
        }
	}
}
