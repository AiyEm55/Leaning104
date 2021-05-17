using System;

namespace CH13_While_Loop_in_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your target");

            int UserTarget = int.Parse(Console.ReadLine());

            int Start = 0;
            while (Start <= UserTarget)
            {
                Console.WriteLine(Start);
                Start = Start + 2;
            }
        }
    }
}
