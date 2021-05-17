using System;

namespace CH59_Difference_between_Convert_string_toString
{
   public class MainClass
    {
        private static void Main()
        {
            Customer C1 = new Customer();
            // string str = C1.ToString();
            string str = Convert.ToString(C1);
            Console.WriteLine(str);
        }
    }
    public class Customer
    {
        public string name { get; set; }
    }
}
