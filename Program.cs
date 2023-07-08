using System.Data.SqlClient;

namespace EmployeePayrollAdo.Net;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Employee Payroll service using ADO.Net");

        string connectionString = @"Data Source = DESKTOP-53EDIV8; Initial Catalog=master; Integrated Security = True";

        string databaseName = "EmployeePayrollAdoDOTNet";
        try
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string createDatabaseQuery = $"create database {databaseName}";

            SqlCommand command = new SqlCommand(createDatabaseQuery, connection);
            command.ExecuteNonQuery();
            Console.WriteLine($"Databse {databaseName} created");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error" + ex.Message);
        }
        Console.ReadLine();
    }
}
