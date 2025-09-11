using System;

namespace StudentReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //Displays the title and subtitle of the application
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");
            //Asks for student name. The name is stored in a string variable called studentName
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();
            //Asks the course name and stores it.
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            //Asks for the page  number the student is on. The input is converted from string to an integer.
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            //Asks if the student needs help. The input is converted from string into a boolean.
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string needHelp = Console.ReadLine();
            bool needHelpBool = bool.Parse(needHelp);
            //Collects positive experiences and stored as string.
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            //Collects additional feedback and stores it as string.
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            //Asks how many house the student studied. Converts the input into an integer.
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int studyHoursInt = Convert.ToInt32(studyHours);
            //Displays a closing thank you message.
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }   
    }
}