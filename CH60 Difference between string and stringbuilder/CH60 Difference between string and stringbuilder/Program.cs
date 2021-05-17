using System;
using System.Text;

namespace CH60_Difference_between_string_and_stringbuilder
{
   public class MainClass
    {
        public static void Main()
        {
            //Example One
            /* StringBuilder userString  = new StringBuilder("C#");
             userString.Append(" Video");
             userString.Append(" Tutorial");
             userString.Append(" For");
             userString.Append(" Beginner");

             Console.WriteLine(userString); */
            
            //Example Two
            string userString = string.Empty;
            for (int i = 1; i <=1000; i++)
            {
                userString += i.ToString() + " ";
            }
            Console.WriteLine(userString);

           
        }
    }
}
