namespace HMS
{
    partial class AdminMain
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
            label2 = new Label();
            Close = new Label();
            panel2 = new Panel();
            logout_btn = new Button();
            rooms_btn = new Button();
            guests_btn = new Button();
            addUser_btn = new Button();
            dashboard_btn = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            panel9 = new Panel();
            label10 = new Label();
            label11 = new Label();
            pictureBox5 = new PictureBox();
            panel8 = new Panel();
            label8 = new Label();
            label9 = new Label();
            pictureBox4 = new PictureBox();
            panel7 = new Panel();
            label6 = new Label();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            panel6 = new Panel();
            label4 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 14, 28);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1448, 46);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(270, 23);
            label2.TabIndex = 1;
            label2.Text = "Hotel Management System";
            // 
            // Close
            // 
            Close.AutoSize = true;
            Close.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Close.ForeColor = Color.White;
            Close.Location = new Point(1414, 9);
            Close.Name = "Close";
            Close.Size = new Size(22, 23);
            Close.TabIndex = 0;
            Close.Text = "X";
            Close.Click += Close_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(52, 110, 138);
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(rooms_btn);
            panel2.Controls.Add(guests_btn);
            panel2.Controls.Add(addUser_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(294, 678);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // logout_btn
            // 
            logout_btn.BackColor = Color.FromArgb(52, 110, 138);
            logout_btn.Cursor = Cursors.Hand;
            logout_btn.FlatAppearance.BorderSize = 0;
            logout_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 14, 28);
            logout_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 14, 28);
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout_btn.ForeColor = Color.White;
            logout_btn.Location = new Point(12, 616);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(270, 39);
            logout_btn.TabIndex = 14;
            logout_btn.Text = "Logout";
            logout_btn.UseVisualStyleBackColor = false;
            logout_btn.Click += logout_btn_Click;
            // 
            // rooms_btn
            // 
            rooms_btn.BackColor = Color.FromArgb(52, 110, 138);
            rooms_btn.Cursor = Cursors.Hand;
            rooms_btn.FlatAppearance.BorderSize = 0;
            rooms_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(3, 14, 28);
            rooms_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 14, 28);
            rooms_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 14, 28);
            rooms_btn.FlatStyle = FlatStyle.Flat;
            rooms_btn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms_btn.ForeColor = Color.White;
            rooms_btn.Location = new Point(36, 379);
            rooms_btn.Name = "rooms_btn";
            rooms_btn.RightToLeft = RightToLeft.Yes;
            rooms_btn.Size = new Size(220, 39);
            rooms_btn.TabIndex = 13;
            rooms_btn.Text = "Rooms";
            rooms_btn.UseVisualStyleBackColor = false;
            rooms_btn.Click += rooms_btn_Click;
            // 
            // guests_btn
            // 
            guests_btn.BackColor = Color.FromArgb(52, 110, 138);
            guests_btn.Cursor = Cursors.Hand;
            guests_btn.FlatAppearance.BorderSize = 0;
            guests_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(3, 14, 28);
            guests_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 14, 28);
            guests_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 14, 28);
            guests_btn.FlatStyle = FlatStyle.Flat;
            guests_btn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guests_btn.ForeColor = Color.White;
            guests_btn.Location = new Point(36, 457);
            guests_btn.Name = "guests_btn";
            guests_btn.Size = new Size(220, 39);
            guests_btn.TabIndex = 12;
            guests_btn.Text = "Guests";
            guests_btn.UseVisualStyleBackColor = false;
            // 
            // addUser_btn
            // 
            addUser_btn.BackColor = Color.FromArgb(52, 110, 138);
            addUser_btn.Cursor = Cursors.Hand;
            addUser_btn.FlatAppearance.BorderSize = 0;
            addUser_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(3, 14, 28);
            addUser_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 14, 28);
            addUser_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 14, 28);
            addUser_btn.FlatStyle = FlatStyle.Flat;
            addUser_btn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUser_btn.ForeColor = Color.White;
            addUser_btn.Location = new Point(36, 297);
            addUser_btn.Name = "addUser_btn";
            addUser_btn.Size = new Size(220, 39);
            addUser_btn.TabIndex = 11;
            addUser_btn.Text = "Add User";
            addUser_btn.UseVisualStyleBackColor = false;
            addUser_btn.Click += addUser_btn_Click;
            // 
            // dashboard_btn
            // 
            dashboard_btn.BackColor = Color.FromArgb(52, 110, 138);
            dashboard_btn.Cursor = Cursors.Hand;
            dashboard_btn.FlatAppearance.BorderSize = 0;
            dashboard_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(3, 14, 28);
            dashboard_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 14, 28);
            dashboard_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 14, 28);
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_btn.ForeColor = Color.White;
            dashboard_btn.Location = new Point(36, 222);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(220, 39);
            dashboard_btn.TabIndex = 10;
            dashboard_btn.Text = "Dashboard";
            dashboard_btn.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(58, 173);
            label3.Name = "label3";
            label3.Size = new Size(158, 23);
            label3.TabIndex = 2;
            label3.Text = "Welcome, User";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.download;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(69, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 113);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(294, 46);
            panel3.Name = "panel3";
            panel3.Size = new Size(1154, 678);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel6);
            panel4.Location = new Point(18, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(1097, 191);
            panel4.TabIndex = 4;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(52, 110, 138);
            panel9.Controls.Add(label10);
            panel9.Controls.Add(label11);
            panel9.Controls.Add(pictureBox5);
            panel9.Location = new Point(829, 26);
            panel9.Name = "panel9";
            panel9.Size = new Size(252, 138);
            panel9.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(181, 18);
            label10.Name = "label10";
            label10.Size = new Size(48, 20);
            label10.TabIndex = 6;
            label10.Text = "$ 0.0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(43, 109);
            label11.Name = "label11";
            label11.Size = new Size(100, 20);
            label11.TabIndex = 4;
            label11.Text = "Total Profit";
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.revenue_12983663;
            pictureBox5.BackgroundImageLayout = ImageLayout.Center;
            pictureBox5.Location = new Point(32, 31);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(75, 62);
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(52, 110, 138);
            panel8.Controls.Add(label8);
            panel8.Controls.Add(label9);
            panel8.Controls.Add(pictureBox4);
            panel8.Location = new Point(558, 26);
            panel8.Name = "panel8";
            panel8.Size = new Size(252, 138);
            panel8.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(188, 18);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 5;
            label8.Text = "$ 0.0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(25, 109);
            label9.Name = "label9";
            label9.Size = new Size(122, 20);
            label9.TabIndex = 4;
            label9.Text = "Today's Profit";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.profit_10851961;
            pictureBox4.BackgroundImageLayout = ImageLayout.Center;
            pictureBox4.Location = new Point(25, 31);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(72, 62);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(52, 110, 138);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(pictureBox3);
            panel7.Location = new Point(288, 26);
            panel7.Name = "panel7";
            panel7.Size = new Size(252, 138);
            panel7.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(214, 18);
            label6.Name = "label6";
            label6.Size = new Size(19, 20);
            label6.TabIndex = 5;
            label6.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(21, 109);
            label7.Name = "label7";
            label7.Size = new Size(146, 20);
            label7.TabIndex = 4;
            label7.Text = "Available Rooms";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.interior_design_12799889;
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Location = new Point(21, 31);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 69);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(52, 110, 138);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(pictureBox2);
            panel6.Location = new Point(18, 26);
            panel6.Name = "panel6";
            panel6.Size = new Size(252, 138);
            panel6.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(219, 18);
            label4.Name = "label4";
            label4.Size = new Size(19, 20);
            label4.TabIndex = 3;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(16, 109);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 2;
            label5.Text = "Total Staff";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.organizational_12128997;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(16, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(91, 62);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(18, 231);
            panel5.Name = "panel5";
            panel5.Size = new Size(1097, 424);
            panel5.TabIndex = 5;
            // 
            // AdminMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1448, 724);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label Close;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button dashboard_btn;
        private Label label3;
        private Button logout_btn;
        private Button rooms_btn;
        private Button guests_btn;
        private Button addUser_btn;
        private Panel panel3;
        private Panel panel4;
        private Panel panel9;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox5;
        private Panel panel8;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox4;
        private Panel panel7;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox3;
        private Panel panel6;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox2;
        private Panel panel5;
    }
}