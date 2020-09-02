using System;

namespace M5_L52_Polym_EX4_bird
{
	public class Bird
	{
		public virtual void Fly() // base method use of the key word "virtual"
		{
			Console.WriteLine("Flying...");
		}
	}

	public class Penguin : Bird
	{
		public override void Fly() // override base method with the use of the key word "override"
		{
			Console.WriteLine("Penguins can't fly!");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Run time polymorphic behaviour");
			Console.WriteLine("Creating an object bird (parent class) :");
			Bird o = new Bird();
			o.Fly();
			Console.WriteLine("Creating an object penguin (child class) :");
			Penguin b = new Penguin();
			b.Fly();
			Console.WriteLine("Creating an object bird using the contructor of the child class penguin :");
			Bird c = new Penguin();
			c.Fly();


		}
	}
}
