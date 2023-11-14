using System;

namespace Assignment_01
{
    public class Positive
    {
        public static void Main()
        {
            int num;
            Console.WriteLine("Check whether a number is positive or negative:\n");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Input an integer : ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)
                Console.WriteLine("{0} is a positive number.\n", num);
            else
                Console.WriteLine("{0} is a negative number. \n", num);
            Console.Read();
        }
    }
}
