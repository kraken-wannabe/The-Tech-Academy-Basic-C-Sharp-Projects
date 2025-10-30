using System;


namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //This line is for Multiplication
            long userInput1;
            Console.WriteLine("What number do you want to multiply it by 50?");

            //Keep asking until we get a valid number
            while (!long.TryParse(Console.ReadLine(), out userInput1))
            {
                Console.WriteLine("Invalid input. Please enter numbers only for the next few questions:");
            }

            //Now we have a valid number in userInput1
            long result1 = userInput1 * 50;
            Console.WriteLine("Your number multiplied by 50 is: " + result1);


            //This line is for Addition
            Console.WriteLine("What number do you want to be added to 25?");
            string userInput2 = Console.ReadLine();
            int userNumber2 = Convert.ToInt32(userInput2);
            int result2 = userNumber2 + 25;
            Console.WriteLine("Your number plus 25 is: " + result2);

            //This line is for Division
            Console.WriteLine("What number do you want to divide by 12.5?");
            string userInput3 = Console.ReadLine();
            double userNumber3 = Convert.ToDouble(userInput3);
            double result3 = userNumber3 / 12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + result3);

            //This line is for Comparison
            Console.WriteLine("What number do you want to check if it's greater than 50?");
            string userInput4 = Console.ReadLine();
            int userNumber4 = Convert.ToInt32(userInput4);
            bool result4 = userNumber4 > 50;
            Console.WriteLine("Is your number greater than 50? Answer is: " + result4);

            //This line is for Modulus or remainder
            Console.WriteLine("What number do you want to divide by 7 and get the remainder?");
            string userInput5 = Console.ReadLine();
            int userNumber5 = Convert.ToInt32(userInput5);
            int result5 = userNumber5 % 7;
            Console.WriteLine("The remainder of your number divided by 7 is: " + result5);



            Console.ReadLine();
        }
    }
}