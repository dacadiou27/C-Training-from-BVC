using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace M4_L43_C_Lists_T
{
    class Student 
    {
        public string Name { get; set; }
        public long ID { get; set; }

        public Student(string name,long id) { 
            Name =name;
            ID =id;
        }

        public Student(){}
        public void Display()
        {
            Console.Write("Student name: " + Name);
            Console.WriteLine(" , ID: "+ ID);
        }
        
    }

    class Program
    {        


        static void DisplayList(List<int> x) 
        {
            foreach (var item in x)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            // List are dynamic : we can add value after the fact (opposite of arrays)
            //int[] x = { 1, 2, 3, 4, 5 };
            //int[] x = new int[100];
            //x[4] = 7;
            //x[5] = 7;// out of band position


            //// CLIST

            //int[] x = new int[100];   //Array is a static collection -  we need to specify the size
            List<int> x = new List<int>(); //List is a dynamic collection -  no need of specifying the size
            //List<double> x = new List<double>(); 
            //List<string> x = new List<string>(); 

            x.Add(1);
            x.Add(20);
            x.Add(3);
            x.Add(40);
            x.Add(5);
            DisplayList(x);
            Console.WriteLine(x.Count);
            Console.WriteLine();

            x.Add(6);
            x.Add(10);
            DisplayList(x);
            Console.WriteLine(x.Count);
            Console.WriteLine();

            x.AddRange(Enumerable.Range(100, 10));
            DisplayList(x);
            Console.WriteLine(x.Count);
            Console.WriteLine();

            Console.WriteLine("remove 1 and 100 from the list");
            x.Remove(1);
            x.Remove(100);
            DisplayList(x);
            Console.WriteLine(x.Count);
            Console.WriteLine();

            Console.WriteLine("Use of a for loop");
            for (int i =0; i < x.Count; i++) 
            {
                Console.Write(x[i] + " ");
            }

            Console.WriteLine();
            x.Reverse();
            foreach (var item in x)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            x.Sort();
            DisplayList(x);
            Console.WriteLine();

            int val = x.Find(a=>a==20);
            Console.WriteLine(val);
            Console.WriteLine();


            List<Student> myList = new List<Student>();
            Student david = new Student("David",123456);
            Student john = new Student("John Smith", 222222);

            myList.Add(david);
            myList.Add(john);
            myList.Add(new Student() { Name = "Susan", ID = 666666 });

            foreach (var std in myList) {
                std.Display();
            }
            Console.WriteLine();

            Console.WriteLine("after search for ID :222222 ");
            Student obj = myList.Find(s => s.ID == 222222);
            obj.Display();

            Console.WriteLine();
            Console.WriteLine("after search for name :Susan & Deletion");
            Student obj2 = myList.Find(s => s.Name == "Susan");
            myList.Remove(obj2);
            foreach (var std in myList)
            {
                std.Display();
            }
            Console.WriteLine();

            /// Random List

            List<int> myList2 = new List<int>();

            Random r = new Random();

            for (int i = 0; i < 20; i++)
            {
                myList2.Add(r.Next(1, 11));
            }

            myList2.Insert(0, 77);

            foreach (var item in myList2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            /// Array List - can stonre anytime of data at once

            ArrayList myArrayList = new ArrayList();

            myArrayList.Add(1); // adding integers
            myArrayList.Add(1.5f); // adding floats
            myArrayList.Add(1.5); // adding doubles
            myArrayList.Add(5435363.9); // adding doubles
            myArrayList.Add("This is a test"); // adding strings
            myArrayList.Add(new Student() { Name = "DAny", ID = 27 } ); // adding objects

            foreach (var item in myArrayList)
            {
                Console.WriteLine(item.GetType()+ " : " + item + " ");
            }
            Console.WriteLine();

            Console.Read();
        }
    }
}
