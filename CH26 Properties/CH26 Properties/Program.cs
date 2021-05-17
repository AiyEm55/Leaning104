using System;

namespace CH26_Properties
{
    public class Student
    {
        private int _ID;
        private string _Name;
        private int _PassMark = 45;

        public int GetPassMark()
        {
            return this._PassMark;
        }

        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name cannot be null or empty");
            }
            this._Name = Name;
        }
        public string GetName()
        {
            return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
        }

        public void SetID (int Id)
        {
            if (Id <=0)
            {
                throw new Exception("Student Id Canont be negative");
            }
            this._ID = Id;
        }

        public int GetId()
        {
            return this._ID;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student C1 = new Student();
            C1.SetID( 101);
            C1.SetName(" Aiy EM");
          

            Console.WriteLine("Student Id ={0}", C1.GetId());
            Console.WriteLine("Student Name ={0}", C1.GetName());
            Console.WriteLine("PassMark={0}", C1.GetPassMark());

            //Console.WriteLine("ID 0 {0} && Name = {1} && PassMark = {2}",
            //    C1.ID, C1.Name, C1.PassMark);
        }
    }
}
