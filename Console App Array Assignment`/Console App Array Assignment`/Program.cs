using System;
using System.Collections.Generic;


namespace Console_App_Array_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array of strings
            string[] nameArray = { "Alice", "Bob", "Charlie", "Mike", "Mira", "Ken", "Dom" };
            // ask user to input 0-6
            Console.WriteLine("Please enter a number between 0 and 6:");
            int stringSelect = Convert.ToInt32(Console.ReadLine());
            bool validStringSelect = false;

            while (!validStringSelect)
            {
                if (stringSelect >= 0 && stringSelect <= 6)
                {
                    validStringSelect = true;
                    Console.WriteLine("You selected: " + nameArray[stringSelect]);
                }
                else
                {
                    //if false , ask user to input 0-6 again
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 6:");
                    stringSelect = Convert.ToInt32(Console.ReadLine());
                }
            }
            // Array of Lists
            List<string> colorListArray = new List<string>()
            {
                "red",
                "blue",
                "green",
                "yellow",
                "orange",
                "purple",
                "black",
                "white",
                "gray"
            };
            // ask user to input 0-8
            Console.WriteLine("Please enter a number between 0 and 8:");
            int colorSelect = Convert.ToInt32(Console.ReadLine());
            bool validColorSelect = false;
            while (!validColorSelect)
            {
                if (colorSelect >= 0 && colorSelect <= 8)
                {
                    validColorSelect = true;
                    Console.WriteLine("You selected: " + colorListArray[colorSelect]);
                }
                else
                {
                    //if false , ask user to input 0-8 again
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 8:");
                    colorSelect = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
