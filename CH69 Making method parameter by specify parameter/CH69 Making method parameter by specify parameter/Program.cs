using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH69_Making_method_parameter_by_specify_parameter
{
    class Program
    {
        public static void Main()
        {
            Test(1,   2);
        }
      
        public static void Test(int a, int b = 10, int c =20)
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
        }
    }
}
