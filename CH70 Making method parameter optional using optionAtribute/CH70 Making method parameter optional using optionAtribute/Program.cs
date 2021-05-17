using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using system.Runtime.InteropServices;

namespace CH70_Making_method_parameter_optional_using_optionAtribute
{
    class Program
    {
        public static void Main()
        {
            AddNumbers(10, 20 new int[] { 30, 40, 50 });
        }
        public static void AddNumbers(int firstNumber, int secondNumber, [Optional] int[]restOfNumbers)
        {
            int result = firstNumber + secondNumber;

            if (restOfNumbers! - null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Total = " + result.ToString());
        }
    }
}
