//Written by Sam Stuyvenberg  //02/16/2025
using System;

class Program
{
    // Function to move each character to the next letter
    static string Move(string str)
    {
        string result = ""; // To store the transformed string

        // Iterate through each character in the input string
        foreach (char c in str)
        {
            // Check if the character is a lowercase letter (a-z)
            if (char.IsLower(c))
            {
                // Get the next letter by converting it to the next ASCII value
                result += (char)(c + 1);
            }
        }

        return result; // Return the transformed string
    }

    // Main method to get input and output result
    static void Main()
    {
        // Prompt user to enter a string
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        // Call the move function and get the result
        string result = Move(inputString);

        // Display the result
        Console.WriteLine($"Result: {result}");
    }
}
