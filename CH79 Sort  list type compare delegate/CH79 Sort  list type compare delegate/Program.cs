using System;
using System.Collections.Generic;

namespace CH79_Sort__list_type_compare_delegate
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
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.ID);
            }

            //listCustomers.Sort(delegate(Customer c1, Customer c2) { return c1.ID.CompareTo(c2.ID); }); //Using delegate
            listCustomers.Sort((x, y) => x.ID.CompareTo(y.ID));  // Using x . x to compare

            Console.WriteLine("After Sorting");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.ID);
            }
        }
    }

    public class Customer 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }


        
    }
}
