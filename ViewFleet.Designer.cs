namespace NorthstarCollection_portal
{
    partial class ViewFleet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFleet));
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pbBack = new PictureBox();
            dgvFleet = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            label7 = new Label();
            lblTokenValue = new Label();
            lblStatusValue = new Label();
            lblRateValue = new Label();
            lblBrandValue = new Label();
            lblNameValue = new Label();
            pbCarImage = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFleet).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCarImage).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaptionText;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(186, 178);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(190, 56);
            label1.Name = "label1";
            label1.Size = new Size(300, 68);
            label1.TabIndex = 20;
            label1.Text = "View Fleet";
            // 
            // pbBack
            // 
            pbBack.BackColor = SystemColors.Control;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(1255, 633);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(68, 66);
            pbBack.SizeMode = PictureBoxSizeMode.Zoom;
            pbBack.TabIndex = 21;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // dgvFleet
            // 
            dgvFleet.BackgroundColor = SystemColors.ScrollBar;
            dgvFleet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFleet.Location = new Point(37, 198);
            dgvFleet.Name = "dgvFleet";
            dgvFleet.RowHeadersWidth = 51;
            dgvFleet.Size = new Size(1274, 192);
            dgvFleet.TabIndex = 22;
            dgvFleet.CellClick += dgvFleet_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1348, 183);
            panel1.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(lblTokenValue);
            panel2.Controls.Add(lblStatusValue);
            panel2.Controls.Add(lblRateValue);
            panel2.Controls.Add(lblBrandValue);
            panel2.Controls.Add(lblNameValue);
            panel2.Controls.Add(pbCarImage);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dgvFleet);
            panel2.Controls.Add(pbBack);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1348, 721);
            panel2.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Garamond", 22.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(37, 407);
            label7.Name = "label7";
            label7.Size = new Size(194, 42);
            label7.TabIndex = 34;
            label7.Text = "Car Details";
            // 
            // lblTokenValue
            // 
            lblTokenValue.AutoSize = true;
            lblTokenValue.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTokenValue.Location = new Point(563, 643);
            lblTokenValue.Name = "lblTokenValue";
            lblTokenValue.Size = new Size(0, 25);
            lblTokenValue.TabIndex = 33;
            // 
            // lblStatusValue
            // 
            lblStatusValue.AutoSize = true;
            lblStatusValue.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatusValue.Location = new Point(563, 599);
            lblStatusValue.Name = "lblStatusValue";
            lblStatusValue.Size = new Size(0, 25);
            lblStatusValue.TabIndex = 32;
            // 
            // lblRateValue
            // 
            lblRateValue.AutoSize = true;
            lblRateValue.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRateValue.Location = new Point(563, 556);
            lblRateValue.Name = "lblRateValue";
            lblRateValue.Size = new Size(0, 25);
            lblRateValue.TabIndex = 31;
            // 
            // lblBrandValue
            // 
            lblBrandValue.AutoSize = true;
            lblBrandValue.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBrandValue.Location = new Point(563, 511);
            lblBrandValue.Name = "lblBrandValue";
            lblBrandValue.Size = new Size(0, 25);
            lblBrandValue.TabIndex = 30;
            // 
            // lblNameValue
            // 
            lblNameValue.AutoSize = true;
            lblNameValue.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNameValue.Location = new Point(563, 466);
            lblNameValue.Name = "lblNameValue";
            lblNameValue.Size = new Size(0, 25);
            lblNameValue.TabIndex = 29;
            // 
            // pbCarImage
            // 
            pbCarImage.Location = new Point(37, 466);
            pbCarImage.Name = "pbCarImage";
            pbCarImage.Size = new Size(401, 233);
            pbCarImage.TabIndex = 28;
            pbCarImage.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(476, 643);
            label6.Name = "label6";
            label6.Size = new Size(73, 25);
            label6.TabIndex = 27;
            label6.Text = "Token :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(476, 599);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 26;
            label5.Text = "Status :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(476, 556);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 25;
            label4.Text = "Rate :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(476, 511);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 24;
            label3.Text = "Brand :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(476, 466);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 23;
            label2.Text = "Name :";
            // 
            // ViewFleet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "ViewFleet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewFleet";
            Load += ViewFleet_Load;
            Click += ViewFleet_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFleet).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCarImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pbBack;
        private DataGridView dgvFleet;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pbCarImage;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblTokenValue;
        private Label lblStatusValue;
        private Label lblRateValue;
        private Label lblBrandValue;
        private Label lblNameValue;
        private Label label7;
    }
}