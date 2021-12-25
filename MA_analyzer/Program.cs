// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int counter = 0;

var lines = System.IO.File.ReadLines(@"..\..\..\data\feed.json");

// Read the file and display it line by line.  
foreach (string line in lines)
{
    extract(line, "about");
    extract(line, "team");
    extract(line, "customers");
   
    counter++;
}

System.Console.WriteLine("There were {0} lines.", counter);
// Suspend the screen.  
System.Console.ReadLine();  

string extract (string line, string keyWord)
{
    if (line.Contains(keyWord))
    {
        var data = line.Substring(line.IndexOf(':') + 1);
        data = data.Substring(0, data.Length - 1);
        System.Console.WriteLine(data);
        System.Console.WriteLine("\n");
        return data; 
    }
    return string.Empty;
    
}