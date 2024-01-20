using System;
using Microsoft.Data.Sqlite;
namespace TODO
{
	public class Connections
	{
        
        public SqliteConnection conn { get; set; }

        public Connections()
        {
            conn = CreateConn();
        }

        public void CloseConn()
        {
            conn.Close();
        }

        private static SqliteConnection CreateConn()
        {
            String desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            String dbPath = "TODO.db";
            String fullName = Path.Combine(desktopPath, dbPath);

            SqliteConnection sqlite_conn = new SqliteConnection("Data Source=" + fullName + ";");

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
        
    }
}

