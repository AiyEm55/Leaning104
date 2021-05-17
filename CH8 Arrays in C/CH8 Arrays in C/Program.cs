using System;

namespace CH8_Arrays_in_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] EvenNumbers = new int[3];

            EvenNumbers[0] = 0;
            EvenNumbers[1] = 2;
            EvenNumbers[2] = 5;

            Console.WriteLine(EvenNumbers[2]);

        }
    }
}
