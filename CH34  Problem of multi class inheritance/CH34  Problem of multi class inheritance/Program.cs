using System;

namespace CH34__Problem_of_multi_class_inheritance
{
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A Implementation");
        }
    }
    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B Implementation");
        }
    }
    class C : A
    {
        public override void Print()
        {
            Console.WriteLine("C Implementation");
        }
    }

    class D : B, C
    {

    }

    class Program
    {
        public static void Main()
        {
            D d = new D();
            d.Print();
        }
    }
}
