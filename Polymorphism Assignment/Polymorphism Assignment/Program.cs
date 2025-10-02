using System;
using Polymorphism_Assignment;


namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // polymorphism: variable is the interface type, object is Employee
            IQuittable quitter = new Employee { firstName = "The New", lastName = "Student" };

            //call the interface method
            quitter.Quit();

            //End program
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadLine();
        }
    }
}