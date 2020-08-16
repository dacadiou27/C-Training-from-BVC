using System;
using System.Collections.Generic;

namespace M4_L43_C_Lists_Example2
{
	public class Student
	{   // add access modifiers
		//public int ID; // public field
		 public int ID { get; set; } //converted to property
		//private int _id; // Private field encasulapted
		//public int Id { get => _id; set => _id = value; } // Alt + enter encasulated in a public property
			
        public string Name { get; set; }  // get help us to get the property and set help to set the property
		public double Cgpa { get; set; }
		public Student()
		{

		}
		public Student(int id, string name, double cgpa)
		{
			ID = id;
			Name = name;
			Cgpa = cgpa;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			List<Student> stdList = new List<Student>();
			stdList.Add(new Student() { ID = 1, Name = "Draco Malfoy", Cgpa = 3.98 });
			Student newStudent = new Student(2, "Hermione Granger", 3.97);
			stdList.Add(newStudent);
			stdList.Insert(0, new Student(3, "Harry Potter", 4.0));

			Console.WriteLine("List of Students: \n");
			// stdList = stdList.OrderBy(u=>u.ID).ToList();
			foreach (var std in stdList)
			{
				// iterate over a collection
				Console.WriteLine("Name: " + std.Name);
				Console.WriteLine("Studnt ID: " + std.ID);
				Console.WriteLine("CGPA: " + std.Cgpa);
			}
			Console.Read();
		}
	}
}
