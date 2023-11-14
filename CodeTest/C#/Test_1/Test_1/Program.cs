using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            Console.WriteLine("Enter the position to remove:");
            int position = int.Parse(Console.ReadLine());
            if (position >= 0 && position < input.Length)
            {
                string result = input.Remove(position, 1);
                Console.WriteLine("Result: " + result);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

    }
}
