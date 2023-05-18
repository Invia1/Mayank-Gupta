using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        Dictionary<string, int> studentScores = new Dictionary<string, int>();

        
        studentScores.Add("John", 80);
        studentScores.Add("Emily", 95);
        studentScores.Add("Michael", 70);

        
        string studentName = "Emily";
        if (studentScores.ContainsKey(studentName))
        {
            int score = studentScores[studentName];
            Console.WriteLine($"Score of {studentName}: {score}");
        }
        else
        {
            Console.WriteLine($"No score found for {studentName}");
        }

        
        string studentToUpdate = "John";
        if (studentScores.ContainsKey(studentToUpdate))
        {
            studentScores[studentToUpdate] = 90;
            Console.WriteLine($"Updated score of {studentToUpdate}: {studentScores[studentToUpdate]}");
        }

        
        Console.WriteLine("All student scores:");
        foreach (KeyValuePair<string, int> pair in studentScores)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }

        
        string studentToRemove = "Michael";
        if (studentScores.ContainsKey(studentToRemove))
        {
            studentScores.Remove(studentToRemove);
            Console.WriteLine($"Removed {studentToRemove} from the Dictionary.");
        }

        
        string studentToCheck = "John";
        if (studentScores.ContainsKey(studentToCheck))
        {
            Console.WriteLine($"{studentToCheck} is present in the Dictionary.");
        }
        else
        {
            Console.WriteLine($"{studentToCheck} is not present in the Dictionary.");
        }

        
        studentScores.Clear();

        
        if (studentScores.Count == 0)
        {
            Console.WriteLine("Dictionary is empty.");
        }
        else
        {
            Console.WriteLine("Dictionary is not empty.");
        }
    }
}
