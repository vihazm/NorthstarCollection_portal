namespace NorthstarCollection_portal
{
    partial class UserManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagement));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            dgvUsers = new DataGridView();
            pbBack = new PictureBox();
            label6 = new Label();
            label2 = new Label();
            txtAUser = new TextBox();
            txtAPass = new TextBox();
            btnAdd = new Button();
            label3 = new Label();
            cmbARole = new ComboBox();
            label4 = new Label();
            label7 = new Label();
            txtEPass = new TextBox();
            label5 = new Label();
            label8 = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            label9 = new Label();
            txtDUid = new TextBox();
            btnUserLog = new Button();
            label10 = new Label();
            txtEUid = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
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
            label1.Size = new Size(501, 68);
            label1.TabIndex = 20;
            label1.Text = "User Management";
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
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(24, 203);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(1299, 188);
            dgvUsers.TabIndex = 26;
            // 
            // pbBack
            // 
            pbBack.BackColor = SystemColors.Control;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(1268, 643);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(68, 66);
            pbBack.SizeMode = PictureBoxSizeMode.Zoom;
            pbBack.TabIndex = 39;
            pbBack.TabStop = false;
            pbBack.Click += btnBack_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(86, 473);
            label6.Name = "label6";
            label6.Size = new Size(105, 22);
            label6.TabIndex = 40;
            label6.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 421);
            label2.Name = "label2";
            label2.Size = new Size(125, 31);
            label2.TabIndex = 41;
            label2.Text = "Add User";
            // 
            // txtAUser
            // 
            txtAUser.BorderStyle = BorderStyle.FixedSingle;
            txtAUser.Location = new Point(197, 471);
            txtAUser.Name = "txtAUser";
            txtAUser.Size = new Size(142, 27);
            txtAUser.TabIndex = 42;
            // 
            // txtAPass
            // 
            txtAPass.BorderStyle = BorderStyle.FixedSingle;
            txtAPass.Location = new Point(197, 516);
            txtAPass.Name = "txtAPass";
            txtAPass.Size = new Size(142, 27);
            txtAPass.TabIndex = 43;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 255, 192);
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(86, 615);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 47);
            btnAdd.TabIndex = 44;
            btnAdd.Text = "Add User";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(86, 518);
            label3.Name = "label3";
            label3.Size = new Size(100, 22);
            label3.TabIndex = 45;
            label3.Text = "Password :";
            // 
            // cmbARole
            // 
            cmbARole.FormattingEnabled = true;
            cmbARole.Location = new Point(197, 562);
            cmbARole.Name = "cmbARole";
            cmbARole.Size = new Size(142, 28);
            cmbARole.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(86, 564);
            label4.Name = "label4";
            label4.Size = new Size(59, 22);
            label4.TabIndex = 47;
            label4.Text = "Role :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(454, 518);
            label7.Name = "label7";
            label7.Size = new Size(100, 22);
            label7.TabIndex = 51;
            label7.Text = "Password :";
            // 
            // txtEPass
            // 
            txtEPass.BorderStyle = BorderStyle.FixedSingle;
            txtEPass.Location = new Point(560, 517);
            txtEPass.Name = "txtEPass";
            txtEPass.Size = new Size(142, 27);
            txtEPass.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(429, 421);
            label5.Name = "label5";
            label5.Size = new Size(129, 31);
            label5.TabIndex = 52;
            label5.Text = "Edit User";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(787, 421);
            label8.Name = "label8";
            label8.Size = new Size(154, 31);
            label8.TabIndex = 53;
            label8.Text = "Delete User";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 255, 192);
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(454, 564);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(124, 47);
            btnUpdate.TabIndex = 54;
            btnUpdate.Text = "Update User";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 192, 192);
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(805, 518);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 47);
            btnDelete.TabIndex = 55;
            btnDelete.Text = "Delete User";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(805, 472);
            label9.Name = "label9";
            label9.Size = new Size(81, 22);
            label9.TabIndex = 57;
            label9.Text = "User id :";
            // 
            // txtDUid
            // 
            txtDUid.BorderStyle = BorderStyle.FixedSingle;
            txtDUid.Location = new Point(892, 471);
            txtDUid.Name = "txtDUid";
            txtDUid.Size = new Size(142, 27);
            txtDUid.TabIndex = 56;
            // 
            // btnUserLog
            // 
            btnUserLog.BackColor = Color.FromArgb(192, 192, 255);
            btnUserLog.FlatStyle = FlatStyle.Popup;
            btnUserLog.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserLog.Location = new Point(1161, 421);
            btnUserLog.Name = "btnUserLog";
            btnUserLog.Size = new Size(162, 72);
            btnUserLog.TabIndex = 58;
            btnUserLog.Text = "Download User Log";
            btnUserLog.UseVisualStyleBackColor = false;
            btnUserLog.Click += btnUserLog_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(454, 473);
            label10.Name = "label10";
            label10.Size = new Size(81, 22);
            label10.TabIndex = 60;
            label10.Text = "User id :";
            // 
            // txtEUid
            // 
            txtEUid.BorderStyle = BorderStyle.FixedSingle;
            txtEUid.Location = new Point(560, 471);
            txtEUid.Name = "txtEUid";
            txtEUid.Size = new Size(142, 27);
            txtEUid.TabIndex = 59;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(label10);
            Controls.Add(txtEUid);
            Controls.Add(btnUserLog);
            Controls.Add(label9);
            Controls.Add(txtDUid);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(txtEPass);
            Controls.Add(label4);
            Controls.Add(cmbARole);
            Controls.Add(label3);
            Controls.Add(btnAdd);
            Controls.Add(txtAPass);
            Controls.Add(txtAUser);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(pbBack);
            Controls.Add(dgvUsers);
            Controls.Add(panel1);
            Name = "UserManagement";
            Text = "UserManagement";
            Load += UserManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private DataGridView dgvUsers;
        private PictureBox pbBack;
        private Label label6;
        private Label label2;
        private TextBox txtAUser;
        private TextBox txtAPass;
        private Button btnAdd;
        private Label label3;
        private ComboBox cmbARole;
        private Label label4;
        private Label label7;
        private TextBox txtEPass;
        private Label label5;
        private Label label8;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label9;
        private TextBox txtDUid;
        private Button btnUserLog;
        private Label label10;
        private TextBox txtEUid;
    }
}