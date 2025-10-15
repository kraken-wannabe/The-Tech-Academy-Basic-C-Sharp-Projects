using System;


namespace DateTimeAssignment

{
    class Program
    {
        static void Main(string[] args)
        {
            //show the current date and time
            Console.WriteLine("Current date and time: " + DateTime.Now);

            //ask user how many hours to add
            Console.Write("Enter number of hours to add: ");

            //get user input and add hours to current date and time
            int hoursToAdd = int.Parse(Console.ReadLine());

            //add hours to current date and time
            DateTime newDateTime = DateTime.Now.AddHours(hoursToAdd);
            //show the new date and time
            Console.WriteLine("New date and time: " + newDateTime);

        
            Console.ReadLine();

        }
    }
}