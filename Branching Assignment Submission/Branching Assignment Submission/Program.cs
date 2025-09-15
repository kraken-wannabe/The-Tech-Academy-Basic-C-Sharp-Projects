using System;

namespace Branching_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use a loop so the program can restart if input is invalid
            while (true)
            {
                //Greeting message for the user
                Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
                //ASk for package weight
                Console.WriteLine("Please enter the package weight:");
                //Convert string input to integer
                int packageWeight = Convert.ToInt32(Console.ReadLine());

                //Check if weight is too heavy
                if (packageWeight > 50)
                {
                    //Message and restart program
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Please try again.\n");
                    continue; //Go back to the start of the loop
                }
                //Ask for package dimensions
                Console.WriteLine("Please enter the package width:");
                int packageWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                int packageHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int packageLength = Convert.ToInt32(Console.ReadLine());

                //Check if dimensions are too large
                int dimensionSum = packageWidth + packageHeight + packageLength;
                if (dimensionSum > 50)
                {
                    //Message and restart program
                    Console.WriteLine("Package too big to be shipped via Package Express. Please try again.\n");
                    break; //Exit the loop and end the program
                }
                
                // Calculate shipping quote
                int quote = (packageWidth * packageHeight * packageLength * packageWeight) / 100;

                //Display quote to user
                Console.WriteLine($"Your estimated total for shipping this package is: ${quote}.00");
                Console.WriteLine("Thank you!");
                Console.WriteLine("Press Enter to exit.");
                Console.ReadLine();
                break; //Exit the loop and end the program
            }

        }
    }
}