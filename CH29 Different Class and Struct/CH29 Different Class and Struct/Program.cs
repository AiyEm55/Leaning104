using System;

namespace CH29_Different_Class_and_Struct
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            int i = 10;
            int j = i;
            j = j + 1;

            Console.WriteLine("i = {0} && j = {1}", i, j);

            Customer C1 = new Customer();
            C1.ID = 555;
            C1.Name = "Aiy EM";

            Customer C2 = C1;

            C2.Name = "Nong May";

            Console.WriteLine("C1.Name = {0} && C2.Name = {1}", C1.Name, C2.Name);

        }
    }
}

