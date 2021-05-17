using System;

namespace CH56_Generice_in_C
{
    public class MainClass
    {
        private static  void Main()
        {
            bool Equal = Calculator<int>.AreEqual(11, 10);

            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
    public class Calculator<T>
    {
        public static bool AreEqual(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
    }
}
