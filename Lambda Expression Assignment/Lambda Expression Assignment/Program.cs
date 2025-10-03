using System;
using System.Collections.Generic; // for List<T>
using System.Linq; // for LINQ methods and lambda expressions


namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a list of at least 10 employees
            var employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Joe",   LastName = "Doe" },
                new Employee { Id = 2, FirstName = "Anna",  LastName = "Lopez" },
                new Employee { Id = 3, FirstName = "Aira",   LastName = "Chen" },
                new Employee { Id = 4, FirstName = "Mira",  LastName = "Luna" },
                new Employee { Id = 5, FirstName = "Gaby",  LastName = "Reed" },
                new Employee { Id = 6, FirstName = "Jean",  LastName = "Cruz" },
                new Employee { Id = 7, FirstName = "Joe",   LastName = "Malone" }, // second Joe
                new Employee { Id = 8, FirstName = "Ken",  LastName = "Chan" },
                new Employee { Id = 9, FirstName = "Leo",   LastName = "Park" },
                new Employee { Id = 10, FirstName = "Mira", LastName = "Nah" }
            };
            //FOREACH loop make a new list with FirstName == "Joe"
            var joesForeach = new List<Employee>(); //empty list to fill
            foreach (var emp in employees)
            {
                //compare the property FirstName of the object emp
                if (emp.FirstName == "Joe")
                {
                    joesForeach.Add(emp); //keep only Joes
                }
            }
            Console.WriteLine("Joe's (foreach):");
            foreach (var e in joesForeach) Console.WriteLine(e);

            // e => e.FirstName == "Joe" is a lambda expression
            var joesLambda = employees.Where(e => e.FirstName == "Joe").ToList();

            // print the results
            Console.WriteLine("\nJoe's (lambda):");
            foreach (var e in joesLambda) Console.WriteLine(e);

            // using a lambda expression, make a new list with Id > 5
            var idGreaterThan5 = employees.Where(e => e.Id > 5).ToList(); 

            // print the results
            Console.WriteLine("\nEmployees with Id > 5:");
            foreach (var e in idGreaterThan5) Console.WriteLine(e);

            //End of program
            Console.WriteLine("\nPress enter to exit...");
            Console.ReadLine();
        }
    }
}