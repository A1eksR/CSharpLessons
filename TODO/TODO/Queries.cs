using System;
using Microsoft.Data.Sqlite;

namespace TODO
{
	public class Queries
	{
        public static List<Task> CreateTODOList(SqliteConnection conn)
        {
            List<Task> tasks = new List<Task>();

            SqliteDataReader sQLiteDataReader;
            SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT TODO.id, TODO.title, TODO.apraksts, TODO.statuss " +
                "FROM TODO ;";

            sQLiteDataReader = cmd.ExecuteReader();
            while (sQLiteDataReader.Read())
            {
                int id = sQLiteDataReader.GetInt32(0);
                String title = sQLiteDataReader.GetString(1);
                String apraksts = sQLiteDataReader.GetString(2);
                String statuss = sQLiteDataReader.GetString(3);
                

                tasks.Add(new Task(id, title, apraksts, statuss));
            }

            return tasks;
        }

        public static void InsertTask(SqliteConnection conn, int id, String title, String apraksts, String statuss)
        {
            SqliteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO TODO(id, title, apraksts, statuss) " +
                "VALUES (@id, @title, @apraksts, @statuss);";


            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@apraksts", apraksts);
            cmd.Parameters.AddWithValue("@statuss", statuss);
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("It worked!");
            }
            catch
            {
                Console.WriteLine("SQL error");
            }
        }
    }
}

