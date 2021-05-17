using System;

namespace CH19_Intro_Class_in_C
{
    class Customer
    {
        string _firstName;
        string _lastName;

        public Customer(String FirstName, string LastName)
        {
            this._firstName = FirstName;
            this._lastName = LastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine("Full Name = {0}", this._firstName + " " + this._lastName);
        }
        Customer()
        {
            //Clean up code
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer("Aiy Em", "SOUSKAVATH");
            C1.PrintFullName();
        }
    }
}
