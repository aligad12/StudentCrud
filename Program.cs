using Npgsql;

string password = Environment.GetEnvironmentVariable("STUDENT_DB_PASSWORD")
    ?? throw new InvalidOperationException("Set STUDENT_DB_PASSWORD first.");

string connectionString = 
$"Host=localhost;port=5432;Database=studentdb;Username=postgres;Password={password}";

using var conn = new NpgsqlConnection(connectionString);
conn.Open();

Console.WriteLine("Connected! PostgreSQL version: " + conn.PostgreSqlVersion);