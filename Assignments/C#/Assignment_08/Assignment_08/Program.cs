
using System;

namespace Assignment_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Shape Type :");
            string shapeType = Console.ReadLine();
            IShape ss = ShapeFactory.GetShapes(shapeType);
            if (ss != null)
            {
                Console.WriteLine("Shape Type : {0}", ss.GetShapeType());
                Console.WriteLine("Shape Area : {0}", ss.GetShapeArea());
                Console.WriteLine("Perimeter : {0}", ss.GetPerimeter());

            }
            else
            {
                Console.WriteLine("The given one is invalid Shape.. please give correct type");
            }
            Console.Read();
        }
    }
}