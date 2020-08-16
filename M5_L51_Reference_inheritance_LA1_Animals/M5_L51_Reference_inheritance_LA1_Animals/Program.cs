using System;

namespace M5_L51_Reference_inheritance_LA1_Animals
{
    using System;

    namespace Activity_Animal
    {
        public class Animal
        {
            //To Do

            public string Name { get; set; }
            public int Legs { get; set; }

            public Animal()
            {
                Name = "animal";
                Legs = 0;
            }
        }

        public class Dog : Animal
        {
            public Dog()
            {
                Name = "dog";
                Legs = 4;
            }

            public void Bark() 
            {
                Console.WriteLine("Woof");
            }
            //public void Swim()
            //{
            //    Console.WriteLine("Some are good swimmers !");
            //}
        }

        public class Fish : Animal
        {

            public Fish()
            {
                Name = "fish";
                Legs = 0;
            }

            public Fish(string name)
            {
                // aditional contructor taht we can use for Shark
                Name = name;
                Legs = 0;
            }

            public void Swim()
            {
                Console.WriteLine("Just Keep Swimming!");
            }
        }

        public class Shark : Fish
        {
            //public Shark()
            //{
            //    Name = "shark";
            //    Legs = 0;
            //}

            public Shark() : base("shark")
            {
            }

            public void Eat(Animal obj)
            {
                Console.WriteLine("Shark ate {0} !", obj.Name);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Animal lastAnimal = null;
                string input;
                while ((input = Console.ReadLine()) != "exit")
                {
                    if (input == "animal")
                    {
                        var animal = new Animal();
                        Console.WriteLine(animal.Name);
                        lastAnimal = animal;
                    }
                    else if (input == "dog")
                    {
                        var dog = new Dog();
                        Console.WriteLine(dog.Name + " " + dog.Legs);
                        dog.Bark();
                        lastAnimal = dog;
                    }
                    else if (input == "fish")
                    {
                        var fish = new Fish();
                        Console.WriteLine(fish.Name + " " + fish.Legs);
                        fish.Swim();
                        lastAnimal = fish;
                    }
                    else if (input == "shark")
                    {
                        var shark = new Shark();
                        Console.WriteLine(shark.Name + " " + shark.Legs);
                        shark.Swim();
                        shark.Eat(lastAnimal);
                        lastAnimal = shark;
                    }
                }
            }
        }
    }

}
