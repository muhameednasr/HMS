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
            panel1 = new Panel();
            addUser_clearbtn = new Button();
            addUser_deletebtn = new Button();
            addUser_updatebtn = new Button();
            addUser_addbtn = new Button();
            addUser_role = new ComboBox();
            addUser_password = new TextBox();
            addUser_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            dgvUsers = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(addUser_clearbtn);
            panel1.Controls.Add(addUser_deletebtn);
            panel1.Controls.Add(addUser_updatebtn);
            panel1.Controls.Add(addUser_addbtn);
            panel1.Controls.Add(addUser_role);
            panel1.Controls.Add(addUser_password);
            panel1.Controls.Add(addUser_username);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(18, 17);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 510);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // addUser_clearbtn
            // 
            addUser_clearbtn.BackColor = Color.FromArgb(3, 14, 28);
            addUser_clearbtn.FlatAppearance.BorderSize = 0;
            addUser_clearbtn.FlatStyle = FlatStyle.Flat;
            addUser_clearbtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUser_clearbtn.ForeColor = Color.White;
            addUser_clearbtn.Location = new Point(11, 459);
            addUser_clearbtn.Margin = new Padding(3, 2, 3, 2);
            addUser_clearbtn.Name = "addUser_clearbtn";
            addUser_clearbtn.Size = new Size(245, 37);
            addUser_clearbtn.TabIndex = 10;
            addUser_clearbtn.Text = "Clear";
            addUser_clearbtn.UseVisualStyleBackColor = false;
            // 
            // addUser_deletebtn
            // 
            addUser_deletebtn.BackColor = Color.FromArgb(3, 14, 28);
            addUser_deletebtn.FlatAppearance.BorderSize = 0;
            addUser_deletebtn.FlatStyle = FlatStyle.Flat;
            addUser_deletebtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUser_deletebtn.ForeColor = Color.White;
            addUser_deletebtn.Location = new Point(11, 407);
            addUser_deletebtn.Margin = new Padding(3, 2, 3, 2);
            addUser_deletebtn.Name = "addUser_deletebtn";
            addUser_deletebtn.Size = new Size(245, 37);
            addUser_deletebtn.TabIndex = 9;
            addUser_deletebtn.Text = "Delete";
            addUser_deletebtn.UseVisualStyleBackColor = false;
            // 
            // addUser_updatebtn
            // 
            addUser_updatebtn.BackColor = Color.FromArgb(3, 14, 28);
            addUser_updatebtn.FlatAppearance.BorderSize = 0;
            addUser_updatebtn.FlatStyle = FlatStyle.Flat;
            addUser_updatebtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUser_updatebtn.ForeColor = Color.White;
            addUser_updatebtn.Location = new Point(11, 334);
            addUser_updatebtn.Margin = new Padding(3, 2, 3, 2);
            addUser_updatebtn.Name = "addUser_updatebtn";
            addUser_updatebtn.Size = new Size(245, 37);
            addUser_updatebtn.TabIndex = 8;
            addUser_updatebtn.Text = "Update";
            addUser_updatebtn.UseVisualStyleBackColor = false;
            // 
            // addUser_addbtn
            // 
            addUser_addbtn.BackColor = Color.FromArgb(3, 14, 28);
            addUser_addbtn.FlatAppearance.BorderSize = 0;
            addUser_addbtn.FlatStyle = FlatStyle.Flat;
            addUser_addbtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUser_addbtn.ForeColor = Color.White;
            addUser_addbtn.Location = new Point(11, 285);
            addUser_addbtn.Margin = new Padding(3, 2, 3, 2);
            addUser_addbtn.Name = "addUser_addbtn";
            addUser_addbtn.Size = new Size(245, 37);
            addUser_addbtn.TabIndex = 7;
            addUser_addbtn.Text = "Add";
            addUser_addbtn.UseVisualStyleBackColor = false;
            addUser_addbtn.Click += addUser_addbtn_Click;
            // 
            // addUser_role
            // 
            addUser_role.FormattingEnabled = true;
            addUser_role.Items.AddRange(new object[] { "Admin", "Staff" });
            addUser_role.Location = new Point(26, 226);
            addUser_role.Margin = new Padding(3, 2, 3, 2);
            addUser_role.Name = "addUser_role";
            addUser_role.Size = new Size(231, 23);
            addUser_role.TabIndex = 6;
            // 
            // addUser_password
            // 
            addUser_password.Location = new Point(26, 154);
            addUser_password.Margin = new Padding(3, 2, 3, 2);
            addUser_password.Name = "addUser_password";
            addUser_password.Size = new Size(231, 23);
            addUser_password.TabIndex = 5;
            // 
            // addUser_username
            // 
            addUser_username.Location = new Point(26, 67);
            addUser_username.Margin = new Padding(3, 2, 3, 2);
            addUser_username.Name = "addUser_username";
            addUser_username.Size = new Size(231, 23);
            addUser_username.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 209);
            label3.Name = "label3";
            label3.Size = new Size(37, 16);
            label3.TabIndex = 2;
            label3.Text = "Role";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 126);
            label2.Name = "label2";
            label2.Size = new Size(74, 16);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 40);
            label1.Name = "label1";
            label1.Size = new Size(76, 16);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dgvUsers);
            panel2.Location = new Point(312, 17);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(816, 510);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 13);
            label4.Name = "label4";
            label4.Size = new Size(86, 16);
            label4.TabIndex = 11;
            label4.Text = "User's Data";
            // 
            // dgvUsers
            // 
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
            dgvUsers.Location = new Point(12, 40);
            dgvUsers.Margin = new Padding(3, 2, 3, 2);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvUsers.Size = new Size(777, 455);
            dgvUsers.TabIndex = 0;
            // 
            // admin_addUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 546);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "admin_addUser";
            Text = "admin_addUser";
            Load += admin_addUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox addUser_password;
        private TextBox addUser_username;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button addUser_clearbtn;
        private Button addUser_deletebtn;
        private Button addUser_updatebtn;
        private Button addUser_addbtn;
        private ComboBox addUser_role;
        private DataGridView dgvUsers;
        private Label label4;
    }
}