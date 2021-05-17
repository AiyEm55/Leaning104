using System;

namespace CH16_Method_in_C
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program p = new Program();
            //    p.EvenNumber();

            Program.EvenNumber(30);

            Program P = new Program();
            int Sum = P.Add(10, 20);

            Console.WriteLine("Sum = {0}", Sum);
        }

        public int Add(int FN, int SN)
        {
            return FN + SN;
        }
        public static void EvenNumber(int Target)
        {
            int Start = 0;

            while(Start <= Target)
            {
                Console.WriteLine(Start);
                Start = Start + 2;
            }
        }
    }
}
