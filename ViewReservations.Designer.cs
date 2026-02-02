namespace NorthstarCollection_portal
{
    partial class ViewReservations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewReservations));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            dgvReservations = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNameSearch = new TextBox();
            btnFilter = new Button();
            cmbYear = new ComboBox();
            cmbMonth = new ComboBox();
            pbBack = new PictureBox();
            btnRefresh = new Button();
            label5 = new Label();
            lblSalesGoal = new Label();
            lblCurrentSales = new Label();
            label7 = new Label();
            lblSalesComment = new Label();
            btnRenew = new Button();
            txtAmount = new TextBox();
            label6 = new Label();
            btnSet = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
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
            panel1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(204, 54);
            label1.Name = "label1";
            label1.Size = new Size(498, 68);
            label1.TabIndex = 20;
            label1.Text = "View Reservations";
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
            // dgvReservations
            // 
            dgvReservations.BackgroundColor = Color.White;
            dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservations.Location = new Point(56, 204);
            dgvReservations.Name = "dgvReservations";
            dgvReservations.RowHeadersWidth = 51;
            dgvReservations.Size = new Size(1236, 203);
            dgvReservations.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(115, 440);
            label2.Name = "label2";
            label2.Size = new Size(244, 22);
            label2.TabIndex = 30;
            label2.Text = "Search by Customer Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(115, 498);
            label3.Name = "label3";
            label3.Size = new Size(59, 22);
            label3.TabIndex = 31;
            label3.Text = "Year :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(383, 498);
            label4.Name = "label4";
            label4.Size = new Size(76, 22);
            label4.TabIndex = 32;
            label4.Text = "Month :";
            // 
            // txtNameSearch
            // 
            txtNameSearch.BorderStyle = BorderStyle.FixedSingle;
            txtNameSearch.Location = new Point(373, 440);
            txtNameSearch.Name = "txtNameSearch";
            txtNameSearch.Size = new Size(250, 27);
            txtNameSearch.TabIndex = 33;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(192, 255, 192);
            btnFilter.FlatStyle = FlatStyle.Popup;
            btnFilter.Font = new Font("Garamond", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilter.Location = new Point(115, 551);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(103, 38);
            btnFilter.TabIndex = 34;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // cmbYear
            // 
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(180, 496);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(151, 28);
            cmbYear.TabIndex = 36;
            // 
            // cmbMonth
            // 
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(465, 496);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(151, 28);
            cmbMonth.TabIndex = 37;
            // 
            // pbBack
            // 
            pbBack.BackColor = SystemColors.Control;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(1268, 643);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(68, 66);
            pbBack.SizeMode = PictureBoxSizeMode.Zoom;
            pbBack.TabIndex = 38;
            pbBack.TabStop = false;
            pbBack.Click += btnBack_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(192, 192, 255);
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Garamond", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(228, 551);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(103, 38);
            btnRefresh.TabIndex = 39;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(798, 456);
            label5.Name = "label5";
            label5.Size = new Size(109, 22);
            label5.TabIndex = 40;
            label5.Text = "Sales Goal :";
            // 
            // lblSalesGoal
            // 
            lblSalesGoal.AutoSize = true;
            lblSalesGoal.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalesGoal.Location = new Point(937, 456);
            lblSalesGoal.Name = "lblSalesGoal";
            lblSalesGoal.Size = new Size(106, 22);
            lblSalesGoal.TabIndex = 41;
            lblSalesGoal.Text = "lblSalesGoal";
            // 
            // lblCurrentSales
            // 
            lblCurrentSales.AutoSize = true;
            lblCurrentSales.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentSales.Location = new Point(937, 498);
            lblCurrentSales.Name = "lblCurrentSales";
            lblCurrentSales.Size = new Size(129, 22);
            lblCurrentSales.TabIndex = 43;
            lblCurrentSales.Text = "lblCurrentSales";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(798, 498);
            label7.Name = "label7";
            label7.Size = new Size(133, 22);
            label7.TabIndex = 42;
            label7.Text = "Current Sales :";
            // 
            // lblSalesComment
            // 
            lblSalesComment.AutoSize = true;
            lblSalesComment.Font = new Font("Garamond", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalesComment.Location = new Point(798, 551);
            lblSalesComment.Name = "lblSalesComment";
            lblSalesComment.Size = new Size(169, 26);
            lblSalesComment.TabIndex = 44;
            lblSalesComment.Text = "lblSalesComment";
            // 
            // btnRenew
            // 
            btnRenew.FlatStyle = FlatStyle.Popup;
            btnRenew.Font = new Font("Garamond", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRenew.Location = new Point(798, 621);
            btnRenew.Name = "btnRenew";
            btnRenew.Size = new Size(188, 38);
            btnRenew.TabIndex = 45;
            btnRenew.Text = "Renew Sales Goal";
            btnRenew.UseVisualStyleBackColor = true;
            btnRenew.Click += btnRenew_Click;
            // 
            // txtAmount
            // 
            txtAmount.BorderStyle = BorderStyle.FixedSingle;
            txtAmount.Location = new Point(888, 674);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(131, 27);
            txtAmount.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(798, 676);
            label6.Name = "label6";
            label6.Size = new Size(87, 22);
            label6.TabIndex = 47;
            label6.Text = "Amount :";
            // 
            // btnSet
            // 
            btnSet.FlatStyle = FlatStyle.Popup;
            btnSet.Location = new Point(1025, 674);
            btnSet.Name = "btnSet";
            btnSet.Size = new Size(74, 29);
            btnSet.TabIndex = 48;
            btnSet.Text = "Set";
            btnSet.UseVisualStyleBackColor = true;
            btnSet.Click += btnSet_Click;
            // 
            // ViewReservations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(btnSet);
            Controls.Add(label6);
            Controls.Add(txtAmount);
            Controls.Add(btnRenew);
            Controls.Add(lblSalesComment);
            Controls.Add(lblCurrentSales);
            Controls.Add(label7);
            Controls.Add(lblSalesGoal);
            Controls.Add(label5);
            Controls.Add(btnRefresh);
            Controls.Add(pbBack);
            Controls.Add(cmbMonth);
            Controls.Add(cmbYear);
            Controls.Add(btnFilter);
            Controls.Add(txtNameSearch);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvReservations);
            Controls.Add(panel1);
            Name = "ViewReservations";
            Text = "ViewReservations";
            Load += ViewReservations_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private DataGridView dgvReservations;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNameSearch;
        private Button btnFilter;
        private ComboBox cmbYear;
        private ComboBox cmbMonth;
        private PictureBox pbBack;
        private Button btnRefresh;
        private Label label5;
        private Label lblSalesGoal;
        private Label lblCurrentSales;
        private Label label7;
        private Label lblSalesComment;
        private Button btnRenew;
        private TextBox txtAmount;
        private Label label6;
        private Button btnSet;
    }
}