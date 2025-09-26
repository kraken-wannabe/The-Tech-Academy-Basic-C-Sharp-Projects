using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssignment
{
    //
    public class MathOps
    {
        private int lastComputed; //stores result of math on first int

        //takes two int. Does math on first and prints second.
        public void Process(int first, int second)
        {
            lastComputed = first * 2; //math on first
            Console.WriteLine(second); //show second
        }
    }
}
