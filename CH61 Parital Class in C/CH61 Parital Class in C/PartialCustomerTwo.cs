using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH61_Parital_Class_in_C
{
    public partial class PartialCustomer
    {
        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }
    }
}
