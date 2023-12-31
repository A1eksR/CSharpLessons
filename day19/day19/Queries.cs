using System;
using System.Data.SQLite;

namespace day19
{
    public class Queries
    {
        public static List<Employee> CreateEmplList(SQLiteConnection conn)
        {
            List<Employee> employees = new List<Employee>();

            SQLiteDataReader sQLiteDataReader;
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                "SELECT employees.EmployeeId, employees.FirstName, employees.LastName, employees.City, employees.Country " +
                "FROM employees;";

            sQLiteDataReader = cmd.ExecuteReader();
            while (sQLiteDataReader.Read())
            {
                int id = sQLiteDataReader.GetInt32(0);
                String employeeName = sQLiteDataReader.GetString(1);
                String employeeLastName = sQLiteDataReader.GetString(2);
                String city = sQLiteDataReader.GetString(3);
                String country = sQLiteDataReader.GetString(4);

                employees.Add(new Employee(id, employeeName, employeeLastName, city, country)); 
            }

            return employees;
        }

        public static void InsertEmp(SQLiteConnection conn, int id,  String vards, String uzvards, String city, String country)
        {
            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO Employees(EmployeeId, FirstName, Lastname, city, country) " +
                "VALUES (@id, @firstName, @lastName, @city, @country)";

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@firstName", vards);
            cmd.Parameters.AddWithValue("@lastName", uzvards);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@country", country);

            cmd.ExecuteNonQuery();
        }
    }

}

