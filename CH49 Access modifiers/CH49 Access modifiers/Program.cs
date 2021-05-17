using System;

namespace CH49_Access_modifiers
{
    public class Customer
    {
        protected int ID;
    }
    public class CorporateCustomer : Customer
    {
        public void PrintID()
        {
            CorporateCustomer CC = new CorporateCustomer();
            CC.ID = 555;

            this.ID
        }
    }
    public class MainClass
    {
        private static void Main()
        {
            Customer C1 = new Customer();
            Console.WriteLine(C1.ID);   // public can call ID
           
        }
    }
}
