using System;
using Microsoft.Data.Sqlite;

namespace day20
{
	public class Queries
	{
        public static List<Author> CreateAuthorList(SqliteConnection conn)
        {
            List<Author> authors = new List<Author>();

            SqliteDataReader sQLiteDataReader;
            SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                "SELECT Autors.Id, Autors.Vards, Autors.Uzvards" +
                "FROM Autors;";
                

            sQLiteDataReader = cmd.ExecuteReader();
            while (sQLiteDataReader.Read())
            {
                int id = sQLiteDataReader.GetInt32(0);
                String vards = sQLiteDataReader.GetString(1);
                String uzvards = sQLiteDataReader.GetString(2);
                
                authors.Add(new Author(id, vards, uzvards));
            }

            return authors;
        }

        public static void InsertAuthor(SqliteConnection conn, int id, String vards, String uzvards)
        {
            SqliteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO Author(Id, vards, uzvards) " +
                "VALUES (@Id, @vards, @uzvards)";

            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@uzvards", vards);
            cmd.Parameters.AddWithValue("@uzvards", uzvards);


            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("SQL error");
            }


        }
    }
}

