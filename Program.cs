using System;
using Microsoft.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        string connectionString = "Server=localhost;Database=ExampleDb;User Id=cyapura;Password=123456;TrustServerCertificate=True";
        string query = "SELECT CustomerId, Name, Email FROM Customers";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int customerId = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string email = reader.GetString(2);

                    Console.WriteLine($"ID: {customerId}, Name: {name}, Email: {email}");
                }
            }
        }
    }
}

