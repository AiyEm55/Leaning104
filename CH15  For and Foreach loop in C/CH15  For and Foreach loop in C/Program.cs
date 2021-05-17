using System;

namespace CH15__For_and_Foreach_loop_in_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[4];

            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;
            Numbers[3] = 104;

            //Example 1
            /*foreach (int k in Numbers)
            {
                Console.WriteLine(k);
            }*/

            //Example 2
            /*for (int j = 0; j < Numbers.Length; j++)
            {
                Console.WriteLine(Numbers[j]);
            }*/

            //Example 3
            /*int i = 0;
            while (i < Numbers.Length)
            {
                Console.WriteLine(Numbers[i]);
                i++;
            }*/


            //Example 4
            for (int i = 1; i <=20; i++)
            {
                if (i % 2 == 1)
                    continue;
                Console.WriteLine(i);

                //if (i == 10) break;
            }
        }
    }
}
