using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH67_Optional_parameter_in_C
{
    class Program
    {
        public static void Main()
        {
            AddNumbers(10, 20, new int[] { 30, 40 });
        }
        public static void AddNumbers(int firstNumber, int secondNumber)
        {
            AddNumbers(firstNumber, secondNumber, null);
        }
        public static void AddNumbers(int firstNumber, int secondNumber, params object[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;
            if (restOfNumbers! - null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Sum = " + result);
        }
    }
}
