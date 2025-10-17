using System;
using System.ComponentModel;
using System.Security.AccessControl;
using System.Linq;

namespace TryOrCatchAssignment
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Ask the user for their age
            Console.WriteLine("How old are you?");

            try
            {
                //Read and clean input
                string input = Console.ReadLine();
                string raw = input.Trim();

                //if use type 4 or more digits, throw an exception
                if (raw.All(char.IsDigit) && raw.Length >= 4)
                {
                    throw new OverflowException();
                }

                //Convert the text to integer
                int age = int.Parse(raw);

                //If age is less than 0 or greater than 130, throw an exception
                if (age <= 0 || age > 130)
                {
                    throw new ArgumentOutOfRangeException();
                }

                int currentYear = DateTime.Now.Year; //get the current year
                int birthYear = currentYear - age; //simple math
                Console.WriteLine($"You were born in {birthYear}");
            }
            catch (ArgumentOutOfRangeException)
            {
                //this exception will catch ages less than 0 or greater than 130
                Console.WriteLine("Age must be more than zero and less than 130.");

            }
            catch (FormatException)
            {
                //this exception will catch letters or decimal points
                Console.WriteLine("Please enter digits only, not decimal or letters.");

            }
            catch (OverflowException)
            {
                //this exception will catch numbers that are too big or too small for an integer
                Console.WriteLine("The number you entered is too big or too small.");
               
            }
            catch (Exception ex)
            {
                //This is a generic exception which will catch any other exceptions
                Console.WriteLine($"An unexpected error occurred. Please contact your system administrator.");
                
            }
            Console.ReadLine(); //keep the console open in debug mode
        }
    }
}


