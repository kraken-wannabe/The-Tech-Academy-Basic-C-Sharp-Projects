using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstStudent
{
    public class SchoolContext : DbContext
    {
        
        public SchoolContext() : base("SchoolContext")
        {

        }
       //this becomes a table called Students
        public DbSet<Student> Students { get; set; }
    }
}
