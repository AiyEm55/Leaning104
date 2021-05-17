using System;

namespace CH43_Exception_handing_abuse
{
    public class ExceptionHandingAbuse
    {
        public static void Main()
        {
            try
            { 
            Console.WriteLine("Please enter number");
            int Numerator = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter Denominator");
            int Demominator = Convert.ToInt32(Console.ReadLine());

            int Result = Numerator / Demominator;

            Console.WriteLine("Result = {0}", Result);
        }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a Number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Only number between {0} && {1} are allowed", Int32.MinValue, Int32.MaxValue);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Denominator cannot be zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
