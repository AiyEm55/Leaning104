using System;

namespace CH5_Commom_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int Numerator = 10;
            int Denominator = 2;

            int Result = Numerator % Denominator;

            Console.WriteLine("Result = {0}", Result);


            int Number = 10;
            int AnotherNumber = 20;

            //if (Number !=10 && AnotherNumber ==20) 
            if (Number != 10 || AnotherNumber == 20)

                Console.WriteLine("Hello");*/



            //Long sentence
            /*int Number = 15;

            bool Isnumber10;

            if (Number == 10)
            {
                Isnumber10 = true;
            }
            else
            {
                Isnumber10 = false;
            }

            Console.WriteLine("Number == 10 is {0}", Isnumber10);*/


            //Example Short sentence
            int Number = 15;

            bool Isnumber10 = Number == 10 ? true : false;

            Console.WriteLine("Number == 10 is {0}", Isnumber10);
        }
    }
}
