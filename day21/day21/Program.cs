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
        Console.WriteLine("1- saglabāt ierakstus no faila datubāzē, 2-saglabāt ierakstus no datubāzes failā");
        List<Employee> list1 = FileRead.ReadFile();
        List<Employee> lst = Queries.CreateEmplList(connection.conn);
        int izvele = Convert.ToInt32(Console.ReadLine());
        if(izvele == 2)
        {
            InsertIntoFile(connection, lst);
        }
        else if(izvele == 1)
        {
            foreach(var emp in list1)
            {
                lst.Add(emp);
            }
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

