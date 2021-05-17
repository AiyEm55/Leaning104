using System;

namespace CH35_Mulitple_class_inheritance_using_interface
{
    interface IA
    {
        void AMethod();
    }
   
   class  A : IA
    {
        public void AMethod()
        {
            Console.WriteLine("A");
        }
    }

    interface IB
    {
        void AMethod();
    }

    class B : IB
    {
        public void AMethod()
        {
            Console.WriteLine("B");
        }
    }

    class AB : IA, IB
    {
        A a = new A();
        B b = new B();

        public void AMethod()
        {
            a.AMethod();
        }

        public void BMethod()
        {
            b.AMethod();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            AB ab = new AB();
            ab.AMethod();
            ab.BMethod();
        }
    }
}
