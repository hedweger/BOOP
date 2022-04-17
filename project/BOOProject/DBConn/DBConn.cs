using System;
using Microsoft.Data.SqlClient;

public class DBConn {
    static void Main(string[] args) {
        try {
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        builder.DataSource = "localhost";
        builder.UserID = "sa";
        builder.Password = "password.Password123";
        builder.InitialCatalog = "music_groups";

        Console.Write("Connecting to SQL Server ... ");
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    Console.WriteLine("Done.");
                }
        }
        catch (SqlException e) {
            Console.WriteLine(e.ToString());
        }
    }
}