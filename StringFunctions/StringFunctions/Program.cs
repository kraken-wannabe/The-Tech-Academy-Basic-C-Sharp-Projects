using System;


namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello, World!";
            string str2 = "hello, world!";
            // Case-sensitive comparison
            bool areEqualCaseSensitive = str1.Equals(str2);
            Console.WriteLine($"Case-sensitive comparison: {areEqualCaseSensitive}");
            // Case-insensitive comparison
            bool areEqualCaseInsensitive = str1.Equals(str2, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine($"Case-insensitive comparison: {areEqualCaseInsensitive}");
            // Using Compare method for case-insensitive comparison
            int comparisonResult = string.Compare(str1, str2, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine($"Comparison result (case-insensitive): {comparisonResult}");
            // Using Contains method with case-insensitivity
            bool containsSubstring = str1.Contains("WORLD", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine($"Contains 'WORLD' (case-insensitive): {containsSubstring}");

            Console.ReadLine();
        }
    }
}
