using System;

namespace M4_L41_OOPC_Example_2_Bank_Account
{
    class BankAccount
    {
        private string _name;
        private double _balance;

        public string Name { get => _name; set => _name = value; }
        public double Balance { get => _balance; set => _balance = value; }

        public BankAccount() 
        {
            Balance = 0;
        }

        public BankAccount(string name)
        {
            Balance = 0;
            Name = name;
        }

        public void Deposit(double amount) {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Transfer(double amount, BankAccount target) 
        {
            Withdraw(amount);
            target.Deposit(amount);
        }

        public void AccountInfo() 
        {
            Console.Write("\nAccount Name " + Name +", ");
            Console.Write("Account Balance " + Balance);
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            var John = new BankAccount("John");
            John.Deposit(100);
            var Bob = new BankAccount("Bob");
            John.AccountInfo();
            Bob.AccountInfo();

            John.Transfer(60,Bob);
            John.AccountInfo();
            Bob.AccountInfo();

            //Console.WriteLine("Before Transfer: ");
            //Console.WriteLine("Balance of John: $" + John.GetBalance());
            //Console.WriteLine("Balance of Bob: $" + Bob.GetBalance());
            //John.Transfer(60, Bob);
            //Console.WriteLine("After John Transfers $60 to Bob: ");
            //Console.WriteLine("Balance of John: $" + John.GetBalance());
            //Console.WriteLine("Balance of Bob: $" + Bob.GetBalance());
            Console.Read();
        }
    }
}
