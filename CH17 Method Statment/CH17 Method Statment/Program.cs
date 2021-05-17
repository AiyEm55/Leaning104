using System;

namespace CH17_Method_Statment
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int i = 0;
            SimpleMethod(i);

            Console.WriteLine(i);
        }
        public static void SimpleMethod(int j)
        {
            j = 10;
        }*/

            //Example 2
            /*int Total = 0;
            int Product = 0;
            Calculate(10, 20, out Total, out Product);

            Console.WriteLine("Sum = (0) && Product = {1}", Total, Product);
        }
        public static void Calculate(int FN, int SN, out int Sum, out int Product)
        {
            Sum = FN + SN;
                Product = FN * SN;
        }*/


            //Example 3
            int[] Numbers = new int[3];

            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;

            //ParamsMethod();
            //ParamsMethod(Numbers);
            ParamsMethod(1, 2, 3, 4, 5);

        }
        public static void ParamsMethod(params int[] Numbers)
        {
            Console.WriteLine("There are {0} elements", Numbers.Length);

            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
