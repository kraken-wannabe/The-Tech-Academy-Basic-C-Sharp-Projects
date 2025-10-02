using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    // Represents an employee
    public class Employee
    {
        //Properties
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }

        //Equality operator: compare by Id
        public static bool operator == (Employee left, Employee right)
        {
            //if both are the same reference, they are equal
            if (ReferenceEquals(left, right)) return true;

            //If either side is null, not equal
            if (left is null || right is null) return false;

            //Compare Ids
            return left.Id == right.Id;
        }
        // Must overload != when overloading ==
        public static bool operator != (Employee left, Employee right) => !(left == right);

        //Override Equals to match the == behavior         
        public override bool Equals(object obj)
        {
            if (obj is Employee other) return this == other;
            return false;
        }
            //Hash code should be consistent with equality
            public override int GetHashCode() => Id.GetHashCode();

            //Text for printing
            public override string ToString() => $"{Id}: {FName} {LName}";
    }   
}
