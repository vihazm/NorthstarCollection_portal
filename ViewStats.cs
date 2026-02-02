using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace NorthstarCollection_portal
{
    public partial class ViewStats : Form
    {
        public ViewStats()
        {
            InitializeComponent();
        }

        private void ViewStats_Load(object sender, EventArgs e)
        {
            if (cmbSelectMonth.Items.Count == 0)
                cmbSelectMonth.Items.AddRange(new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });

            if (cmbSelectYear.Items.Count == 0)
                cmbSelectYear.Items.AddRange(new string[] { "2024", "2025", "2026" });

            cmbSelectYear.Text = DateTime.Now.Year.ToString();
            cmbSelectMonth.SelectedIndex = DateTime.Now.Month - 1;

            LoadMonthlyStats();
        }

        private void LoadMonthlyStats()
        {
            if (string.IsNullOrEmpty(cmbSelectYear.Text) || cmbSelectMonth.SelectedIndex == -1) return;

            try
            {
                int month = cmbSelectMonth.SelectedIndex + 1;
                if (!int.TryParse(cmbSelectYear.Text, out int year)) return;

                // --- 1. TOTAL REVENUE ---
                string revQ = @"SELECT SUM(""totalcost"") FROM tbl_Reservations 
                        WHERE EXTRACT(MONTH FROM ""startdate"") = @month 
                        AND EXTRACT(YEAR FROM ""startdate"") = @year";

                // Create fresh parameters for this specific call
                NpgsqlParameter[] revParams = {
            new NpgsqlParameter("@month", month),
            new NpgsqlParameter("@year", year)
        };
                DataTable dtRev = DatabaseHelper.ExecuteQuery(revQ, revParams);
                decimal totalRev = (dtRev.Rows.Count > 0 && dtRev.Rows[0][0] != DBNull.Value)
                                   ? Convert.ToDecimal(dtRev.Rows[0][0]) : 0;
                lblTotalRevenue.Text = totalRev.ToString("C");

                // --- 2. FLEET OCCUPATION ---
                string totQ = @"SELECT COUNT(*) FROM tbl_fleet WHERE ""IsActive"" = 1";

                // Parameter for the rental count query
                NpgsqlParameter[] occParams = {
            new NpgsqlParameter("@month", month),
            new NpgsqlParameter("@year", year)
        };
                string rentQ = @"SELECT COUNT(DISTINCT ""carid"") FROM tbl_Reservations 
                         WHERE EXTRACT(MONTH FROM ""startdate"") = @month 
                         AND EXTRACT(YEAR FROM ""startdate"") = @year";

                double totalCars = Convert.ToDouble(DatabaseHelper.ExecuteQuery(totQ).Rows[0][0]);
                double rentedCars = Convert.ToDouble(DatabaseHelper.ExecuteQuery(rentQ, occParams).Rows[0][0]);
                lblFleetOccupation.Text = (totalCars > 0 ? (rentedCars / totalCars) * 100 : 0).ToString("0") + "%";

                // --- 3. NEW CUSTOMERS GAINED ---
                string custQ = @"SELECT COUNT(DISTINCT ""customername"") FROM tbl_Reservations 
                         WHERE EXTRACT(MONTH FROM ""startdate"") = @month 
                         AND EXTRACT(YEAR FROM ""startdate"") = @year
                         AND ""customername"" NOT IN (
                             SELECT ""customername"" FROM tbl_Reservations 
                             WHERE ""startdate"" < CAST(@year || '-' || @month || '-01' AS DATE)
                         )";

                // Fresh parameters for the customer query
                NpgsqlParameter[] custParams = {
            new NpgsqlParameter("@month", month),
            new NpgsqlParameter("@year", year)
        };
                lblNewCustomers.Text = DatabaseHelper.ExecuteQuery(custQ, custParams).Rows[0][0].ToString();

                // --- 4. MOST POPULAR CAR ---
                string popQ = @"SELECT f.""UniqueToken"", COUNT(r.""reservationid"") as BookingCount 
                        FROM tbl_Reservations r
                        JOIN tbl_fleet f ON r.""carid""::text = f.""CarID""::text
                        WHERE EXTRACT(MONTH FROM r.""startdate"") = @month 
                        AND EXTRACT(YEAR FROM r.""startdate"") = @year
                        GROUP BY f.""UniqueToken"", f.""DailyRate""
                        ORDER BY BookingCount DESC, f.""DailyRate"" DESC 
                        LIMIT 1";

                // Fresh parameters for the popular car query
                NpgsqlParameter[] popParams = {
            new NpgsqlParameter("@month", month),
            new NpgsqlParameter("@year", year)
        };
                DataTable dtPop = DatabaseHelper.ExecuteQuery(popQ, popParams);

                pbCarImage.Image = null;
                if (dtPop.Rows.Count > 0)
                {
                    string token = dtPop.Rows[0]["UniqueToken"].ToString();
                    SetCarImageDynamic(token);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stats: " + ex.Message);
            }
        }

        private void SetCarImageDynamic(string token)
        {
            try
            {
                string folderPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CarImages");

                // Define potential paths for both jpg and png
                string jpgPath = System.IO.Path.Combine(folderPath, token + ".jpg");
                string pngPath = System.IO.Path.Combine(folderPath, token + ".png");

                string finalPath = null;

                // Check which file exists
                if (System.IO.File.Exists(jpgPath))
                {
                    finalPath = jpgPath;
                }
                else if (System.IO.File.Exists(pngPath))
                {
                    finalPath = pngPath;
                }

                if (finalPath != null)
                {
                    using (System.IO.FileStream fs = new System.IO.FileStream(finalPath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        pbCarImage.Image = Image.FromStream(fs);
                    }
                    pbCarImage.SizeMode = PictureBoxSizeMode.Zoom;
                    pbCarImage.BackColor = Color.Transparent;
                }
                else
                {
                    pbCarImage.Image = null; // No image found for this token
                }
            }
            catch
            {
                pbCarImage.Image = null;
            }
        }

        private void cmbSelectMonth_SelectedIndexChanged(object sender, EventArgs e) => LoadMonthlyStats();
        private void cmbSelectYear_SelectedIndexChanged(object sender, EventArgs e) => LoadMonthlyStats();
        private void btnBack_Click(object sender, EventArgs e) => this.Close();
    }
}