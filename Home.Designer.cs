namespace HMS
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            Roomsbtn = new Button();
            Guestsbtn = new Button();
            Bookingbtn = new Button();
            Paymentsbtn = new Button();
            Staffbtn = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 11);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 0;
            label1.Text = "Today's Revenue";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 11);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 1;
            label2.Text = "Today's Reservation";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.GradientActiveCaption;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(70, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 135);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(Staffbtn);
            panel1.Controls.Add(Paymentsbtn);
            panel1.Controls.Add(Bookingbtn);
            panel1.Controls.Add(Guestsbtn);
            panel1.Controls.Add(Roomsbtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 697);
            panel1.TabIndex = 3;
            // 
            // Roomsbtn
            // 
            Roomsbtn.BackColor = SystemColors.GradientActiveCaption;
            Roomsbtn.BackgroundImage = Properties.Resources.furniture_13528109;
            Roomsbtn.BackgroundImageLayout = ImageLayout.Center;
            Roomsbtn.Location = new Point(70, 251);
            Roomsbtn.Name = "Roomsbtn";
            Roomsbtn.RightToLeft = RightToLeft.Yes;
            Roomsbtn.Size = new Size(177, 100);
            Roomsbtn.TabIndex = 3;
            Roomsbtn.UseVisualStyleBackColor = false;
            // 
            // Guestsbtn
            // 
            Guestsbtn.BackColor = SystemColors.GradientActiveCaption;
            Guestsbtn.BackgroundImage = Properties.Resources.travelers_8012916;
            Guestsbtn.BackgroundImageLayout = ImageLayout.Center;
            Guestsbtn.Location = new Point(70, 143);
            Guestsbtn.Name = "Guestsbtn";
            Guestsbtn.Size = new Size(177, 102);
            Guestsbtn.TabIndex = 4;
            Guestsbtn.UseVisualStyleBackColor = false;
            // 
            // Bookingbtn
            // 
            Bookingbtn.BackColor = SystemColors.GradientActiveCaption;
            Bookingbtn.BackgroundImage = Properties.Resources.reservation_18671725;
            Bookingbtn.BackgroundImageLayout = ImageLayout.Center;
            Bookingbtn.Location = new Point(70, 357);
            Bookingbtn.Name = "Bookingbtn";
            Bookingbtn.Size = new Size(177, 99);
            Bookingbtn.TabIndex = 5;
            Bookingbtn.UseVisualStyleBackColor = false;
            // 
            // Paymentsbtn
            // 
            Paymentsbtn.BackColor = SystemColors.GradientActiveCaption;
            Paymentsbtn.BackgroundImage = Properties.Resources.Hotel_Pay;
            Paymentsbtn.BackgroundImageLayout = ImageLayout.Center;
            Paymentsbtn.Location = new Point(70, 457);
            Paymentsbtn.Name = "Paymentsbtn";
            Paymentsbtn.Size = new Size(177, 103);
            Paymentsbtn.TabIndex = 6;
            Paymentsbtn.UseVisualStyleBackColor = false;
            // 
            // Staffbtn
            // 
            Staffbtn.BackColor = SystemColors.GradientActiveCaption;
            Staffbtn.BackgroundImage = Properties.Resources.bellboy_3230924;
            Staffbtn.BackgroundImageLayout = ImageLayout.Center;
            Staffbtn.Location = new Point(70, 566);
            Staffbtn.Name = "Staffbtn";
            Staffbtn.Size = new Size(177, 96);
            Staffbtn.TabIndex = 7;
            Staffbtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(419, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 148);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientInactiveCaption;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(690, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(185, 148);
            panel3.TabIndex = 5;
            panel3.Paint += panel3_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientInactiveCaption;
            panel4.Controls.Add(label7);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(941, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(187, 148);
            panel4.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.GradientInactiveCaption;
            panel5.Controls.Add(label8);
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(1175, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(186, 148);
            panel5.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 11);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 2;
            label3.Text = "Current Guests";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 11);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 3;
            label4.Text = "Available Rooms";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 117);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 1;
            label5.Text = "Today's Revenue";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaption;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(48, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 67);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ActiveCaption;
            pictureBox3.BackgroundImage = Properties.Resources.sign_15804851;
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Location = new Point(57, 39);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 75);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ActiveCaption;
            pictureBox4.BackgroundImage = Properties.Resources.expert_5477085;
            pictureBox4.BackgroundImageLayout = ImageLayout.Center;
            pictureBox4.Location = new Point(45, 39);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(99, 75);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.InactiveCaption;
            pictureBox5.BackgroundImage = Properties.Resources.rooms_9540427;
            pictureBox5.BackgroundImageLayout = ImageLayout.Center;
            pictureBox5.Location = new Point(49, 43);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(87, 63);
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 117);
            label6.Name = "label6";
            label6.Size = new Size(139, 20);
            label6.TabIndex = 10;
            label6.Text = "Today's Reservation";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 117);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 11;
            label7.Text = "Current Guests";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 117);
            label8.Name = "label8";
            label8.Size = new Size(121, 20);
            label8.TabIndex = 12;
            label8.Text = "Available Rooms";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1373, 697);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button Staffbtn;
        private Button Paymentsbtn;
        private Button Bookingbtn;
        private Button Guestsbtn;
        private Button Roomsbtn;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label7;
        private Label label8;
    }
}