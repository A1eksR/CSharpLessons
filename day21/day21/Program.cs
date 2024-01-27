using System.Diagnostics.Metrics;
using System.Text.Json;
using Microsoft.Data.Sqlite;

namespace day21;

class Program
{
    static void Main(string[] args)
    {
        Connection connection = new Connection();
        List<Employee> lst = Queries.CreateEmplList(connection.conn);

        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        String json = JsonSerializer.Serialize(lst, options);

        FileRead.SaveFile(json);

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

