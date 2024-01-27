using System.Diagnostics.Metrics;
using System.Text.Json;
using Microsoft.Data.Sqlite;

namespace day21;

class Program
{
    static void Main(string[] args)
    {
        Connection connection = new Connection();
        Queries emp = new Queries();
        List<Employee> lst = Queries.CreateEmplList(connection.conn);
        
        String json = JsonSerializer.Serialize(lst);
        String desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        String fullName = Path.Combine(desktopPath, "JSON.txt");

        try
        {
            StreamWriter wr = new StreamWriter(fullName, false);
            wr.WriteLine(json);
            wr.Flush();
            wr.Dispose();
            Console.WriteLine("Done");
        }
        catch
        {
            Console.WriteLine("Error!");
        }
        Console.ReadLine();
    }

    /*public static void homework()
    {
        List<Employee> lst = FileRead.ReadFile();
        Connection connection = new Connection();

        foreach (var emp in lst)
        {
            Queries.InsertEmp(connection.conn, emp);
        }

        Console.ReadLine();
    }*/

    

}

