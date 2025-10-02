using System;


namespace Parsing_Enums
{
        // Create an enum for days of the week
        // Note: Using "weekday" to avoid conflict with System.DayOfWeek
        public enum Weekday
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    class Program
    {
        static void Main(string[] args)
        {
            bool isvalid = false;
            //while loop until valid input is received
            while (!isvalid)
            try
            {
                //Prompt the user to enter the current day of the week
                Console.WriteLine("Enter the current day of the week:");
                string dayInput = Console.ReadLine();

                //Assign the input to a variable of the enum type
                //Enum.Parse will attempt to convert the string to our Weekday enum.
                //The third argument ignores case sensitivity.
                Weekday today = (Weekday)Enum.Parse(typeof(Weekday), dayInput, ignoreCase: true);

                //If parsing succeeds, print the parsed enum value
                Console.WriteLine($"You entered: {today}. Have a great day!");
                Console.WriteLine("Press Enter twice to exit.");
                Console.ReadLine();
                isvalid = true;
                }
            catch (ArgumentException)
            {
                    //If parsing fails, inform the user and prompt again
                    Console.WriteLine("Invalid day entered. Please try again.");
            }
            //End program
            Console.WriteLine("\nPress Enter to exit.");
            Console.ReadLine();
        }
    }
}