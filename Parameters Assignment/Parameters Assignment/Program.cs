using System;


namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee with generic parameter string
            var empStrings = new Employee<string>();

            //Assign a list of strings to Things
            empStrings.Things.AddRange(new List<string> { "Laptop", "Notebook", "Pen" });

            //Employee with generic parameter int
            var empInts = new Employee<int>();
            //Assign a list of integers to Things
            empInts.Things.AddRange(new List<int> { 3, 6, 9, 12 });

            //Loops that print all Things to the Console
            Console.WriteLine("empStrings.Things:");
            foreach (var item in empStrings.Things) //each item is an int
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nempInts.Things:");
            foreach (var number in empInts.Things) //each number is a string
            {
                Console.WriteLine(number);
            }
            //End game
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadLine();
        }
    }
}