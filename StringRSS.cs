//Written by Sam Stuyveberg //02/16/25
using System;

class Program
{
    static string SwapFirstLast(string str)
    {
        if (string.IsNullOrEmpty(str) || str.Length < 2) // Check for null or empty input
            return "Incompatible.";

        if (str[0] == str[str.Length - 1]) // Check if first and last characters are the same
            return "Two's a pair.";

        // Convert string to character array
        char[] charArray = str.ToCharArray();

        // Swap first and last characters using a temporary variable
        char temp = charArray[0];
        charArray[0] = charArray[charArray.Length - 1];
        charArray[charArray.Length - 1] = temp;

        return new string(charArray); // Convert back to string and return
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        string result = SwapFirstLast(input);
        Console.WriteLine($"Result: {result}");
    }
}
