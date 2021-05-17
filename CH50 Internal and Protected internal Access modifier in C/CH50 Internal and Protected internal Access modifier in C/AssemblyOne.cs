using System;

namespace CH50_Internal_and_Protected_internal_Access_modifier_in_C
{
    public class AssemblyOneClassI
    {
        protected internal int ID = 555;
    }
    public class AssemblyOneClassII
    {
        public void SampleMethod()
        {
            AssemblyOneClassI A1 = new AssemblyOneClassI();
            Console.writeLine(A1.ID);
        }
    }
}
