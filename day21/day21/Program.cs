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

        Console.WriteLine("Ievadi id");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ievadi vardu");
        String vards = Console.ReadLine();
        Console.WriteLine("Ievadi autora id");
        String uzvards = Console.ReadLine();
        Console.WriteLine("Ievadi pilsetu");
        String city = Console.ReadLine();
        Console.WriteLine("country");
        String country = Console.ReadLine();

        Queries.InsertEmp(connection.conn, id, vards, uzvards, city, country);

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

