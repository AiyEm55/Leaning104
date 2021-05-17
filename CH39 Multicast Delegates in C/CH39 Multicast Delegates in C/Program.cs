using System;

namespace CH39_Multicast_Delegates_in_C
{
    public delegate void SampleDelegate(out int Integer);
    class Program
    {
        public static void Main()
        {

            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodTwo;

            int DelegateOutputParameterValue = -1;

            del(out DelegateOutputParameterValue);

            Console.WriteLine("DelegateOutputParameterValue = {0}", DelegateOutputParameterValue);
           
        }
        public static void SampleMethodOne(out int Number)
        {
            Number = 1;
        }
        public static void SampleMethodTwo(out int Number)
        {
            Number = 2;
        }
    }
}
