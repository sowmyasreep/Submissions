using System;

namespace Assignment_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int int1, int2;
            Console.WriteLine("Input 1st number: ");
            int1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 2nd number: ");
            int2 = Convert.ToInt32(Console.ReadLine());


            if (int1 == int2)

                Console.WriteLine("{0} and {1} are equal.\n", int1, int2);

            else

                Console.WriteLine("{0} and {1} are not equal.\n", int1, int2);
            Console.ReadLine();
        }

    }
}
