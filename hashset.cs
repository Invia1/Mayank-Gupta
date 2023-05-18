using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        HashSet<int> numbers = new HashSet<int>();

        
        numbers.Add(5);
        numbers.Add(10);
        numbers.Add(15);
        numbers.Add(20);

        
        int elementToFind = 10;
        if (numbers.Contains(elementToFind))
        {
            Console.WriteLine($"{elementToFind} is present in the HashSet.");
        }
        else
        {
            Console.WriteLine($"{elementToFind} is not present in the HashSet.");
        }

        
        int elementToRemove = 15;
        if (numbers.Remove(elementToRemove))
        {
            Console.WriteLine($"Removed {elementToRemove} from the HashSet.");
        }
        else
        {
            Console.WriteLine($"{elementToRemove} is not present in the HashSet.");
        }

        
        Console.WriteLine("Elements in the HashSet:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        
        numbers.Clear();

        
        if (numbers.Count == 0)
        {
            Console.WriteLine("HashSet is empty.");
        }
        else
        {
            Console.WriteLine("HashSet is not empty.");
        }
    }
}
