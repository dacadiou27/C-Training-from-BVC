using System;

namespace M5_L51_Reference_inheritance_Ex2
{
	public class Account
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public double Value { get; protected set; } = 0.0;
		public void Deposit(double amount)
		{
			Value += amount;
		}
		public void Withdraw(double amount)
		{
			Value -= amount;
		}
	}

	public class SavingsAccount : Account
	{
		public double InterestRate { get; set; }

		public void MonthEnd()
		{
			Value += Value * InterestRate;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			var myAccount = new SavingsAccount { ID = 5, Name = "My Bank Account", InterestRate = 0.03 };
			myAccount.Deposit(100.0);
			myAccount.Withdraw(20.0);
			Console.WriteLine(myAccount.Value);
			myAccount.MonthEnd();
			Console.WriteLine(myAccount.Value);

			Console.Read();
		}
	}
}
