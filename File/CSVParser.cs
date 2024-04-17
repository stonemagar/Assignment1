using System;
using System.IO;
// using System.Collections.Generic;

public class CSVParser
{
    public List<Person> People { get; private set; }

    public CSVParser()
    {
        People = new List<Person>();
    }

    public void Parse(string filePath)
    {
        using (var reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                // Assuming the CSV columns are in the order: FirstName, LastName, Age
                var person = new Person
                {
                    FirstName = values[2],
                    LastName = values[3],
                   
                };

                People.Add(person);
            }
        }
    }

    public void PrintNames()
    {   
         int i = 0;
        foreach (var person in People)
        {   
            Console.WriteLine($"{i} {person.FirstName}  {person.LastName}");
            i++; 
        }
        
    }
}
