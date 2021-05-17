using System;
using System.Collections.Generic;

namespace CH75_List_collection_class_in_C
{
    class Program
    {
        public static void Main()
        {
            Customer customer1 = new Customer()
            {
                ID = 555,
                Name = "Em",
                Salary = 550000
            };
            Customer customer2 = new Customer()
            {
                ID = 222,
                Name = "Mary",
                Salary = 1000000
            };
            Customer customer3 = new Customer()
            {
                ID = 333,
                Name = "Nana",
                Salary = 2000000
            };

            Customer[] customersArray = new Customer[3];
            customersArray[0] = customer1;
            customersArray[1] = customer2;
            customersArray[2] = customer3;

            List<Customer> listCustomers = customersArray.ToList();
            foreach (Customer c in listCustomers)
                {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}