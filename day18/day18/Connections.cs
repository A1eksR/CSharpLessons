using System;
using System.Data.SQLite;
namespace day18
{
    public class Connections
    {
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


        public static void ReadCustomerCount(SQLiteConnection conn)
        {
            SQLiteDataReader sQLiteDataReader;
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(customers.CustomerId) FROM customers";

            sQLiteDataReader = cmd.ExecuteReader();

            while (sQLiteDataReader.Read())
            {
                int line = sQLiteDataReader.GetInt32(0);
                Console.WriteLine(line);
            }
        }

        public static void ReadEmployeeInfo(SQLiteConnection conn)
        {
            SQLiteDataReader sQLiteDataReader;
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                "SELECT(employees.FirstName || ' ' || employees.LastName) as 'Employee name', employees.Title, employees.City,employees.Country " +
                "FROM employees;";

            sQLiteDataReader = cmd.ExecuteReader();

            while (sQLiteDataReader.Read())
            {
                String employeeName = sQLiteDataReader.GetString(0);
                String employeeInfo = sQLiteDataReader.GetString(1);
                String city = sQLiteDataReader.GetString(2);
                String country = sQLiteDataReader.GetString(3);


                Console.WriteLine(employeeName + ": " + employeeInfo);
                Console.WriteLine(country + ", " + city);
                Console.WriteLine("------------");
            }
        }
    }
}
	


