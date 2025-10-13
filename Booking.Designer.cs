namespace HMS
{
    partial class Booking
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
            DeleteBookingbtn = new Button();
            UpdateBookingbtn = new Button();
            EditBookingbtn = new Button();
            label1 = new Label();
            TotalPricelbl = new Label();
            ConfirmBookingbtn = new Button();
            TotalPricebtn = new Button();
            dtpChickout = new DateTimePicker();
            dtpChickin = new DateTimePicker();
            Selectbtn = new Button();
            SelectedRoomtxt = new TextBox();
            SelectedGuesttxt = new TextBox();
            dgvBooking = new DataGridView();
            NameGuesttxt = new TextBox();
            dgvRoom = new DataGridView();
            RoomTypecmb = new ComboBox();
            dgvGuest = new DataGridView();
            Searchbtn = new Button();
            AddGuestbtn = new Button();
            SelectGuestID = new TextBox();
            txtNights = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvBooking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGuest).BeginInit();
            SuspendLayout();
            // 
            // DeleteBookingbtn
            // 
            DeleteBookingbtn.Location = new Point(931, 529);
            DeleteBookingbtn.Name = "DeleteBookingbtn";
            DeleteBookingbtn.Size = new Size(250, 35);
            DeleteBookingbtn.TabIndex = 34;
            DeleteBookingbtn.Text = "Delete Booking";
            DeleteBookingbtn.UseVisualStyleBackColor = true;
            DeleteBookingbtn.Click += DeleteBookingbtn_Click;
            // 
            // UpdateBookingbtn
            // 
            UpdateBookingbtn.Location = new Point(1087, 464);
            UpdateBookingbtn.Name = "UpdateBookingbtn";
            UpdateBookingbtn.Size = new Size(215, 35);
            UpdateBookingbtn.TabIndex = 33;
            UpdateBookingbtn.Text = "Update Booking";
            UpdateBookingbtn.UseVisualStyleBackColor = true;
            UpdateBookingbtn.Click += UpdateBookingbtn_Click;
            // 
            // EditBookingbtn
            // 
            EditBookingbtn.Location = new Point(810, 464);
            EditBookingbtn.Name = "EditBookingbtn";
            EditBookingbtn.Size = new Size(215, 33);
            EditBookingbtn.TabIndex = 32;
            EditBookingbtn.Text = "Edit Booking";
            EditBookingbtn.UseVisualStyleBackColor = true;
            EditBookingbtn.Click += EditBookingbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1016, 6);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 31;
            label1.Text = "ALL Booking";
            // 
            // TotalPricelbl
            // 
            TotalPricelbl.AutoSize = true;
            TotalPricelbl.Location = new Point(676, 648);
            TotalPricelbl.Name = "TotalPricelbl";
            TotalPricelbl.Size = new Size(78, 20);
            TotalPricelbl.TabIndex = 30;
            TotalPricelbl.Text = "Total Price";
            // 
            // ConfirmBookingbtn
            // 
            ConfirmBookingbtn.Location = new Point(858, 609);
            ConfirmBookingbtn.Name = "ConfirmBookingbtn";
            ConfirmBookingbtn.Size = new Size(286, 35);
            ConfirmBookingbtn.TabIndex = 29;
            ConfirmBookingbtn.Text = "Confirm Booking";
            ConfirmBookingbtn.UseVisualStyleBackColor = true;
            ConfirmBookingbtn.Click += ConfirmBookingbtn_Click;
            // 
            // TotalPricebtn
            // 
            TotalPricebtn.Location = new Point(345, 641);
            TotalPricebtn.Name = "TotalPricebtn";
            TotalPricebtn.Size = new Size(286, 35);
            TotalPricebtn.TabIndex = 28;
            TotalPricebtn.Text = "Total Price";
            TotalPricebtn.UseVisualStyleBackColor = true;
            TotalPricebtn.Click += TotalPricebtn_Click;
            // 
            // dtpChickout
            // 
            dtpChickout.Location = new Point(333, 529);
            dtpChickout.Name = "dtpChickout";
            dtpChickout.Size = new Size(268, 27);
            dtpChickout.TabIndex = 27;
            dtpChickout.ValueChanged += dtpChickout_ValueChanged;
            // 
            // dtpChickin
            // 
            dtpChickin.Location = new Point(333, 472);
            dtpChickin.Name = "dtpChickin";
            dtpChickin.Size = new Size(268, 27);
            dtpChickin.TabIndex = 26;
            dtpChickin.ValueChanged += dtpChickin_ValueChanged;
            // 
            // Selectbtn
            // 
            Selectbtn.Location = new Point(333, 358);
            Selectbtn.Name = "Selectbtn";
            Selectbtn.Size = new Size(224, 35);
            Selectbtn.TabIndex = 25;
            Selectbtn.Text = "Select";
            Selectbtn.UseVisualStyleBackColor = true;
            Selectbtn.Click += Selectbtn_Click;
            // 
            // SelectedRoomtxt
            // 
            SelectedRoomtxt.Location = new Point(333, 429);
            SelectedRoomtxt.Name = "SelectedRoomtxt";
            SelectedRoomtxt.ReadOnly = true;
            SelectedRoomtxt.Size = new Size(224, 27);
            SelectedRoomtxt.TabIndex = 24;
            // 
            // SelectedGuesttxt
            // 
            SelectedGuesttxt.Location = new Point(330, 232);
            SelectedGuesttxt.Name = "SelectedGuesttxt";
            SelectedGuesttxt.ReadOnly = true;
            SelectedGuesttxt.Size = new Size(224, 27);
            SelectedGuesttxt.TabIndex = 23;
            // 
            // dgvBooking
            // 
            dgvBooking.AllowUserToAddRows = false;
            dgvBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooking.Location = new Point(667, 29);
            dgvBooking.Name = "dgvBooking";
            dgvBooking.RowHeadersWidth = 51;
            dgvBooking.Size = new Size(635, 427);
            dgvBooking.TabIndex = 22;
            dgvBooking.CellContentClick += dgvBooking_CellContentClick;
            // 
            // NameGuesttxt
            // 
            NameGuesttxt.Location = new Point(12, 29);
            NameGuesttxt.Name = "NameGuesttxt";
            NameGuesttxt.Size = new Size(369, 27);
            NameGuesttxt.TabIndex = 21;
            // 
            // dgvRoom
            // 
            dgvRoom.ColumnHeadersHeight = 29;
            dgvRoom.Location = new Point(12, 414);
            dgvRoom.Name = "dgvRoom";
            dgvRoom.RowHeadersWidth = 51;
            dgvRoom.Size = new Size(312, 230);
            dgvRoom.TabIndex = 35;
            dgvRoom.CellContentClick += dgvRoom_CellContentClick;
            // 
            // RoomTypecmb
            // 
            RoomTypecmb.FormattingEnabled = true;
            RoomTypecmb.Items.AddRange(new object[] { "Single", "Double", "Suite", "ALL" });
            RoomTypecmb.Location = new Point(12, 358);
            RoomTypecmb.Name = "RoomTypecmb";
            RoomTypecmb.Size = new Size(300, 28);
            RoomTypecmb.TabIndex = 20;
            RoomTypecmb.SelectedIndexChanged += Room_Num_SelectedIndexChanged;
            // 
            // dgvGuest
            // 
            dgvGuest.AllowUserToAddRows = false;
            dgvGuest.ColumnHeadersHeight = 29;
            dgvGuest.Location = new Point(15, 80);
            dgvGuest.Name = "dgvGuest";
            dgvGuest.RowHeadersWidth = 51;
            dgvGuest.Size = new Size(312, 272);
            dgvGuest.TabIndex = 36;
            dgvGuest.CellContentClick += dgvGuest_CellContentClick;
            // 
            // Searchbtn
            // 
            Searchbtn.Location = new Point(330, 83);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new Size(227, 35);
            Searchbtn.TabIndex = 37;
            Searchbtn.Text = "Search";
            Searchbtn.UseVisualStyleBackColor = true;
            Searchbtn.Click += Searchbtn_Click;
            // 
            // AddGuestbtn
            // 
            AddGuestbtn.Location = new Point(330, 146);
            AddGuestbtn.Name = "AddGuestbtn";
            AddGuestbtn.RightToLeft = RightToLeft.Yes;
            AddGuestbtn.Size = new Size(227, 35);
            AddGuestbtn.TabIndex = 38;
            AddGuestbtn.Text = "Add New Guest";
            AddGuestbtn.UseVisualStyleBackColor = true;
            AddGuestbtn.Click += AddGuestbtn_Click;
            // 
            // SelectGuestID
            // 
            SelectGuestID.Location = new Point(333, 275);
            SelectGuestID.Name = "SelectGuestID";
            SelectGuestID.ReadOnly = true;
            SelectGuestID.Size = new Size(224, 27);
            SelectGuestID.TabIndex = 39;
            // 
            // txtNights
            // 
            txtNights.Location = new Point(333, 581);
            txtNights.Name = "txtNights";
            txtNights.ReadOnly = true;
            txtNights.Size = new Size(224, 27);
            txtNights.TabIndex = 40;
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1316, 688);
            Controls.Add(txtNights);
            Controls.Add(SelectGuestID);
            Controls.Add(AddGuestbtn);
            Controls.Add(Searchbtn);
            Controls.Add(dgvGuest);
            Controls.Add(DeleteBookingbtn);
            Controls.Add(UpdateBookingbtn);
            Controls.Add(EditBookingbtn);
            Controls.Add(label1);
            Controls.Add(TotalPricelbl);
            Controls.Add(ConfirmBookingbtn);
            Controls.Add(TotalPricebtn);
            Controls.Add(dtpChickout);
            Controls.Add(dtpChickin);
            Controls.Add(Selectbtn);
            Controls.Add(SelectedRoomtxt);
            Controls.Add(SelectedGuesttxt);
            Controls.Add(dgvBooking);
            Controls.Add(NameGuesttxt);
            Controls.Add(dgvRoom);
            Controls.Add(RoomTypecmb);
            Name = "Booking";
            Text = "Booking";
            Load += Booking_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooking).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGuest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteBookingbtn;
        private Button UpdateBookingbtn;
        private Button EditBookingbtn;
        private Label label1;
        private Label TotalPricelbl;
        private Button ConfirmBookingbtn;
        private Button TotalPricebtn;
        private DateTimePicker dtpChickout;
        private DateTimePicker dtpChickin;
        private Button Selectbtn;
        private TextBox SelectedRoomtxt;
        private TextBox SelectedGuesttxt;
        private DataGridView dgvBooking;
        private TextBox NameGuesttxt;
        private DataGridView dgvRoom;
        private ComboBox RoomTypecmb;
        private DataGridView dgvGuest;
        private Button Searchbtn;
        private Button AddGuestbtn;
        private TextBox SelectGuestID;
        private TextBox txtNights;
    }
}