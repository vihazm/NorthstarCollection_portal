using Npgsql;
using System.Data;
using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace NorthstarCollection_portal
{
    public class DatabaseHelper
    {
        private static string connectionString = LoadConnectionString();

        //connection string lives in appsettings.json next to the exe, not in source, so it never gets committed
        private static string LoadConnectionString()
        {
            try
            {
                string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
                string json = File.ReadAllText(configPath);

                using JsonDocument doc = JsonDocument.Parse(json);
                return doc.RootElement.GetProperty("ConnectionStrings").GetProperty("Default").GetString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load appsettings.json next to the application. " +
                    "Copy appsettings.example.json to appsettings.json and fill in your database credentials.\n\n" + ex.Message,
                    "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
                return null;
            }
        }

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

        //one-way SHA256 hash so passwords are never stored or compared in plain text
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes) sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        private static bool IsHashedPassword(string value)
        {
            if (value == null || value.Length != 64) return false;
            foreach (char c in value)
            {
                if (!Uri.IsHexDigit(c)) return false;
            }
            return true;
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
                    ('admin', @pAdmin, 'Admin'),
                    ('manager1', @pManager, 'Manager'),
                    ('sales1', @pSales, 'Sales')
                    ON CONFLICT (Username) DO NOTHING;";


                    string seedFleet = @"
                    INSERT INTO tbl_fleet (""Brand"", ""Model"", ""DailyRate"", ""Status"", ""UniqueToken"", ""IsActive"") VALUES
                    ('Aston Martin', 'Vantage', 2800.00, 'Available', 'MN-VANTG', 1),
                    ('Lamborghini', 'Aventador SVJ', 2900.00, 'Available', 'MN-AVENT', 1),
                    ('Ferrari', '488 Pista', 2800.00, 'Available', 'MN-PISTA', 1)
                    ON CONFLICT (""UniqueToken"") DO NOTHING;";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(seedUsers, conn))
                    {
                        cmd.Parameters.AddWithValue("pAdmin", HashPassword("admin123"));
                        cmd.Parameters.AddWithValue("pManager", HashPassword("manager123"));
                        cmd.Parameters.AddWithValue("pSales", HashPassword("sales123"));
                        cmd.ExecuteNonQuery();
                    }
                    using (NpgsqlCommand cmd = new NpgsqlCommand(seedFleet, conn)) cmd.ExecuteNonQuery();

                    //migrate any pre-existing plain text passwords (from before hashing was added) to hashed ones
                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT userid, password FROM tbl_users", conn))
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        var legacyRows = new System.Collections.Generic.List<(int id, string plainPassword)>();
                        while (reader.Read())
                        {
                            string storedPassword = reader.GetString(1);
                            if (!IsHashedPassword(storedPassword))
                                legacyRows.Add((reader.GetInt32(0), storedPassword));
                        }
                        reader.Close();

                        foreach (var row in legacyRows)
                        {
                            using NpgsqlCommand updateCmd = new NpgsqlCommand("UPDATE tbl_users SET password = @p WHERE userid = @id", conn);
                            updateCmd.Parameters.AddWithValue("p", HashPassword(row.plainPassword));
                            updateCmd.Parameters.AddWithValue("id", row.id);
                            updateCmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Initialization Error: " + ex.Message);
                }
            }
        }
    }
}