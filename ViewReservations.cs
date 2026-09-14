using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing; 
using System.Windows.Forms;
using Npgsql;

namespace NorthstarCollection_portal
{
    public partial class ViewReservations : Form
    {
        
        private decimal currentMonthlyGoal;

        public ViewReservations()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            
            txtAmount.Visible = false;
            btnSet.Visible = false;
            label6.Visible = false;
        }

        private void ViewReservations_Load(object sender, EventArgs e)
        {
            cmbYear.Items.AddRange(new string[] { "", "2024", "2025", "2026" });
            cmbMonth.Items.AddRange(new string[] { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });

            LoadSalesGoalFromDB(); 
            LoadAllReservations();
            LoadMonthlySalesStats();
        }

        private void LoadSalesGoalFromDB()
        {
            try
            {
                
                string query = "SELECT setting_value FROM tbl_Settings WHERE setting_name = 'MonthlySalesGoal'";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                    currentMonthlyGoal = Convert.ToDecimal(dt.Rows[0][0]);
                else
                    currentMonthlyGoal = 10000; 
            }
            catch { currentMonthlyGoal = 10000; }
        }

        private void LoadAllReservations()
        {
            string query = @"SELECT r.""reservationid"", r.""customername"", r.""startdate"", r.""enddate"", 
                             f.""Brand"", f.""Model"", r.""totalcost"" 
                             FROM tbl_Reservations r
                             JOIN ""tbl_fleet"" f ON r.""carid""::text = f.""CarID""::text
                             ORDER BY r.""startdate"" DESC";

            dgvReservations.DataSource = DatabaseHelper.ExecuteQuery(query);

            
            dgvReservations.EnableHeadersVisualStyles = false;

           
            dgvReservations.ColumnHeadersDefaultCellStyle.Font = new Font(dgvReservations.Font, FontStyle.Bold);

            
            dgvReservations.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvReservations.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadMonthlySalesStats()
        {
            try
            {
                DateTime today = DateTime.Today;

                string salesQ = @"SELECT SUM(""totalcost"") FROM tbl_Reservations 
                                  WHERE EXTRACT(MONTH FROM ""startdate"") = @month 
                                  AND EXTRACT(YEAR FROM ""startdate"") = @year";

                NpgsqlParameter[] param = {
                    new NpgsqlParameter("@month", today.Month),
                    new NpgsqlParameter("@year", today.Year)
                };

                object result = DatabaseHelper.ExecuteQuery(salesQ, param).Rows[0][0];
                decimal currentSales = (result != DBNull.Value) ? Convert.ToDecimal(result) : 0;

                
                lblSalesGoal.Text = currentMonthlyGoal.ToString("C");
                lblCurrentSales.Text = currentSales.ToString("C");

                
                if (currentSales >= currentMonthlyGoal)
                {
                    decimal surplus = currentSales - currentMonthlyGoal;
                    lblSalesComment.Text = $"Goal Achieved! Surplus: {surplus:C}";
                    lblSalesComment.ForeColor = Color.Green;
                }
                else
                {
                    decimal needed = currentMonthlyGoal - currentSales;
                    lblSalesComment.Text = $"Goal not met. You need {needed:C} more sales.";
                    lblSalesComment.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Sales Stats Error: " + ex.Message);
            }
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            txtAmount.Visible = true;
            btnSet.Visible = true;
            txtAmount.Focus();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal newGoal))
            {
                try
                {
                    // Update the database permanently
                    string updateQ = "UPDATE tbl_Settings SET setting_value = @val WHERE setting_name = 'MonthlySalesGoal'";
                    NpgsqlParameter[] p = { new NpgsqlParameter("@val", newGoal) };
                    DatabaseHelper.ExecuteQuery(updateQ, p);

                    currentMonthlyGoal = newGoal;
                    txtAmount.Visible = false;
                    btnSet.Visible = false;
                    label6.Visible = false; // Added to match your requested logic
                    txtAmount.Clear();

                    LoadMonthlySalesStats();
                    MessageBox.Show("Monthly sales goal saved permanently!");
                }
                catch (Exception ex) { MessageBox.Show("Error saving goal: " + ex.Message); }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric amount.");
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> conditions = new List<string>();
                List<NpgsqlParameter> parameters = new List<NpgsqlParameter>();

                if (!string.IsNullOrWhiteSpace(txtNameSearch.Text))
                {
                    conditions.Add(@"r.""customername"" ILIKE @name");
                    parameters.Add(new NpgsqlParameter("@name", "%" + txtNameSearch.Text.Trim() + "%"));
                }

                if (!string.IsNullOrEmpty(cmbYear.Text))
                {
                    conditions.Add(@"EXTRACT(YEAR FROM r.""startdate"") = @year");
                    parameters.Add(new NpgsqlParameter("@year", int.Parse(cmbYear.Text)));
                }

                if (cmbMonth.SelectedIndex > 0)
                {
                    conditions.Add(@"EXTRACT(MONTH FROM r.""startdate"") = @month");
                    parameters.Add(new NpgsqlParameter("@month", cmbMonth.SelectedIndex));
                }

                string baseQuery = @"SELECT r.""reservationid"", r.""customername"", r.""startdate"", r.""enddate"", 
                                     f.""Brand"", f.""Model"", r.""totalcost"" 
                                     FROM tbl_Reservations r
                                     JOIN ""tbl_fleet"" f ON r.""carid""::text = f.""CarID""::text";

                if (conditions.Count > 0) baseQuery += " WHERE " + string.Join(" AND ", conditions);
                baseQuery += @" ORDER BY r.""startdate"" DESC";

                dgvReservations.DataSource = DatabaseHelper.ExecuteQuery(baseQuery, parameters.ToArray());
            }
            catch (Exception ex) { MessageBox.Show("Filter Error: " + ex.Message); }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtNameSearch.Clear();
            cmbYear.SelectedIndex = 0;
            cmbMonth.SelectedIndex = 0;
            LoadSalesGoalFromDB(); // Re-fetch goal on refresh
            LoadAllReservations();
            LoadMonthlySalesStats();
        }

        private void btnBack_Click(object sender, EventArgs e) => this.Close();
    }
}