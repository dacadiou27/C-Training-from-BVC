using System;

namespace M4_L42_LA_InClass_Initia_Student
{
    public class Student
    {
        //private field definition
        private string _FirstName;
        private string _LastName;
        private string _Email; 
        private string _Address;
        private int _BirthYear;

        //public properties by encapsulating the fields
        public string FirstName { get => _FirstName; set => _FirstName = value; }
        public string LastName { get => _LastName; set => _LastName = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Address { get => _Address; set => _Address = value; }
        public int BirthYear { get => _BirthYear; set => _BirthYear = value; }
        // Add Constructor methods

        public Student() //Default Constructor
        {
            BirthYear = 1900;
            FirstName = LastName = Address = Email = "";
        }
        public Student(int birthYear, string firstName, string lastName, string address, string email) // Constructor with parameters
        {
            BirthYear = birthYear;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Email = email;
        }


        // The display method
        public void DisplayStudentInfo()
        {
            Console.WriteLine("\nStudent Name: " + FirstName + " " + LastName);
            Console.WriteLine("Birth Year: " + BirthYear);
            Console.WriteLine("Mailing Address: " + Address);
            Console.WriteLine("e-mail address: " + Email);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {   // ToDo: Instatiation object using default constructor and initialize fields by accessing them
            var std1 = new Student();
            // ToDo: object initialization using parameterized constructor
            var std2 = new Student(1983, "Dany", "Cadiou", "Calgary", "dacadiou@homtail.com");
            // ToDo: initialization using object initializers
            var std3 = new Student() { FirstName = "Dan", LastName = "Cad", BirthYear = 1984, Email = "dd@homtail.com" };
            // initialization by accessing field values
            var std4 = new Student();
            std4.FirstName = "D";
            std4.LastName = "D";
            std4.BirthYear = 1985;
            std4.Email = "DD@hotmail.com";

            std1.DisplayStudentInfo();
            std2.DisplayStudentInfo();
            std3.DisplayStudentInfo();
            std4.DisplayStudentInfo();

            Console.Read();
        }
    }
}
