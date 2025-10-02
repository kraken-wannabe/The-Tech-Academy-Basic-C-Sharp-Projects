using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //abstract base class
    public abstract class Person
    {
        //requirements string properties
        public string firstName { get; set; }
        public string lastName { get; set; }

        //abstract method to be implemented by child classes
        public abstract void SayName();
    }
}
