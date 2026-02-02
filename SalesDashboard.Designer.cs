namespace NorthstarCollection_portal
{
    partial class SalesDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesDashboard));
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnViewFleet = new Button();
            btnViewCustomers = new Button();
            btnCreateReservations = new Button();
            panel1 = new Panel();
            btnLogout = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(143, 258);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(85, 85);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(143, 138);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(85, 85);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(143, 379);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btnViewFleet
            // 
            btnViewFleet.BackColor = Color.PapayaWhip;
            btnViewFleet.FlatStyle = FlatStyle.Popup;
            btnViewFleet.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewFleet.ForeColor = Color.Black;
            btnViewFleet.Location = new Point(245, 163);
            btnViewFleet.Name = "btnViewFleet";
            btnViewFleet.Size = new Size(192, 43);
            btnViewFleet.TabIndex = 8;
            btnViewFleet.Text = "View Fleet";
            btnViewFleet.UseVisualStyleBackColor = false;
            btnViewFleet.Click += btnViewFleet_Click;
            // 
            // btnViewCustomers
            // 
            btnViewCustomers.BackColor = Color.PapayaWhip;
            btnViewCustomers.FlatStyle = FlatStyle.Popup;
            btnViewCustomers.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewCustomers.ForeColor = Color.Black;
            btnViewCustomers.Location = new Point(245, 399);
            btnViewCustomers.Name = "btnViewCustomers";
            btnViewCustomers.Size = new Size(192, 43);
            btnViewCustomers.TabIndex = 10;
            btnViewCustomers.Text = "View Customers";
            btnViewCustomers.UseVisualStyleBackColor = false;
            btnViewCustomers.Click += btnViewCustomers_Click;
            // 
            // btnCreateReservations
            // 
            btnCreateReservations.BackColor = Color.PapayaWhip;
            btnCreateReservations.FlatStyle = FlatStyle.Popup;
            btnCreateReservations.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateReservations.ForeColor = Color.Black;
            btnCreateReservations.Location = new Point(245, 279);
            btnCreateReservations.Name = "btnCreateReservations";
            btnCreateReservations.Size = new Size(192, 43);
            btnCreateReservations.TabIndex = 9;
            btnCreateReservations.Text = "Create Reservations";
            btnCreateReservations.UseVisualStyleBackColor = false;
            btnCreateReservations.Click += btnCreateReservations_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnViewFleet);
            panel1.Controls.Add(btnViewCustomers);
            panel1.Controls.Add(btnCreateReservations);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(784, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(564, 721);
            panel1.TabIndex = 16;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DarkRed;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(398, 633);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(130, 54);
            btnLogout.TabIndex = 16;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(189, 70);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(384, 425);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.NavajoWhite;
            label1.Location = new Point(87, 442);
            label1.Name = "label1";
            label1.Size = new Size(596, 68);
            label1.TabIndex = 18;
            label1.Text = "Welcome Salesperson!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Garamond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(191, 528);
            label2.Name = "label2";
            label2.Size = new Size(377, 31);
            label2.TabIndex = 19;
            label2.Text = "What would you like to do today?";
            // 
            // SalesDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1348, 721);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Name = "SalesDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SalesDashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Button btnViewFleet;
        private Button btnViewCustomers;
        private Button btnCreateReservations;
        private Panel panel1;
        private Button btnLogout;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
    }
}