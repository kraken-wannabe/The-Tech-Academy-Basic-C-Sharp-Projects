using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    //Employee class with Id, FirstName, LastName properties
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        //nice way to display an employee
        public override string ToString() => $"{Id}: {FirstName} {LastName}";
    }
}
