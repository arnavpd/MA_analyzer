// See https://aka.ms/new-console-template for more information
using MA_analyzer;

Console.WriteLine("Hello, World!");
int counter = 0;
var companies = new List<Company>();
var lines = System.IO.File.ReadLines(@"..\..\..\data\feed.json");

// Read the file and display it line by line.  
foreach (string line in lines)
{
    var company = new Company();
    companies.Add(company);
    company.About = extract(line, "about");
    company.Team = extract(line, "team");
    company.Customers = extract(line, "customers");
    company.Revenue = extract(line, "revenue");

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