using System.Diagnostics.Metrics;
using System.Text.Json;
using Microsoft.Data.Sqlite;

namespace day21;

class Program
{
    static void Main(string[] args)
    {

        //ReadFile();
        Connection connection = new Connection();

        Employee emp1 = new Employee(1, "arturs", "Abolins", "Riga", "Latvija");
        Queries.InsertEmp(connection.conn, emp1);

        Console.ReadLine();
    }
    /*public static void ReadFile()
    {
        String filename = "json.txt";
        try
        {
            String desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            String fullName = Path.Combine(desktopPath, filename);

            StreamReader sr = new StreamReader(fullName);

            String line = sr.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error!");
            Console.WriteLine(ex.Message);
        }
    }*/
    
}

