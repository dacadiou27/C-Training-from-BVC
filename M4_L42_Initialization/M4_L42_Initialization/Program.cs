using System;

namespace M4_L42_Initialization
{
	class Employee  // Starter Code
	{
		// ToDo Set Private Data Field
		private string _name;
		private double _wage;
		private double _amountDue; // I don't not create a property for this variable because I don't want anybody to have access to it for this property because I don;t want anybody to have access to it
		private double _hours;// I don't not create a property for this variable because I don't want anybody to have access to it

		public string Name { get => _name; set => _name = value; }
		public double Wage { get => _wage; set => _wage = value; }
        public double AmountDue { get => _amountDue; set => _amountDue = value; }
        public double Hours { get => _hours; set => _hours = value; }

        public Employee()
		{/* 
		  * desactivated because setting up initialization
			_name = "";
			_wage = 0;
			_amountDue = 0;
			_hours = 0;
			*/
		}
		public Employee(string name,double wage,double hours,double amountDue)
		{//desactivated because setting up initialization by parametrisation
		// if you defined an overloaded constructor like this you make obsolete the default constructor unless you declare it as it is above
			Name = name;
			Wage = wage;
			Hours = hours;
			AmountDue = amountDue;
		}

		public void SetName(string name)
		{ // ToDo
			_name = name;
		}
		public string GetName()
		{ // ToDo
			return _name;
		}
		public void SetWage(double rate)
		{ // ToDo
			_wage = rate;
		}
		public void Work(double hours)
		{ // ToDo
			_hours += hours;
			_amountDue = _hours * _wage;


		}
		public double Pay()
		{ // ToDo
			_hours = 0;
			return _amountDue;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			// create two employee objects

			Employee emp1 = new Employee();
			// Initialization
			emp1.Name = "David";
			emp1.Wage = 15;
			emp1.AmountDue = 0;
			emp1.Hours = 0;


			//Parametric initalization
			Employee emp2 = new Employee("Susan", 20, 0, 0);

			// Initializing object by object initializers
			Employee emp3 = new Employee() { Name="Boss", Wage=50, Hours=0, AmountDue=0};

			Console.WriteLine("Employee '{0}' is paid {1} before working...", emp1.Name, emp1.Pay());
			Console.WriteLine("Employee '{0}' is paid {1} before working...", emp2.Name, emp2.Pay());
			Console.WriteLine("Employee '{0}' is paid {1} before working...", emp3.Name, emp3.Pay());
			emp1.Work(5);
			emp2.Work(8);
			emp3.Work(2);
			Console.WriteLine("Employee '{0}' is paid {1} after working...", emp1.Name, emp1.Pay());
			Console.WriteLine("Employee '{0}' is paid {1} after working...", emp2.Name, emp2.Pay());
			Console.WriteLine("Employee '{0}' is paid {1} after working...", emp3.Name, emp3.Pay());
			emp1.Work(5);
			emp2.Work(2);
			emp3.Work(3);
			Console.WriteLine("Employee '{0}' is paid {1} after working...", emp1.Name, emp1.Pay());
			Console.WriteLine("Employee '{0}' is paid {1} after working...", emp2.Name, emp2.Pay());
			Console.WriteLine("Employee '{0}' is paid {1} after working...", emp3.Name, emp3.Pay());

			Console.Read();
		}
	}
}
