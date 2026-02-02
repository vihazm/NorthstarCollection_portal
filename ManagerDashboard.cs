using Npgsql;
using System;
using System.Windows.Forms;
using static NorthstarCollection_portal.DatabaseHelper;

namespace NorthstarCollection_portal
{
    public partial class ManagerDashboard : Form
    {
        public ManagerDashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // 1. Navigation: Manage Fleet (Combined Inventory + Management
        private void btnViewFleet_Click(object sender, EventArgs e)
        {
            // We will create this form next - it will be a read-only view for Admin
            ViewFleet fleetView = new ViewFleet();
            fleetView.Show();
        }
        private void btnManageFleet_Click(object sender, EventArgs e)
        {
            // This is the specific hub for the Manager to Edit/Add cars
            ManageFleet manageFleet = new ManageFleet();
            manageFleet.Show();
        }

        // 2. Navigation: View Reservations (Shared with Admin)
        private void btnViewReservations_Click(object sender, EventArgs e)
        {
            ViewReservations res = new ViewReservations();
            res.Show();
        }

        // 3. Navigation: Reports
        

        // 4. Logout Logic (Matching Admin & Sales)
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

        // 5. Security: Handle 'X' button
        private void ManagerDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Login"] == null || !Application.OpenForms["Login"].Visible)
            {
                Application.Exit();
            }
        }

        private void btnViewStats_Click(object sender, EventArgs e)
        {
            ViewStats stats = new ViewStats();
            stats.Show();
        }
    }
}