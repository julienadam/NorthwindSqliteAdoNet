using Microsoft.Data.Sqlite;

namespace NorthwindSqliteAdoNet
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var conn = new SqliteConnection(@"Data Source=.\northwind.db"))
            {
                conn.Open();
                Console.WriteLine("Connection successful");
                var cmd = conn.CreateCommand();
                cmd.CommandText = "Select count(*) from employees";
                var result = cmd.ExecuteScalar();
                Console.WriteLine($"Number of employees : {result}");
            }

            Console.WriteLine("Success");
        }
    }
}