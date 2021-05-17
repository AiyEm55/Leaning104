using System;

namespace CH48_Different_between_Types_and__Type_member
{
    public class Customer
    {
        #region Fields
        private int _id;
        private string _FirstName;
        private string _LastName;
        #endregion

        #region Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        #endregion

        #region Method
        public string GetFullname()
        {
            return this._FirstName + " " + this._LastName;
        }
        #endregion
    }
}
