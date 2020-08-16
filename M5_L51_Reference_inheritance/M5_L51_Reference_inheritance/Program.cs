using System;

namespace M5_L51_Reference_inheritance
{


	class Animal
	{
		//public string Name { get; set; }
		protected string Name { get; set; } // my main funtion which is inside the roigram class can not access to name
		public string Food { get; set; }
		public Animal() { }
		public Animal(string name)
		{
			Name = name;
		}

		public void PrintMyName()
		{
			Console.WriteLine("I am {0}", Name);
		}
		public void PrintMyFood()
		{
			Console.WriteLine("My food is {0}", Food);
		}
	}

	class Dog : Animal
	{
		public Dog() { }
		public Dog(string name)
		{
			Name = name;
		}

		//public string Name { get; set; }
		//public string Food { get; set; }
		public string Sound { get; set; }
		//public void PrintMyName()
		//{
		//	Console.WriteLine("I am {0}", Name);
		//}
		//public void PrintMyFood()
		//{
		//	Console.WriteLine("My food is {0}", Food);
		//}
		public void MySound()
		{
			Console.WriteLine("My sound is {0}", Sound);
		}
	}

	// You may also want to have a Puppy Class with
	// Eyes method and is derived from Dog.
	class Puppy : Dog
	{
		public Puppy() { }
		public Puppy(string name)
		{
			Name = name;
		}

		public string Eyes { set; get; }
		public void MyEyes()
		{
			Console.WriteLine("My eyes are {0}", Eyes);
		}
	}
	class Program
    {
        static void Main(string[] args)
        {
			//Animal newAnimal = new Animal();
			Animal newAnimal = new Animal("Max");
			//newAnimal.Name = "Max";
			newAnimal.Food = "Bone";

			newAnimal.PrintMyName();
			newAnimal.PrintMyFood();

			//Dog newDog = new Dog();
			Dog newDog = new Dog("Mr.Husky");
			//newDog.Name = "Mr.Husky";
			newDog.Food = "Bone";
			newDog.Sound = "Woof";

			newDog.PrintMyName();
			newDog.PrintMyFood();
			newDog.MySound();

			//Puppy charlie = new Puppy();
			Puppy charlie = new Puppy("Charlie");
			//charlie.Name = "Charlie";
			charlie.Food = "Meatloaf";
			charlie.Sound = "Woof";
			charlie.Eyes = "Bright";

			charlie.PrintMyName();
			charlie.PrintMyFood();
			charlie.MySound();
			charlie.MyEyes();

			Console.ReadLine();

        }
    }
}
