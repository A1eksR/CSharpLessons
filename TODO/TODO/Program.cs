using Microsoft.Data.Sqlite;
using static System.Reflection.Metadata.BlobBuilder;

namespace TODO;

class Program
{
    static void Main(string[] args)
    {
        Connections connection = new Connections();

        bool a = false; 
       
        while (a = true)
        {
            Console.WriteLine("Lai beigtu ciklu raksti O");
            String beigtCiklu = Console.ReadLine();
            if(beigtCiklu == "O")
            {
                a = true;
            }

            List<Task> tasks = Queries.CreateTODOList(connection.conn);

            for (int i = 0; i < tasks.Count; i++)
            {
                tasks[i].ShowInfo();
            }


            Console.WriteLine("Ievadi id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadi nosaukumu");
            String title = Console.ReadLine();
            Console.WriteLine("Ievadi autora id");
            String apraksts = Console.ReadLine();
            Console.WriteLine("Ievadi statusu");
            String statuss = Console.ReadLine();

            Queries.InsertTask(connection.conn, id, title, apraksts, statuss);
        }

        Console.ReadLine();
    }

}

