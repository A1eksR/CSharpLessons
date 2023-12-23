using System.Data.SQLite;
namespace day18;
class Program
{
    static void Main(string[] args)
    {
        SQLiteConnection conn = Connections.CreateConn();
        Connections.ReadEmployeeInfo(conn);
        Console.ReadLine();
    }
}
