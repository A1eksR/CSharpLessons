using System;
using System.Data.SQLite;
namespace day18
{
	public class Employees
	{
        public int id { get; set; }
        public String vards { get; set; }
        public String uzvards { get; set; }
        public String pilseta { get; set; }
        public String valsts { get; set; }

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


        public Employees(SQLiteConnection conn)
        {
            SQLiteDataReader sQLiteDataReader1;
            SQLiteCommand cmd1 = conn.CreateCommand();
            cmd1.CommandText =
                "SELECT employee.FirstName" +
                "FROM employees;";

            sQLiteDataReader1 = cmd1.ExecuteReader();

            SQLiteDataReader sQLiteDataReader2;
            SQLiteCommand cmd2 = conn.CreateCommand();
            cmd2.CommandText =
                "SELECT employee.LastName" +
                "FROM employees;";

            sQLiteDataReader2 = cmd2.ExecuteReader();

            SQLiteDataReader sQLiteDataReader3;
            SQLiteCommand cmd3 = conn.CreateCommand();
            cmd3.CommandText =
                "SELECT employee.EmployeeId" +
                "FROM employees;";

            sQLiteDataReader3= cmd3.ExecuteReader();

            SQLiteDataReader sQLiteDataReader4;
            SQLiteCommand cmd4 = conn.CreateCommand();
            cmd4.CommandText =
                "SELECT employee.City" +
                "FROM employees;";

            sQLiteDataReader4 = cmd4.ExecuteReader();

            SQLiteDataReader sQLiteDataReader5;
            SQLiteCommand cmd5 = conn.CreateCommand();
            cmd5.CommandText =
                "SELECT employee.City" +
                "FROM employees;";

            sQLiteDataReader5 = cmd5.ExecuteReader();

            id = sQLiteDataReader3;
            vards = sQLiteDataReader1;
            uzvards = sQLiteDataReader3;
            pilseta = sQLiteDataReader4;
            valsts = sQLiteDataReader5;
        }
        
    }
}

