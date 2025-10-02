using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    //abstract base class
    public abstract class Person
    {
        //requirements string properties
        public string firstName { get; set; }
        public string lastName { get; set; }

        //abstract method to be implemented in derived classes
        public abstract void SayName();
    }
}
