using System;

namespace Assignment_01
{
    public class Operators
    {
        public static void Main()
        {
            int x, y;
            char operation;

            Console.WriteLine("Input first number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input operation: ");
            operation = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Input second number: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (operation == '+')
                Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            else if (operation == '-')
                Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            else if ((operation == 'x') || (operation == '*'))
                Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            else if (operation == '/')
                Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            else
                Console.WriteLine("Wrong Character");

            Console.Read();
        }

    }


}