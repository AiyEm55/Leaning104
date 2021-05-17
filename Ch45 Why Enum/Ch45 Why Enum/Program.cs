using System;

namespace Ch45_Why_Enum
{
 public class Enum
    {
        public static void Main()
        {
            Customer[] customers = new Customer[3];

            customers[0] = new Customer
            {
                Name = "Em",
                Gender = 1
            };
            customers[1] = new Customer
            {
                Name = "Mary",
                Gender = 2
            };
            customers [2] = new Customer
            {
                Name = "Test",
                Gender = 0
            };
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Name = {0} && Gender = {1}", customer.Name,GetGender( customer.Gender));
            }
        }
        public static string GetGender(int gender)
        {
            switch(gender)
            {
                case 0:
                    return "Unknow";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Invalid data detected";
            }
        }
    }
    //0  -Unknow
    //1 - Male
    //2 - Female
    public class Customer
    {
        public string Name { get; set; }
        public int Gender { get; set; }
    }
}
