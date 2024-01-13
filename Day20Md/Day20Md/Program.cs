using Microsoft.Data.Sqlite;

namespace Day20Md;

class Program
{
    static void Main(string[] args)
    {
        Connections connection = new Connections();
        
        Console.WriteLine("Ko gribi darit :");
        Console.WriteLine("1: pievienot jaunu gramatu, 2: paradit visas gramatas");
        String izvele = Console.ReadLine();

        if(izvele == "1")
        {
            Console.WriteLine("Ievadi id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadi nosaukumu");
            String nosaukums = Console.ReadLine();
            Console.WriteLine("Ievadi autora id");
            int authorId = Convert.ToInt32(Console.ReadLine());

            Queries.InsertBook(connection.conn, id, nosaukums, authorId);
        }
        else if (izvele == "2")
        {
            List<Book> books = Queries.CreateBookList(connection.conn);

            for (int i = 0; i < books.Count; i++)
            {
                books[i].ShowInfo();
            }
        }
        else
        {
            Console.WriteLine("error");
        }
        Console.ReadLine();
    }
}

