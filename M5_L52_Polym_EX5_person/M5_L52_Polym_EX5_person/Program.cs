using System;

namespace M5_L52_Polym_EX5_person
{
	public class Person
	{
		public string Name { get; set; }

		public virtual void PrintInfo()
		{
			Console.WriteLine("Name: " + Name);
		}
	}

	public class Student : Person
	{
		public int StudentID { get; set; }

		public override void PrintInfo()
		{
			base.PrintInfo();
			Console.WriteLine("Student ID: " + StudentID);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Person p = new Person() { Name = "Dany" };
			p.PrintInfo();
			Console.WriteLine("------------");
			Student s = new Student() { Name = "Dany", StudentID =1234};
			s.PrintInfo();
			Console.WriteLine("------------");
			Person q = new Student() { Name = "Dany", StudentID = 1234 };
			q.PrintInfo();

		}
	}
}
