using System;


namespace MethodsAndObjectsAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Inside of the main method, instantiate and initialize
            //an employee object with the first name "Sample" and last name "Student".
            Employee sam = new Employee() { FirstName = "Sample", LastName = "Student" };
            //Call the superclass method SayName() on the Employee object
            sam.sayName();
            Console.ReadLine();
        }
    }
}