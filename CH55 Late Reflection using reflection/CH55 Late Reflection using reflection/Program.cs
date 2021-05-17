using System;
using System.Reflection;

namespace CH55_Late_Reflection_using_reflection
{
   public class MainClass
    {
        private static void Main()
        {
            Assembly excutingAssembly = Assembly.GetExecutingAssembly();

            Type customerType = excutingAssembly.GetType("Pragim.Customer");

            object customerInstance = Activator.CreateInstance(customerType);

            MethodInfo getFullnameMethod = customerType.GetMethod("GetFullName");

            string[] paramaters = new string[2];
            paramaters[0] = "Pargim";
            paramaters[1] = "Test";

            string fullname = (string)getFullnameMethod.Invoke(customerInstance, paramaters);
            Console.WriteLine("Full Name = {0}", fullname);


           /* Customer C1 = new Customer();
                string fullName = C1.GetFullName("Pragin", "Tech");
            Console.WriteLine("Full Name = {0}", fullName); */
        }
    }
   public class Customer
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    } 
}
