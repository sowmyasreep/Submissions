
using System;

namespace Assignment_05

{
    class question1

    {
        static void Main(string[] args)

        {
            Console.WriteLine(" Please enter your First Name:");

            string first_name = Console.ReadLine();

            Console.WriteLine("Please enter your Last Name:");

            string last_name = Console.ReadLine();

            Display(first_name, last_name);

            Console.ReadKey();

        }
        static void Display(string first_name, string last_name)

        {
            Console.WriteLine(first_name.ToUpper());

            Console.WriteLine(last_name.ToUpper());

        }

    }

}