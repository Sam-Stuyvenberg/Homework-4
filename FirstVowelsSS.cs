using System;
using System.Linq;

class Program
{
   
    static string FirstNVowels(string str, int n)
    {
        string vowels = "aeiouAEIOU";               // String containing all vowel characters.
        string result = "";                         // Variable to store the extracted vowels.

        // Iterate through each character in the input string.
        foreach (char c in str)
        {
            // Check if the character is a vowel.
            if (vowels.Contains(c))
            {
                result += c; // Append the vowel to the result string.

               
                if (result.Length == n)
                    break;
            }
        }

       
        return result.Length == n ? result : "invalid";          // If the result has exactly 'n' vowels, return it, otherwise return "invalid".
    }

   
    static void Main()
    {
        
        Console.Write("Enter a string: ");              // Prompt user to enter a string.
        string inputString = Console.ReadLine();

        Console.Write("Enter the number of vowels to extract: ");

       
        if (int.TryParse(Console.ReadLine(), out int n))  // Try to parse the user input into an integer (n).
        {
           
           string result = FirstNVowels(inputString, n);  // Call the method to get the first 'n' vowels.

            
            Console.WriteLine($"Result: {result}"); // Display the result.
        }
        else
        {
            
            Console.WriteLine("Invalid input. Please enter a valid number."); // If the input is not a valid integer, inform the user.
        }
    }
}
