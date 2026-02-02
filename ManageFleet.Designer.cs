namespace NorthstarCollection_portal
{
    partial class ManageFleet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageFleet));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pbBack = new PictureBox();
            txtBrand = new TextBox();
            txtModel = new TextBox();
            txtRate = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtToken = new TextBox();
            btnAddCar = new Button();
            dgvCarDetails = new DataGridView();
            label7 = new Label();
            btnEditCar = new Button();
            btnApplyChanges = new Button();
            cmbUpdateStatus = new ComboBox();
            txtUpdateRate = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtUpdateToken = new TextBox();
            label12 = new Label();
            btnSelectImage = new Button();
            pbSelectedImage = new PictureBox();
            pbRefresh = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSelectedImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1348, 183);
            panel1.TabIndex = 24;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaptionText;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-2, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(186, 178);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(190, 56);
            label1.Name = "label1";
            label1.Size = new Size(378, 68);
            label1.TabIndex = 20;
            label1.Text = "Manage Fleet";
            // 
            // pbBack
            // 
            pbBack.BackColor = SystemColors.Control;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(1255, 631);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(68, 66);
            pbBack.SizeMode = PictureBoxSizeMode.Zoom;
            pbBack.TabIndex = 25;
            pbBack.TabStop = false;
            pbBack.Click += btnBack_Click;
            // 
            // txtBrand
            // 
            txtBrand.BorderStyle = BorderStyle.FixedSingle;
            txtBrand.ImeMode = ImeMode.NoControl;
            txtBrand.Location = new Point(161, 285);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(150, 27);
            txtBrand.TabIndex = 26;
            // 
            // txtModel
            // 
            txtModel.BorderStyle = BorderStyle.FixedSingle;
            txtModel.Location = new Point(161, 333);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(150, 27);
            txtModel.TabIndex = 27;
            // 
            // txtRate
            // 
            txtRate.BorderStyle = BorderStyle.FixedSingle;
            txtRate.Location = new Point(161, 385);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(150, 27);
            txtRate.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(129, 220);
            label2.Name = "label2";
            label2.Size = new Size(121, 34);
            label2.TabIndex = 29;
            label2.Text = "Add Car";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(65, 287);
            label3.Name = "label3";
            label3.Size = new Size(73, 22);
            label3.TabIndex = 30;
            label3.Text = "Brand :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(65, 335);
            label4.Name = "label4";
            label4.Size = new Size(74, 22);
            label4.TabIndex = 31;
            label4.Text = "Model :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(65, 387);
            label5.Name = "label5";
            label5.Size = new Size(59, 22);
            label5.TabIndex = 32;
            label5.Text = "Rate :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(65, 439);
            label6.Name = "label6";
            label6.Size = new Size(75, 22);
            label6.TabIndex = 33;
            label6.Text = "Token :";
            // 
            // txtToken
            // 
            txtToken.BorderStyle = BorderStyle.FixedSingle;
            txtToken.Location = new Point(161, 437);
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(150, 27);
            txtToken.TabIndex = 34;
            // 
            // btnAddCar
            // 
            btnAddCar.BackColor = Color.FromArgb(192, 255, 192);
            btnAddCar.FlatStyle = FlatStyle.Popup;
            btnAddCar.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCar.Location = new Point(65, 636);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(121, 45);
            btnAddCar.TabIndex = 35;
            btnAddCar.Text = "Add";
            btnAddCar.UseVisualStyleBackColor = false;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // dgvCarDetails
            // 
            dgvCarDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarDetails.Location = new Point(433, 285);
            dgvCarDetails.Name = "dgvCarDetails";
            dgvCarDetails.RowHeadersWidth = 51;
            dgvCarDetails.Size = new Size(875, 188);
            dgvCarDetails.TabIndex = 36;
            dgvCarDetails.SelectionChanged += dgvCarDetails_SelectionChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(433, 220);
            label7.Name = "label7";
            label7.Size = new Size(218, 34);
            label7.TabIndex = 37;
            label7.Text = "Edit Car Details";
            // 
            // btnEditCar
            // 
            btnEditCar.BackColor = Color.FromArgb(255, 255, 192);
            btnEditCar.FlatStyle = FlatStyle.Popup;
            btnEditCar.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditCar.Location = new Point(433, 492);
            btnEditCar.Name = "btnEditCar";
            btnEditCar.Size = new Size(121, 45);
            btnEditCar.TabIndex = 38;
            btnEditCar.Text = "Edit";
            btnEditCar.UseVisualStyleBackColor = false;
            btnEditCar.Click += btnEditCar_Click;
            // 
            // btnApplyChanges
            // 
            btnApplyChanges.BackColor = Color.FromArgb(255, 255, 192);
            btnApplyChanges.FlatStyle = FlatStyle.Popup;
            btnApplyChanges.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApplyChanges.Location = new Point(570, 636);
            btnApplyChanges.Name = "btnApplyChanges";
            btnApplyChanges.Size = new Size(152, 45);
            btnApplyChanges.TabIndex = 39;
            btnApplyChanges.Text = "Apply Changes";
            btnApplyChanges.UseVisualStyleBackColor = false;
            btnApplyChanges.Click += btnApplyChanges_Click;
            // 
            // cmbUpdateStatus
            // 
            cmbUpdateStatus.FormattingEnabled = true;
            cmbUpdateStatus.Items.AddRange(new object[] { "Available", "Unavailable" });
            cmbUpdateStatus.Location = new Point(659, 541);
            cmbUpdateStatus.Name = "cmbUpdateStatus";
            cmbUpdateStatus.Size = new Size(157, 28);
            cmbUpdateStatus.TabIndex = 40;
            // 
            // txtUpdateRate
            // 
            txtUpdateRate.BorderStyle = BorderStyle.FixedSingle;
            txtUpdateRate.Location = new Point(659, 497);
            txtUpdateRate.Name = "txtUpdateRate";
            txtUpdateRate.Size = new Size(157, 27);
            txtUpdateRate.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(570, 499);
            label8.Name = "label8";
            label8.Size = new Size(59, 22);
            label8.TabIndex = 42;
            label8.Text = "Rate :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(570, 543);
            label9.Name = "label9";
            label9.Size = new Size(71, 22);
            label9.TabIndex = 43;
            label9.Text = "Status :";
            // 
            // txtUpdateToken
            // 
            txtUpdateToken.BorderStyle = BorderStyle.FixedSingle;
            txtUpdateToken.Location = new Point(659, 589);
            txtUpdateToken.Name = "txtUpdateToken";
            txtUpdateToken.Size = new Size(157, 27);
            txtUpdateToken.TabIndex = 49;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(570, 591);
            label12.Name = "label12";
            label12.Size = new Size(75, 22);
            label12.TabIndex = 48;
            label12.Text = "Token :";
            // 
            // btnSelectImage
            // 
            btnSelectImage.BackColor = Color.White;
            btnSelectImage.FlatStyle = FlatStyle.Popup;
            btnSelectImage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectImage.Location = new Point(65, 487);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(246, 34);
            btnSelectImage.TabIndex = 50;
            btnSelectImage.Text = "Select Image";
            btnSelectImage.UseVisualStyleBackColor = false;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // pbSelectedImage
            // 
            pbSelectedImage.Location = new Point(65, 527);
            pbSelectedImage.Name = "pbSelectedImage";
            pbSelectedImage.Size = new Size(185, 89);
            pbSelectedImage.TabIndex = 51;
            pbSelectedImage.TabStop = false;
            // 
            // pbRefresh
            // 
            pbRefresh.Image = (Image)resources.GetObject("pbRefresh.Image");
            pbRefresh.Location = new Point(1255, 233);
            pbRefresh.Name = "pbRefresh";
            pbRefresh.Size = new Size(53, 46);
            pbRefresh.SizeMode = PictureBoxSizeMode.Zoom;
            pbRefresh.TabIndex = 52;
            pbRefresh.TabStop = false;
            pbRefresh.Click += pbRefresh_Click;
            // 
            // ManageFleet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(pbRefresh);
            Controls.Add(pbSelectedImage);
            Controls.Add(btnSelectImage);
            Controls.Add(txtUpdateToken);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtUpdateRate);
            Controls.Add(cmbUpdateStatus);
            Controls.Add(btnApplyChanges);
            Controls.Add(btnEditCar);
            Controls.Add(label7);
            Controls.Add(dgvCarDetails);
            Controls.Add(btnAddCar);
            Controls.Add(txtToken);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtRate);
            Controls.Add(txtModel);
            Controls.Add(txtBrand);
            Controls.Add(pbBack);
            Controls.Add(panel1);
            Name = "ManageFleet";
            Text = " ";
            Load += ManageFleet_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSelectedImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pbBack;
        private TextBox txtBrand;
        private TextBox txtModel;
        private TextBox txtRate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtToken;
        private Button btnAddCar;
        private DataGridView dgvCarDetails;
        private Label label7;
        private Button btnEditCar;
        private Button btnApplyChanges;
        private ComboBox cmbUpdateStatus;
        private TextBox txtUpdateRate;
        private Label label8;
        private Label label9;
        private TextBox txtUpdateToken;
        private Label label12;
        private Button btnSelectImage;
        private PictureBox pbSelectedImage;
        private PictureBox pbRefresh;
    }
}