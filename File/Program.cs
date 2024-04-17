// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


        var parser = new CSVParser();
        parser.Parse(@"C:\Users\Dragon\Desktop\gitdemo\File\People.csv"); // Replace with your CSV file path
        parser.PrintNames();

        // Wait for user input before closing the console window
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
