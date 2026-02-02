using Npgsql;
using System;
using System.Windows.Forms;
using static NorthstarCollection_portal.DatabaseHelper;

namespace NorthstarCollection_portal
{
    public partial class SalesDashboard : Form
    {
        public SalesDashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // 1. Navigation: View Fleet (Same form as Admin)
        private void btnViewFleet_Click(object sender, EventArgs e)
        {
            // Reusing the same ViewFleet form we used for the Admin
            ViewFleet fleetView = new ViewFleet();
            fleetView.Show();
        }

        // 3. Navigation: Create Reservations
        private void btnCreateReservations_Click(object sender, EventArgs e)
        {
            CreateReservation reservationPage = new CreateReservation();
            reservationPage.Show();
        }

        // 4. Navigation: View Customers
        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            ViewCustomers customerPage = new ViewCustomers();
            customerPage.Show();
        }

        // 5. Logout Logic (Matching Admin logic)
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

        // 6. Security: Handle 'X' button
        private void SalesDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Check if login is visible; if not, exit app
            if (Application.OpenForms["Login"] == null || !Application.OpenForms["Login"].Visible)
            {
                Application.Exit();
            }
        }
    }
}