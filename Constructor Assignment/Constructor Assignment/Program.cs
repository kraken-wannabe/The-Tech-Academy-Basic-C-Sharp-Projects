using System;

namespace Constructor_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create const variables
            const string const1 = "Your name is: ";
            const string const2 = "Your favorite number is: ";

            //ask the user for either name of number
            Console.WriteLine("Please enter your name or favorite number: ");

            //use var so the compiler figures out the type
            var answer = Console.ReadLine();

            //try to treat the input as a number first 
            if (float.TryParse(answer, out float x))
            {
                //It's a number show number message and call the float constructor
                Console.WriteLine(const2);
                Chain newChain = new Chain(x); //chains to (num1, name1) with default name "Bob"
            }
            else
            {
                //its not a number show name message and call the string constructor
                Console.WriteLine(const1);
                Chain newChain = new Chain(answer); //chains to (num1, name1) with default number 42
            }

        }
    }
}