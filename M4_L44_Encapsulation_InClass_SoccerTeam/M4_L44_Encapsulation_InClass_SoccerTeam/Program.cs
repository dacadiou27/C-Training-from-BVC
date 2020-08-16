using System;
using System.Collections.Generic;

namespace M4_L44_Encapsulation_InClass_SoccerTeam
{
        class Player
        {
            private string _name;
            private int _avgbatting;

            public string Name { get => _name; set => _name = value; }
            public int Avgbatting { get => _avgbatting; set => _avgbatting = value; }
            public Player() { }
            public Player(string name)
            {
                Name = _name;
                Random avg = new Random();
                int n = avg.Next(25, 101);
                Avgbatting = n;
            }

        }

        class Team
        {
            private List<Player> _playerList;

            public Team()
            {
                _playerList = new List<Player>();
            }

            public void Add(string name)
            {
                Player newPlayer = new Player(name);
                _playerList.Add(newPlayer);
            }

            public bool Remove(string name)
            {
                Player removePlayer = _playerList.Find(a => a.Name == name);
                if (removePlayer != null)
                {
                    _playerList.Remove(removePlayer);
                    return true;
                }
                else return false;
            }
            public float AvgTeam()
            {
                int i = 1;
                float avgTeam = 0;
                foreach (var player in _playerList)
                {
                    avgTeam += player.Avgbatting;
                    i++;
                }
                return avgTeam = avgTeam / i;
            }
            public void Display()
            {
                foreach (var player in _playerList)
                {
                    Console.Write("Player {0} has an batting average of {1} \n", player.Name, player.Avgbatting);
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                string command;
                string[] words;
                Team canadaTeam = new Team();

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
                        canadaTeam.Add(words[1]);
                        Console.WriteLine("{0} is added to the team.",words[1]);
                    }
                    else if (words[0] == "average")
                    {
                        Console.WriteLine("Team batting avreage is {0}", canadaTeam.AvgTeam());
                    }
                    else if (words[0] == "remove")
                    {
                        if (canadaTeam.Remove(words[1]) == true)
                            Console.WriteLine("{0} is removed from the team.", words[1]);
                        else Console.WriteLine("Player not found");
                    }

                    else if (words[0] == "display")
                    {
                        canadaTeam.Display();
                    }
                    else Console.WriteLine("Please enter a correct command!");


                } while (command == "exit");

                Console.Read();
            }
        }
    }
