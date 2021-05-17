using System;

namespace CH57_Why_Should_you_override_toString_method
{
   public class MainClass
    {
        private static void Main()
        {
            int Number = 5;
            Console.WriteLine(Number.ToString());

            Customer C1 = new Customer();
            C1.FirstName = "Aiy Em";
            C1.LastName = "SOUKSAVATH";

            //Console.WriteLine(C1.ToString());
            Console.WriteLine(Convert.ToString(C1));

        }
    }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return this.LastName + " , " + this.FirstName;
        }
    }

}
