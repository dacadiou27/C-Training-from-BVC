using System;

namespace M5_L53_Abstract_Concept_EX1_4legs_animal
{
 	abstract class FourLeggedAnimal
	{
		public virtual string Describe()
		{
			return "This animal has four legs.";
		}
		public string Eat()
		{
			return "This animal eats.";
		}
		public virtual string Quantity()
		{
			return "This animal eats small.";
		}
	}
	class Husky : FourLeggedAnimal
	{
		public override string Describe()
		{
			string result = base.Describe();
			result += " In fact, it is Mr. Husky!";
			return result;
		}

		public override string Quantity()
		{
			return "This animal eats a lot.";
		}
	}
	class FluffyDog : FourLeggedAnimal
	{
		public override string Describe()
		{
			string result = base.Describe();
			result += " In fact, it's the fluffy dog 'Puffy'!";
			return result;
		}
	}
	static class Program
	{
		public static void Main()
		{
			//Husky myHusky = new Husky();
			FourLeggedAnimal myHusky = new Husky();  // we can use the parent class and call the child class constructor "run time polymorphism"
			Console.WriteLine(myHusky.Describe());
			Console.WriteLine(myHusky.Eat());
			Console.WriteLine(myHusky.Quantity());

			Console.WriteLine();

			//FluffyDog puffy = new FluffyDog();
			FourLeggedAnimal puffy = new FluffyDog(); // we can use the parent class and call the child class constructor "run time polymorphism"
			Console.WriteLine(puffy.Describe());
			Console.WriteLine(puffy.Eat());
			Console.WriteLine(puffy.Quantity());

			Console.Read();
		}
	}
}
