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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            panel1.Location = new Point(21, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 680);
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
            addUser_clearbtn.Location = new Point(13, 612);
            addUser_clearbtn.Name = "addUser_clearbtn";
            addUser_clearbtn.Size = new Size(280, 49);
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
            addUser_deletebtn.Location = new Point(13, 543);
            addUser_deletebtn.Name = "addUser_deletebtn";
            addUser_deletebtn.Size = new Size(280, 49);
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
            addUser_updatebtn.Location = new Point(13, 445);
            addUser_updatebtn.Name = "addUser_updatebtn";
            addUser_updatebtn.Size = new Size(280, 49);
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
            addUser_addbtn.Location = new Point(13, 380);
            addUser_addbtn.Name = "addUser_addbtn";
            addUser_addbtn.Size = new Size(280, 49);
            addUser_addbtn.TabIndex = 7;
            addUser_addbtn.Text = "Add";
            addUser_addbtn.UseVisualStyleBackColor = false;
            addUser_addbtn.Click += addUser_addbtn_Click;
            // 
            // addUser_role
            // 
            addUser_role.FormattingEnabled = true;
            addUser_role.Items.AddRange(new object[] { "Admin", "Staff" });
            addUser_role.Location = new Point(30, 302);
            addUser_role.Name = "addUser_role";
            addUser_role.Size = new Size(263, 28);
            addUser_role.TabIndex = 6;
            // 
            // addUser_password
            // 
            addUser_password.Location = new Point(30, 205);
            addUser_password.Name = "addUser_password";
            addUser_password.Size = new Size(263, 27);
            addUser_password.TabIndex = 5;
            // 
            // addUser_username
            // 
            addUser_username.Location = new Point(30, 89);
            addUser_username.Name = "addUser_username";
            addUser_username.Size = new Size(263, 27);
            addUser_username.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 279);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Role";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 168);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 54);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dgvUsers);
            panel2.Location = new Point(356, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(932, 680);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 17);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 11;
            label4.Text = "User's Data";
            // 
            // dgvUsers
            // 
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(3, 14, 28);
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.Location = new Point(14, 54);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvUsers.Size = new Size(888, 607);
            dgvUsers.TabIndex = 0;
            // 
            // admin_addUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 728);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
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