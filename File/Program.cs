// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


        // var parser = new CSVParser();
        // parser.Parse(@"C:\Users\Dragon\Desktop\InternAssign\Assignment1\File\People.csv"); // Replace with your CSV file path
        // parser.PrintNames();

        // // Wait for user input before closing the console window
        // Console.WriteLine("Press any key to exit...");
        // Console.ReadKey();


// Language Integrated Query

// Imperative [Procedural, OOP etc.] (C, C++, C# etc.) vs Declarative [Functional] (SQL, Haskell, C#, Lisp etc. ) programming languages

using System.Collections.Generic;
using System.Linq;

class LINQ
{
    int[] ages = [23, 45, 67, 8, 9, 12, 345, 67, 889, 34, 56, 78];

    // Find squares of all numbers in ages collection

    static void Main()
    {
        int[] ages = { 23, 45, 67, 8, 9, 12, 345, 67, 889, 34, 56, 78 };

        var cubesOfEvenNumbers = from age in ages
                                 where age % 2 == 0
                                 select age * age * age;

        foreach (var cube in cubesOfEvenNumbers)
        {
            Console.WriteLine(cube);
        }
    }
       
}