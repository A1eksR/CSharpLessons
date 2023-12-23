using System;
using System.Data.SQLite;
namespace day18
{
	public class Employees
	{
        public int id { get; set; }
        public String vards;
        public String uzvards;
        public String pilseta;
        public String valsts;

        public Employees(int id, String vards, String uzvards, String pilseta, String valsts)
        {
            this.id = id;
            this.vards = vards;
            this.uzvards = uzvards;
            this.pilseta = pilseta;
            this.valsts = valsts;
        }

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
                "SELECT employees.EmployeeId, employees.FirstName, employees.LastName, employees.City, employees.Country" +
                "FROM employees;";

            sQLiteDataReader = cmd.ExecuteReader();

            while (sQLiteDataReader.Read())
            {
                int id = sQLiteDataReader.GetString(0);
                String employeeName = sQLiteDataReader.GetString(1);
                String employeeInfo = sQLiteDataReader.GetString(2);
                String city = sQLiteDataReader.GetString(3);
                String country = sQLiteDataReader.GetString(4);


                Console.WriteLine(employeeName + ": " + employeeInfo);
                Console.WriteLine(country + ", " + city);
                Console.WriteLine("------------");
            }
        }

    }
}

