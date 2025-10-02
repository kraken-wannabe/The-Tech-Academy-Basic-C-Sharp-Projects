using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
   
        //Make employee a generic class
        //The <T> is a placeholder for the data type (string, int, double, etc.)
        public class Employee<T>
        {
            //"Things" is a list whose element type matches T
            public List<T> Things { get; set; }

            //Simple constructor so Things is ready to use
            public Employee()
            {
                Things = new List<T>();
            }
        }
}