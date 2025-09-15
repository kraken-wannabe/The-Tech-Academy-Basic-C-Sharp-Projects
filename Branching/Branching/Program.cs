using System;




namespace Branching
{
       class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number?");
            int favNumber = Convert.ToInt32(Console.ReadLine());

            string result = favNumber == 12 ? "You have an awesome favorite number!" : "You do not have an awesome favorite number.";
            Console.WriteLine(result);

            //int currentTemperature = 72;
            //int roomTemperature = 71;
            //string comparisonResult = currentTemperature == roomTemperature ? "It is room temp." : "It is not room temp.";

            //Console.WriteLine(comparisonResult);

            //int roomTemperature = 70;

            //Console.WriteLine("Hello! What is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi " + name + "! What is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (currentTemperature < roomTemperature)
            //{
            //    Console.WriteLine("It is cooler than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("Uhh... something went wrong.");
            //}
            Console.ReadLine();
        }
    }
}