using System.Text.Json;

namespace PedejaisMd;

class Program
{
    static void Main(string[] args)
    {
        Connection connection = new Connection();
        Console.WriteLine("Izvelies ko gribi darit :");
        Console.WriteLine("1- saglabāt ierakstus no faila datubāzē, 2-saglabāt ierakstus no datubāzes failā, 3- rediget kadu customer");

        int izvele = Convert.ToInt32(Console.ReadLine());
        if (izvele == 2)
        {
            List<Customer> lst = Queries.CreateEmplList(connection.conn);
            InsertIntoFile(connection, lst);
            Console.WriteLine("Done");
        }
        else if (izvele == 1)
        {
            List<Customer> lst = FileRead.ReadFile();
            Homework(lst);
            Console.WriteLine("Done");
        }
        else if (izvele == 3)
        {
            Console.WriteLine("Ievadi customer id ");
            int ievaditaisId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadi vardu ");
            String jaunaisVards = Console.ReadLine();
            Console.WriteLine("Ievadi uzvardu");
            String jaunaisUzvards = Console.ReadLine();

            Queries.UpdateCus(connection.conn, ievaditaisId, jaunaisVards, jaunaisUzvards);
        }

    }
    static void InsertIntoFile(Connection connection, List<Customer> lst)
    {


        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        String json = JsonSerializer.Serialize(lst, options);

        FileRead.SaveFile(json);
    }
    public static void Homework(List<Customer> lst)
    {
        Connection connection = new Connection();

        foreach (var emp in lst)
        {
            Queries.InsertCus(connection.conn, emp);
        }

        Console.ReadLine();

    }
}

