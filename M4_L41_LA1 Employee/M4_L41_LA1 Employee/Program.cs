using System;

namespace M4_L41_LA1_Employee
{
    class Employee 
    {

        private string _name;
        private int _hourlyWage;
        private double _balance;
        private int _hours;


        public string Name { get => _name; set => _name = value; }
        public int HourlyWage { get => _hourlyWage; set => _hourlyWage = value; }
        public double Balance { get => _balance; set => _balance = value; }
        public int Hours { get => _hours; set => _hours = value; }

        public Employee(string name, int hourlyWage) 
        {
            Name = name;
            HourlyWage = hourlyWage;
            Hours = 0;
            Balance = 0;         
        }

        public void Work(int hours)
        {
            double PayAmount=0;
            Hours += hours;
            PayAmount = HourlyWage * hours;
            Balance += PayAmount;
            
        }

       
    }
    class Program
    {
        static void Main(string[] args)
        {

            // create two employee objects
            var John = new Employee("John",15);
            var Susan = new Employee("Susan",20);
            int hours=0;

            Console.WriteLine("Employee {0} is paid {1} before working...", John.Name, John.Balance, John.Hours);
            Console.WriteLine("Employee {0} is paid {1} before working...", Susan.Name, Susan.Balance, John.Hours);

            Console.WriteLine("How many hours did {0} worked : ", John.Name);
            hours = int.Parse(Console.ReadLine());
            John.Work(hours); 
            Console.WriteLine("Employee {0} is paid {1} after working {2} hours", John.Name, John.Balance, John.Hours);

            Console.WriteLine();

            Console.WriteLine("How many hours did {0} worked : ", Susan.Name);
            hours = int.Parse(Console.ReadLine());
            Susan.Work(hours);
            Console.WriteLine("Employee {0} is paid {1} after working {2} hours", Susan.Name , Susan.Balance, Susan.Hours);

            Console.WriteLine();

            Console.WriteLine("How many hours did {0} worked : ", John.Name);
            hours = int.Parse(Console.ReadLine());
            John.Work(hours);
            Console.WriteLine("Employee {0} is paid {1} after working {2} hours", John.Name, John.Balance, John.Hours);

            Console.WriteLine();

            Console.WriteLine("How many hours did {0} worked : ", Susan.Name);
            hours = int.Parse(Console.ReadLine());
            Susan.Work(hours);
            Console.WriteLine("Employee {0} is paid {1} after working {2} hours", Susan.Name, Susan.Balance, Susan.Hours);

        }
    }
}
