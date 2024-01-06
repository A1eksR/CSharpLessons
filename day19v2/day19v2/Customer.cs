using System;
using System.Diagnostics.Metrics;
using Microsoft.Data.Sqlite;
namespace day19v2
{
	public class Customer
	{
        public int id { get; set; }
        public String vards { get; set; }
        public String uzvards { get; set; }
        public String epasts { get; set; }

        public Customer(int id, String vards, String uzvards, String pilseta, String valsts)
        {
            this.id = id;
            this.vards = vards;
            this.uzvards = uzvards;
            this.epasts = epasts;
            
        }

        public void Print()
        {
            Console.WriteLine("id: " + id + ", vards: " + vards + ", uzvards: " + uzvards + ", pilseta: " + epasts);
            Console.WriteLine("-----------------");
        }
        public static void DabutKlientus(SqliteConnection conn)
		{
			Connection.CreateConn();
            List<Customer> customers = new List<Customer>();
            SqliteDataReader sQLiteDataReader;
            SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                "SELECT customers.CustomerId, customers.FirstName, customers.LastName, customers.Email, " +
                "FROM customers;";

            sQLiteDataReader = cmd.ExecuteReader();

            

            while (sQLiteDataReader.Read())
            {
                int customerId = sQLiteDataReader.GetInt32(0);
                String firstName = sQLiteDataReader.GetString(1);
                String lastName = sQLiteDataReader.GetString(2);
                String email = sQLiteDataReader.GetString(3);

                customers.Add(new Customer(customerId, firstName, lastName, email));

            }
        }

        
    }
}

