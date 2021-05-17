using System;

namespace CH24_Different_Override_and_method_hiding_in_C
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am a base class Print Method");
        }
    }

    public class DerivedClass : BaseClass
    {
        //public override void  Print() //OverRide
        public new void Print()  //Hiding
        {
            Console.WriteLine("I am a Devide class Print method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass B = new DerivedClass();
            B.Print();
        }
    }
}
