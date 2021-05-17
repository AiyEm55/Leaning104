using System;

namespace CH47_Enum_in_C
{
    public class Enums
    {
        public static void Main()
        {
            short[] values = (short[])Enum.GetValues(typeof(Gender));

            foreach (short value in values)
            {
                Console.WriteLine(value);
            }
            string[] Names = Enum.GetNames(typeof(Gender));
            
            foreach (string Name in Names) 
            {
                Console.WriteLine(Name);
            }
        }
    }
    public enum Gender : short
    {
        Unkonw =1,
        Male = 5,
        Female = 23,
    }
}
