using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;

namespace CH80_Useful_method_of_list_collection_class
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

            List<Customer> listCustomers = new List<Customer>(100);
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            // Using Example As Read Only
            /* ReadOnlyCollection<Customer> readonlyCustomer = listCustomers.AsReadOnly();  
             Console.WriteLine("items = " + readonlyCustomer.Count); */

            // Using Example True for all
            /* Console.WriteLine("Are all salaries greater than 5000"  +
                listCustomers.TrueForAll(x => x.Salary > 5000)); */

            // Using TrimExcess
            Console.WriteLine("Capacity before trimming = " + listCustomers.Capacity);  
            listCustomers.TrimExcess();
            Console.WriteLine("Capacity after trimming = " + listCustomers.Capacity);

        }
        private static int CompareCustomer(Customer x, Customer y)
        {
            return x.ID.CompareTo(y.ID);
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
