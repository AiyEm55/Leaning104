using System;

namespace CH_2_Read_and_Write
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter your name");

            //string Username = Console.ReadLine();

            //Console.WriteLine("Hello " + Username);  //ex1

            //Console.WriteLine("Hello {0}", Username);  //ex2

            //The ex1 and ex2 show the same


            Console.WriteLine("Please enter your first name");

            string Firstname = Console.ReadLine();

            Console.WriteLine("Please enter your last name");

            string Lastmane = Console.ReadLine();

            Console.WriteLine("Hello {0}, {1}" , Firstname, Lastmane);  



        }
    }
}
