using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Data.Sqlite;

namespace day21
{
	public class Queries
	{
        public static List<Employee> CreateEmplList(SqliteConnection conn)
        {
            List<Employee> employees = new List<Employee>();

            SqliteDataReader sQLiteDataReader;
            SqliteCommand cmd = conn.CreateCommand();
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
        public static void InsertEmp(SqliteConnection conn, Employee e)
        {
            SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Employees(EmployeeId, FirstName, Lastname, city, country)" +
                " VALUES(@id, @firstName, @lastName, @city, @country);";
            e.Print();

            cmd.Parameters.AddWithValue("@id", e.id);
            cmd.Parameters.AddWithValue("@firstName", e.vards);
            cmd.Parameters.AddWithValue("@lastName", e.uzvards);
            cmd.Parameters.AddWithValue("@city", e.pilseta);
            cmd.Parameters.AddWithValue("@country", e.valsts);

            cmd.ExecuteNonQuery();
        }
        public static void UpdateEmp(SqliteConnection conn, int jaunaisId, String jaunaisVards, String jaunaisUzvards)
        { 
            SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "update employee set employees.Id = @id where employeeId = jaunaisId"+
                "update employee set firstName = @firstName where FirstName = jaunaisVards"+
                "update employee set lastName = @lastName where LastName = jaunaisUzvards";

            cmd.Parameters.AddWithValue("@id", jaunaisId);
            cmd.Parameters.AddWithValue("@firstName", jaunaisVards);
            cmd.Parameters.AddWithValue("@lastName", jaunaisUzvards);
        }
    }
}

