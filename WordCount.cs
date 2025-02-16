//Written By Sam Stuyvenberg //02/16/2025
using System;

class Program
{
    // Method to count the number of words in a sentence
    static int CountWords(string str)
    {
        // Split the string into words based on whitespace
        string[] words = str.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        // Return the length of the array (number of words)
        return words.Length;
    }

    // Main method to get input and output result
    static void Main()
    {
        // Prompt user to enter a sentence
        Console.Write("Enter a sentence: ");
        string inputString = Console.ReadLine();

        // Call the countWords method and get the result
        int wordCount = CountWords(inputString);

        // Display the result
        Console.WriteLine($"Word count: {wordCount}");
    }
}
