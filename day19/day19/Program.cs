namespace day19;

class Program
{
    static void Main(string[] args)
    {
        Connection.CreateConn();
        Connection connection = new Connection();

        Queries.InsertEmp(connection.conn, 1, "a", "b", "c", "d");

        List<Employee> employees = Queries.CreateEmplList(connection.conn);

        foreach (Employee employee in employees)
        {
            employee.Print();
        }

        Console.WriteLine("Ievadi id : ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ievadi vardu : ");
        String vards = Console.ReadLine();

        Console.WriteLine("Ievadi uzvardu : ");
        String uzvards = Console.ReadLine();

        Console.WriteLine("Ievadi pilsetu : ");
        String city = Console.ReadLine();

        Console.WriteLine("Ievadi valsti");
        String country = Console.ReadLine();

        Console.ReadLine();
    }
}

