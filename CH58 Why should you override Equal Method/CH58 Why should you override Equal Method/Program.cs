using System;

namespace CH58_Why_should_you_override_Equal_Method
{
    public class MainClass
    {
        public class MainCalss
        {
            private static void Main()
            {
                Customer C1 = new Customer();
                C1.FirstName = "AIy Em";
                C1.LastName = "SOUKSAVATH";

                Customer C2 = new Customer();
                C1.FirstName = "Mary";
                C1.LastName = "Cute";

                Console.WriteLine(C1 == C2);
                Console.WriteLine(C1.Equals(C2));
            }

        }
        public class Customer
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public override bool Equals(object obj)
            {
                if(obj == null)
                {
                    return false;
                }
                if (!(obj is Customer))
                {
                    return false;
                            }
                return this.FirstName == ((Customer)obj).FirstName &&
                    this.LastName == ((Customer)obj).LastName;
                               }
        }
    }
}
