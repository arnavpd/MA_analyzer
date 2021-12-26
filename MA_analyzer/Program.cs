// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;
using Dapper;
using MA_analyzer;
const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\arnav\\source\\repos\\MA_analyzer\\MA_analyzer\\Data\\MA_Data.mdf;Integrated Security=True;Connect Timeout=30";
using (var connection = new SqlConnection(connectionString))
{
    if (connection != null)
    {
        var startups = connection.Query<Company>("select * from Startups").ToList();
    }
}


Console.WriteLine("Hello, World!");
int counter = 0;
var companies = new List<Company>();
var company = new Company();
var lines = System.IO.File.ReadLines(@"..\..\..\data\feed_all.json");

// Read the file and display it line by line.  
foreach (string line in lines)
{
    if (line.Contains("\"date\":"))
    {
        company = new Company();
        companies.Add(company);
    }
    var data = extract(line, "about");
    if (data != null)
    {
        company.About = data;
    }

    data = extract(line, "team");

    if (data != null)
    {
        company.Team = data;
    }

    data = extract(line, "customers");

    if (data != null)
    {
        company.Customers = data;
    }

    data = extract(line, "revenue");

    if (data != null)
    {
        company.Revenue = data;
    }

    data = extract(line, "startupId");
    if (data != null)
    {
        company.StartupId = data;
    }

    data = extract(line, "keywords");
    if (data != null)
    {
        company.Keywords = data;
    }

    data = extract(line, "askingPrice");
    if (data != null)
    {
        company.AskingPrice = data;
    }

    data = extract(line, "annualProfit");
    if (data != null)
    {
        company.AnnualProfit = data;
    }

    data = extract(line, "competitors");
    if (data != null)
    {
        company.Competitors = data;
    }

    counter++; 
 }



File.WriteAllText(@"..\..\..\data\startups.csv", "StartupId, About" + Environment.NewLine);
string sqlCustomerInsert = "INSERT INTO Startups (StartupId, About) Values (@StartupId, @About);";
using (var connection = new SqlConnection(connectionString))
{
    if (connection != null)
    {
        connection.Execute("delete Startups");
        foreach (var startup in companies)
        {
            var eachLine = startup.StartupId + ",\'" + startup.About + "\'" + Environment.NewLine;
            File.AppendAllText(@"..\..\..\data\startups.csv", eachLine);
            var affectedRows = connection.Execute(sqlCustomerInsert, startup);
        }
    }
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
    return null;
    
}