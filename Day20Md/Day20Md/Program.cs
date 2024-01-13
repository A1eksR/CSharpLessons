using Microsoft.Data.Sqlite;

namespace Day20Md;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ko gribi darit :");
        Console.WriteLine("1: pievienot jaunu gramatu, 2: paradit visas gramatas");
        int izvele = Convert.ToInt32(Console.ReadLine());
        if(izvele == 1)
        {
            Queries.InsertBook(SqliteConnection conn, id, nosaukums, authorId);
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
            Console.WirteLine("error");
        }
        Console.ReadLine();
    }
}

