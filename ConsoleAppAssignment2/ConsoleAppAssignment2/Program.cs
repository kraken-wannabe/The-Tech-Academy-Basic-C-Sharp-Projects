using System;

namespace ConsoleAppAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do loop
            int count = 1;
            do
                {
                Console.WriteLine("Do Loop Count: " + count);
                count++; //add one to count
            } while (count <= 10); //continue while count is less than or equal to 10

            //While loop
            int count2 = 1;
            while (count2 <= 10) //continue while count2 is less than or equal to 10
            {
                Console.WriteLine("While Loop Count: " + count2);
                count2++; //add one to count2
            }
            Console.ReadLine(); //keep console open
        }
    }
}