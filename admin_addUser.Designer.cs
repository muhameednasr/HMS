namespace HMS
{
    partial class admin_addUser
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel4 = new Panel();
            label7 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            addUser_staffID = new ComboBox();
            addUser_hotelID = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            addUser_clearbtn = new Button();
            addUser_deletebtn = new Button();
            addUser_updatebtn = new Button();
            addUser_addbtn = new Button();
            addUser_role = new ComboBox();
            addUser_password = new TextBox();
            addUser_username = new TextBox();
            label1 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel2 = new Panel();
            dgvUsers = new DataGridView();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(3, 14, 28);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1317, 49);
            panel4.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1288, 9);
            label7.Name = "label7";
            label7.Size = new Size(22, 23);
            label7.TabIndex = 13;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(578, 9);
            label5.Name = "label5";
            label5.Size = new Size(205, 32);
            label5.TabIndex = 12;
            label5.Text = "🏨User's Data";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(1317, 679);
            panel1.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(addUser_staffID);
            panel3.Controls.Add(addUser_hotelID);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(addUser_clearbtn);
            panel3.Controls.Add(addUser_deletebtn);
            panel3.Controls.Add(addUser_updatebtn);
            panel3.Controls.Add(addUser_addbtn);
            panel3.Controls.Add(addUser_role);
            panel3.Controls.Add(addUser_password);
            panel3.Controls.Add(addUser_username);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(374, 679);
            panel3.TabIndex = 17;
            // 
            // addUser_staffID
            // 
            addUser_staffID.FormattingEnabled = true;
            addUser_staffID.Location = new Point(33, 314);
            addUser_staffID.Name = "addUser_staffID";
            addUser_staffID.Size = new Size(263, 28);
            addUser_staffID.TabIndex = 14;
            // 
            // addUser_hotelID
            // 
            addUser_hotelID.FormattingEnabled = true;
            addUser_hotelID.Location = new Point(33, 237);
            addUser_hotelID.Name = "addUser_hotelID";
            addUser_hotelID.Size = new Size(263, 28);
            addUser_hotelID.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 277);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 12;
            label2.Text = "StaffID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 214);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 11;
            label3.Text = "Hotel ID";
            // 
            // addUser_clearbtn
            // 
            addUser_clearbtn.BackColor = Color.FromArgb(3, 14, 28);
            addUser_clearbtn.FlatAppearance.BorderSize = 0;
            addUser_clearbtn.FlatStyle = FlatStyle.Flat;
            addUser_clearbtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUser_clearbtn.ForeColor = Color.White;
            addUser_clearbtn.Location = new Point(13, 612);
            addUser_clearbtn.Name = "addUser_clearbtn";
            addUser_clearbtn.Size = new Size(280, 49);
            addUser_clearbtn.TabIndex = 10;
            addUser_clearbtn.Text = "Clear";
            addUser_clearbtn.UseVisualStyleBackColor = false;
            addUser_clearbtn.Click += addUser_clearbtn_Click;
            // 
            // addUser_deletebtn
            // 
            addUser_deletebtn.BackColor = Color.FromArgb(3, 14, 28);
            addUser_deletebtn.FlatAppearance.BorderSize = 0;
            addUser_deletebtn.FlatStyle = FlatStyle.Flat;
            addUser_deletebtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUser_deletebtn.ForeColor = Color.White;
            addUser_deletebtn.Location = new Point(13, 543);
            addUser_deletebtn.Name = "addUser_deletebtn";
            addUser_deletebtn.Size = new Size(280, 49);
            addUser_deletebtn.TabIndex = 9;
            addUser_deletebtn.Text = "Delete";
            addUser_deletebtn.UseVisualStyleBackColor = false;
            addUser_deletebtn.Click += addUser_deletebtn_Click;
            // 
            // addUser_updatebtn
            // 
            addUser_updatebtn.BackColor = Color.FromArgb(3, 14, 28);
            addUser_updatebtn.FlatAppearance.BorderSize = 0;
            addUser_updatebtn.FlatStyle = FlatStyle.Flat;
            addUser_updatebtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUser_updatebtn.ForeColor = Color.White;
            addUser_updatebtn.Location = new Point(13, 445);
            addUser_updatebtn.Name = "addUser_updatebtn";
            addUser_updatebtn.Size = new Size(280, 49);
            addUser_updatebtn.TabIndex = 8;
            addUser_updatebtn.Text = "Update";
            addUser_updatebtn.UseVisualStyleBackColor = false;
            addUser_updatebtn.Click += addUser_updatebtn_Click;
            // 
            // addUser_addbtn
            // 
            addUser_addbtn.BackColor = Color.FromArgb(3, 14, 28);
            addUser_addbtn.FlatAppearance.BorderSize = 0;
            addUser_addbtn.FlatStyle = FlatStyle.Flat;
            addUser_addbtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUser_addbtn.ForeColor = Color.White;
            addUser_addbtn.Location = new Point(13, 380);
            addUser_addbtn.Name = "addUser_addbtn";
            addUser_addbtn.Size = new Size(280, 49);
            addUser_addbtn.TabIndex = 7;
            addUser_addbtn.Text = "Add";
            addUser_addbtn.UseVisualStyleBackColor = false;
            addUser_addbtn.Click += addUser_addbtn_Click_1;
            // 
            // addUser_role
            // 
            addUser_role.FormattingEnabled = true;
            addUser_role.Items.AddRange(new object[] { "Admin", "Receptionist", "Staff" });
            addUser_role.Location = new Point(33, 183);
            addUser_role.Name = "addUser_role";
            addUser_role.Size = new Size(263, 28);
            addUser_role.TabIndex = 6;
            // 
            // addUser_password
            // 
            addUser_password.Location = new Point(33, 122);
            addUser_password.Name = "addUser_password";
            addUser_password.Size = new Size(263, 27);
            addUser_password.TabIndex = 5;
            // 
            // addUser_username
            // 
            addUser_username.Location = new Point(33, 43);
            addUser_username.Name = "addUser_username";
            addUser_username.Size = new Size(263, 27);
            addUser_username.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 152);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 2;
            label1.Text = "Role";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(30, 82);
            label10.Name = "label10";
            label10.Size = new Size(90, 20);
            label10.TabIndex = 1;
            label10.Text = "Password";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(27, 20);
            label11.Name = "label11";
            label11.Size = new Size(93, 20);
            label11.TabIndex = 0;
            label11.Text = "Username";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dgvUsers);
            panel2.Location = new Point(380, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(925, 559);
            panel2.TabIndex = 16;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(3, 14, 28);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.Location = new Point(28, 17);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvUsers.Size = new Size(879, 515);
            dgvUsers.TabIndex = 0;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            // 
            // admin_addUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 728);
            Controls.Add(panel1);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admin_addUser";
            Text = "admin_addUser";
            Load += admin_addUser_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel4;
        private Label label7;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvUsers;
        private Panel panel3;
        private Button addUser_clearbtn;
        private Button addUser_deletebtn;
        private Button addUser_updatebtn;
        private Button addUser_addbtn;
        private ComboBox addUser_role;
        private TextBox addUser_password;
        private TextBox addUser_username;
        private Label label1;
        private Label label10;
        private Label label11;
        private Label label2;
        private Label label3;
        private ComboBox addUser_staffID;
        private ComboBox addUser_hotelID;
    }
}