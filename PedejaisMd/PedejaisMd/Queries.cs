using System;
using Microsoft.Data.Sqlite;

namespace PedejaisMd
{
	public class Queries
	{
        public static List<Customer> CreateCuslList(SqliteConnection conn)
        {
            List<Customer> customers = new List<Customer>();

            SqliteDataReader sQLiteDataReader;
            SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                "SELECT customers.CustomerId, customers.FirstName, customers.LastName, customers.City, customers.Country " +
                "FROM customers;";

            sQLiteDataReader = cmd.ExecuteReader();
            while (sQLiteDataReader.Read())
            {
                int id = sQLiteDataReader.GetInt32(0);
                String employeeName = sQLiteDataReader.GetString(1);
                String employeeLastName = sQLiteDataReader.GetString(2);
                String city = sQLiteDataReader.GetString(3);
                String country = sQLiteDataReader.GetString(4);

                customers.Add(new Customer(id, employeeName, employeeLastName, city, country));
            }

            return customers;
        }
        public static void InsertCus(SqliteConnection conn, Customer e)
        {
            SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO customers(CustomerId, FirstName, Lastname, city, country)" +
                " VALUES(@id, @firstName, @lastName, @city, @country);";
            e.Print();

            cmd.Parameters.AddWithValue("@id", e.id);
            cmd.Parameters.AddWithValue("@firstName", e.vards);
            cmd.Parameters.AddWithValue("@lastName", e.uzvards);
            cmd.Parameters.AddWithValue("@city", e.pilseta);
            cmd.Parameters.AddWithValue("@country", e.valsts);

            cmd.ExecuteNonQuery();
        }
        public static void UpdateCus(SqliteConnection conn, int ievaditaisId, String jaunaisVards, String jaunaisUzvards)
        {
            SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM customers" +
                "WHERE customerId = " +ievaditaisId;

            //cmd.Parameters.AddWithValue("@id", ievaditaisId);
            //cmd.Parameters.AddWithValue("@firstName", jaunaisVards);
            //cmd.Parameters.AddWithValue("@lastName", jaunaisUzvards);
            cmd.ExecuteNonQuery();
        }
    }
}

