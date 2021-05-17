using System;

namespace CH21_Method_hiding_in_C
{
    public class Employee
    {
        public String FirstName;
        public String LastName;

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class PartTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            //base.PrintFullName();
            Console.WriteLine(FirstName + " " + LastName + " - Contrator");
        }
    }

    public class FullTimeEmployee : Employee
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Aiy Em";
            FTE.LastName = "SOUSKAVATH";
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = ("Test");
            PTE.LastName = ("Part");
            PTE.PrintFullName();
            //((Employee)PTE).PrintFullName();
        }
    }
}
