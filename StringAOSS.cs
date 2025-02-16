//Written By Sam Stuyvenebrg 2/16/2025
using System;

class Program
{
    static bool IsInOrder(string str)
    {
        for (int i = 1; i < str.Length; i++)
        {
            if (str[i] < str[i - 1]) // If any character is smaller than the previous one
                return false;
        }
        return true; // If loop completes, the string is in order
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        bool result = IsInOrder(input);
        Console.WriteLine($"Is the string in order? {result}");
    }
}
