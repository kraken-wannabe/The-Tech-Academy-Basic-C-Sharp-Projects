using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine($"Passing test score: {testScores[i]}");
        //    }
        //}
        //Console.ReadLine();
        //string[] names = { "Jesse", "Erik", "Daniel", "Adam", "Ben" };

        //for (int j = 0; j < names.Length; j++)
        //{
        //    if (names[j] == "Jesse")
        //    {
        //        Console.WriteLine(names[j]);
        //    }
        //}
        //Console.ReadLine();

        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(70);
        //testScores.Add(92);

        //foreach (int score in testScores)
        //    {
        //    if (score > 85)
        //    {
        //        Console.WriteLine($"Passing test score: {score}");
        //    }
        //}
        
        //List<string> names = new List<string>() { "Jesse", "Erik", "Daniel", "Adam", "Ben" };
        //foreach (string name in names)
        //{
        //    {
        //        Console.WriteLine(name);
        //    }
        //}
        List<int> testScores = new List<int>() { 98, 99, 81, 72, 70, 92 };
        List<int> passingScores = new List<int>();

        foreach (int score in testScores)
        {
            if (score > 85)
            {
                passingScores.Add(score);
            }
        }
        Console.WriteLine(passingScores.Count);





















        Console.ReadLine();
    }
}