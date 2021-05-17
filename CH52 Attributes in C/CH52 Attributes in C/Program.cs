using System;
using System.Collections.Generic;

namespace CH52_Attributes_in_C
{
  public class MainClass
    {
        private static void Main()
        {
            Calculator.Add(new List<int>() { 10, 20, 40 });
            //Calculator.Add(10, 20, 39);
        }
    }
    public class Calculator
    {
        [ObsoleteAttribute("Used Add(List<int> Number) Method", true)]
        public static int Add(int FirstNumber, int SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }
        public static int Add(List<int> Numbers)
        {
            int Sum = 0;
            foreach (int NUmber in Numbers)
            {
                Sum = Sum + NUmber;
            }
            return Sum;
        }
        public static int Add(int FirstNumber, int SecondNumber, int ThirdNumber)
        {
            return FirstNumber + SecondNumber + ThirdNumber;
        }
    }
}
