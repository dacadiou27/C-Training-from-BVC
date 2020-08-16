using System;
using System.Collections.Generic;
using System.Linq;

namespace M4_L44_Encapsulation_LA3_Blockbuster
{

    class VHSTape
    {
        private string _name;
        private float _duration;
        private bool _rented;
        private float _progress;

        public string Name { get => _name; set => _name = value; }
        public float Duration { get => _duration; set => _duration = value; }
        public bool Rented { get => _rented; set => _rented = value; }
        public float Progress { get => _progress; set => _progress = value; }

        public void Play(float playFoward) 
        {
            Progress += playFoward;
            if (Progress >= Duration)
            {
                Console.WriteLine("The tape has been completed!");
                Progress = Duration;
            } 
        }

        public void Rewind(float playRewind)
        {
            Progress -= playRewind;
            if (Progress <= 0)
            {
                Console.WriteLine("The tape is being restarted to the start");
                Progress = 0;
            } 
        }

        public void Rent()
        {
            if (Rented == false)
            {
            Rented = true;
            //Console.WriteLine("Thank you for renting {0}.",Name);
            }
            //else Console.WriteLine("The tape is now available");
        }

        public VHSTape() { }

        public VHSTape(string name, float duration) 
        {
            Name = name;
            Duration = duration;
            Rented = false;
            Progress = 0;
        }

    }

    class Blockbuster
    {
        private string _address;
        public List<VHSTape> MovieList = new List<VHSTape>();

        public string Address { get => _address; set => _address = value; }

        public Blockbuster(string address)
        {
            Address = address;
        }

        //public void AddMovie(string name, float duration)
        //{
        //   VHSTape newMovie = new VHSTape(name,  duration);
        //    _movielist.Add(newMovie);
        //}

        public void AddMovie(VHSTape newMovie)
        {
            VHSTape addMovie = newMovie;
            MovieList.Add(newMovie);
        }

        public bool HasMovie(string name)
        {
            VHSTape findVHSTape = MovieList.Find(n => n.Name == name);
            if (findVHSTape == null) 
            {

                //Console.WriteLine("The tape is not available at this location");
                return false;
            }
            else
            {
                //Console.WriteLine("The tape is available at this location");
                return true;
            }
        }

        public bool IsMovieAvailable(string name)
        {
            VHSTape findVHSTape = MovieList.Find(n => n.Name == name);
            if (findVHSTape.Name == name && findVHSTape.Rented == false)
            {
                //Console.WriteLine("The tape is available!");
                return true;
            }
            if (findVHSTape.Name == name && findVHSTape.Rented == true)
            {
                //Console.WriteLine("The tape is already rented, come back another day!");
                return false;
            }
            else
            {
                //Console.WriteLine("The tape is not available at this location.");
                return true;
            }
        }

        public VHSTape GetRented(string name)
        {
            VHSTape findVHSTape = MovieList.Find(n => n.Name == name);
            findVHSTape.Rent();
            return findVHSTape;
        }

        public VHSTape Rent(string name)
        {
            VHSTape findVHSTape = MovieList.Find(n => n.Name == name);
            findVHSTape.Rent();
            return findVHSTape;
        }

        public VHSTape Return(string name)
        {
            VHSTape findVHSTape = MovieList.Find(n => n.Name == name);
            findVHSTape.Rented = false;
            //Console.WriteLine("The tape -{0}- is now available at this location.", findVHSTape.Name);
            return findVHSTape;
        }

        public void DisplayMovieList()
        {
            foreach (var movie in MovieList)
            {
                Console.Write("Tille: {0} ; Duration {1}; \n", movie.Name, movie.Duration);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var store = new Blockbuster("Calgary, Alberta, Canada.");
            string command = "";
            Console.WriteLine("Please enter a command: ");
            while (command != "exit")
            {
                command = Console.ReadLine();
                var cmdArgs = command.Split();
                if (cmdArgs.Length == 0)
                    continue;
                if (cmdArgs[0] == "add")
                {
                    var name = string.Join(" ", cmdArgs.Skip(1).Take(cmdArgs.Length - 2));
                    var length = float.Parse(cmdArgs.Last());
                    var tape = new VHSTape(name, length);
                    store.AddMovie(tape);
                }
                else if (cmdArgs[0] == "find")
                {
                    var name = string.Join(" ", cmdArgs.Skip(1).Take(cmdArgs.Length - 1));
                    bool hasMovie = store.HasMovie(name);
                    if (hasMovie)
                        Console.WriteLine("Store has " + name);
                    else
                        Console.WriteLine("Store does not have " + name);
                }
                else if (cmdArgs[0] == "available")
                {
                    var name = string.Join(" ", cmdArgs.Skip(1).Take(cmdArgs.Length - 1));
                    bool available = store.IsMovieAvailable(name);
                    if (available)
                        Console.WriteLine(name + " is available");
                    else
                        Console.WriteLine(name + " is rented");
                }
                else if (cmdArgs[0] == "rent")
                {
                    var name = string.Join(" ", cmdArgs.Skip(1).Take(cmdArgs.Length - 1));
                    VHSTape movie = store.Rent(name);
                    Console.WriteLine(name + ": " + (movie.Rented ? "rented" : "available"));
                }
                else if (cmdArgs[0] == "play")
                {
                    var name = string.Join(" ", cmdArgs.Skip(1).Take(cmdArgs.Length - 2));
                    var duration = float.Parse(cmdArgs.Last());
                    var movie = store.GetRented(name);
                    movie.Play(duration);
                    Console.WriteLine(movie.Name + ": " + movie.Progress);
                }
                else if (cmdArgs[0] == "rewind")
                {
                    var name = string.Join(" ", cmdArgs.Skip(1).Take(cmdArgs.Length - 2));
                    var duration = float.Parse(cmdArgs.Last());
                    var movie = store.GetRented(name);
                    movie.Rewind(duration);
                    Console.WriteLine(movie.Name + ": " + movie.Progress);
                }
                else if (cmdArgs[0] == "return")
                {
                    var name = string.Join(" ", cmdArgs.Skip(1).Take(cmdArgs.Length - 1));
                    var movie = store.GetRented(name);
                    store.Return(name);
                    Console.WriteLine(name + ": " + (movie.Rented ? "rented" : "available"));
                }
                else if (cmdArgs[0] == "display")
                {
                    store.DisplayMovieList();
                }
            }
        }
    }
}
