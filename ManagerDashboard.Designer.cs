namespace NorthstarCollection_portal
{
    partial class ManagerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerDashboard));
            panel2 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            btnViewFleet = new Button();
            pictureBox6 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnLogout = new Button();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnViewReservations = new Button();
            btnManageFleet = new Button();
            btnViewStats = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(-1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1350, 721);
            panel2.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.NavajoWhite;
            label1.Location = new Point(120, 421);
            label1.Name = "label1";
            label1.Size = new Size(523, 68);
            label1.TabIndex = 9;
            label1.Text = "Welcome Manager!";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(192, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(384, 425);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Garamond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(194, 504);
            label2.Name = "label2";
            label2.Size = new Size(377, 31);
            label2.TabIndex = 10;
            label2.Text = "What would you like to do today?";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnViewFleet);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(btnViewReservations);
            panel1.Controls.Add(btnManageFleet);
            panel1.Controls.Add(btnViewStats);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(778, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(572, 721);
            panel1.TabIndex = 19;
            // 
            // btnViewFleet
            // 
            btnViewFleet.BackColor = Color.PapayaWhip;
            btnViewFleet.FlatStyle = FlatStyle.Popup;
            btnViewFleet.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewFleet.ForeColor = Color.Black;
            btnViewFleet.Location = new Point(237, 126);
            btnViewFleet.Name = "btnViewFleet";
            btnViewFleet.Size = new Size(184, 43);
            btnViewFleet.TabIndex = 23;
            btnViewFleet.Text = "View Fleet";
            btnViewFleet.UseVisualStyleBackColor = false;
            btnViewFleet.Click += btnViewFleet_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(135, 106);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(85, 85);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 22;
            pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(135, 477);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(85, 85);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DarkRed;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(396, 624);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(130, 54);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(135, 358);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(85, 85);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(135, 230);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(85, 85);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // btnViewReservations
            // 
            btnViewReservations.BackColor = Color.PapayaWhip;
            btnViewReservations.FlatStyle = FlatStyle.Popup;
            btnViewReservations.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewReservations.ForeColor = Color.Black;
            btnViewReservations.Location = new Point(237, 378);
            btnViewReservations.Name = "btnViewReservations";
            btnViewReservations.Size = new Size(184, 43);
            btnViewReservations.TabIndex = 12;
            btnViewReservations.Text = "View Reservations";
            btnViewReservations.UseVisualStyleBackColor = false;
            btnViewReservations.Click += btnViewReservations_Click;
            // 
            // btnManageFleet
            // 
            btnManageFleet.BackColor = Color.PapayaWhip;
            btnManageFleet.FlatStyle = FlatStyle.Popup;
            btnManageFleet.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageFleet.ForeColor = Color.Black;
            btnManageFleet.Location = new Point(237, 252);
            btnManageFleet.Name = "btnManageFleet";
            btnManageFleet.Size = new Size(184, 43);
            btnManageFleet.TabIndex = 11;
            btnManageFleet.Text = "Manage Fleet";
            btnManageFleet.UseVisualStyleBackColor = false;
            btnManageFleet.Click += btnManageFleet_Click;
            // 
            // btnViewStats
            // 
            btnViewStats.BackColor = Color.PapayaWhip;
            btnViewStats.FlatStyle = FlatStyle.Popup;
            btnViewStats.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewStats.ForeColor = Color.Black;
            btnViewStats.Location = new Point(237, 500);
            btnViewStats.Name = "btnViewStats";
            btnViewStats.Size = new Size(184, 43);
            btnViewStats.TabIndex = 13;
            btnViewStats.Text = "View Stats";
            btnViewStats.UseVisualStyleBackColor = false;
            btnViewStats.Click += btnViewStats_Click;
            // 
            // ManagerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(panel2);
            Name = "ManagerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagerDashboard";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Button btnManageFleet;
        private Button btnViewStats;
        private Button btnViewReservations;
        private Button btnLogout;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Button btnViewFleet;
        private PictureBox pictureBox6;
    }
}