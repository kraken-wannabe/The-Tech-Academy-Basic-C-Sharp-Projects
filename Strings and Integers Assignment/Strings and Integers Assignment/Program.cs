using System;


namespace StringAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of integers
            List<int> numbers = new List<int>() { 20, 40, 60, 80, 100, 120, 140 };
            //Ask the user to input a number to divide each number in the list by
            bool isValidInput = false;
            while (!isValidInput)
            {
                //using a try/catch block to handle any potential errors
                try
                {
                    Console.Write("\nEnter a number to divide from the list. ");
                    float userInput = float.Parse(Console.ReadLine());
                    //if statement to check if the user input is 0
                    if (userInput == 0)
                    {
                        Console.WriteLine("Please enter a number other than 0");
                    }
                    //if the input is valid, set isValidInput to true to exit the loop
                    else
                    {
                        //loop through the list and divide each number by the user input
                        foreach (int number in numbers)
                        {
                            float result = number / userInput;
                            Console.WriteLine($"{number} divided by {userInput} equals {result}");
                        }
                        isValidInput = true;
                        
                    }
                }
                //catch block displaying a message if the user input is not a valid number
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
            //Message to indicate the program has ended try/catch block
            Console.WriteLine("\nThe program has ended. Press any key to exit.");
        }
    }
}