using System;

namespace CH46__Enums_Example
{

    public class Enum
    {
        public static void Main()
        {
            Customer[] customers = new Customer[3];

            customers[0] = new Customer
            {
                Name = "Em",
                Gender = Gender.Male
            };
            customers[1] = new Customer
            {
                Name = "Mary",
                Gender = Gender.Female
            };
            customers[2] = new Customer
            {
                Name = "Test",
                Gender = Gender.Unkonw
            };
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Name = {0} && Gender = {1}", customer.Name, GetGender(customer.Gender));
            }
        }
        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unkonw:
                    return "Unknow";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid data detected";
            }
        }
    }

    public enum Gender
    {
        Unkonw,
        Male,
        Female
    }
    //0  -Unknow
    //1 - Male
    //2 - Female
    public class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }
}
