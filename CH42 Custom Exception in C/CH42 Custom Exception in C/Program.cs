using System;
using System.IO;
using System.Runtime.Serialization;


namespace CH42_Custom_Exception_in_C
{
    public class CustomExceptionDemo
    {
        public static void Main()
        {
            try
            {
                throw new UserAlreadyLoggedInException("User is logged in - no depulicate session allowed");
            }
            catch (UserAlreadyLoggedInException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    [Serializable]
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException()
            : base()
        {

        }
        public UserAlreadyLoggedInException(string message)
            : base(message)
        {

        }

        public UserAlreadyLoggedInException(String message, Exception innerexception)
            : base(message, innerexception)
        {

        }

        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context)
            :base (info, context)
        {

        }
    }
}

