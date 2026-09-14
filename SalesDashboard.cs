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

        
        private void btnViewFleet_Click(object sender, EventArgs e)
        {
           
            ViewFleet fleetView = new ViewFleet();
            fleetView.Show();
        }

        
        private void btnCreateReservations_Click(object sender, EventArgs e)
        {
            CreateReservation reservationPage = new CreateReservation();
            reservationPage.Show();
        }

        
        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            ViewCustomers customerPage = new ViewCustomers();
            customerPage.Show();
        }

       
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (SessionManager.CurrentLogId != 0)
            {
                
                string updateLog = "UPDATE tbl_LoginHistory SET logout_time = CURRENT_TIMESTAMP WHERE log_id = @id";
                NpgsqlParameter[] p = { new NpgsqlParameter("@id", SessionManager.CurrentLogId) };
                DatabaseHelper.ExecuteQuery(updateLog, p);
            }

            
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        // Handling task kill when user clicks 'X' button
        private void SalesDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            if (Application.OpenForms["Login"] == null || !Application.OpenForms["Login"].Visible)
            {
                Application.Exit();
            }
        }
    }
}