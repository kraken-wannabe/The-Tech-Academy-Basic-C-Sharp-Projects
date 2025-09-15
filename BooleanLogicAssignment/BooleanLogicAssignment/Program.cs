using System;


namespace BooleanLogicAssignment
{
    class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Boolean Logic Assignment");
        //Ask the user to enter their age.
        Console.Write("\nWhat is your age? ");
        int age = Convert.ToInt32(Console.ReadLine());

        // Ask if the user has ever had a DUI.
        Console.Write("\nHave you ever had a DUI? (True/False) ");
        bool hasDUI = Convert.ToBoolean(Console.ReadLine());

        // Ask how many speeding tickets the user has.
        Console.Write("\nHow many speeding tickets do you have? ");
        int speedingTickets = Convert.ToInt32(Console.ReadLine());

            // Qualification rules:
            //1. Must be over 15 years old.
            //2. Must not have any DUIs.
            //3. Must have 3 or fewer speeding tickets.
            bool isQualified = (age > 15) && (!hasDUI) && (speedingTickets <= 3);

            // Print result
            Console.WriteLine("Qualified?");
            Console.WriteLine(isQualified);

            // Keep console window open until user presses a key
            Console.ReadLine();
        }
    }
}