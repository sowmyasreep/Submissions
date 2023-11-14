
using System;
namespace Test_3
{
    class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public Box(double len, double bred)
        {
            Length = len;
            Breadth = bred;
        }
        public static Box AddBoxes(Box box1, Box box2)
        {
            double sumLength = box1.Length + box2.Length;
            double sumBreadth = box1.Breadth + box2.Breadth;
            return new Box(sumLength, sumBreadth);
        }
        public void Display()
        {
            Console.WriteLine($"Length: {Length}, Breadth: {Breadth}");
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter dimensions for Box 1:");
            Console.Write("Length in cm: ");
            double length1 = double.Parse(Console.ReadLine());
            Console.Write("Breadth in cm: ");
            double breadth1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter dimensions for Box 2:");
            Console.Write("Length in cm: ");
            double length2 = double.Parse(Console.ReadLine());
            Console.Write("Breadth in cm: ");
            double breadth2 = double.Parse(Console.ReadLine());

            Box box1 = new Box(length1, breadth1);
            Box box2 = new Box(length2, breadth2);
            Box box3 = Box.AddBoxes(box1, box2);

            Console.WriteLine("\nBox 1 Details:");
            box1.Display();

            Console.WriteLine("\nBox 2 Details:");
            box2.Display();

            Console.WriteLine("\nBox 3 (Final result) Details:");
            box3.Display();

        }

    }
}