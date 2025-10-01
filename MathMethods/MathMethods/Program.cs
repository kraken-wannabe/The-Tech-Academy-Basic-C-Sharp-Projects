using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //make an object from the class
            VoidMethod math = new VoidMethod();
            //call the void method
            Console.WriteLine("Input a number:");
            int dividend = Convert.ToInt32(Console.ReadLine());
            math.MathOp(dividend);
            Console.WriteLine(math.Value);
            Console.ReadLine();
            //call the method with an out parameter
            Console.WriteLine("Input a phrase: ");
            string input = Console.ReadLine();
            string phrase = math.StringCounter(input, out int count);
            Console.WriteLine(phrase);
            Console.WriteLine("Doubled would be: " + (count * 2));
            Console.ReadLine();

            //Call the overloaded method (no out)
            Console.WriteLine("Input another phrase: ");
            string input2 = Console.ReadLine();
            int phrase2 = math.StringCounter(input2);
            Console.WriteLine("This phrase is " + phrase2 + " characters long.");
            Console.ReadLine();

            //Call a method on a static class
            Console.WriteLine("Input another phrase:");
            string input3 = Console.ReadLine();
            int i_count = VoidMethod.IFinder(input3);
            Console.WriteLine("This phrase has " + i_count + " i's in it.");
            Console.ReadLine();

            //End of program
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}