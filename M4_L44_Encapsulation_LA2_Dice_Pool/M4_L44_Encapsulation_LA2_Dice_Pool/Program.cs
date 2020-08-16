using System;
using System.Collections.Generic;

namespace M4_L44_Encapsulation_LA2_Dice_Pool
{
    class Die
    {
        private int _nb_sides;
        private Random val = new Random();
        public int Nb_sides { get => _nb_sides; set => _nb_sides = value ; }

        public Die() {}
        public Die(int sides)
        {
            Nb_sides = sides;
        }
        public int Roll() 
        {
            int n = val.Next(1, Nb_sides + 1);
            return n;
        }
    }

    class DicePool 
    {
        private List<Die> _dicePool;
        public DicePool() 
        {
            _dicePool = new List<Die>();
        }

        public void Add(int s) 
        {
            Die newDie = new Die(s);
            _dicePool.Add(newDie);
        }

        public bool Remove(int s)
        {
            Die deleteDie = _dicePool.Find(a => a.Nb_sides == s);
            if (deleteDie != null)
            {
                _dicePool.Remove(deleteDie);
                return true;
            }
            else return false;
        }
        public int Roll(int s) 
        {
            Die findDie = _dicePool.Find(a => a.Nb_sides == s);
            return findDie.Roll();
        }
        public int RollAll() 
        {
            int sum = 0;
            int i = 1;
            int result;
            foreach (var die in _dicePool) 
            {
                result = die.Roll();
                Console.Write("Roll {0} from a dice with {1} sides rolled number {2}\n", i, die.Nb_sides, result) ;
                sum += result;
                i++;
            }
            return sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string command;
            string[] words;
            DicePool npool = new DicePool();
            int result;

            do
            {
                Console.WriteLine("PLease enter a command: ");
                command = Console.ReadLine();
                command = command.ToLower();
                command = command.Trim();
                while (command.Contains("  "))
                {
                    command.Replace("  ", " ");
                }
                words = command.Split(' ');

                if (words[0] == "add")
                { 
                    npool.Add(int.Parse(words[1]));
                    Console.WriteLine(words[1] + " Sided dice is added to the pool.");
                   }
                else if (words[0] == "roll") 
                {
                    result = npool.Roll(int.Parse(words[1]));
                    Console.WriteLine("Die with {0} sides rolled a {1}.", words[1],result);
                }
                else if (words[0] == "remove")
                {
                    if (npool.Remove(int.Parse(words[1])) == true)
                        Console.WriteLine("Die with {0} sides removed from the pool.", words[1]);
                    else Console.WriteLine("Die not found");
                }

                else if (words[0] == "rollall")
                {
                    result = npool.RollAll();
                   Console.WriteLine("The sum of all all dice is {0}.", result);
                }
                else Console.WriteLine("Please enter a correct command!");


            } while (command != "exit");




            /*
            Die Rdice = new Die();
            int NbRolls;
            Console.WriteLine("Please enter a number of face for your die: ");
            Rdice.Nb_sides = int.Parse(Console.ReadLine());
            Console.WriteLine("Holl many rolls do you want to do: ");
            NbRolls = int.Parse(Console.ReadLine());

            for(int i=1;i<= NbRolls; i++)
            {
                Console.WriteLine("Your rolled number is : {0}", Rdice.Roll(Rdice.Nb_sides));
            }
            */

            Console.Read();
        }
    }
}
