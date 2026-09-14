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
                
                string query = @"SELECT ""customername"", MAX(""customerphone"") as customerphone, 
                                 COUNT(*) as totalrentals, SUM(""totalcost"") as lifetimespend 
                                 FROM tbl_Reservations 
                                 GROUP BY ""customername"" 
                                 ORDER BY lifetimespend DESC";

                dgvCustomerSummary.DataSource = DatabaseHelper.ExecuteQuery(query);

                
                dgvCustomerSummary.EnableHeadersVisualStyles = false;

                
                dgvCustomerSummary.ColumnHeadersDefaultCellStyle.Font = new Font(dgvCustomerSummary.Font, FontStyle.Bold);

                
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
                
                DataGridViewRow row = dgvCustomerSummary.Rows[e.RowIndex];

                string name = row.Cells["customername"].Value.ToString();
                string phone = row.Cells["customerphone"].Value.ToString();
                decimal spend = Convert.ToDecimal(row.Cells["lifetimespend"].Value);

                
                lblCustomerName.Text = name;
                lblContact.Text = phone;

                
                UpdateRentalTimeline(name);
                PassDetailsToLabels(name, spend);
            }
        }

        private void UpdateRentalTimeline(string name)
        {
            
            string query = $@"SELECT r.""startdate"", r.""enddate"", f.""Brand"", f.""Model"", r.""totalcost"" 
                             FROM tbl_Reservations r
                             JOIN ""tbl_fleet"" f ON r.""carid""::text = f.""CarID""::text
                             WHERE r.""customername"" = @name
                             ORDER BY r.""startdate"" DESC";

            NpgsqlParameter[] parameters = { new NpgsqlParameter("@name", name) };
            dgvHistoryTimeline.DataSource = DatabaseHelper.ExecuteQuery(query, parameters);

            
            dgvHistoryTimeline.EnableHeadersVisualStyles = false;

            
            dgvHistoryTimeline.ColumnHeadersDefaultCellStyle.Font = new Font(dgvHistoryTimeline.Font, FontStyle.Bold);

            
            dgvHistoryTimeline.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvHistoryTimeline.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        private void PassDetailsToLabels(string name, decimal spend)
        {
            try
            {
                
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

                
                if (spend >= 250000)
                {
                    lblLoyalty.Text = "RED MEMBER";
                    lblLoyalty.ForeColor = Color.Red;
                }
                else if (spend >= 100000)
                {
                    lblLoyalty.Text = "GOLD MEMBER";
                    lblLoyalty.ForeColor = Color.Gold;
                }
                else
                {
                    lblLoyalty.Text = "SILVER MEMBER";
                    lblLoyalty.ForeColor = Color.DimGray; 
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