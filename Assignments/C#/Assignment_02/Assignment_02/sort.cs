using System;
using System.Linq;
namespace Assignment_02

{
    class Sort
    {
        public class PRGM2
        {
            static void Main()
            {
                int[] marks = new int[10];
                Console.WriteLine("Enter ten marks:");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"Mark {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out marks[i]) == false)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer mark.");
                        i--;
                    }
                }
                // Calculate Total
                int total = marks.Sum();
                // Calculate Average
                double average = (double)total / 10;
                // Minimum and Maximum
                int minMark = marks.Min();
                int maxMark = marks.Max();
                // Sort the marks
                int[] ascendingMarks = marks.OrderBy(mark => mark).ToArray();
                int[] descendingMarks = marks.OrderByDescending(mark => mark).ToArray();
                // Display results
                Console.WriteLine($"Total: {total}");
                Console.WriteLine($"Average: {average:F2}");
                Console.WriteLine($"Minimum marks: {minMark}");
                Console.WriteLine($"Maximum marks: {maxMark}");
                Console.WriteLine("Marks in ascending order:");
                foreach (int mark in ascendingMarks)
                {
                    Console.Write($"{mark} ");
                }
                Console.WriteLine();
                Console.WriteLine("Marks in descending order:");
                foreach (int mark in descendingMarks)
                {
                    Console.Write($"{mark} ");
                }
                Console.WriteLine();
            }
        }
    }
}