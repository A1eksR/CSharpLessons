using Microsoft.Data.Sqlite;

namespace Day20Md;

class Program
{
    static void Main(string[] args)
    {
        Connections connection = new Connections();
        List<Book> books = new List<Book>();
        

        Console.WriteLine("Ko gribi darit :");
        Console.WriteLine("1: pievienot jaunu gramatu, 2: paradit visas gramatas");
        int izvele = Convert.ToInt32(Console.ReadLine());

        int jaunaisId = Convert.ToInt32(Console.ReadLine());
        String jaunaisNosaukums = Console.ReadLine();
        int jaunaisAuthorId = Convert.ToInt32(Console.ReadLine());

        if(izvele == 1)
        {
            int id = jaunaisId;
            String nosaukums = jaunaisNosaukums;
            int authorId = jaunaisAuthorId;

            Queries.InsertBook(connection.conn, id, nosaukums, authorId);
        }
        else if (izvele == 2)
        {
            for(int i = 0; i < books.Count; i++)
            {
                Console.WriteLine(books[i]);
            }
        }
        else
        {
            Console.WriteLine("error");
        }
        Console.ReadLine();
    }
}

