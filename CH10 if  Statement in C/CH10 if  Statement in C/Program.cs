using System;

namespace CH10_if__Statement_in_C
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1 if
            /*Console.WriteLine("Please enetr number");

            int UserNumber = int.Parse(Console.ReadLine());

            if (UserNumber == 1)
            {
                Console.WriteLine("Your number is one");
            }

            if (UserNumber == 2)
            {
                Console.WriteLine("Your number is two");
            }
            if (UserNumber == 3)
            {
                Console.WriteLine("Your number is three");
            }

            if (UserNumber != 1 && UserNumber != 2 && UserNumber != 3)
            {
                Console.WriteLine("Your Number is not between 1 and 3");
            }*/


            //Example 2 if else
            /*Console.WriteLine("Please enetr number");

            int UserNumber = int.Parse(Console.ReadLine());
            if (UserNumber == 1)
            {
                Console.WriteLine("Your number is one");
            }
            else if (UserNumber == 2)
            {
                Console.WriteLine("Your number is two");
            }
            else if (UserNumber == 3)
            {
                Console.WriteLine("Your number is three");
            }
            else
            {
                Console.WriteLine("Your Number is not between 1 and 3");
            }*/


            //Example 3
            Console.WriteLine("Please enetr number");

            int UserNumber = int.Parse(Console.ReadLine());
            if (UserNumber == 10 || UserNumber ==20)
            {
                Console.WriteLine("Your Number is 10 or 20");
            }
            else
            {

            }
        }
    }
}
