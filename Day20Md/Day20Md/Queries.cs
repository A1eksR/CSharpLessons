using System;
using Microsoft.Data.Sqlite;

namespace Day20Md
{
    public class Queries
    {
        public static List<Book> CreateBookList(SqliteConnection conn)
        {
            List<Book> books = new List<Book>();

            SqliteDataReader sQLiteDataReader;
            SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Books.Id, Books.Nosaukums, Books.AuthorId, Authors.Vards, Authors.Uzvards" +
                "FROM Books, Authors;";

            sQLiteDataReader = cmd.ExecuteReader();
            while (sQLiteDataReader.Read())
            {
                int id = sQLiteDataReader.GetInt32(0);
                String nosaukums = sQLiteDataReader.GetString(1);
                int authorId = sQLiteDataReader.GetInt32(2);
                String vards = sQLiteDataReader.GetString(3);
                String uzvards = sQLiteDataReader.GetString(4);

                books.Add(new Book(id, nosaukums, authorId, vards, uzvards));
            }

            return books;
        }

        public static void InsertBook(SqliteConnection conn, int id, String nosaukums, int authorId, String vards, String uzvards)
        {
            SqliteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO Books(Id, Nosaukums, AuthorId) " +
                "VALUES (@Id, @Nosaukums, @AuthorId)" +
                "INSERT INTO Authors(Vards, Uzvards) " +
                "VALUES (@Vards, @Uzvards)";
            

            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Nosaukums", nosaukums);
            cmd.Parameters.AddWithValue("@AuthorId", authorId);
            cmd.Parameters.AddWithValue("@Vards", vards);
            cmd.Parameters.AddWithValue("@Uzvards", uzvards);

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

