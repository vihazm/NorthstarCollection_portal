using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace NorthstarCollection_portal
{
    public partial class ViewCustomers : Form
    {
        public ViewCustomers()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ViewCustomers_Load(object sender, EventArgs e)
        {
            LoadCustomerSummary();
        }

        private void LoadCustomerSummary()
        {
            try
            {
                // We pull the phone number into the hidden parts of the grid to use it later
                string query = @"SELECT ""customername"", MAX(""customerphone"") as customerphone, 
                                 COUNT(*) as totalrentals, SUM(""totalcost"") as lifetimespend 
                                 FROM tbl_Reservations 
                                 GROUP BY ""customername"" 
                                 ORDER BY lifetimespend DESC";

                dgvCustomerSummary.DataSource = DatabaseHelper.ExecuteQuery(query);

                // 1. Disable the default Windows visual style to allow custom fonts
                dgvCustomerSummary.EnableHeadersVisualStyles = false;

                // 2. Set the header font to Bold
                dgvCustomerSummary.ColumnHeadersDefaultCellStyle.Font = new Font(dgvCustomerSummary.Font, FontStyle.Bold);

                // 3. Optional: Set a clean background/foreground for the bold headers to make them readable
                dgvCustomerSummary.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dgvCustomerSummary.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

                dgvCustomerSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message);
            }
        }

        private void dgvCustomerSummary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Pulling data directly from the selected row for speed and accuracy
                DataGridViewRow row = dgvCustomerSummary.Rows[e.RowIndex];

                string name = row.Cells["customername"].Value.ToString();
                string phone = row.Cells["customerphone"].Value.ToString();
                decimal spend = Convert.ToDecimal(row.Cells["lifetimespend"].Value);

                // Update UI Labels
                lblCustomerName.Text = name;
                lblContact.Text = phone;

                // Update Timeline and Brand/Tier logic
                UpdateRentalTimeline(name);
                PassDetailsToLabels(name, spend);
            }
        }

        private void UpdateRentalTimeline(string name)
        {
            // Joining lowercase tbl_reservations to PascalCase tbl_fleet
            string query = $@"SELECT r.""startdate"", r.""enddate"", f.""Brand"", f.""Model"", r.""totalcost"" 
                             FROM tbl_Reservations r
                             JOIN ""tbl_fleet"" f ON r.""carid""::text = f.""CarID""::text
                             WHERE r.""customername"" = @name
                             ORDER BY r.""startdate"" DESC";

            NpgsqlParameter[] parameters = { new NpgsqlParameter("@name", name) };
            dgvHistoryTimeline.DataSource = DatabaseHelper.ExecuteQuery(query, parameters);

            // 1. Disable the default Windows visual style to allow custom fonts
            dgvHistoryTimeline.EnableHeadersVisualStyles = false;

            // 2. Set the header font to Bold
            dgvHistoryTimeline.ColumnHeadersDefaultCellStyle.Font = new Font(dgvHistoryTimeline.Font, FontStyle.Bold);

            // 3. Optional: Set a clean background/foreground for the bold headers to make them readable
            dgvHistoryTimeline.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvHistoryTimeline.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        private void PassDetailsToLabels(string name, decimal spend)
        {
            try
            {
                // 1. FAVORITE BRAND LOGIC
                string favQ = @"SELECT f.""Brand"" FROM tbl_Reservations r
                               JOIN ""tbl_fleet"" f ON r.""carid""::text = f.""CarID""::text
                               WHERE r.""customername"" = @name
                               GROUP BY f.""Brand"" ORDER BY COUNT(*) DESC LIMIT 1";

                NpgsqlParameter[] parameters = { new NpgsqlParameter("@name", name) };
                DataTable dtBrand = DatabaseHelper.ExecuteQuery(favQ, parameters);

                if (dtBrand != null && dtBrand.Rows.Count > 0)
                {
                    lblFavBrand.Text = dtBrand.Rows[0][0].ToString();
                }
                else
                {
                    lblFavBrand.Text = "No Brand Found";
                }

                // 2. LOYALTY TIER LOGIC (Using your new lblLoyalty name)
                // Spend for Vihas is 25300.00, which is Silver
                if (spend >= 100000)
                {
                    lblLoyalty.Text = "RED MEMBER";
                    lblLoyalty.ForeColor = Color.Red;
                }
                else if (spend >= 50000)
                {
                    lblLoyalty.Text = "GOLD MEMBER";
                    lblLoyalty.ForeColor = Color.Gold;
                }
                else
                {
                    lblLoyalty.Text = "SILVER MEMBER";
                    lblLoyalty.ForeColor = Color.DimGray; // Darker gray for better visibility on white
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error in Label Passing: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e) => this.Close();
    }
}