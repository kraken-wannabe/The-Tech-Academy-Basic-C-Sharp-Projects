using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment2
{
    //Holds three overloads of the same method name
    //each taking a different parameter type but all returning int
    public class MathMethod2
    {
        //first method, takes an int, does a simple math operation and returns an int
        public int MathOp(int number)
        {
            //example operation: add 7
            return number + 7;
        }
        //second method, takes a decimal, coverts it to int
        //performs a different math operation, returns int.
        public int MathOp(decimal number)
        {
            //convert decimal to int (fractional part is rounded)
            int newnum = Convert.ToInt32(number);

            //example operation: multiply by 20
            return newnum * 20;
        }

        //third method takes a string converts it to int
        //performs another operation, return int
        public int MathOp(string number)
        {
            //convert string to int
            int newnum = Convert.ToInt32(number);

            //example operation modulus 3
            return newnum % 3;
        }
      }
    }
