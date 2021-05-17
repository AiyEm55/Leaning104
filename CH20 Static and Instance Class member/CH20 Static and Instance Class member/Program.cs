using System;

namespace CH20_Static_and_Instance_Class_member
/*{
    class Circle
    {
        float _PI = 3.141F;
        int _Radius;

        public Circle(int Radius)
        {
            this._Radius = Radius;
        }

        public float CalculateArea()
        {
            return this._PI * this._Radius * this._Radius;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle C1 = new Circle(5);
            float Area1 = C1.CalculateArea();
            Console.WriteLine("Area = {0}", Area1);

            Circle C2 = new Circle(8);
            float Area2 = C2.CalculateArea();
            Console.WriteLine("Area = {0}", Area2);
        }
    }
}*/


    //Example 2 Instance
{
    class Circle
    {
       public static float _PI;
        int _Radius;

        static Circle()
        {
            Console.WriteLine("Static Constructor Called");
            Circle._PI = 3.141F;
         }
        public Circle(int Radius)
        {
            Console.WriteLine("Instance Constructor Call");
            this._Radius = Radius;
        }

        public float CalculateArea()
        {
            return Circle._PI * this._Radius * this._Radius;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Circle C1 = new Circle(5);
            float Area1 = C1.CalculateArea();
            Console.WriteLine("Area = {0}", Area1);

            Circle C2 = new Circle(8);
            float Area2 = C2.CalculateArea();
            Console.WriteLine("Area = {0}", Area2);*/

            Console.WriteLine(Circle._PI);
        }
    }
}