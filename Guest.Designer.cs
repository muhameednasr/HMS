namespace HMS
{
    partial class Guest
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblFirstName = new Label();
            btnAddGuest = new Button();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            lblLastName = new Label();
            lblDateOfBirth = new Label();
            label4 = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            dtpDateOfBirth = new DateTimePicker();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            btnUpdate = new Button();
            cmbRoom = new ComboBox();
            label1 = new Label();
            dgv = new DataGridView();
            panel1 = new Panel();
            panelInputs = new Panel();
            fnameInvalid = new Label();
            LnameInvalid = new Label();
            emailInvalid = new Label();
            phoneInvalid = new Label();
            panelButtons = new Panel();
            lblTitle = new Label();
            panelHeader = new Panel();
            btnClearSearch = new Button();
            txtSearch = new TextBox();
            GuestID = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            DateOfBirth = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Room = new DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            panel1.SuspendLayout();
            panelInputs.SuspendLayout();
            panelButtons.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFirstName.ForeColor = Color.FromArgb(55, 65, 81);
            lblFirstName.Location = new Point(10, 11);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(81, 19);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name";
            // 
            // btnAddGuest
            // 
            btnAddGuest.BackColor = Color.FromArgb(5, 20, 50);
            btnAddGuest.FlatAppearance.BorderSize = 0;
            btnAddGuest.FlatStyle = FlatStyle.Flat;
            btnAddGuest.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddGuest.ForeColor = Color.White;
            btnAddGuest.Location = new Point(13, 8);
            btnAddGuest.Margin = new Padding(3, 2, 3, 2);
            btnAddGuest.Name = "btnAddGuest";
            btnAddGuest.Size = new Size(92, 28);
            btnAddGuest.TabIndex = 3;
            btnAddGuest.Text = "Add";
            btnAddGuest.UseVisualStyleBackColor = false;
            btnAddGuest.Click += Add_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(5, 20, 50);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(152, 40);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(92, 25);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "🔄 Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(5, 20, 50);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(13, 70);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(231, 28);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(5, 20, 50);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(13, 40);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(92, 25);
            btnClear.TabIndex = 6;
            btnClear.Text = "✖ Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLastName.ForeColor = Color.FromArgb(55, 65, 81);
            lblLastName.Location = new Point(10, 75);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 19);
            lblLastName.TabIndex = 7;
            lblLastName.Text = "Last Name";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDateOfBirth.ForeColor = Color.FromArgb(55, 65, 81);
            lblDateOfBirth.Location = new Point(10, 139);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(94, 19);
            lblDateOfBirth.TabIndex = 8;
            lblDateOfBirth.Text = "Date of Birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(55, 65, 81);
            label4.Location = new Point(10, 191);
            label4.Name = "label4";
            label4.Size = new Size(63, 19);
            label4.TabIndex = 9;
            label4.Text = "Address";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(55, 65, 81);
            lblPhone.Location = new Point(10, 308);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(51, 19);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(55, 65, 81);
            lblEmail.Location = new Point(10, 244);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(45, 19);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpDateOfBirth.Font = new Font("Segoe UI", 9.75F);
            dtpDateOfBirth.Location = new Point(10, 158);
            dtpDateOfBirth.Margin = new Padding(3, 2, 3, 2);
            dtpDateOfBirth.MinDate = new DateTime(1929, 1, 1, 0, 0, 0, 0);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(239, 25);
            dtpDateOfBirth.TabIndex = 12;
            dtpDateOfBirth.Value = new DateTime(2025, 10, 13, 0, 0, 0, 0);
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFirstName.BackColor = Color.White;
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 10F);
            txtFirstName.Location = new Point(10, 31);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(239, 25);
            txtFirstName.TabIndex = 13;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.BackColor = Color.White;
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI", 10F);
            txtLastName.Location = new Point(10, 94);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(239, 25);
            txtLastName.TabIndex = 14;
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.BackColor = Color.White;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI", 10F);
            txtAddress.Location = new Point(10, 211);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(239, 25);
            txtAddress.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(10, 263);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(239, 25);
            txtEmail.TabIndex = 16;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.BackColor = Color.White;
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.Location = new Point(10, 327);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(239, 25);
            txtPhone.TabIndex = 17;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(5, 20, 50);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(152, 8);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 28);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cmbRoom
            // 
            cmbRoom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbRoom.BackColor = Color.White;
            cmbRoom.FlatStyle = FlatStyle.Flat;
            cmbRoom.Font = new Font("Segoe UI", 10F);
            cmbRoom.FormattingEnabled = true;
            cmbRoom.Location = new Point(10, 391);
            cmbRoom.Margin = new Padding(3, 2, 3, 2);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(239, 25);
            cmbRoom.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(55, 65, 81);
            label1.Location = new Point(10, 371);
            label1.Name = "label1";
            label1.Size = new Size(49, 19);
            label1.TabIndex = 21;
            label1.Text = "Room";
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv.ColumnHeadersHeight = 40;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.Columns.AddRange(new DataGridViewColumn[] { GuestID, FirstName, LastName, DateOfBirth, Address, Phone, Email, Room });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle2;
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = Color.FromArgb(229, 231, 235);
            dgv.Location = new Point(6, 57);
            dgv.Margin = new Padding(18, 8, 9, 15);
            dgv.Name = "dgv";
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 35;
            dgv.Size = new Size(969, 568);
            dgv.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(243, 244, 246);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panelInputs);
            panel1.Controls.Add(panelButtons);
            panel1.Location = new Point(976, 57);
            panel1.Margin = new Padding(9, 8, 18, 15);
            panel1.MinimumSize = new Size(219, 450);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 568);
            panel1.TabIndex = 23;
            panel1.Paint += panel1_Paint;
            // 
            // panelInputs
            // 
            panelInputs.AutoScroll = true;
            panelInputs.Controls.Add(lblFirstName);
            panelInputs.Controls.Add(txtFirstName);
            panelInputs.Controls.Add(fnameInvalid);
            panelInputs.Controls.Add(lblLastName);
            panelInputs.Controls.Add(txtLastName);
            panelInputs.Controls.Add(LnameInvalid);
            panelInputs.Controls.Add(lblDateOfBirth);
            panelInputs.Controls.Add(dtpDateOfBirth);
            panelInputs.Controls.Add(label4);
            panelInputs.Controls.Add(txtAddress);
            panelInputs.Controls.Add(lblEmail);
            panelInputs.Controls.Add(txtEmail);
            panelInputs.Controls.Add(emailInvalid);
            panelInputs.Controls.Add(lblPhone);
            panelInputs.Controls.Add(txtPhone);
            panelInputs.Controls.Add(phoneInvalid);
            panelInputs.Controls.Add(label1);
            panelInputs.Controls.Add(cmbRoom);
            panelInputs.Dock = DockStyle.Fill;
            panelInputs.Location = new Point(0, 0);
            panelInputs.Margin = new Padding(3, 2, 3, 2);
            panelInputs.Name = "panelInputs";
            panelInputs.Padding = new Padding(0, 0, 0, 112);
            panelInputs.Size = new Size(258, 464);
            panelInputs.TabIndex = 30;
            // 
            // fnameInvalid
            // 
            fnameInvalid.AutoSize = true;
            fnameInvalid.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            fnameInvalid.ForeColor = Color.FromArgb(239, 68, 68);
            fnameInvalid.Location = new Point(13, 57);
            fnameInvalid.Name = "fnameInvalid";
            fnameInvalid.Size = new Size(0, 13);
            fnameInvalid.TabIndex = 28;
            fnameInvalid.Visible = false;
            // 
            // LnameInvalid
            // 
            LnameInvalid.AutoSize = true;
            LnameInvalid.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            LnameInvalid.ForeColor = Color.FromArgb(239, 68, 68);
            LnameInvalid.Location = new Point(13, 121);
            LnameInvalid.Name = "LnameInvalid";
            LnameInvalid.Size = new Size(0, 13);
            LnameInvalid.TabIndex = 29;
            LnameInvalid.Visible = false;
            // 
            // emailInvalid
            // 
            emailInvalid.AutoSize = true;
            emailInvalid.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            emailInvalid.ForeColor = Color.FromArgb(239, 68, 68);
            emailInvalid.Location = new Point(13, 290);
            emailInvalid.Name = "emailInvalid";
            emailInvalid.Size = new Size(0, 13);
            emailInvalid.TabIndex = 26;
            emailInvalid.Visible = false;
            // 
            // phoneInvalid
            // 
            phoneInvalid.AutoSize = true;
            phoneInvalid.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            phoneInvalid.ForeColor = Color.FromArgb(239, 68, 68);
            phoneInvalid.Location = new Point(13, 353);
            phoneInvalid.Name = "phoneInvalid";
            phoneInvalid.Size = new Size(0, 13);
            phoneInvalid.TabIndex = 25;
            phoneInvalid.Visible = false;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(243, 244, 246);
            panelButtons.Controls.Add(btnAddGuest);
            panelButtons.Controls.Add(btnUpdate);
            panelButtons.Controls.Add(btnClear);
            panelButtons.Controls.Add(btnRefresh);
            panelButtons.Controls.Add(btnDelete);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 464);
            panelButtons.Margin = new Padding(3, 2, 3, 2);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(258, 102);
            panelButtons.TabIndex = 31;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(37, 99, 235);
            lblTitle.Location = new Point(18, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(180, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🏨 Guest Data";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(btnClearSearch);
            panelHeader.Controls.Add(txtSearch);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1241, 52);
            panelHeader.TabIndex = 24;
            // 
            // btnClearSearch
            // 
            btnClearSearch.BackColor = Color.FromArgb(5, 20, 50);
            btnClearSearch.FlatAppearance.BorderSize = 0;
            btnClearSearch.FlatStyle = FlatStyle.Flat;
            btnClearSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClearSearch.ForeColor = Color.White;
            btnClearSearch.Location = new Point(473, 18);
            btnClearSearch.Margin = new Padding(3, 2, 3, 2);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(32, 25);
            btnClearSearch.TabIndex = 7;
            btnClearSearch.Text = "✖";
            btnClearSearch.UseVisualStyleBackColor = false;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(217, 18);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by name, email, phone...";
            txtSearch.Size = new Size(246, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // GuestID
            // 
            GuestID.HeaderText = "Guest ID";
            GuestID.MinimumWidth = 85;
            GuestID.Name = "GuestID";
            GuestID.ReadOnly = true;
            GuestID.Width = 85;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "First Name";
            FirstName.MinimumWidth = 105;
            FirstName.Name = "FirstName";
            FirstName.Width = 105;
            // 
            // LastName
            // 
            LastName.HeaderText = "Last Name";
            LastName.MinimumWidth = 105;
            LastName.Name = "LastName";
            LastName.Width = 105;
            // 
            // DateOfBirth
            // 
            DateOfBirth.HeaderText = "Date of Birth";
            DateOfBirth.MinimumWidth = 125;
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.Width = 125;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 170;
            Address.Name = "Address";
            Address.Width = 170;
            // 
            // Phone
            // 
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 140;
            Phone.Name = "Phone";
            Phone.Width = 140;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 160;
            Email.Name = "Email";
            Email.Width = 160;
            // 
            // Room
            // 
            Room.HeaderText = "Room";
            Room.Name = "Room";
            // 
            // Guest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            ClientSize = new Size(1241, 632);
            Controls.Add(panelHeader);
            Controls.Add(dgv);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(553, 550);
            Name = "Guest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guest Management";
            Load += Guest_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            panel1.ResumeLayout(false);
            panelInputs.ResumeLayout(false);
            panelInputs.PerformLayout();
            panelButtons.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblFirstName;
        private Button btnAddGuest;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnClear;
        private Label lblLastName;
        private Label lblDateOfBirth;
        private Label label4;
        private Label lblPhone;
        private Label lblEmail;
        private DateTimePicker dtpDateOfBirth;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Button btnUpdate;
        private ComboBox cmbRoom;
        private Label label1;
        private DataGridView dgv;
        private Panel panel1;
        private Panel panelButtons;
        private Panel panelInputs;
        private Label phoneInvalid;
        private Label emailInvalid;
        private Label fnameInvalid;
        private Label LnameInvalid;
        private Label lblTitle;
        private Panel panelHeader;
        private TextBox txtSearch;
        private Button btnClearSearch;
        private DataGridViewTextBoxColumn GuestID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn DateOfBirth;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewComboBoxColumn Room;
    }
}