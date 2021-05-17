using System;
using System.Collections.Generic;

namespace CH37_Delegate_Usage_in_C
{
    class Progrim
    {
        public static void Main()
        {
            List<Employee> emplist = new List<Employee>();

            emplist.Add(new Employee() { ID = 555 , Name = "Mr Lee", Salary = 55555, Experience = 5 });
            emplist.Add(new Employee() { ID = 555, Name = "Mr EM", Salary = 55555, Experience = 15 });

            Employee.PromoteEmployee(emplist);
        }
    }
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList)
        {
            foreach (Employee employee in employeeList)
            {
                if(employee.Experience >= 5)
                {
                    Console.WriteLine(employee.Name + " was promoted");
                }
            }
        }

    }
}
