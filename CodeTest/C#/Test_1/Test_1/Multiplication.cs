using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_01
{
    class Multiplication
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the range:");
            int range = int.Parse(Console.ReadLine());
            Console.WriteLine($"Multiplication table for {number}:");
            for (int i = 1; i <= range; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} x {i} = {result}");
            }

        }
    }
}
