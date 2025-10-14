using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Ask the user for a number
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        // (Optional) echo to the console, similar to your "Console.WriteLine(card);"
        Console.WriteLine(input);

        // Write the number to a text file
        string path = @"C:\Users\kraken\Documents\logs\log.txt";

        //append this file path
        using (StreamWriter file = new StreamWriter(path, true))
        {
            file.WriteLine(input);
        }

        // 3) Read the file and print back to user
        string contents = File.ReadAllText(path);
        Console.WriteLine("\nFile contents:");
        Console.WriteLine(contents);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadLine();
    }
}
