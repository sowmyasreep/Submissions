
using System;


namespace CalculatorApp

{

    // Define delegate types for the calculator functions

    delegate int CalculatorDelegate(int num1, int num2);



    class Program

    {

        static void Main(string[] args)

        {

            CalculatorDelegate addDelegate = Add;

            CalculatorDelegate subtractDelegate = Subtract;

            CalculatorDelegate multiplyDelegate = Multiply;



            while (true)

            {

                Console.WriteLine("\n------Calculator Menu:---------");

                Console.WriteLine("1. Addition");

                Console.WriteLine("2. Subtraction");

                Console.WriteLine("3. Multiplication");

                Console.WriteLine("4. Exit");

                Console.Write("Please enter your choice : ");



                if (int.TryParse(Console.ReadLine(), out int choice))

                {

                    if (choice == 4)

                        break;



                    Console.Write("Enter number 1: ");

                    if (int.TryParse(Console.ReadLine(), out int num1))

                    {

                        Console.Write("Enter number 2: ");

                        if (int.TryParse(Console.ReadLine(), out int num2))

                        {

                            int result = 0;



                            // Perform the selected operation based on user choice

                            switch (choice)

                            {

                                case 1:

                                    result = addDelegate(num1, num2);

                                    Console.WriteLine($"\nFinal Result: {result}");
                                    Console.WriteLine("\n--------------------------------------------------------");

                                    break;

                                case 2:

                                    result = subtractDelegate(num1, num2);

                                    Console.WriteLine($"Final Result: {result}");
                                    Console.WriteLine("\n-------------------------------------------------------");
                                    break;

                                case 3:

                                    result = multiplyDelegate(num1, num2);

                                    Console.WriteLine($"Final Result: {result}");
                                    Console.WriteLine("\n----------------------------------------------------");
                                    break;

                                default:

                                    Console.WriteLine("Invalid choice. Please enter 1, 2, 3, or 4.");

                                    break;

                            }

                        }

                        else

                        {

                            Console.WriteLine("Invalid second number. Please enter a valid integer.");

                        }

                    }

                    else

                    {

                        Console.WriteLine("Invalid first number. Please enter a valid integer.");

                    }

                }

                else

                {

                    Console.WriteLine("Invalid choice. Please enter 1, 2, 3, or 4.");

                }

            }

        }



        // Calculator functions

        static int Add(int num1, int num2)

        {

            return num1 + num2;

        }



        static int Subtract(int num1, int num2)

        {

            return num1 - num2;

        }



        static int Multiply(int num1, int num2)

        {

            return num1 * num2;

        }

    }

}