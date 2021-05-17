using System;

namespace CH27_Properties_Continue_in_C
{
    public class Student
    {
        private int _id;
        private string _Name;
        private int _PassMark = 55;

        private string _city;
        private string _email;

        public string City {get;set;}
        public string Email
        {
            //get
            //{
            //    return this._city;
            //}
            //set
            //{
            //    this._city = value;
            //}
            get;
            set;
        }

        public int PassMark
    { 
        get
        {
            return this._PassMark;
        }
    }
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or empty");
                }
                this._Name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
            }
        }

        public int Id
        {
            set
                {
                if (value <= 0)
                {
                    throw new Exception("Student Id Canont be negative");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }

        public int GetId()
        {
            return this._id;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student C1 = new Student();
            C1.Id = 101;
            C1.Name = "Aiy Em";
            //C1.PassMark = 55;


            Console.WriteLine("Student Id ={0}", C1.Id);
            Console.WriteLine("Student Name ={0}", C1.Name);
            Console.WriteLine("PassMark={0}", C1.PassMark);

            //Console.WriteLine("ID 0 {0} && Name = {1} && PassMark = {2}",
            //    C1.ID, C1.Name, C1.PassMark);
        }
    }
}
