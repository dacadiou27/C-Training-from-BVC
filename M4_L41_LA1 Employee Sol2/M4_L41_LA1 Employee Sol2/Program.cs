using System;

namespace M4_L41_LA1_Employee_Sol2
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

        public Employee()
		{
			_name = "";
			_wage = 0;
			_amountDue = 0;
			_hours = 0;
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
			Employee emp2 = new Employee();

			emp1.Name="David";
			emp1.Wage= 15;
			emp2.Name="Susan";
			emp2.Wage=20;

			Console.WriteLine("Employee '{0}' is paid {1} before working...", emp1.Name, emp1.Pay());
			Console.WriteLine("Employee '{0}' is paid {1} before working...", emp2.Name, emp2.Pay());
			emp1.Work(5);
			emp2.Work(8);
			Console.WriteLine("Employee '{0}' is paid {1} after working...", emp1.Name, emp1.Pay());

			emp1.Work(5);
			emp2.Work(2);
			Console.WriteLine("Employee '{0}' is paid {1} after working...", emp1.Name, emp1.Pay());
			Console.WriteLine("Employee '{0}' is paid {1} after working...", emp2.Name, emp2.Pay());

			Console.Read();
		}
	}
}

