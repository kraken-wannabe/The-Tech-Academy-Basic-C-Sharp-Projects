using System;


namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make two employees and set their properties
            var emp1 = new Employee { Id = 101, FName = "Alice", LName = "Smith" };
            var emp2 = new Employee { Id = 102, FName = "Bob", LName = "Johnson" };

            //show the employees
            Console.WriteLine("Employees created");
            Console.WriteLine(emp1);
            Console.WriteLine(emp2);
            Console.WriteLine();

            //Compare with the overloaded operators
            Console.WriteLine("Comparisons using overloaded operators:");
            Console.WriteLine($"emp1 == emp2: {emp1 == emp2}"); //false (101 vs 102)
            Console.WriteLine($"emp1 != emp2: {emp1 != emp2}"); //true
            Console.WriteLine();

            //show a case where Ids match
            var emp3 = new Employee { Id = 101, FName = "Charlie", LName = "Brown" };
            Console.WriteLine("New employee created:");
            Console.WriteLine(emp3);
            Console.WriteLine($"emp1 == emp3: {emp1 == emp3}"); //True (same Id)
            Console.WriteLine();

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();

        }
    }
}