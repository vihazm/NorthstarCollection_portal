using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Npgsql; 

namespace NorthstarCollection_portal
{
    public partial class ViewFleet : Form
    {
        public ViewFleet()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

           
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }

        private void ViewFleet_Load(object sender, EventArgs e)
        {
            LoadFleetData();
        }

        private void LoadFleetData()
        {
            try
            {
               
                string query = @"
                SELECT f.""CarID"", f.""Brand"", f.""Model"", f.""DailyRate"", 
                CASE 
                    WHEN f.""Status"" = 'Unavailable' THEN 'Unavailable'
                    WHEN r.MaxEndDate < CURRENT_DATE OR r.MaxEndDate IS NULL THEN 'Available'
                    ELSE f.""Status"" 
                END AS Status,
                f.""UniqueToken""
                FROM tbl_fleet f
                LEFT JOIN (
                    SELECT CarID, MAX(EndDate) as MaxEndDate 
                    FROM tbl_Reservations 
                    GROUP BY CarID
                ) r ON f.""CarID"" = r.CarID
                WHERE f.""IsActive"" = 1 
                AND f.""Status"" != 'Unavailable'";

               
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvFleet.DataSource = dt;

                if (dgvFleet.Columns["CarID"] != null) dgvFleet.Columns["CarID"].Visible = false;

               
                dgvFleet.EnableHeadersVisualStyles = false;

               
                dgvFleet.ColumnHeadersDefaultCellStyle.Font = new Font(dgvFleet.Font, FontStyle.Bold);

                
                dgvFleet.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dgvFleet.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

                dgvFleet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFleet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;

                DataGridViewRow row = dgvFleet.Rows[e.RowIndex];

                
                lblNameValue.Text = row.Cells["Model"].Value.ToString();
                lblBrandValue.Text = row.Cells["Brand"].Value.ToString();
                lblRateValue.Text = "$" + row.Cells["DailyRate"].Value.ToString();
                lblStatusValue.Text = row.Cells["Status"].Value.ToString();
                lblTokenValue.Text = row.Cells["UniqueToken"].Value.ToString();

                string token = row.Cells["UniqueToken"].Value.ToString();
                LoadCarImage(token);
            }
        }

        
        private void LoadCarImage(string token)
        {
            try
            {
                string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CarImages");
                string imagePath = "";

                string[] possibleNames = new string[]
                {
                    token + ".jpg",
                    token + ".png",
                    token + ".jpeg",
                    token.Replace("-", "_") + ".jpg",
                    token.Replace("-", "_") + ".png",
                    token.ToLower() + ".jpg",
                    token.ToLower() + ".png"
                };

                bool found = false;
                foreach (string name in possibleNames)
                {
                    string testPath = Path.Combine(folderPath, name);
                    if (File.Exists(testPath))
                    {
                        imagePath = testPath;
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        pbCarImage.Image = Image.FromStream(fs);
                    }
                    pbCarImage.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pbCarImage.Image = null;
                    System.Diagnostics.Debug.WriteLine($"Image Not Found for Token: {token}");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: " + ex.Message);
                pbCarImage.Image = null;
            }
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}