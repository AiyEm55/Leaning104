using System;

namespace CH31_Eplict_Interface_Imple_in_C
{
    interface I1
    {
        void InterfaceMethod();
    }

    interface I2
    {
        void InterfaceMethod();
    }
    public class Program : I1, I2
    {
        void I1.InterfaceMethod()
        {
            Console.WriteLine("I1 Interface method");
        }

         void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 Interface method");
        }


        public static void Main()
        {
            I1 i1 = new Program();
            I2 i2 = new Program();

            i1.InterfaceMethod();
            i2.InterfaceMethod();
        }
    }
}
