using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //open the database (creates it the first time)
            using (var db = new SchoolContext())
            {
                // make one student
                var s = new Student
                {
                    FirstName = "Juan",
                    LastName = "Dela Cruz"
                };


                db.Students.Add(s); //stage the insert
                db.SaveChanges(); //write to the databse

                Console.WriteLine("Added 1 student.");
            }

            Console.WriteLine("Done. Press any key to exit.");
            Console.ReadLine();
        }
    }
}
