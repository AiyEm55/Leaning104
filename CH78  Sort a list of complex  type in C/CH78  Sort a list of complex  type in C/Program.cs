using System;
using System.Collections.Generic;

namespace CH78__Sort_a_list_of_complex__type_in_C
{
    class Program
    {
        public static void Main()
        {
          

            Customer customer1 = new Customer()
            {
                ID = 555,
                Name = "Em",
                Salary = 550000,
                Type = " Photography"

            };
            Customer customer2 = new Customer()
            {
                ID = 222,
                Name = "Mary",
                Salary = 1000000,
                Type = "Nurse"

            };
            Customer customer3 = new Customer()
            {
                ID = 333,
                Name = "Nana",
                Salary = 2000000,
                Type = "Office Girl"

            };

            Customer customer4 = new Customer()
            {
                ID = 333,
                Name = "Souk",
                Salary = 2000000,
                Type = "Editor"
            };
            Customer customer5 = new Customer()
            {
                ID = 333,
                Name = "sone",
                Salary = 2000000,
                Type = "Boss"
            };

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            Console.WriteLine("Before Sorting");
            foreach(Customer c in listCustomers)
            {
                Console.WriteLine(c.Salary);
            }

            listCustomers.Sort();
            listCustomers.Reverse();

            Console.WriteLine("After Sorting");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Salary);
            }

            SortbyName sortbyName = new SortbyName();
            listCustomers.Sort();
            Console.WriteLine("Sorting by Name");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Name);
            }

        }
    }

    public class SortbyName : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    public class Customer : IComparable<Customer>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }

        public int CompareTo(Customer other)
        {
            if (this.Salary > other.Salary)
                return 1;
            else if (this.Salary > other.Salary)
                return -1;
            else

                return 0;
        }
    }
}
