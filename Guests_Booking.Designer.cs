namespace HMS
{
    partial class Guests_Booking
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
            panel2 = new Panel();
            panel1 = new Panel();
            panel4 = new Panel();
            dgvGuests = new DataGridView();
            panel3 = new Panel();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel5 = new Panel();
            booking_guestName = new Label();
            label12 = new Label();
            txtPricePerNight = new Label();
            label9 = new Label();
            txtDays = new Label();
            label6 = new Label();
            label3 = new Label();
            checkOutPicker = new DateTimePicker();
            checkInPicker = new DateTimePicker();
            label14 = new Label();
            bookRoom_roomPrice = new Label();
            label = new Label();
            bookRoom_roomStatus = new Label();
            label10 = new Label();
            bookRoom_hotelID = new Label();
            label8 = new Label();
            bookRoom_roomtype = new Label();
            label5 = new Label();
            bookRoom_roomID = new Label();
            label1 = new Label();
            booking_clearbtn = new Button();
            booking_printbtn = new Button();
            booking_boohkbtn = new Button();
            booking_schedulebtn = new Button();
            panel6 = new Panel();
            label7 = new Label();
            label4 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuests).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(panel6);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1419, 752);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(1419, 710);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvGuests);
            panel4.Location = new Point(14, 341);
            panel4.Name = "panel4";
            panel4.Size = new Size(867, 310);
            panel4.TabIndex = 24;
            // 
            // dgvGuests
            // 
            dgvGuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGuests.Location = new Point(37, 16);
            dgvGuests.Name = "dgvGuests";
            dgvGuests.RowHeadersWidth = 51;
            dgvGuests.Size = new Size(773, 277);
            dgvGuests.TabIndex = 1;
            dgvGuests.CellContentClick += dgvGuests_CellContentClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(dataGridView1);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(14, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(867, 329);
            panel3.TabIndex = 6;
            panel3.Paint += panel3_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(3, 14, 28);
            label2.Location = new Point(24, 14);
            label2.Name = "label2";
            label2.Size = new Size(171, 23);
            label2.TabIndex = 14;
            label2.Text = "Available Rooms";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(773, 250);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(booking_guestName);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(txtPricePerNight);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(txtDays);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(checkOutPicker);
            panel5.Controls.Add(checkInPicker);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(bookRoom_roomPrice);
            panel5.Controls.Add(label);
            panel5.Controls.Add(bookRoom_roomStatus);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(bookRoom_hotelID);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(bookRoom_roomtype);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(bookRoom_roomID);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(booking_clearbtn);
            panel5.Controls.Add(booking_printbtn);
            panel5.Controls.Add(booking_boohkbtn);
            panel5.Controls.Add(booking_schedulebtn);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(913, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(506, 710);
            panel5.TabIndex = 3;
            panel5.Paint += panel5_Paint;
            // 
            // booking_guestName
            // 
            booking_guestName.AutoSize = true;
            booking_guestName.Location = new Point(135, 231);
            booking_guestName.Name = "booking_guestName";
            booking_guestName.Size = new Size(99, 20);
            booking_guestName.TabIndex = 24;
            booking_guestName.Text = "_______________";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 9F);
            label12.Location = new Point(11, 233);
            label12.Name = "label12";
            label12.Size = new Size(102, 17);
            label12.TabIndex = 23;
            label12.Text = "Guest Name:";
            // 
            // txtPricePerNight
            // 
            txtPricePerNight.AutoSize = true;
            txtPricePerNight.Font = new Font("Arial Rounded MT Bold", 9F);
            txtPricePerNight.Location = new Point(153, 436);
            txtPricePerNight.Name = "txtPricePerNight";
            txtPricePerNight.Size = new Size(31, 17);
            txtPricePerNight.TabIndex = 22;
            txtPricePerNight.Text = "0.0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 9F);
            label9.Location = new Point(5, 460);
            label9.Name = "label9";
            label9.Size = new Size(111, 17);
            label9.TabIndex = 21;
            label9.Text = "Total Price($):";
            // 
            // txtDays
            // 
            txtDays.AutoSize = true;
            txtDays.Location = new Point(135, 401);
            txtDays.Name = "txtDays";
            txtDays.Size = new Size(99, 20);
            txtDays.TabIndex = 20;
            txtDays.Text = "_______________";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9F);
            label6.Location = new Point(24, 401);
            label6.Name = "label6";
            label6.Size = new Size(89, 17);
            label6.TabIndex = 19;
            label6.Text = "Total Days:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F);
            label3.Location = new Point(27, 351);
            label3.Name = "label3";
            label3.Size = new Size(86, 17);
            label3.TabIndex = 18;
            label3.Text = "CheckOut:";
            // 
            // checkOutPicker
            // 
            checkOutPicker.Location = new Point(135, 344);
            checkOutPicker.Name = "checkOutPicker";
            checkOutPicker.Size = new Size(250, 27);
            checkOutPicker.TabIndex = 17;
            checkOutPicker.ValueChanged += checkOutPicker_ValueChanged;
            // 
            // checkInPicker
            // 
            checkInPicker.Location = new Point(135, 281);
            checkInPicker.Name = "checkInPicker";
            checkInPicker.Size = new Size(250, 27);
            checkInPicker.TabIndex = 16;
            checkInPicker.ValueChanged += checkInPicker_ValueChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Rounded MT Bold", 9F);
            label14.Location = new Point(39, 288);
            label14.Name = "label14";
            label14.Size = new Size(74, 17);
            label14.TabIndex = 14;
            label14.Text = "CheckIn:";
            // 
            // bookRoom_roomPrice
            // 
            bookRoom_roomPrice.AutoSize = true;
            bookRoom_roomPrice.Font = new Font("Arial Rounded MT Bold", 9F);
            bookRoom_roomPrice.Location = new Point(153, 460);
            bookRoom_roomPrice.Name = "bookRoom_roomPrice";
            bookRoom_roomPrice.Size = new Size(31, 17);
            bookRoom_roomPrice.TabIndex = 13;
            bookRoom_roomPrice.Text = "0.0";
            bookRoom_roomPrice.Click += bookRoom_roomPrice_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Arial Rounded MT Bold", 9F);
            label.Location = new Point(5, 436);
            label.Name = "label";
            label.Size = new Size(111, 17);
            label.TabIndex = 12;
            label.Text = "Total Price($):";
            // 
            // bookRoom_roomStatus
            // 
            bookRoom_roomStatus.AutoSize = true;
            bookRoom_roomStatus.Location = new Point(135, 172);
            bookRoom_roomStatus.Name = "bookRoom_roomStatus";
            bookRoom_roomStatus.Size = new Size(99, 20);
            bookRoom_roomStatus.TabIndex = 11;
            bookRoom_roomStatus.Text = "_______________";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 9F);
            label10.Location = new Point(8, 172);
            label10.Name = "label10";
            label10.Size = new Size(105, 17);
            label10.TabIndex = 10;
            label10.Text = "Room Status:";
            // 
            // bookRoom_hotelID
            // 
            bookRoom_hotelID.AutoSize = true;
            bookRoom_hotelID.Location = new Point(135, 128);
            bookRoom_hotelID.Name = "bookRoom_hotelID";
            bookRoom_hotelID.Size = new Size(99, 20);
            bookRoom_hotelID.TabIndex = 9;
            bookRoom_hotelID.Text = "_______________";
            bookRoom_hotelID.Click += label6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 9F);
            label8.Location = new Point(42, 128);
            label8.Name = "label8";
            label8.Size = new Size(71, 17);
            label8.TabIndex = 8;
            label8.Text = "Hotel ID:";
            // 
            // bookRoom_roomtype
            // 
            bookRoom_roomtype.AutoSize = true;
            bookRoom_roomtype.Location = new Point(135, 79);
            bookRoom_roomtype.Name = "bookRoom_roomtype";
            bookRoom_roomtype.Size = new Size(99, 20);
            bookRoom_roomtype.TabIndex = 7;
            bookRoom_roomtype.Text = "_______________";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F);
            label5.Location = new Point(22, 81);
            label5.Name = "label5";
            label5.Size = new Size(94, 17);
            label5.TabIndex = 6;
            label5.Text = "Room Type:";
            // 
            // bookRoom_roomID
            // 
            bookRoom_roomID.AutoSize = true;
            bookRoom_roomID.Location = new Point(135, 25);
            bookRoom_roomID.Name = "bookRoom_roomID";
            bookRoom_roomID.Size = new Size(99, 20);
            bookRoom_roomID.TabIndex = 5;
            bookRoom_roomID.Text = "_______________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F);
            label1.Location = new Point(38, 25);
            label1.Name = "label1";
            label1.Size = new Size(75, 17);
            label1.TabIndex = 4;
            label1.Text = "Room ID:";
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
            booking_clearbtn.Location = new Point(267, 497);
            booking_clearbtn.Name = "booking_clearbtn";
            booking_clearbtn.Size = new Size(227, 45);
            booking_clearbtn.TabIndex = 3;
            booking_clearbtn.Text = "Clear";
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
            booking_printbtn.Location = new Point(267, 578);
            booking_printbtn.Name = "booking_printbtn";
            booking_printbtn.Size = new Size(227, 45);
            booking_printbtn.TabIndex = 2;
            booking_printbtn.Text = "Print";
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
            booking_boohkbtn.Location = new Point(34, 578);
            booking_boohkbtn.Name = "booking_boohkbtn";
            booking_boohkbtn.Size = new Size(227, 45);
            booking_boohkbtn.TabIndex = 1;
            booking_boohkbtn.Text = "Book";
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
            booking_schedulebtn.Location = new Point(34, 497);
            booking_schedulebtn.Name = "booking_schedulebtn";
            booking_schedulebtn.Size = new Size(227, 45);
            booking_schedulebtn.TabIndex = 0;
            booking_schedulebtn.Text = "Schedule Now";
            booking_schedulebtn.UseVisualStyleBackColor = false;
            booking_schedulebtn.Click += booking_shedulebtn_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(3, 14, 28);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(label4);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1419, 42);
            panel6.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1375, 10);
            label7.Name = "label7";
            label7.Size = new Size(22, 23);
            label7.TabIndex = 13;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(557, 10);
            label4.Name = "label4";
            label4.Size = new Size(140, 23);
            label4.TabIndex = 12;
            label4.Text = "Booking Data";
            // 
            // Guests_Booking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 752);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Guests_Booking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guests_Booking";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGuests).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel1;
        private Panel panel4;
        private DataGridView dgvGuests;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Panel panel5;
        private Button booking_clearbtn;
        private Button booking_printbtn;
        private Button booking_boohkbtn;
        private Button booking_schedulebtn;
        private Panel panel6;
        private Label label7;
        private Label label4;
        private Label label14;
        private Label bookRoom_roomPrice;
        private Label label;
        private Label bookRoom_roomStatus;
        private Label label10;
        private Label bookRoom_hotelID;
        private Label label8;
        private Label bookRoom_roomtype;
        private Label label5;
        private Label bookRoom_roomID;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker checkOutPicker;
        private DateTimePicker checkInPicker;
        private Label txtDays;
        private Label label6;
        private Label label9;
        private Label txtPricePerNight;
        private Label booking_guestName;
        private Label label12;
    }
}