using System;


namespace CH50_Internal_and_Protected_internal_Access_modifier_in_C
{
    public class AssemblyTwoClassI
    {
        public void Print()
        { 
            AssemblyOneClassI A1 = new AssemblyOneClassI();
            base.ID = 555;

            AssemblyOneClassI A2 = new AssemblyOneClassI();
            Console.WriteLine(A1.ID);
        }
    }
}
