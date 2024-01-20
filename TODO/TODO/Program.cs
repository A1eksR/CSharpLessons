using Microsoft.Data.Sqlite;
using static System.Reflection.Metadata.BlobBuilder;

namespace TODO;

class Program
{
    static void Main(string[] args)
    {
        Connections connection = new Connections();

        bool a = false; 
       
        while (a == false)
        {
            Console.WriteLine("Parādīt- 1");
            Console.WriteLine("ievadīt- 2");
            Console.WriteLine("Iziet- 0");

            String beigtCiklu = Console.ReadLine();
            if(beigtCiklu == "0")
            {
                a = true;
            }
            else if(beigtCiklu == "1")
            {
                List<Task> tasks = Queries.CreateTODOList(connection.conn);
                for (int i = 0; i < tasks.Count; i++)
                {
                    tasks[i].ShowInfo();
                }
            }
            else if(beigtCiklu == "2")
            {
                Console.WriteLine("Ievadi id");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ievadi title");
                String title = Console.ReadLine();
                Console.WriteLine("Ievadi aprakstu");
                String apraksts = Console.ReadLine();
                Console.WriteLine("Ievadi statusu");
                String statuss = Console.ReadLine();

                Queries.InsertTask(connection.conn, id, title, apraksts, statuss);
            }
            else
            {
                Console.WriteLine("Nepareiza ievade");
            }

        }

        Console.ReadLine();
    }

}

