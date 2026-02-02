namespace NorthstarCollection_portal
{
    partial class ViewCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCustomers));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            dgvCustomerSummary = new DataGridView();
            pbBack = new PictureBox();
            dgvHistoryTimeline = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblCustomerName = new Label();
            lblContact = new Label();
            label2 = new Label();
            label3 = new Label();
            lblFavBrand = new Label();
            lblLoyalty = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerSummary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistoryTimeline).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1348, 183);
            panel1.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(204, 54);
            label1.Name = "label1";
            label1.Size = new Size(446, 68);
            label1.TabIndex = 20;
            label1.Text = "View Customers";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaptionText;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-2, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 183);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // dgvCustomerSummary
            // 
            dgvCustomerSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerSummary.Location = new Point(38, 197);
            dgvCustomerSummary.Name = "dgvCustomerSummary";
            dgvCustomerSummary.RowHeadersWidth = 51;
            dgvCustomerSummary.Size = new Size(1270, 232);
            dgvCustomerSummary.TabIndex = 26;
            dgvCustomerSummary.CellClick += dgvCustomerSummary_CellClick;
            // 
            // pbBack
            // 
            pbBack.BackColor = SystemColors.Control;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(1252, 627);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(68, 66);
            pbBack.SizeMode = PictureBoxSizeMode.Zoom;
            pbBack.TabIndex = 39;
            pbBack.TabStop = false;
            pbBack.Click += btnBack_Click;
            // 
            // dgvHistoryTimeline
            // 
            dgvHistoryTimeline.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoryTimeline.Location = new Point(202, 444);
            dgvHistoryTimeline.Name = "dgvHistoryTimeline";
            dgvHistoryTimeline.RowHeadersWidth = 51;
            dgvHistoryTimeline.Size = new Size(1106, 124);
            dgvHistoryTimeline.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 477);
            label4.Name = "label4";
            label4.Size = new Size(158, 62);
            label4.TabIndex = 45;
            label4.Text = "Customer's \r\nChoice";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(206, 606);
            label5.Name = "label5";
            label5.Size = new Size(72, 22);
            label5.TabIndex = 46;
            label5.Text = "Name :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(206, 658);
            label6.Name = "label6";
            label6.Size = new Size(86, 22);
            label6.TabIndex = 47;
            label6.Text = "Contact :";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.BackColor = SystemColors.Control;
            lblCustomerName.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerName.Location = new Point(304, 608);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(0, 22);
            lblCustomerName.TabIndex = 48;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.BackColor = SystemColors.Control;
            lblContact.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContact.Location = new Point(304, 660);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(0, 22);
            lblContact.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(671, 608);
            label2.Name = "label2";
            label2.Size = new Size(158, 22);
            label2.TabIndex = 50;
            label2.Text = "Favourite Brand :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(671, 658);
            label3.Name = "label3";
            label3.Size = new Size(129, 22);
            label3.TabIndex = 51;
            label3.Text = "Loyalty Tier : ";
            // 
            // lblFavBrand
            // 
            lblFavBrand.AutoSize = true;
            lblFavBrand.Font = new Font("Garamond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFavBrand.Location = new Point(847, 609);
            lblFavBrand.Name = "lblFavBrand";
            lblFavBrand.Size = new Size(52, 21);
            lblFavBrand.TabIndex = 52;
            lblFavBrand.Text = "label7";
            // 
            // lblLoyalty
            // 
            lblLoyalty.AutoSize = true;
            lblLoyalty.Font = new Font("Garamond", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoyalty.Location = new Point(847, 659);
            lblLoyalty.Name = "lblLoyalty";
            lblLoyalty.Size = new Size(55, 21);
            lblLoyalty.TabIndex = 53;
            lblLoyalty.Text = "label8";
            // 
            // ViewCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(lblLoyalty);
            Controls.Add(lblFavBrand);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblContact);
            Controls.Add(lblCustomerName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dgvHistoryTimeline);
            Controls.Add(pbBack);
            Controls.Add(dgvCustomerSummary);
            Controls.Add(panel1);
            Name = "ViewCustomers";
            Text = "ViewCustomers";
            Load += ViewCustomers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerSummary).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistoryTimeline).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private DataGridView dgvCustomerSummary;
        private PictureBox pbBack;
        private DataGridView dgvHistoryTimeline;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblCustomerName;
        private Label lblContact;
        private Label label2;
        private Label label3;
        private Label lblFavBrand;
        private Label lblLoyalty;
    }
}