// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int counter = 0;

var lines = System.IO.File.ReadLines(@"..\..\..\data\feed.json");

// Read the file and display it line by line.  
foreach (string line in lines)
{
    System.Console.WriteLine(line);
    counter++;
}

System.Console.WriteLine("There were {0} lines.", counter);
// Suspend the screen.  
System.Console.ReadLine();