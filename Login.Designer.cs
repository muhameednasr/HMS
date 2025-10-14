namespace HMS
{
    partial class Login
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
            panel1 = new Panel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            Close = new Label();
            label2 = new Label();
            label3 = new Label();
            login_username = new TextBox();
            txtPassword = new TextBox();
            login_btn = new Button();
            label4 = new Label();
            login_showpass = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 14, 28);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 653);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(124, 330);
            label5.Name = "label5";
            label5.Size = new Size(221, 21);
            label5.TabIndex = 8;
            label5.Text = "Hotel Management System";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.download;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(122, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 197);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Close
            // 
            Close.AutoSize = true;
            Close.FlatStyle = FlatStyle.Flat;
            Close.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close.ForeColor = Color.Black;
            Close.Location = new Point(1231, 9);
            Close.Name = "Close";
            Close.Size = new Size(20, 21);
            Close.TabIndex = 1;
            Close.Text = "X";
            Close.TextAlign = ContentAlignment.TopRight;
            Close.Click += Close_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(655, 179);
            label2.Name = "label2";
            label2.Size = new Size(136, 18);
            label2.TabIndex = 2;
            label2.Text = "Username or Email";
            label2.TextAlign = ContentAlignment.TopRight;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(655, 301);
            label3.Name = "label3";
            label3.Size = new Size(74, 18);
            label3.TabIndex = 3;
            label3.Text = "Password";
            label3.TextAlign = ContentAlignment.TopRight;
            label3.Click += label3_Click;
            // 
            // login_username
            // 
            login_username.BorderStyle = BorderStyle.FixedSingle;
            login_username.Location = new Point(655, 223);
            login_username.Name = "login_username";
            login_username.Size = new Size(488, 23);
            login_username.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(655, 332);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(488, 23);
            txtPassword.TabIndex = 5;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(3, 14, 28);
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 110, 138);
            login_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 110, 138);
            login_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.ForeColor = SystemColors.Window;
            login_btn.Location = new Point(726, 453);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(320, 46);
            login_btn.TabIndex = 6;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(778, 84);
            label4.Name = "label4";
            label4.Size = new Size(168, 21);
            label4.TabIndex = 7;
            label4.Text = "Welcome back, User";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // login_showpass
            // 
            login_showpass.AutoSize = true;
            login_showpass.Location = new Point(655, 374);
            login_showpass.Name = "login_showpass";
            login_showpass.Size = new Size(112, 19);
            login_showpass.TabIndex = 10;
            login_showpass.Text = "Show Password";
            login_showpass.UseVisualStyleBackColor = true;
            login_showpass.CheckedChanged += login_showpass_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 653);
            Controls.Add(login_showpass);
            Controls.Add(label4);
            Controls.Add(login_btn);
            Controls.Add(txtPassword);
            Controls.Add(login_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Close);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label Close;
        private Label label2;
        private Label label3;
        private TextBox login_username;
        private TextBox txtPassword;
        private Button login_btn;
        private Label label4;
        private Label label5;
        private CheckBox login_showpass;
    }
}