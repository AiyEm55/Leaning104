using System;

namespace CH35_Delegates_in_C
{
    class Program
    {
        public delegate void HelloFunctionDelegate(string Message);

        static void Main(string[] args)
        {
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hello from Delegate");
            //A delegates is a type safe function pointer
        }

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }
}
