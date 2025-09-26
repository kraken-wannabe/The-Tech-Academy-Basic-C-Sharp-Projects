using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate MathOperation1 class
            MathOperation1 mathOp = new MathOperation1();
            //ask user to proviude parameter
            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            //Ask user to provide a second number or press enter
            Console.WriteLine("Enter a second number or just press enter: ");
            try
            {
                //Call method with 2 parameters if both parameters are provided
                int num2 = Convert.ToInt32(Console.ReadLine());
                int results = mathOp.MathOp(num1, num2);
                Console.WriteLine(num1 + " x " + num2 + " = " + results);
             }
            catch
            {
                //Call methoiod with one parameter if only one is provided
                int results = mathOp.MathOp(num1);
                Console.WriteLine(num1 + " x Default 1 = " + results);
            }
            //End Program
            Console.WriteLine("\nPress any key to exit");
            Console.ReadLine();
        }
    }
}
