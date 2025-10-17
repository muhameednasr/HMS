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
            txtPosition = new TextBox();
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
            label1.Location = new Point(313, 12);
            label1.Name = "label1";
            label1.Size = new Size(300, 37);
            label1.TabIndex = 0;
            label1.Text = "🏨 Staff Management";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
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
            groupBox1.Controls.Add(txtPosition);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(lblPhone);
            groupBox1.Controls.Add(lblSalary);
            groupBox1.Controls.Add(lblPosition);
            groupBox1.Controls.Add(lblLastName);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(lblFirstName);
            groupBox1.Location = new Point(38, 59);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1045, 592);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Staff Info";
            // 
            // dgvStaff
            // 
            dgvStaff.AllowUserToAddRows = false;
            dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStaff.BackgroundColor = SystemColors.ButtonHighlight;
            dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaff.Columns.AddRange(new DataGridViewColumn[] { StaffID, HotelID, FirstName, LastName, Position, Salary, DateOfBirth, Phone, Email, HireDate });
            dgvStaff.Location = new Point(7, 384);
            dgvStaff.Margin = new Padding(3, 4, 3, 4);
            dgvStaff.Name = "dgvStaff";
            dgvStaff.RowHeadersWidth = 51;
            dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaff.Size = new Size(1031, 200);
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
            btnReload.Location = new Point(339, 332);
            btnReload.Margin = new Padding(3, 4, 3, 4);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(125, 31);
            btnReload.TabIndex = 6;
            btnReload.Text = "🔄 Reload";
            btnReload.UseVisualStyleBackColor = true;
            // 
            // comboBoxHotel
            // 
            comboBoxHotel.FormattingEnabled = true;
            comboBoxHotel.Location = new Point(88, 293);
            comboBoxHotel.Margin = new Padding(3, 4, 3, 4);
            comboBoxHotel.Name = "comboBoxHotel";
            comboBoxHotel.Size = new Size(138, 28);
            comboBoxHotel.TabIndex = 20;
            // 
            // btnClear
            // 
            btnClear.ForeColor = Color.Gray;
            btnClear.Location = new Point(247, 332);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 31);
            btnClear.TabIndex = 5;
            btnClear.Text = "✨ Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(88, 254);
            dtpHireDate.Margin = new Padding(3, 4, 3, 4);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(264, 27);
            dtpHireDate.TabIndex = 19;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(129, 332);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 31);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "🗑 Delete Staff";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dtpBirth
            // 
            dtpBirth.Location = new Point(88, 216);
            dtpBirth.Margin = new Padding(3, 4, 3, 4);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(262, 27);
            dtpBirth.TabIndex = 18;
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = Color.Green;
            btnAdd.Location = new Point(0, 332);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(122, 31);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "➕ Add Staff";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblHotel
            // 
            lblHotel.AutoSize = true;
            lblHotel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblHotel.Location = new Point(11, 297);
            lblHotel.Name = "lblHotel";
            lblHotel.Size = new Size(50, 20);
            lblHotel.TabIndex = 14;
            lblHotel.Text = "Hotel:";
            // 
            // lblHire
            // 
            lblHire.AutoSize = true;
            lblHire.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblHire.Location = new Point(7, 261);
            lblHire.Name = "lblHire";
            lblHire.Size = new Size(74, 20);
            lblHire.TabIndex = 13;
            lblHire.Text = "Hire Date";
            // 
            // lblBirth
            // 
            lblBirth.AutoSize = true;
            lblBirth.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblBirth.Location = new Point(7, 221);
            lblBirth.Name = "lblBirth";
            lblBirth.Size = new Size(78, 20);
            lblBirth.TabIndex = 12;
            lblBirth.Text = "Birth Date";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(87, 180);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(114, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(87, 154);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(114, 27);
            txtPhone.TabIndex = 10;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(87, 117);
            txtSalary.Margin = new Padding(3, 4, 3, 4);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(114, 27);
            txtSalary.TabIndex = 9;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(87, 91);
            txtPosition.Margin = new Padding(3, 4, 3, 4);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(114, 27);
            txtPosition.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(87, 52);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(114, 27);
            txtLastName.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(7, 183);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPhone.Location = new Point(7, 157);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(53, 20);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Phone";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSalary.Location = new Point(11, 120);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(52, 20);
            lblSalary.TabIndex = 4;
            lblSalary.Text = "Salary";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPosition.Location = new Point(7, 93);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(63, 20);
            lblPosition.TabIndex = 3;
            lblPosition.Text = "Position";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblLastName.Location = new Point(7, 55);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(80, 20);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(87, 19);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(114, 27);
            txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblFirstName.Location = new Point(7, 24);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(83, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 685);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(1126, 732);
            MinimizeBox = false;
            MinimumSize = new Size(1126, 732);
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
        private TextBox txtPosition;
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
    }
}