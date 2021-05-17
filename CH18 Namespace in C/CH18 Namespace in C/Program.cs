using System;


namespace CH18_Namespace_in_C
{
    using PATA = ProjectA.TeamA; 
    using PATB = ProjectA.TeamB;
    class Program
    {
        static void Main(string[] args)
        {
          PATA. ClassA.Print();
          PATB. ClassA.Print();
        }
    }

    namespace ProjectA
    {
        namespace TeamA
        { 
            class ClassA
            {
                public static void Print()
                { 
                    Console.WriteLine("Team A Print Mehtod");
                }
            }
        }
    }

    namespace ProjectA
    {
        namespace TeamB
        {
            class ClassA
            {
                public static void Print()
                {
                    Console.WriteLine("Team B Print Mehtod");
                }
            }
        }
    }
}

