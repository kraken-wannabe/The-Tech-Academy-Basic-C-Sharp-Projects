using System;


namespace Constructor_Assignment
{
    public class Chain
    {
        //The two simpler constructors above call into this one using the "this" keyword
        public Chain(float num1, string name1)
        {
            Num = num1;
            Name = name1;
        }
        //Properties to hold the final values after chaining
        public string Name { get; set; }
        public float Num { get; set; }

        //user gives a number (float)
        //we chain the main constructor setting a deafault name bob
        public Chain(float num1) : this(num1, "Bob")
        {
            Console.WriteLine(num1 + " and your default name is " + Name);
        }

        //we chain the main constructor setting a default number 42
        public Chain(string name1) : this(42, name1)
        {
            Console.WriteLine(name1 + " and your favorite number is " + Num);
        }
    }
}
