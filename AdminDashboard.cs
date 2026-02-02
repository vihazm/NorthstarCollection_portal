using Npgsql;
using System;
using System.Windows.Forms;
using static NorthstarCollection_portal.DatabaseHelper;

namespace NorthstarCollection_portal
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // 1. Navigation: View Fleet
        private void btnViewFleet_Click(object sender, EventArgs e)
        {
            // We will create this form next - it will be a read-only view for Admin
            ViewFleet fleetView = new ViewFleet();
            fleetView.Show();
        }

        // 2. Navigation: View Stats
        private void btnViewStats_Click(object sender, EventArgs e)
        {
            ViewStats stats = new ViewStats();
            stats.Show();
        }

        // 3. Navigation: View Reservations
        private void btnViewReservations_Click(object sender, EventArgs e)
        {
            ViewReservations res = new ViewReservations();
            res.Show();
        }

        // 4. Navigation: Manage Users
        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            UserManagement users = new UserManagement();
            users.Show();
        }

        // 5. Logout Logic
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (SessionManager.CurrentLogId != 0)
            {
                // Update the specific row with the current logout time
                string updateLog = "UPDATE tbl_LoginHistory SET logout_time = CURRENT_TIMESTAMP WHERE log_id = @id";
                NpgsqlParameter[] p = { new NpgsqlParameter("@id", SessionManager.CurrentLogId) };
                DatabaseHelper.ExecuteQuery(updateLog, p);
            }

            // Go back to login screen
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        // 6. Security: Ensure app closes fully if the user clicks the 'X'
        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            // If the user isn't just logging out, kill the process
            if (!Application.OpenForms["Login"].Visible)
            {
                Application.Exit();
            }
        }
    }
}