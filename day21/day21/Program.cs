using System.Diagnostics.Metrics;
using System.Text.Json;
using Microsoft.Data.Sqlite;

namespace day21;

class Program
{
    static void Main(string[] args)
    {
        Connection connection = new Connection();
        Console.WriteLine("Izvelies ko gribi darit :");
        Console.WriteLine("1- saglabāt ierakstus no faila datubāzē, 2-saglabāt ierakstus no datubāzes failā, 3- rediget kadu employee");

        int izvele = Convert.ToInt32(Console.ReadLine());
        if(izvele == 2)
        {
            List<Employee> lst = Queries.CreateEmplList(connection.conn);
            InsertIntoFile(connection, lst);
            Console.WriteLine("Done");
        }
        else if(izvele == 1)
        {
            List<Employee> lst = FileRead.ReadFile();
            Homework(lst);
            Console.WriteLine("Done");
        }
        else if(izvele == 3)
        {
            Console.WriteLine("Ievadi id");
            int ievaditaisId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadi jauno vardu");
            String jaunaisVards = Console.ReadLine();
            Console.WriteLine("Ievadi jauno uzvardu");
            String jaunaisUzvards = Console.ReadLine();

            Queries.UpdateEmp(connection.conn, ievaditaisId, jaunaisVards, jaunaisUzvards);
            Console.WriteLine("Done");
        }
        Console.ReadLine();

    }
    static void InsertIntoFile(Connection connection, List<Employee> lst)
    {
        

        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        String json = JsonSerializer.Serialize(lst, options);

        FileRead.SaveFile(json);
    }

    public static void Homework(List<Employee> lst)
    {
        Connection connection = new Connection();

        foreach (var emp in lst)
        {
            Queries.InsertEmp(connection.conn, emp);
        }

        Console.ReadLine();
    }

    

}

