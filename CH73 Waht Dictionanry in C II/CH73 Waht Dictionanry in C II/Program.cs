using System;
using System.Collections.Generic;

namespace CH73_Waht_Dictionanry_in_C_II
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

            List<Customr> customers = new List<Customr>();
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            Dictionary<int, Customr> dictionaryCustomers = new Dictionary<int, Customr>();
         dictionaryCustomers.Add(customer1.ID, customer1);
         dictionaryCustomers.Add(customer2.ID, customer2);
         dictionaryCustomers.Add(customer3.ID, customer3); 

            /*    Cusomter cust;
               if (dictionaryCustomers.TryGetValue(555, out cust))
                {
                    Console.WriteLine("ID = {0}, Name {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
                }
                else
                {
                    Console.WriteLine("The Key is not Found");
                }

            } */

             Console.WriteLine("Total Items = {0}", dictionaryCustomers.Count);   //Count

            // dictionaryCustomers.Remove(333);

            // dictionaryCustomers.Clear();


            //Example 
            /* Dictionary<int, Customr> dict = customers.ToDictionary(cust => cust.ID, cust => cust);

            foreach (KeyValuePair<int, Customr> Kvp in dict)
            {
                Console.WriteLine("Key = {0}", Kvp.Key);
                Customr cust = Kvp.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            } */


        }
    }
    public class Customr
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}