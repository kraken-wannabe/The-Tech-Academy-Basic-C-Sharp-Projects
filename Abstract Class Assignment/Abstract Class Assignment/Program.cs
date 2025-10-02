using System;


namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //make an employee and set the names
            Employee emp = new Employee {  firstName = "Sample", lastName = "Student" };

            // call SayName() on the object
            emp.SayName();

            //end program
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadLine();
        }
    }
}