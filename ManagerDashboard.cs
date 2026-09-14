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

        
        private void btnViewFleet_Click(object sender, EventArgs e)
        {
            
            ViewFleet fleetView = new ViewFleet();
            fleetView.Show();
        }
        private void btnManageFleet_Click(object sender, EventArgs e)
        {
            
            ManageFleet manageFleet = new ManageFleet();
            manageFleet.Show();
        }

        
        private void btnViewReservations_Click(object sender, EventArgs e)
        {
            ViewReservations res = new ViewReservations();
            res.Show();
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

        //handling task kill when user clicks 'X' button
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