using System;

namespace CH12_Swith_Statment_Continued
{
    class Program
    {
        static void Main(string[] args)
        {

            int TotalCoffeeCost = 0;

            Start:
            Console.WriteLine("Please Select your coffee size 1 - Small, 2 -Meduim, 3 -Large");
            int UserChoice = int.Parse(Console.ReadLine());

            switch (UserChoice)
            {
                case 1:
                    TotalCoffeeCost += 1;
                    break;
                case 2:
                    TotalCoffeeCost += 2;
                    break;
                case 3:
                    TotalCoffeeCost += 3;
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid", UserChoice);
                    goto Start;
            }
            Decide:
            Console.WriteLine("Do you want to buy another coffee - Yes or No?");
            string UserDecision = Console.ReadLine();

            switch (UserDecision.ToUpper())
            { 
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid. Please try again...", UserDecision);
                    goto Decide; 
            }

            Console.WriteLine("Thank You for Shopping with US");
            Console.WriteLine("Bill Amount = {0}", TotalCoffeeCost);
        }
    }
}
