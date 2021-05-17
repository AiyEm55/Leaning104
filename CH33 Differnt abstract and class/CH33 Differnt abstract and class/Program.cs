using System;

namespace CH33_Differnt_abstract_and_class
{
   public abstract class Customer
    {
        public void Print()
        {
            Console.WriteLine("Print");
        }
    }
    public interface ICustomer
    {
        void Print();
    }

    public class program
    {
        public static void Main()
        {

        }
    }
}
