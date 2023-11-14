
using System;
using Concession; // Adding  this namespace to access ConcessionCalculator
namespace ConcessionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your age:");
          if (int.TryParse(Console.ReadLine(), out int age))
            {
               ConcessionCalculator.CalculateConcession(age, name);
            }
            else
            {
              Console.WriteLine("The enter  one is invalid age input.");
            }
        }
    }

}
