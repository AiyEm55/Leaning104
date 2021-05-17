using System;

namespace CH7_DataType_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Example 1
            //int i = 100;
            //float f = i;

            //Console.WriteLine(f);


            ////Example 2
            //float f = 123.45F;
            //int i = (int)f;

            //Console.WriteLine(i);


            ////Example 2
            //float f = 123.45F;
            //int i = Convert.ToInt32(f);

            //Console.WriteLine(i);


            ////Example 3
            //float f = 123335353555.45F;
            //int i = (int)f;

            //Console.WriteLine(i);


            ////Example 4
            //string strNumber = "100TT";
            //int i = int.Parse(strNumber);

            //Console.WriteLine(i);


            ////Example 4
            string strNumber = "9900";

            int Result = 0;
            bool IsConversionSuccessful = int.TryParse(strNumber, out Result);

            if (IsConversionSuccessful)
            {
                Console.WriteLine(Result);
            }
            else
            {
                Console.WriteLine("Please enter valid number");
            }

        }
    }
}
