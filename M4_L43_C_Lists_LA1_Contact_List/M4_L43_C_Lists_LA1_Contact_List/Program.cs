using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace M4_L43_C_Lists_LA1_Contact_List
{

    class Contact
    {
        //Fields
        private string _name;
        private string _number; 

        //Propertires
        public string Name { get => _name; set => _name = value; }
        public string Number { get => _number; set => _number = value; }

        //Contructors
        public Contact() { }
        public Contact(string name, string number) {
            Name = name;
            Number = number;
        }

        //Methods
        public void DisplayContact()
        {
            Console.WriteLine("Name : {0}, Phone number : {1}.", Name, Number);
        }

    }

    class Program
    {

        static void DisplayAll(List<Contact> ContactsList) 
        {
            Console.WriteLine("Your phone number list is:\n");
            foreach(var Item in ContactsList)
            {
                Item.DisplayContact();
            }
        }

        static void Main(string[] args)
        {
            List<Contact> ContactsList = new List<Contact>();
            string [] SpiltInput;

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
                    DisplayAll(ContactsList);
                    Console.WriteLine();
                }

                else if (SpiltInput[0].CompareTo("add") == 0) //“add <Name> <Number>”
                {
                    ContactsList.Add(new Contact() { Name = SpiltInput[1], Number = SpiltInput[2] });
                }

                else if (SpiltInput[0].CompareTo("update") == 0) //“update <Old Number> <Updated Name> <New Number>”
                {
                    string UpDateContactNumber= SpiltInput[1];
                    Contact ContactToUpdate = ContactsList.Find(a => a.Number == UpDateContactNumber);//Use of the Link Command for Find
                    ContactToUpdate.Name = SpiltInput[2];
                    ContactToUpdate.Number = SpiltInput[3];
                }

                else if (SpiltInput[0].CompareTo("delete") == 0) //“delete <Number>”
                {
                    string DelNumber = SpiltInput[1];
                    Contact ContactToDeleteNumber = ContactsList.Find(a => a.Number == DelNumber);//Use of the Link Command for Find
                    ContactsList.Remove(ContactToDeleteNumber);
                }

                else if (SpiltInput[0].CompareTo("find") == 0) // “find <Name>” & return all the numbers
                {
                    string FindName = SpiltInput[1];
                    Contact ContactToFind= ContactsList.Find(a => a.Name == FindName);//Use of the Link Command for Find
                    ContactToFind.DisplayContact();
                }
                else Console.WriteLine("Incorrect command! \nPlease enter a command such - add update delete find exit display- :  ");
              
            } while (SpiltInput[0].CompareTo("exit") != 0);

            //Console.Read();
        }
    }
}
