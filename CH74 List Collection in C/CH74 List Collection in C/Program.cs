using System;
using System.Collections.Generic;

namespace CH74_List_Collection_in_C
{
    class Program
    {
        public static void Main()
        {
            Customr customer1 = new Customr()
            {
                ID = 555,
                Name = "Em",
                Salary = 550000
            };
            Customr customer2 = new Customr()
            {
                ID = 222,
                Name = "Mary",
                Salary = 1000000
            };
            Customr customer3 = new Customr()
            {
                ID = 333,
                Name = "Nana",
                Salary = 2000000
            };

            List<Customr> customers = new List<Customr>(2);
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            customers.Insert(0, customer3);

            foreach (Customr c in customers)
            {
                Console.WriteLine(c.ID);
            }
        }
    }
    public class Customr
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}