namespace HMS
{
    partial class staff
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            comboPosition = new ComboBox();
            dgvStaff = new DataGridView();
            StaffID = new DataGridViewTextBoxColumn();
            HotelID = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            Salary = new DataGridViewTextBoxColumn();
            DateOfBirth = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            HireDate = new DataGridViewTextBoxColumn();
            btnReload = new Button();
            comboBoxHotel = new ComboBox();
            btnClear = new Button();
            dtpHireDate = new DateTimePicker();
            btnDelete = new Button();
            dtpBirth = new DateTimePicker();
            btnAdd = new Button();
            lblHotel = new Label();
            lblHire = new Label();
            lblBirth = new Label();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtSalary = new TextBox();
            txtLastName = new TextBox();
            lblEmail = new Label();
            lblPhone = new Label();
            lblSalary = new Label();
            lblPosition = new Label();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(274, 9);
            label1.Name = "label1";
            label1.Size = new Size(231, 30);
            label1.TabIndex = 0;
            label1.Text = "🏨 Staff Management";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboPosition);
            groupBox1.Controls.Add(dgvStaff);
            groupBox1.Controls.Add(btnReload);
            groupBox1.Controls.Add(comboBoxHotel);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(dtpHireDate);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(dtpBirth);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(lblHotel);
            groupBox1.Controls.Add(lblHire);
            groupBox1.Controls.Add(lblBirth);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtSalary);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(lblPhone);
            groupBox1.Controls.Add(lblSalary);
            groupBox1.Controls.Add(lblPosition);
            groupBox1.Controls.Add(lblLastName);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(lblFirstName);
            groupBox1.Location = new Point(33, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(914, 444);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Staff Info";
            // 
            // comboPosition
            // 
            comboPosition.FormattingEnabled = true;
            comboPosition.Location = new Point(285, 14);
            comboPosition.Name = "comboPosition";
            comboPosition.Size = new Size(121, 23);
            comboPosition.TabIndex = 21;
            // 
            // dgvStaff
            // 
            dgvStaff.AllowUserToAddRows = false;
            dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStaff.BackgroundColor = SystemColors.ButtonHighlight;
            dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaff.Columns.AddRange(new DataGridViewColumn[] { StaffID, HotelID, FirstName, LastName, Position, Salary, DateOfBirth, Phone, Email, HireDate });
            dgvStaff.Location = new Point(6, 288);
            dgvStaff.Name = "dgvStaff";
            dgvStaff.RowHeadersWidth = 51;
            dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaff.Size = new Size(902, 150);
            dgvStaff.TabIndex = 2;
            // 
            // StaffID
            // 
            StaffID.HeaderText = "Staff ID";
            StaffID.MinimumWidth = 6;
            StaffID.Name = "StaffID";
            // 
            // HotelID
            // 
            HotelID.HeaderText = "Hotel ID";
            HotelID.MinimumWidth = 6;
            HotelID.Name = "HotelID";
            // 
            // FirstName
            // 
            FirstName.HeaderText = "First Name";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            LastName.HeaderText = "Last Name";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            // 
            // Position
            // 
            Position.HeaderText = "Position";
            Position.MinimumWidth = 6;
            Position.Name = "Position";
            // 
            // Salary
            // 
            Salary.HeaderText = "Salary";
            Salary.MinimumWidth = 6;
            Salary.Name = "Salary";
            // 
            // DateOfBirth
            // 
            DateOfBirth.HeaderText = "Birth Date";
            DateOfBirth.MinimumWidth = 6;
            DateOfBirth.Name = "DateOfBirth";
            // 
            // Phone
            // 
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            // 
            // HireDate
            // 
            HireDate.HeaderText = "Hire Date";
            HireDate.MinimumWidth = 6;
            HireDate.Name = "HireDate";
            // 
            // btnReload
            // 
            btnReload.ForeColor = Color.FromArgb(0, 0, 192);
            btnReload.Location = new Point(297, 249);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(109, 23);
            btnReload.TabIndex = 6;
            btnReload.Text = "🔄 Reload";
            btnReload.UseVisualStyleBackColor = true;
            // 
            // comboBoxHotel
            // 
            comboBoxHotel.FormattingEnabled = true;
            comboBoxHotel.Location = new Point(77, 218);
            comboBoxHotel.Name = "comboBoxHotel";
            comboBoxHotel.Size = new Size(121, 23);
            comboBoxHotel.TabIndex = 20;
            // 
            // btnClear
            // 
            btnClear.ForeColor = Color.Gray;
            btnClear.Location = new Point(216, 249);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "✨ Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(77, 184);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(232, 23);
            dtpHireDate.TabIndex = 19;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(113, 249);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(97, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "🗑 Delete Staff";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dtpBirth
            // 
            dtpBirth.Location = new Point(77, 150);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(230, 23);
            dtpBirth.TabIndex = 18;
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = Color.Green;
            btnAdd.Location = new Point(0, 249);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "➕ Add Staff";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblHotel
            // 
            lblHotel.AutoSize = true;
            lblHotel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblHotel.Location = new Point(10, 222);
            lblHotel.Name = "lblHotel";
            lblHotel.Size = new Size(39, 15);
            lblHotel.TabIndex = 14;
            lblHotel.Text = "Hotel:";
            // 
            // lblHire
            // 
            lblHire.AutoSize = true;
            lblHire.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblHire.Location = new Point(6, 188);
            lblHire.Name = "lblHire";
            lblHire.Size = new Size(57, 15);
            lblHire.TabIndex = 13;
            lblHire.Text = "Hire Date";
            // 
            // lblBirth
            // 
            lblBirth.AutoSize = true;
            lblBirth.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblBirth.Location = new Point(6, 154);
            lblBirth.Name = "lblBirth";
            lblBirth.Size = new Size(60, 15);
            lblBirth.TabIndex = 12;
            lblBirth.Text = "Birth Date";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(77, 116);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 11;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(285, 43);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 10;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(77, 82);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(100, 23);
            txtSalary.TabIndex = 9;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(77, 48);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(6, 120);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPhone.Location = new Point(215, 45);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Phone";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSalary.Location = new Point(10, 86);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(39, 15);
            lblSalary.TabIndex = 4;
            lblSalary.Text = "Salary";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPosition.Location = new Point(216, 14);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(50, 15);
            lblPosition.TabIndex = 3;
            lblPosition.Text = "Position";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblLastName.Location = new Point(6, 52);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(77, 14);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblFirstName.Location = new Point(6, 18);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // staff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 520);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(987, 559);
            MinimizeBox = false;
            MinimumSize = new Size(987, 559);
            Name = "staff";
            Text = "       staff management   ";
            Load += staff_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtSalary;
        private TextBox txtLastName;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblSalary;
        private Label lblPosition;
        private Label lblLastName;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblHotel;
        private Label lblHire;
        private Label lblBirth;
        private DateTimePicker dtpBirth;
        private DateTimePicker dtpHireDate;
        private ComboBox comboBoxHotel;
        private DataGridView dgvStaff;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnClear;
        private Button btnReload;
        private DataGridViewTextBoxColumn StaffID;
        private DataGridViewTextBoxColumn HotelID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn Salary;
        private DataGridViewTextBoxColumn DateOfBirth;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn HireDate;
        private ComboBox comboPosition;
    }
}