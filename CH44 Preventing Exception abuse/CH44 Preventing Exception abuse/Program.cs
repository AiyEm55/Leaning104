using System;

namespace CH44_Preventing_Exception_abuse
{
    public class ExceptionHandingAbuse
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Please enter number");
                int Numerator;

                bool IsnumratorConverionSuccessful =  Int32.TryParse(Console.ReadLine(), out Numerator);

                if(IsnumratorConverionSuccessful)
                {
                    Console.WriteLine("Please enter Denominator");
                    int Denominator;
                    bool IsDenominatorSuccessful = Int32.TryParse(Console.ReadLine(), out Denominator);

                    if(IsDenominatorSuccessful && Denominator !=0)
                    {
                        int Result = Numerator / Denominator;

                        Console.WriteLine("Result = {0}", Result);
                    }  
                    else
                    {
                        if (Denominator ==0)
                        {
                            Console.WriteLine("Denominator cannot be zero");
                        }
                        else
                        {
                            Console.WriteLine("Denominator should be a valid number between {0} && {1}", Int32.MinValue, Int32.MaxValue);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Nmerator should be a v valid number between {0} && {1}", Int32.MinValue, Int32.MaxValue);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a Number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Only number between {0} && {1} are allowed", Int32.MinValue, Int32.MaxValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
