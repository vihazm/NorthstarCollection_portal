using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Npgsql;

namespace NorthstarCollection_portal
{
    public partial class ManageFleet : Form
    {
        private string selectedImagePath = "";

        public ManageFleet()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ToggleEditFields(false);
            pbRefresh.Click += new EventHandler(pbRefresh_Click);
        }

        private void ManageFleet_Load(object sender, EventArgs e)
        {
            LoadFleetData();
        }

        private void LoadFleetData()
        {
            try
            {
                dgvCarDetails.DataSource = null;

                
                string query = @"SELECT ""CarID"", ""Brand"", ""Model"", ""DailyRate"", ""Status"", ""UniqueToken"" FROM tbl_fleet";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                dgvCarDetails.DataSource = dt;

                if (dgvCarDetails.Columns["CarID"] != null) dgvCarDetails.Columns["CarID"].Visible = false;

                
                dgvCarDetails.EnableHeadersVisualStyles = false;

                
                dgvCarDetails.ColumnHeadersDefaultCellStyle.Font = new Font(dgvCarDetails.Font, FontStyle.Bold);

                
                dgvCarDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dgvCarDetails.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

                dgvCarDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCarDetails.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading fleet: " + ex.Message);
            }
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            LoadFleetData();
            ToggleEditFields(false);
        }

        private void ToggleEditFields(bool show)
        {
            txtUpdateRate.Visible = show;
            cmbUpdateStatus.Visible = show;
            txtUpdateToken.Visible = show;
            btnApplyChanges.Visible = show;
            label8.Visible = show;
            label9.Visible = show;
            label12.Visible = show;
        }

        private void UpdateEditFieldsFromGrid()
        {
            if (dgvCarDetails.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvCarDetails.SelectedRows[0];
                txtUpdateRate.Text = selectedRow.Cells["DailyRate"].Value.ToString();
                cmbUpdateStatus.Text = selectedRow.Cells["Status"].Value.ToString();
                txtUpdateToken.Text = selectedRow.Cells["UniqueToken"].Value.ToString();
            }
        }

        private void dgvCarDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (btnApplyChanges.Visible && dgvCarDetails.SelectedRows.Count > 0)
            {
                UpdateEditFieldsFromGrid();
            }
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    pbSelectedImage.Image = Image.FromFile(selectedImagePath);
                    pbSelectedImage.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtToken.Text) || string.IsNullOrEmpty(selectedImagePath))
                {
                    MessageBox.Show("Please enter a Token and select an Image.");
                    return;
                }

                
                string query = @"INSERT INTO tbl_fleet (""Brand"", ""Model"", ""DailyRate"", ""UniqueToken"", ""Status"", ""IsActive"") 
                                 VALUES (@brand, @model, @rate, @token, 'Available', 1)";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@brand", txtBrand.Text),
                    new NpgsqlParameter("@model", txtModel.Text),
                    new NpgsqlParameter("@rate", Convert.ToDecimal(txtRate.Text)),
                    new NpgsqlParameter("@token", txtToken.Text.Trim())
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);

                
                string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CarImages");
                if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);

                string extension = Path.GetExtension(selectedImagePath);
                string destPath = Path.Combine(folderPath, txtToken.Text.Trim() + extension);

                File.Copy(selectedImagePath, destPath, true);

                MessageBox.Show("New car successfully added!");
                LoadFleetData();
                ClearAddFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Addition failed: " + ex.Message);
            }
        }

        private void ClearAddFields()
        {
            txtBrand.Clear();
            txtModel.Clear();
            txtRate.Clear();
            txtToken.Clear();
            pbSelectedImage.Image = null;
            selectedImagePath = "";
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            if (dgvCarDetails.SelectedRows.Count > 0)
            {
                UpdateEditFieldsFromGrid();
                ToggleEditFields(true);
            }
        }

        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCarDetails.SelectedRows.Count == 0) return;

                DataGridViewRow selectedRow = dgvCarDetails.SelectedRows[0];
                int carId = Convert.ToInt32(selectedRow.Cells["CarID"].Value);
                string currentStatusInDb = selectedRow.Cells["Status"].Value.ToString();

                if (currentStatusInDb == "Rented")
                {
                    MessageBox.Show("This car is currently Rented and cannot be modified.");
                    return;
                }

                string newStatus = cmbUpdateStatus.SelectedItem?.ToString() ?? cmbUpdateStatus.Text.Trim();

                if (string.IsNullOrEmpty(newStatus))

                {
                    MessageBox.Show("Please select a status.");
                    return;
                }

                
                string updateQuery = @"UPDATE tbl_fleet SET 
                                      ""DailyRate"" = @rate, 
                                      ""Status"" = @status, 
                                      ""UniqueToken"" = @token 
                                      WHERE ""CarID"" = @id";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@rate", Convert.ToDecimal(txtUpdateRate.Text)),
                    new NpgsqlParameter("@status", newStatus),
                    new NpgsqlParameter("@token", txtUpdateToken.Text.Trim()),
                    new NpgsqlParameter("@id", carId)
                };

                DatabaseHelper.ExecuteNonQuery(updateQuery, parameters);

                MessageBox.Show($"Car updated successfully!");
                LoadFleetData();
                ToggleEditFields(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error applying changes: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e) => this.Close();
    }
}