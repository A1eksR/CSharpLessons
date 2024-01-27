using System.Diagnostics.Metrics;
using System.Text.Json;
using Microsoft.Data.Sqlite;

namespace day21;

class Program
{
    static void Main(string[] args)
    {


    }

    public static void homework()
    {
        List<Employee> lst = FileRead.ReadFile();
        Connection connection = new Connection();

        foreach (var emp in lst)
        {
            Queries.InsertEmp(connection.conn, emp);
        }

        Console.ReadLine();
    }
      
}

