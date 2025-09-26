using System;

namespace VoidMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class
            MathOps ops = new MathOps();

            //call the method class passing two numbers
            ops.Process(5, 42);    

            //call the method again specifying parameters by name
            ops.Process(second: 99, first: 3); 

            //ENd program
            Console.WriteLine("\nPress Enter to exit.");
            Console.ReadLine();
        }
    }
}