namespace HMS
{
    partial class Guest
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
            GuestID = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            DateOfBirth = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            room = new DataGridViewComboBoxColumn();
            panel1 = new Panel();
            LnameInvalid = new Label();
            fnameInvalid = new Label();
            emailInvalid = new Label();
            phoneInvalid = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(5, 1);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name";
            // 
            // btnAddGuest
            // 
            btnAddGuest.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddGuest.Location = new Point(10, 530);
            btnAddGuest.Margin = new Padding(3, 4, 3, 4);
            btnAddGuest.Name = "btnAddGuest";
            btnAddGuest.Size = new Size(76, 31);
            btnAddGuest.TabIndex = 3;
            btnAddGuest.Text = "Add";
            btnAddGuest.UseVisualStyleBackColor = true;
            btnAddGuest.Click += Add_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRefresh.Location = new Point(135, 568);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 31);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.Location = new Point(175, 530);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(74, 31);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClear.Location = new Point(56, 568);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(73, 31);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblLastName
            // 
            lblLastName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(5, 77);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 7;
            lblLastName.Text = "Last Name";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(5, 168);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(94, 20);
            lblDateOfBirth.TabIndex = 8;
            lblDateOfBirth.Text = "Date of Birth";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(9, 232);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 9;
            label4.Text = "Address";
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(9, 381);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(50, 20);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(9, 303);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDateOfBirth.Location = new Point(9, 191);
            dtpDateOfBirth.MinDate = new DateTime(1929, 1, 1, 0, 0, 0, 0);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(243, 27);
            dtpDateOfBirth.TabIndex = 12;
            dtpDateOfBirth.Value = new DateTime(2025, 10, 13, 0, 0, 0, 0);
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFirstName.Location = new Point(9, 24);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(243, 27);
            txtFirstName.TabIndex = 13;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtLastName.Location = new Point(9, 100);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(243, 27);
            txtLastName.TabIndex = 14;
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtAddress.Location = new Point(9, 255);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(243, 27);
            txtAddress.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtEmail.Location = new Point(1063, 338);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(239, 27);
            txtEmail.TabIndex = 16;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPhone.Location = new Point(1063, 416);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(239, 27);
            txtPhone.TabIndex = 17;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdate.Location = new Point(92, 530);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(77, 31);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cmbRoom
            // 
            cmbRoom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbRoom.FormattingEnabled = true;
            cmbRoom.Location = new Point(9, 488);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(239, 28);
            cmbRoom.TabIndex = 20;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(10, 465);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 21;
            label1.Text = "Room";
            // 
            // dgv
            // 
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { GuestID, FirstName, LastName, DateOfBirth, Address, Phone, Email, room });
            dgv.Location = new Point(3, 12);
            dgv.Margin = new Padding(3, 4, 3, 4);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(1050, 603);
            dgv.TabIndex = 22;
            // 
            // GuestID
            // 
            GuestID.HeaderText = "GuestID";
            GuestID.MinimumWidth = 6;
            GuestID.Name = "GuestID";
            GuestID.ReadOnly = true;
            GuestID.Width = 125;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "FirstName";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.Width = 125;
            // 
            // LastName
            // 
            LastName.HeaderText = "LastName";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            LastName.Width = 125;
            // 
            // DateOfBirth
            // 
            DateOfBirth.HeaderText = "DateOfBirth";
            DateOfBirth.MinimumWidth = 6;
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.Width = 125;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 125;
            // 
            // Phone
            // 
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // room
            // 
            room.HeaderText = "room";
            room.MinimumWidth = 6;
            room.Name = "room";
            room.Width = 125;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(LnameInvalid);
            panel1.Controls.Add(fnameInvalid);
            panel1.Controls.Add(emailInvalid);
            panel1.Controls.Add(cmbRoom);
            panel1.Controls.Add(phoneInvalid);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAddGuest);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(lblLastName);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(lblFirstName);
            panel1.Controls.Add(lblPhone);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dtpDateOfBirth);
            panel1.Controls.Add(lblDateOfBirth);
            panel1.Location = new Point(1054, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 603);
            panel1.TabIndex = 23;
            panel1.Paint += panel1_Paint;
            // 
            // LnameInvalid
            // 
            LnameInvalid.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LnameInvalid.AutoSize = true;
            LnameInvalid.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LnameInvalid.ForeColor = Color.Red;
            LnameInvalid.Location = new Point(55, 130);
            LnameInvalid.Name = "LnameInvalid";
            LnameInvalid.Size = new Size(0, 17);
            LnameInvalid.TabIndex = 29;
            LnameInvalid.Visible = false;
            // 
            // fnameInvalid
            // 
            fnameInvalid.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            fnameInvalid.AutoSize = true;
            fnameInvalid.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fnameInvalid.ForeColor = Color.Red;
            fnameInvalid.Location = new Point(55, 54);
            fnameInvalid.Name = "fnameInvalid";
            fnameInvalid.Size = new Size(0, 17);
            fnameInvalid.TabIndex = 28;
            fnameInvalid.TextAlign = ContentAlignment.TopCenter;
            fnameInvalid.Visible = false;
            // 
            // emailInvalid
            // 
            emailInvalid.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            emailInvalid.AutoSize = true;
            emailInvalid.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailInvalid.ForeColor = Color.Red;
            emailInvalid.Location = new Point(247, 356);
            emailInvalid.Name = "emailInvalid";
            emailInvalid.Size = new Size(0, 17);
            emailInvalid.TabIndex = 26;
            emailInvalid.Visible = false;
            // 
            // phoneInvalid
            // 
            phoneInvalid.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            phoneInvalid.AutoSize = true;
            phoneInvalid.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phoneInvalid.ForeColor = Color.Red;
            phoneInvalid.Location = new Point(14, 434);
            phoneInvalid.Name = "phoneInvalid";
            phoneInvalid.Size = new Size(0, 17);
            phoneInvalid.TabIndex = 25;
            phoneInvalid.Visible = false;
            // 
            // Guest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 629);
            Controls.Add(dgv);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(320, 676);
            Name = "Guest";
            Text = "Guest";
            Load += Guest_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnUpdate; // الزر الجديد
        private ComboBox cmbRoom;
        private Label label1;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn GuestID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn DateOfBirth;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewComboBoxColumn room;
        private Panel panel1;
        private Label phoneInvalid;
        private Label emailInvalid;
        private Label fnameInvalid;
        private Label LnameInvalid;
    }
}