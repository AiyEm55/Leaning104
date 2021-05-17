using System;

namespace CH25_Method_Overloading_in_C
{
    class Program
    {
       public static void Main()
        {
          
        }

        public static void Add(int FN, int SN, params int [] TN)
        {
            Console.WriteLine("sum = (0)", FN + SN);
        }
      
    }
}
