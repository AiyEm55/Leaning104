using System;

namespace CH28_Structs_in_C
{
    public struct Customer
    {
        private int _id;
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int ID
        {
            get { return this._id; }
            set { _id = value; }
        }
        public Customer (int Id, string Name)
        {
            this._id = Id;
            this._name = Name;
        }
        public void PrintDetail()
        {
            Console.WriteLine("Id = {0} && Name = {1}", this._id, this._name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer(101, "Em");
            C1.PrintDetail();

            Customer C2 = new Customer();
            C2.ID = 102;
            C2.Name = "Test";
            C2.PrintDetail();

            Customer C3 = new Customer
            {
                ID =555,
                Name = "AiyEm55"
            };
            C3.PrintDetail();

        }
    }
}
