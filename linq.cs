using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age{get;set;}
}
class Program
{
    static void Main()
    {
       
        List<Person> people = new List<Person>
        {
            new Person { Id = 1, Name = "John", Age = 25 },
            new Person { Id = 2, Name = "Alice", Age = 30 },
            new Person { Id = 3, Name = "Bob", Age = 28 }
        };

        
        var result = from person in people
                     where person.Age > 25
                     select person;

       
    
            
              foreach (var person in result)
        {
            Console.WriteLine("Name: {0}, Age: {1}",person.Name,person.Age);
        }

        
        var personToUpdate = people.FirstOrDefault(person => person.Id == 2);
        if (personToUpdate != null)
        {
            personToUpdate.Age = 32;
        }

        
        people.RemoveAll(person => person.Id == 3);

        
        foreach (var person in people)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }

        Console.ReadLine();
    }
}