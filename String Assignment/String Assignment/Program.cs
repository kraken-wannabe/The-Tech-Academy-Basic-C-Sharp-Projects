using System;
using System.Text;



namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cpmcatenate three strings
            string first = "Hello,";
            string second = "my name is";
            string third = "Kent.";

            //Concatenation: joins the three strigns into one sentence
            string fullSentence = first + " " + second + " "+ third;
            Console.WriteLine("Concatenated string: " + fullSentence);

            //Convert a string to uppercase
            //Use toUpper() method to change all characters to uppercase
            string upperCaseSentence = fullSentence.ToUpper();
            Console.WriteLine("Uppercase version: " + upperCaseSentence);

            //Create a stringbuilder and build a paragraph of text
            //string builder is more efficient for building or edting strings
            StringBuilder paragraph = new StringBuilder();

            //append sentences one at a time
            paragraph.AppendLine("This is the first sentence.");
            paragraph.AppendLine("Here is the second sentence.");
            paragraph.AppendLine("Finally, this is the third sentence that completes the paragraph.");

            Console.WriteLine("\nParagraph using StringBuilder:");
            Console.WriteLine(paragraph);

            //Keep  console window open
            Console.ReadLine();
        }
    }
    
        
    }
