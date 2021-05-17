using System;
using System.Collections.Generic;

namespace CH72_What_dictaionary_in_C
{
    class Program
    {
       public static void Main()
        {
            Cusomter customer1 = new Cusomter()
            {
                ID = 555, Name = "Em", Salary = 550000
            };
              Cusomter customer2 = new Cusomter()
            {
                ID = 222, Name = "Mary", Salary = 1000000
            };
                Cusomter customer3 = new Cusomter()
            {
                ID = 333, Name = "Nana", Salary = 2000000
            };

            Dictionary<int, Cusomter> dictionaryCustomers = new Dictionary<int, Cusomter>();
            dictionaryCustomers.Add(customer1.ID, customer1);
            dictionaryCustomers.Add(customer2.ID, customer2);
            dictionaryCustomers.Add(customer3.ID, customer3);

            Cusomter cusomter333 = dictionaryCustomers[333];

            //Console.WriteLine("ID = {0}, Name = {1}, Salarry = {2}", cusomter333.ID, cusomter333.Name, cusomter333.Salary);
            /* foreach (KeyValuePair<int, Cusomter> customerkeyValuePair in dictionaryCustomers)
             {
                 Console.WriteLine("ID = {0}", customerkeyValuePair.Key);
                 Cusomter cust = customerkeyValuePair.Value;
                 Console.WriteLine("ID = {0}, Name ={1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
                 Console.WriteLine("-----------------------------------------------------");
             } */

            foreach (var customerkeyValuePair in dictionaryCustomers)
            {
                Console.WriteLine("ID = {0}", customerkeyValuePair.Key);
                Cusomter cust = customerkeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name ={1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
                Console.WriteLine("-----------------------------------------------------");
            }
        }
    }
    public class Cusomter
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
