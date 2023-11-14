using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string : ");
        string str = Console.ReadLine();
        //Length of the string
        int len = str.Length;
        Console.WriteLine("Length of the string is : " + len);
        // Convert the input string to a character array
        char[] charArray = str.ToCharArray();
        // Reverse the character array
        Array.Reverse(charArray);
        // Create a new string from the reversed character array
        string reversedWord = new string(charArray);
        Console.WriteLine("Reversed word: " + reversedWord);
        Console.Write("Enter the first word: ");
        string word1 = Console.ReadLine();
        Console.Write("Enter the second word: ");
        string word2 = Console.ReadLine();
        // Check if the two words are the same (case-insensitive comparison)
        bool areSame = string.Equals(word1, word2, StringComparison.OrdinalIgnoreCase);
        if (areSame)

            Console.WriteLine("The two words are the same.");

        else

            Console.WriteLine("The two words are different.");

        Console.Read();
    }
}
