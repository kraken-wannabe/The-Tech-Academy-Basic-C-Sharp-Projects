using System;

namespace MathAndComparisonOperatorsAssignment;
class Program
{
    static void Main(string[] args)
    {
        //Print the title of the program
        Console.WriteLine("Anonymous Income Comparison Program");

        //Get details for Person 1
        Console.WriteLine("\nPerson 1");
        Console.Write("Hourly Rate? ");
        //user input for hourly rate
        decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Hours worked per week? ");
        //user input for hours worked per week
        int hoursperWeek1 = Convert.ToInt32(Console.ReadLine());

        //Get details for Person 2
        Console.WriteLine("\nPerson 2");
        Console.Write("Hourly Rate? ");
        //user input for hourly rate
        decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Hours worked per week? ");
        //user input for hours worked per week
        int hoursperWeek2 = Convert.ToInt32(Console.ReadLine());

        //Calculate annual salary for Person 1
        decimal annualSalary1 = hourlyRate1 * hoursperWeek1 * 52;
        Console.WriteLine("\nAnnual salary of Person 1:");
        Console.WriteLine(annualSalary1);

        //Calculate annual salary for Person 2
        decimal annualSalary2 = hourlyRate2 * hoursperWeek2 * 52;
        Console.WriteLine("\nAnnual salary of Person 2:");
        Console.WriteLine(annualSalary2);  

        //Compare salary of Person 1 and Person 2
        Console.WriteLine("\nPerson 1 makes more money than person 2");
        Console.WriteLine(annualSalary1 > annualSalary2);


        Console.ReadLine();
    }
    }