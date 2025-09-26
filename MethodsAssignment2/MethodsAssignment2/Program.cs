using System;


namespace MethodsAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the class so we can call its instance methods
            MathMethod2 math1 = new MathMethod2();

            //Call the first overload with an int parameter
            Console.WriteLine(math1.MathOp(7)); //expects 7 + 7 = 14

            //Call the second oveerload with a decimal parameter
            //using the m suffix to indicate decimal literal
            Console.WriteLine(math1.MathOp(7.3m)); //expects 7 * 20 = 140

            //Call the third overload with a string parameter
            Console.WriteLine(math1.MathOp("7")); //expects 7 % 3 = 1

            //End program
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadLine();
        }
    }
}