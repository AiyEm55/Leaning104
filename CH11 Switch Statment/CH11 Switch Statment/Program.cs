using System;

namespace CH11_Switch_Statment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1
            /*Console.WriteLine("Please enter a number");
            int UserNumber = int.Parse(Console.ReadLine());

            if (UserNumber == 10)
            {
                Console.WriteLine("Your number is 10");
            }
            else if (UserNumber == 20)
            {
                Console.WriteLine("Your number is 20");
            }
            else if (UserNumber == 30)
            {
                Console.WriteLine("Your number is 30");
            }
            else 
            {
                Console.WriteLine("Your number is not 10, 20, & 30");
            }*/

            //Example 2 using Switch
            /*Console.WriteLine("Please enter a number");
            int UserNumber = int.Parse(Console.ReadLine());

            switch (UserNumber)
            {
                case 10:
                    Console.WriteLine("Your number is 10");
                    break;
                case 20:
                    Console.WriteLine("Your number is 20");
                    break;
                case 30:
                    Console.WriteLine("Your number is 30");
                    break;
                default:
                    Console.WriteLine("Your number is not 10, 20 & 30");
                    break;
            }*/


            //Example 3 Short case
            Console.WriteLine("Please enter a number");
            int UserNumber = int.Parse(Console.ReadLine());

            switch (UserNumber)
                {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("Your number is {0}", UserNumber);
                    break;
                default:
                    Console.WriteLine("Your number is not 10, 20 & 30");
                    break;

            }
            

             
        }
    }
}
