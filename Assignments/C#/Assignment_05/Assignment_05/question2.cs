
using System;
namespace Assignment_05
{
    class question2

    {
        static int Count(string input_string, char letterToCount)

        {
            int count = 0;

            foreach (char c in input_string)
            {

                if (char.ToUpper(c) == char.ToUpper(letterToCount))

                {
                    count++;
                }

            }
            return count;

        }

        static void Main(string[] args)

        {

            Console.WriteLine("Please enter any  string:");

            string input_string = Console.ReadLine();

            Console.WriteLine("Okay...!! For the given string enter the letter to be counted:");

            char letterToCount = Console.ReadKey().KeyChar;

            int count = Count(input_string, letterToCount);

            Console.WriteLine($"\nThe letter '{letterToCount}' appears {count} times in the string.");

            Console.ReadKey();

        }

    }
}
