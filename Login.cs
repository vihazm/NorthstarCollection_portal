using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using static NorthstarCollection_portal.DatabaseHelper;

namespace NorthstarCollection_portal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please enter both username and password.", "Midnight Exotics", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                
                string query = "SELECT \"UserRole\" FROM tbl_users WHERE \"username\" = @user AND \"password\" = @pass";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@user", user),
                    new NpgsqlParameter("@pass", pass)
                };

                DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);
                
                if (result.Rows.Count > 0)
                {
                    string role = result.Rows[0]["UserRole"].ToString();

                    string logQuery = "INSERT INTO tbl_LoginHistory (username, position) VALUES (@u, @p) RETURNING log_id";
                    NpgsqlParameter[] logParams = {
                    new NpgsqlParameter("@u", user),
                    new NpgsqlParameter("@p", role)
};

                   
                    DataTable logResult = DatabaseHelper.ExecuteQuery(logQuery, logParams);

                    //update current log result
                    if (logResult != null && logResult.Rows.Count > 0)
                    {
                        
                        SessionManager.CurrentLogId = Convert.ToInt32(logResult.Rows[0][0]);
                    }

                    OpenDashboardByRole(role);
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenDashboardByRole(string role)
        {
            if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                AdminDashboard admin = new AdminDashboard();
                admin.Show();
            }
            else if (role.Equals("Manager", StringComparison.OrdinalIgnoreCase))
            {
                ManagerDashboard manager = new ManagerDashboard();
                manager.Show();
            }
            else if (role.Equals("Sales", StringComparison.OrdinalIgnoreCase))
            {
                SalesDashboard sales = new SalesDashboard();
                sales.Show();
            }
            else
            {
                MessageBox.Show("Role not recognized: " + role);
                return;
            }

            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}