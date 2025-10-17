namespace HMS
{
    partial class Booking_view
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
            label4 = new Label();
            panel6 = new Panel();
            label7 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            panel7 = new Panel();
            dgvbooking = new DataGridView();
            panel4 = new Panel();
            label1 = new Label();
            dgvBookingBackup = new DataGridView();
            panel5 = new Panel();
            label5 = new Label();
            txtSearch = new TextBox();
            booking_clearbtn = new Button();
            booking_printbtn = new Button();
            booking_boohkbtn = new Button();
            booking_schedulebtn = new Button();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvbooking).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookingBackup).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(587, 11);
            label4.Name = "label4";
            label4.Size = new Size(196, 28);
            label4.TabIndex = 12;
            label4.Text = "📋 Booking Data";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(3, 14, 28);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(label4);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1465, 55);
            panel6.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1431, 11);
            label7.Name = "label7";
            label7.Size = new Size(22, 23);
            label7.TabIndex = 13;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(panel6);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1465, 924);
            panel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(1465, 869);
            panel1.TabIndex = 16;
            // 
            // panel7
            // 
            panel7.Controls.Add(dgvbooking);
            panel7.Location = new Point(3, 27);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(1092, 413);
            panel7.TabIndex = 5;
            // 
            // dgvbooking
            // 
            dgvbooking.AllowUserToDeleteRows = false;
            dgvbooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvbooking.Location = new Point(21, 33);
            dgvbooking.Name = "dgvbooking";
            dgvbooking.ReadOnly = true;
            dgvbooking.RowHeadersWidth = 51;
            dgvbooking.Size = new Size(1053, 344);
            dgvbooking.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(label1);
            panel4.Controls.Add(dgvBookingBackup);
            panel4.Location = new Point(3, 448);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1092, 421);
            panel4.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(3, 14, 28);
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(301, 20);
            label1.Name = "label1";
            label1.Size = new Size(302, 28);
            label1.TabIndex = 14;
            label1.Text = "📋 Booking Data Back-Up";
            // 
            // dgvBookingBackup
            // 
            dgvBookingBackup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookingBackup.Location = new Point(21, 65);
            dgvBookingBackup.Name = "dgvBookingBackup";
            dgvBookingBackup.ReadOnly = true;
            dgvBookingBackup.RowHeadersWidth = 51;
            dgvBookingBackup.Size = new Size(1053, 331);
            dgvBookingBackup.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Controls.Add(txtSearch);
            panel5.Controls.Add(booking_clearbtn);
            panel5.Controls.Add(booking_printbtn);
            panel5.Controls.Add(booking_boohkbtn);
            panel5.Controls.Add(booking_schedulebtn);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(1101, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(364, 869);
            panel5.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(7, 322);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 13;
            label5.Text = "🔍 Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(105, 319);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(241, 27);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // booking_clearbtn
            // 
            booking_clearbtn.BackColor = Color.FromArgb(3, 14, 28);
            booking_clearbtn.FlatAppearance.BorderSize = 0;
            booking_clearbtn.FlatAppearance.CheckedBackColor = Color.FromArgb(3, 14, 28);
            booking_clearbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 14, 28);
            booking_clearbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 14, 28);
            booking_clearbtn.FlatStyle = FlatStyle.Flat;
            booking_clearbtn.ForeColor = Color.White;
            booking_clearbtn.Location = new Point(185, 486);
            booking_clearbtn.Name = "booking_clearbtn";
            booking_clearbtn.Size = new Size(161, 45);
            booking_clearbtn.TabIndex = 3;
            booking_clearbtn.Text = "📤 Export";
            booking_clearbtn.UseVisualStyleBackColor = false;
            booking_clearbtn.Click += booking_clearbtn_Click;
            // 
            // booking_printbtn
            // 
            booking_printbtn.BackColor = Color.FromArgb(3, 14, 28);
            booking_printbtn.FlatAppearance.BorderSize = 0;
            booking_printbtn.FlatAppearance.CheckedBackColor = Color.FromArgb(3, 14, 28);
            booking_printbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 14, 28);
            booking_printbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 14, 28);
            booking_printbtn.FlatStyle = FlatStyle.Flat;
            booking_printbtn.ForeColor = Color.White;
            booking_printbtn.Location = new Point(185, 568);
            booking_printbtn.Name = "booking_printbtn";
            booking_printbtn.Size = new Size(161, 45);
            booking_printbtn.TabIndex = 2;
            booking_printbtn.Text = "🖨 Print";
            booking_printbtn.UseVisualStyleBackColor = false;
            booking_printbtn.Click += booking_printbtn_Click;
            // 
            // booking_boohkbtn
            // 
            booking_boohkbtn.BackColor = Color.FromArgb(3, 14, 28);
            booking_boohkbtn.FlatAppearance.BorderSize = 0;
            booking_boohkbtn.FlatAppearance.CheckedBackColor = Color.FromArgb(3, 14, 28);
            booking_boohkbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 14, 28);
            booking_boohkbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 14, 28);
            booking_boohkbtn.FlatStyle = FlatStyle.Flat;
            booking_boohkbtn.ForeColor = Color.White;
            booking_boohkbtn.Location = new Point(20, 568);
            booking_boohkbtn.Name = "booking_boohkbtn";
            booking_boohkbtn.Size = new Size(159, 45);
            booking_boohkbtn.TabIndex = 1;
            booking_boohkbtn.Text = "📥 Import";
            booking_boohkbtn.UseVisualStyleBackColor = false;
            booking_boohkbtn.Click += booking_boohkbtn_Click;
            // 
            // booking_schedulebtn
            // 
            booking_schedulebtn.BackColor = Color.FromArgb(3, 14, 28);
            booking_schedulebtn.FlatAppearance.BorderSize = 0;
            booking_schedulebtn.FlatAppearance.CheckedBackColor = Color.FromArgb(3, 14, 28);
            booking_schedulebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 14, 28);
            booking_schedulebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 14, 28);
            booking_schedulebtn.FlatStyle = FlatStyle.Flat;
            booking_schedulebtn.ForeColor = Color.White;
            booking_schedulebtn.Location = new Point(20, 486);
            booking_schedulebtn.Name = "booking_schedulebtn";
            booking_schedulebtn.Size = new Size(159, 45);
            booking_schedulebtn.TabIndex = 0;
            booking_schedulebtn.Text = "❌ Cancel Booking";
            booking_schedulebtn.UseVisualStyleBackColor = false;
            booking_schedulebtn.Click += booking_schedulebtn_Click;
            // 
            // Booking_view
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1465, 924);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Booking_view";
            Text = "Booking_view";
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvbooking).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookingBackup).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label4;
        private Panel panel6;
        private Label label7;
        private Label GuestId;
        private Label label12;
        private Label txtPricePerNight;
        private Label label9;
        private Label txtDays;
        private Label label6;
        private Label label3;
        private DateTimePicker checkOutPicker;
        private DateTimePicker checkInPicker;
        private Label label14;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel5;
        private Label bookRoom_roomPrice;
        private Label label;
        private Label bookRoom_roomStatus;
        private Label label10;
        private Label bookRoom_hotelID;
        private Label label8;
        private Label bookRoom_roomtype;
        private Label label5;
        private Button booking_clearbtn;
        private Button booking_printbtn;
        private Button booking_boohkbtn;
        private Button booking_schedulebtn;
        private TextBox txtSearch;
        private Panel panel7;
        private DataGridView dgvbooking;
        private Panel panel4;
        private DataGridView dgvBookingBackup;
        private Label label1;
    }
}