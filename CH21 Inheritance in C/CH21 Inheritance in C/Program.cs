using System;

namespace CH21_Inheritance_in_C
/*{
     public class Employee
     {
         public string FirstName;
         public string LastName;
         public string Email;

         public void PrintFullName()
         {
             Console.WriteLine(FirstName + " " + LastName);
         }
     }

     public class FullTimeEmployee : Employee
     {
         public float YearlySalary;
     }
     public class PartTimeEmployee : Employee
     {
         public float HourlyRate;
     }

     public class A : PartTimeEmployee
     {

     }
     class Program
     {
         static void Main(string[] args)
         {
             FullTimeEmployee FTE = new FullTimeEmployee();
             FTE.FirstName = "Aiy Em";
             FTE.LastName = "SOUKSAVATH";
             FTE.YearlySalary = 55555;
             FTE.PrintFullName();

             PartTimeEmployee PTE = new PartTimeEmployee();
             PTE.FirstName = "Part";
             PTE.LastName = "Test";
             PTE.PrintFullName();
         }
     }
 }*/

{
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("ParentClass Contructor called");
        }
        public ParentClass(String Message)
        {
            Console.WriteLine(Message);
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass() : base("Derived class controlling Parent Clas") //relate from parent class
        {
            Console.WriteLine("ChildClass Contructor called");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ChildClass CC = new ChildClass();
        }
    }
}
