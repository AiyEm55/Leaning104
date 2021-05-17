using System;
using System.Collections.Generic;

namespace CH77_Sort_a_list_of_simple_types
{
    class Program
    {
        public static void Main()
        {
            List<int> numbers = new List<int>(){ 1, 8, 7, 5, 2, 3, 4, 9, 6 };

            Console.WriteLine("Numbers before sorting");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
                    }
            numbers.Sort();

            Console.WriteLine("Numbers after sorting");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Reverse();

            
            Console.WriteLine("Numbers descending order");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Reverse();

            List<string> alphabets = new List<string> (){ "B", "F", "D", "E", "A", "C"};
            Console.WriteLine("Alphabets before sorting");

            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }
            alphabets.Sort();

            Console.WriteLine("Alphabets descending order");

            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }
            alphabets.Reverse();


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

            List<Customer> listCorporateCustomers = new List<Customer>();
            listCorporateCustomers.Add(customer4);
            listCorporateCustomers.Add(customer5);

            listCustomers.InsertRange(3, listCorporateCustomers);

            listCustomers.RemoveAll(x => x.Type == "Nurse");


            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", c.ID, c.Name, c.Salary, c.Type);
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
