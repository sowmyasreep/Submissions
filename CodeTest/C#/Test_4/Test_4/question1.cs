

using System;

using System.IO;

 

class Program

{

    static void Main()

    {

        string filePath = "question1.txt"; // Change this to your desired file path



        Console.WriteLine("Enter text to append to the file:");

        string textToAppend = Console.ReadLine();



        try

        {

            using (StreamWriter writer = new StreamWriter(filePath, true))

            {

                writer.WriteLine(textToAppend);

            }



            Console.WriteLine("Text appended successfully.");

        }

        catch (Exception ex)

        {

            Console.WriteLine("Error: " + ex.Message);

        }

    }

}