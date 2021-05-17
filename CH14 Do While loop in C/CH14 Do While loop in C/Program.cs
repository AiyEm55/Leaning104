using System;

namespace CH14_Do_While_loop_in_C
{
    class Program
    {
        static void Main(string[] args)
        {

            //Example 1
            /*Console.WriteLine("Please enter your target");
            int UserTarget = int.Parse(Console.ReadLine());

            int Start = 0;

            while (Start <= UserTarget)
            {
                Console.WriteLine(Start + " ");
                Start = Start + 2;
            }
            String UserChoice = "";

            do
            {
                Console.WriteLine("Do you want to continue - Yes or No?");

                UserChoice = Console.ReadLine();
                if (UserChoice != "Yes" && UserChoice != "No")
                {
                    Console.WriteLine("Invalid choice, please say Yes or No?");
                }
            } while (UserChoice != "Yes" && UserChoice != "No");
        }*/

            //Example 2
            String UserChoice = string.Empty;
            do
            {
                Console.WriteLine("Please enter your target");
                int UserTarget = int.Parse(Console.ReadLine());

                int Start = 0;

                while (Start <= UserTarget)
                {
                    Console.WriteLine(Start + " ");
                    Start = Start + 2;
                }


                do
                {
                    Console.WriteLine("Do you want to continue - Yes or No?");

                    UserChoice = Console.ReadLine().ToUpper();
                    if (UserChoice != "YES" && UserChoice != "NO")
                    {
                        Console.WriteLine("Invalid choice, please say Yes or No?");
                    }
                } while (UserChoice != "YES" && UserChoice != "NO");
            } while (UserChoice == "YES");
        }
    }
}
