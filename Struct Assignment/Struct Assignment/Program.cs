using System;


namespace StructAssignment
{
    //Create a struct named MyStruct with a decimal property "Amount".
    //struct is a value type in C#
    //decimal is the best for money/precise values
    public struct MyStruct
    {
        //decimal property named Amount to hold a monetary value
        public decimal Amount { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //
            MyStruct struct1 = new MyStruct(); //make a new MyStruct value
            struct1.Amount = 123.45m; // Assign a value to the Amount property

            //Print this amount to the console
            Console.WriteLine("The amount is: " + struct1.Amount);

            //End program
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}