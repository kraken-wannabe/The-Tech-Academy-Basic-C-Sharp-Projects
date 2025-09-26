using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class MathOperation1
    {
        //Create a method that takes two integers as parameters
        //Make one parameter optional by providing a default value
        public int MathOp(int i, int j= 1)
        {
            int result = i * j;
            return result;
        }
    }
}
