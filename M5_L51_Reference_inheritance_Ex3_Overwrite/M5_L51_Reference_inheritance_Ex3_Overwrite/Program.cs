using System;

namespace M5_L51_Reference_inheritance_Ex3_Override
{

		class Animal    // superclass
		{
			public string Name { get; set; }
			public string Food { get; set; }
			public Animal(string name, string food)
			{
				Name = name;
				Food = food;
			}
			public virtual void PrintMyName()
			{
				Console.WriteLine("I am {0}.", Name);
			}
			public void PrintMyFood()
			{
				Console.WriteLine("My food is {0}.", Food);
			}
		}
		class Dog : Animal  // subclass
		{
			public Dog(string name, string food) : base(name, food)
			{
			}
			public override void PrintMyName()
			{
				Console.WriteLine("{0} is my name.", Name);
			}
			public string Sound { get; set; }
			public void MySound()
			{
				Console.WriteLine("My sound is {0}.", Sound);
			}
			public void printMyNameFromBaseClass()
			{
				base.PrintMyName();
			}
		}
		class Program
		{
			static void Main(string[] args)
			{
				Animal tom = new Animal("Tom", "Fish");
				tom.PrintMyName();
				tom.PrintMyFood();
				Console.WriteLine();
				Dog husky = new Dog("Mr. Husky", "Bone");
				husky.Sound = "Woof";
				husky.PrintMyName();
				husky.PrintMyFood();
				husky.MySound();
				husky.printMyNameFromBaseClass();
				Console.ReadLine();
			}
		}
	}

