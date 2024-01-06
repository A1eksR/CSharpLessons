using System;
using Microsoft.Data.Sqlite;


namespace day19v2
{
  
    public class Connection
    {
        public SqliteConnection conn { get; set; }

        public Connection()
        {
            conn = CreateConn();
        }

        public void CloseConn()
        {
            conn.Close();
        }

        public static SqliteConnection CreateConn()
        {
            String desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            String dbPath = "chinook.db";
            String fullName = Path.Combine(desktopPath, dbPath);

            SqliteConnection sqlite_conn = new SqliteConnection("Data Source=" + fullName + "; " );

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

