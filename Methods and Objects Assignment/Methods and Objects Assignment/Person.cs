using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    public class Person
    {
        //Create a class called Person and give two properties:
        //FirstName and LastName.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Give the class a void method called SayName()
        //that prints the person's full name to the console in the format of:
        public void sayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
