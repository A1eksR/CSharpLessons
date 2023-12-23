namespace day18;
using System.Data.SQLite;
class Program
{
    static void Main(string[] args)
    {
        
        Connections.CreateConn();
        
        Connections.ReadEmployeeInfo(SQLiteConnection conn);
        Console.ReadLine();
    }
}
class Connections
{
    SQLiteConnection conn = CreateConn();

    public static SQLiteConnection CreateConn()
    {
        
        String desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        String dbPath = "chinook.db";
        String fullName = Path.Combine(desktopPath, dbPath);

        SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=" + fullName + "; Version=3");

        try
        {
            sqlite_conn.Open();
        }
        catch
        {
            Console.WriteLine("Error");
        }

        return sqlite_conn;
    }

    public static void ReadEmployeeInfo(SQLiteConnection conn)
    {
        SQLiteDataReader sQLiteDataReader;
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText =
            "SELECT (employee.FirstName || ' ' || employee.LastName) as 'Employee name'"+
            "(employee.Title || ' ' || employee.City || ' ' || employee.Country) as 'Employee info'" +
            "FROM employee";

        sQLiteDataReader = cmd.ExecuteReader();

        while (sQLiteDataReader.Read())
        {
            String employeeName = sQLiteDataReader.GetString(0);
            String employeeInfo = sQLiteDataReader.GetString(1);

            Console.WriteLine(employeeName + ": " + employeeInfo);
        }
        conn.Close();
    }

}