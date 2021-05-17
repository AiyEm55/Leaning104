using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH63_Partial_method_in_C
{
   public class PartialClassOne
    {
        public partial class SamplePartialClass
        {
            partial void SamplePartialMethod();

            public void PublicMethod()
            {
                Console.WriteLine("PublicMethod Invoked");
                SamplePartialMethod();
            }
        }
    }
}
