using System;

namespace StringArrayAppender
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Part 1
            ////create a one dimensional array of strings
            //string[] names = { "Ken", "Jean", "Jim", "James" };

            ////ask the user to enter a name
            //Console.WriteLine("Enter a name to append to the array:");
            //string userInput = Console.ReadLine();

            ////First loop - append the user input to each element in the array
            //for (int i = 0; i < names.Length; i++)
            //{
            //    names[i] += " " + userInput;
            //}
            ////Second loop - display the modified array
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //////end program
            ////Console.WriteLine("\nProgram finished. Press any key to exit.");
            ////Console.ReadLine();
            //----------------------------------------------------------------------------



            ////Part 2
            ////create a one dimensional array of strings
            //string[] names = { "Ken", "Jean", "Jim", "James" };

            ////Ask the user to enter a name
            //Console.WriteLine("Enter a name to append to the array:");
            //string userInput = Console.ReadLine();

            ////Append the user input to each name
            //for (int i = 0; i < names.Length; i++)
            //{
            //    names[i] += " " + userInput;
            //}

            ////Infinite loop (example: while (true) will never stop)
            ////Console.WriteLine("This is an infinite loop example:");
            ////while (true)
            ////{
            ////    Console.WriteLine("This will print forever.");
            ////}

            ////fixed loop
            //Console.WriteLine("\nNow printing the updated names properly:");
            //int counter = 0;
            //while (counter < names.Length) //loop ends when counter is no longer less than names.Length
            //{
            //    Console.WriteLine(names[counter]);
            //    counter++; //increment counter to avoid infinite loop
            //}
            ////end program
            //Console.WriteLine("\nProgram finished. Press any key to exit.");
            //Console.ReadLine();
            //--------------------------------------------------------------------------






            ////part 3
            ////create a one dimensional array of strings
            //string[] names = { "Ken", "Jean", "Jim", "James" };

            ////Ask the user to enter a name
            //Console.WriteLine("----------Loop using '<' operator-----");
            ////using < operator
            ////This will print each name in the array until index is no longer less than names.Length
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine("Index " + i+ ": " +names[i]);
            //}

            //Console.WriteLine("----------Loop using '<=' operator-----");
            ////using <= operator
            ////This will cause an "Index out of range" error because the loop tries to access an index equal to names.Length
            //for (int i = 0; i <= names.Length; i++)
            //{
            //    Console.WriteLine("Index " + i + ": " + names[i]);
            //}
            ////end program
            //Console.WriteLine("\nProgram finished. Press any key to exit.");
            //Console.ReadLine();
            //--------------------------------------------------------------------------

            ////part 4
            ////create a one dimensional array of strings
            //List<string> names = new List<string> { "Ken", "Jean", "Jim", "James" };
            ////Ask the user to enter a name
            //Console.WriteLine("Enter a name to search for in the list");
            //string userInput = Console.ReadLine();

            ////Loop through the array to find the user's input
            //bool found = false; //flag to track if name is found
            //for (int i = 0; i < names.Count; i++)
            //{
            //    if (names[i].Equals(userInput, StringComparison.OrdinalIgnoreCase))
            //    {
            //        Console.WriteLine("Found " + userInput + " at index " + i);
            //        found = true; //set flag to true if name is found
            //        break; //exit loop early since we found the name
            //    }
            //}

            ////if no match was found, tekl the user
            //if (!found)
            //{
            //    Console.WriteLine($"Sorry, {userInput} was not found in the list.");
            //}
            ////end program
            //Console.WriteLine("\nProgram finished. Press any key to exit.");
            //Console.ReadLine();
            ////--------------------------------------------------------------------------


            ////Part 5
            ////Create a list with some duplicate names
            //List<string> names = new List<string> { "Ken", "Jean", "Jim", "James", "Jean", "Jim" };

            ////Ask the user to enter a name
            //Console.WriteLine("Enter a name to search for in the list:");
            //string userInput = Console.ReadLine();

            ////Loop through the list to find all occurrences of the user's input
            //bool found = false; //flag to track if name is found
            //for (int i = 0; i < names.Count; i++)
            //{
            //    if (names[i].Equals(userInput, StringComparison.OrdinalIgnoreCase))
            //    {
            //        Console.WriteLine("Found " + userInput + " at index " + i);
            //        found = true; //set flag to true if name is found
            //        //do not break - continue searching for more occurrences
            //    }
            //}

            ////If no match was found, tell the user
            //if (!found)
            //{
            //    Console.WriteLine($"Sorry, {userInput} was not found in the list.");
            //}

            ////End program
            //Console.WriteLine("\nProgram finished. Press any key to exit.");
            //Console.ReadLine();
            //--------------------------------------------------------------------------



            //Part 6
            //Create a list of strings (with duplicates)
            List<string> names = new List<string> { "Ken", "Jean", "Jim", "James", "Jean", "Jim" };
            List<string> repeats = new List<string>();
            Console.WriteLine("The list contains the following names (including duplicates):");

            //Create foreach loop that prints each name in the list
            foreach (string name in names)
            {
                Console.WriteLine(name);
                if (repeats.Contains(name))
                {
                    Console.WriteLine("This name has duplicate. \nPlease try again.");
                }
                else
                {
                    Console.WriteLine("This name is unique");
                }
                repeats.Add(name);
            } Console.ReadLine();


        }
    }
}