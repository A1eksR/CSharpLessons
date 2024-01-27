using System.Diagnostics.Metrics;
using System.Text.Json;
using Microsoft.Data.Sqlite;

namespace day21;

class Program
{
    static void Main(string[] args)
    {
        Connection connection = new Connection();
        Employee employees = new Employee(145, "Janis", "Berzins", "Riga", "Latvia");
        String json = JsonSerializer.Serialize(employees);
        String desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        String fullName = Path.Combine(desktopPath, "JSON.txt");

        try
        {
            StreamWriter wr = new StreamWriter(fullName, false);

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

