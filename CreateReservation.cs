using System;
using System.Data;
using System.Windows.Forms;
using Npgsql; 

namespace NorthstarCollection_portal
{
    public partial class CreateReservation : Form
    {
        public CreateReservation()
        {
            InitializeComponent();
        }

        private void CreateReservation_Load(object sender, EventArgs e)
        {
            FillCarComboBox();
        }

        private void FillCarComboBox()
        {
            try
            {
                string query = "SELECT \"CarID\", \"Model\" FROM tbl_fleet WHERE \"IsActive\" = 1 AND \"Status\" = 'Available'";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                if (dt != null && dt.Rows.Count > 0)
                {
                    cmbCar.DataSource = dt;
                    cmbCar.DisplayMember = "Model";
                    cmbCar.ValueMember = "CarID";
                    cmbCar.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cars: " + ex.Message);
            }
        }

        private void CalculateTotal()
        {
            try
            {
                if (cmbCar.SelectedValue != null && int.TryParse(cmbCar.SelectedValue.ToString(), out int carId))
                {
                    string query = "SELECT \"DailyRate\" FROM tbl_fleet WHERE \"CarID\" = @id";
                    NpgsqlParameter[] parameters = { new NpgsqlParameter("@id", carId) };
                    DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                    if (dt.Rows.Count > 0)
                    {
                        decimal dailyRate = Convert.ToDecimal(dt.Rows[0]["DailyRate"]);

                        DateTime start = dtpStart.Value.Date;
                        DateTime end = dtpEnd.Value.Date;
                        TimeSpan duration = end - start;
                        int totalDays = duration.Days;
                        if (totalDays <= 0) totalDays = 1;

                        decimal subtotal = dailyRate * totalDays;

                        //Sri Lankan 18% VAT Policy
                        decimal tax = subtotal * 0.18m;
                        decimal grandTotal = subtotal + tax;

                        lblDailyRate.Text = dailyRate.ToString("C");
                        lblTotalDays.Text = totalDays.ToString();
                        lblSubtotal.Text = subtotal.ToString("C");

                        
                        lblVAT.Text = tax.ToString("C");

                        lblGrandTotal.Text = grandTotal.ToString("C");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Calculation error: " + ex.Message);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (dtpEnd.Value < dtpStart.Value)
            {
                MessageBox.Show("Return date cannot be earlier than the pick-up date.", "Date Error");
                return;
            }

            if (cmbCar.SelectedValue == null || string.IsNullOrWhiteSpace(txtFullname.Text))
            {
                MessageBox.Show("Please select a car and enter the customer's full name.", "Missing Information");
                return;
            }

            try
            {
                int carId = Convert.ToInt32(cmbCar.SelectedValue);
                decimal total = decimal.Parse(lblGrandTotal.Text, System.Globalization.NumberStyles.Currency);

                
                decimal deposit = 0;

                string insertQuery = @"INSERT INTO tbl_Reservations 
                (CarID, CustomerName, CustomerPhone, InsuranceNumber, StartDate, EndDate, Deposit, TotalCost) 
                VALUES (@carId, @name, @phone, @ins, @start, @end, @dep, @total)";

                NpgsqlParameter[] resParams = {
                    new NpgsqlParameter("@carId", carId),
                    new NpgsqlParameter("@name", txtFullname.Text),
                    new NpgsqlParameter("@phone", txtPhoneNumber.Text),
                    new NpgsqlParameter("@ins", txtInsurance.Text),
                    new NpgsqlParameter("@start", dtpStart.Value.Date),
                    new NpgsqlParameter("@end", dtpEnd.Value.Date),
                    new NpgsqlParameter("@dep", deposit),
                    new NpgsqlParameter("@total", total)
                };

                DatabaseHelper.ExecuteNonQuery(insertQuery, resParams);

                string updateQuery = "UPDATE tbl_fleet SET \"Status\" = 'Rented' WHERE \"CarID\" = @carId";
                NpgsqlParameter[] updateParams = { new NpgsqlParameter("@carId", carId) };
                DatabaseHelper.ExecuteNonQuery(updateQuery, updateParams);

                MessageBox.Show("Reservation Confirmed Successfully!", "Success");
                FillCarComboBox();
                btnClear_Click(sender, e);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Transaction Failed: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullname.Clear();
            txtPhoneNumber.Clear();
            txtInsurance.Clear();

            cmbCar.SelectedIndex = -1;
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now.AddDays(1);

            lblDailyRate.Text = "$0.00";
            lblTotalDays.Text = "0";
            lblSubtotal.Text = "$0.00";
            lblVAT.Text = "$0.00"; 
            lblGrandTotal.Text = "$0.00";
        }

        private void pbBack_Click(object sender, EventArgs e) { this.Close(); }
        private void cmbCar_SelectedIndexChanged(object sender, EventArgs e) { CalculateTotal(); }
        private void dtpStart_ValueChanged(object sender, EventArgs e) { CalculateTotal(); }
        private void dtpEnd_ValueChanged(object sender, EventArgs e) { CalculateTotal(); }
    }
}