using System;
using System.Collections.Generic;
using System.Data;
using System.IO; // .txt file handling library component
using System.Windows.Forms;
using Npgsql;

namespace NorthstarCollection_portal
{
    public partial class UserManagement : Form
    {
        private int selectedUserIdFromGrid = -1;

        public UserManagement()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            cmbARole.Items.AddRange(new string[] { "Admin", "Manager", "Sales" });
            LoadUsers();
        }


        private void LoadUsers()
        {
            
            string query = "SELECT userid, username, password, \"UserRole\" FROM tbl_users ORDER BY userid ASC";

            dgvUsers.DataSource = DatabaseHelper.ExecuteQuery(query);

            
            dgvUsers.EnableHeadersVisualStyles = false;

            
            dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font(dgvUsers.Font, FontStyle.Bold);

            
            dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

           
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //add user
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAUser.Text) || string.IsNullOrWhiteSpace(txtAPass.Text) || cmbARole.SelectedIndex == -1)
            {
                MessageBox.Show("All fields in the Add User section are required.");
                return;
            }

            string query = "INSERT INTO tbl_users (username, password, \"UserRole\") VALUES (@u, @p, @r)";
            NpgsqlParameter[] p = {
                new NpgsqlParameter("@u", txtAUser.Text.Trim()),
                new NpgsqlParameter("@p", txtAPass.Text),
                new NpgsqlParameter("@r", cmbARole.Text)
            };

            DatabaseHelper.ExecuteQuery(query, p);
            MessageBox.Show("New user created!");
            LoadUsers();
        }

        //update user 
        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedUserIdFromGrid = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells["userid"].Value);
                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(txtEUid.Text, out int uid) && !string.IsNullOrWhiteSpace(txtEPass.Text))
            {
                try
                {
                    string query = "UPDATE tbl_users SET password = @p WHERE userid = @id";
                    NpgsqlParameter[] p = {
                new NpgsqlParameter("@p", txtEPass.Text),
                new NpgsqlParameter("@id", uid)
            };

                    DatabaseHelper.ExecuteQuery(query, p);

                    MessageBox.Show($"Password updated for User ID {uid}!", "Success");

                    // Clear fields 
                    txtEPass.Clear();
                    txtEUid.Clear();
                    LoadUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid User ID and a new password.");
            }
        }
         
        //delete user
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDUid.Text, out int id))
            {
                string query = "DELETE FROM tbl_users WHERE userid = @id";
                DatabaseHelper.ExecuteQuery(query, new NpgsqlParameter[] { new NpgsqlParameter("@id", id) });
                MessageBox.Show("User removed.");
                txtDUid.Clear();
                LoadUsers();
            }
        }

        //file handling
        private void btnUserLog_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM tbl_LoginHistory ORDER BY login_time DESC";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                SaveFileDialog sfd = new SaveFileDialog { Filter = "Text Files|*.txt", FileName = "UserAuditLog.txt" };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        sw.WriteLine("================================================================");
                        sw.WriteLine("            NORTHSTAR COLLECTION - LOGIN AUDIT LOG             ");
                        sw.WriteLine("            Report Date: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                        sw.WriteLine("================================================================");
                        sw.WriteLine(string.Format("{0,-15} | {1,-10} | {2,-20} | {3,-20}", "Username", "Position", "Login Time", "Logout Time"));
                        sw.WriteLine(new string('-', 75));

                        foreach (DataRow row in dt.Rows)
                        {
                            string outTime = row["logout_time"] == DBNull.Value ? "Still Logged In" : row["logout_time"].ToString();
                            sw.WriteLine(string.Format("{0,-15} | {1,-10} | {2,-20} | {3,-20}",
                                row["username"], row["position"], row["login_time"], outTime));
                        }
                    }
                    MessageBox.Show("Audit log has been saved to " + sfd.FileName);
                }
            }
            catch (Exception ex) { MessageBox.Show("Export Error: " + ex.Message); }
        }

        private void btnBack_Click(object sender, EventArgs e) => this.Close();
    }
}
