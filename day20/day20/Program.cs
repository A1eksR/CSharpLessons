using System.Xml.Linq;
using Microsoft.Data.Sqlite;

namespace day20;

class Program
{
    static void Main(string[] args)
    {
        Connection connection = new Connection();

        List<Author> authors = Queries.CreateAuthorList(connection.conn);

        foreach (Author employee in authors)
        {
            employee.ShowInfo();
        }

        Console.WriteLine("Ievadi id!");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ievadi vārdu!");
        String vards = Console.ReadLine();

        Console.WriteLine("Ievadi uzvārdu!");
        String uzvards = Console.ReadLine();

         authors.Add(new Author(id, vards, uzvards));
        Queries.InsertAuthor(connection.conn, id, vards, uzvards);
    }
}

