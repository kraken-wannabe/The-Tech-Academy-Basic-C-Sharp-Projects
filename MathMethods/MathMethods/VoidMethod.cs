using System;


namespace ClassMethodAssignment
{
    public class VoidMethod
    {
        //the void method will set a value to the public property
        public int Value { get; set; }

        // stores the result in the value property
        public void MathOp(int number)
        {
            // example operation int divide 2
            Value = number / 2;
        }

        //method with an out parameter
        public string StringCounter(string input, out int count)
        {
            input ??= string.Empty;
            count = input.Length;
            return $"You entered: \"{input}\"";
        }
        //overload no out parameter
        public int StringCounter(string input)
        {
            input ??= string.Empty;
            return input.Length;
        }
        //static method to count i's in a string
        public static int IFinder(string input)
        {
            input ??= string.Empty;
            int total = 0;
            foreach (char c in input)
            {
                if (c == 'i' || c == 'I') total++;
            }
            return total;
        }
    }
}