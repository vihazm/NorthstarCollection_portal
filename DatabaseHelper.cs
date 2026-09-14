using Npgsql;
using System.Data;
using System;
using System.Windows.Forms;

namespace NorthstarCollection_portal
{
    public class DatabaseHelper
    {
        private static string connectionString = "Host=localhost;Port=5432;Database=NorthstarCollection_DB;Username=postgres;Password=vihas123;";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }

        public static DataTable ExecuteQuery(string query, NpgsqlParameter[] parameters = null)
        {
            using (NpgsqlConnection conn = GetConnection())
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    DataTable dt = new DataTable();
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public static int ExecuteNonQuery(string query, NpgsqlParameter[] parameters = null)
        {
            using (NpgsqlConnection conn = GetConnection())
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static void ExecuteNonQuery(string query)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public static class SessionManager
        {
            public static int CurrentLogId { get; set; }
        }

        

        public static void InitializeDatabase()
        {
            using (NpgsqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();

                   
                    string usersTable = @"
                    CREATE TABLE IF NOT EXISTS tbl_Users (
                        UserID SERIAL PRIMARY KEY,
                        Username TEXT NOT NULL UNIQUE,
                        Password TEXT NOT NULL,
                        ""UserRole"" TEXT NOT NULL
                    );";

                    
                    string reservationsTable = @"
                    CREATE TABLE IF NOT EXISTS tbl_Reservations (
                        ReservationID SERIAL PRIMARY KEY,
                        CarID INTEGER,
                        CustomerName TEXT,
                        CustomerPhone TEXT,
                        InsuranceNumber TEXT,
                        StartDate DATE, 
                        EndDate DATE,
                        Deposit NUMERIC(10,2),
                        TotalCost NUMERIC(10,2)
                    );";

                    
                    string fleetTable = @"
                    CREATE TABLE IF NOT EXISTS tbl_fleet (
                        ""CarID"" SERIAL PRIMARY KEY,
                        ""Brand"" TEXT NOT NULL,
                        ""Model"" TEXT NOT NULL,
                        ""DailyRate"" NUMERIC(10,2),
                        ""Status"" TEXT DEFAULT 'Available',
                        ""UniqueToken"" TEXT UNIQUE,
                        ""IsActive"" INTEGER DEFAULT 1
                    );";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(usersTable, conn)) cmd.ExecuteNonQuery();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(reservationsTable, conn)) cmd.ExecuteNonQuery();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(fleetTable, conn)) cmd.ExecuteNonQuery();

                   
                    string seedUsers = @"
                    INSERT INTO tbl_Users (Username, Password, ""UserRole"") VALUES 
                    ('admin', 'admin123', 'Admin'),
                    ('manager1', 'manager123', 'Manager'),
                    ('sales1', 'sales123', 'Sales')
                    ON CONFLICT (Username) DO NOTHING;";

                    
                    string seedFleet = @"
                    INSERT INTO tbl_fleet (""Brand"", ""Model"", ""DailyRate"", ""Status"", ""UniqueToken"", ""IsActive"") VALUES 
                    ('Aston Martin', 'Vantage', 2800.00, 'Available', 'MN-VANTG', 1),
                    ('Lamborghini', 'Aventador SVJ', 2900.00, 'Available', 'MN-AVENT', 1),
                    ('Ferrari', '488 Pista', 2800.00, 'Available', 'MN-PISTA', 1)
                    ON CONFLICT (""UniqueToken"") DO NOTHING;";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(seedUsers, conn)) cmd.ExecuteNonQuery();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(seedFleet, conn)) cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Initialization Error: " + ex.Message);
                }
            }
        }
    }
}