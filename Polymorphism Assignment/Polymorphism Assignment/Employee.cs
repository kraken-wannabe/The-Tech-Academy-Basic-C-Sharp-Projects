using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polymorphism_Assignment;

namespace PolymorphismAssignment
{
    // Employee still inherits Person AND implements IQuittable
    public class Employee : Person, IQuittable
    {
        //print full name
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        //required by IQuittable interface
        public void Quit()
        {
            //implement any behavior you want
            Console.WriteLine(firstName + " " + lastName + " has quit. Goodbye!");
        }
    }
}
