using System;
using System.Collections.Generic;

namespace CH37_Delegate_Usage_in_C
{
    class Progrim
    {
        public static void Main()
        {
            List<Employee> emplist = new List<Employee>();

            emplist.Add(new Employee() { ID = 555, Name = "Mr Lee", Salary = 55555, Experience = 5 });
            emplist.Add(new Employee() { ID = 555, Name = "Mr EM", Salary = 55555, Experience = 15 });
            emplist.Add(new Employee() { ID = 555, Name = "Mr Test", Salary = 55555, Experience = 2 });

            //IsPromotable isPromotable = new IsPromotable(Promote);
            Employee.PromoteEmployee(emplist, emp => emp.Experience >=5);
        }
        //public static bool Promote(Employee emp)
        //{
        //    if (emp.Experience >=5)
        //    {
        //        return true;
        //    }
        //    {
        //        return false;
        //    }
        //}
    }

    delegate Boolean IsPromotable(Employee eml);
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
        {
            foreach (Employee employee in employeeList)
            {
                if (IsEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.Name + " was promoted");
                }
            }
        }

    }
}
