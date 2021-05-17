using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH61_Parital_Class_in_C
{
    public class Customer
    {
        private string _firstName;
        private string _lastName;

        public string LastName
        {
        get { return _lastName; }
        set {_lastName = value; }
        }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }
    }
}
