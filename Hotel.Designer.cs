namespace HMS
{
    partial class Hotel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            dgv = new DataGridView();
            HotelId = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Stars = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel3 = new Panel();
            btnDelete = new Button();
            label1 = new Label();
            label5 = new Label();
            btnAdd = new Button();
            txtPhone = new TextBox();
            txtStars = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtAdress = new TextBox();
            label2 = new Label();
            txtHotel = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 14, 28);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1056, 41);
            panel1.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1026, 10);
            label7.Name = "label7";
            label7.Size = new Size(18, 18);
            label7.TabIndex = 14;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(355, 10);
            label6.Name = "label6";
            label6.Size = new Size(197, 26);
            label6.TabIndex = 13;
            label6.Text = "🏨 System Hotels";
            // 
            // dgv
            // 
            dgv.BackgroundColor = Color.FromArgb(52, 110, 138);
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { HotelId, Name, Address, Phone, Email, Stars });
            dgv.Location = new Point(24, 37);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(703, 397);
            dgv.TabIndex = 1;
            dgv.CellClick += dgv_CellClick;
            // 
            // HotelId
            // 
            HotelId.HeaderText = "Id";
            HotelId.MinimumWidth = 6;
            HotelId.Name = "HotelId";
            HotelId.ReadOnly = true;
            HotelId.Width = 125;
            // 
            // Name
            // 
            Name.HeaderText = "Hotel";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 125;
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
            // Stars
            // 
            Stars.HeaderText = "Stars";
            Stars.MinimumWidth = 6;
            Stars.Name = "Stars";
            Stars.Width = 125;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dgv);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 41);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1056, 448);
            panel2.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(txtPhone);
            panel3.Controls.Add(txtStars);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtAdress);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtHotel);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(745, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(311, 448);
            panel3.TabIndex = 24;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(3, 14, 28);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 110, 138);
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 110, 138);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(73, 412);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(186, 30);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.Location = new Point(73, 48);
            label1.Name = "label1";
            label1.Size = new Size(186, 23);
            label1.TabIndex = 18;
            label1.Text = "Hotel";
            // 
            // label5
            // 
            label5.Location = new Point(73, 182);
            label5.Name = "label5";
            label5.Size = new Size(186, 23);
            label5.TabIndex = 23;
            label5.Text = "Phone";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(3, 14, 28);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 110, 138);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 110, 138);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(73, 376);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(186, 30);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(73, 208);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(186, 23);
            txtPhone.TabIndex = 22;
            // 
            // txtStars
            // 
            txtStars.Location = new Point(73, 330);
            txtStars.Name = "txtStars";
            txtStars.Size = new Size(186, 23);
            txtStars.TabIndex = 14;
            // 
            // label4
            // 
            label4.Location = new Point(73, 304);
            label4.Name = "label4";
            label4.Size = new Size(186, 23);
            label4.TabIndex = 21;
            label4.Text = "Stars";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(73, 268);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(186, 23);
            txtEmail.TabIndex = 15;
            // 
            // label3
            // 
            label3.Location = new Point(73, 242);
            label3.Name = "label3";
            label3.Size = new Size(186, 23);
            label3.TabIndex = 20;
            label3.Text = "Email";
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(73, 141);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(186, 23);
            txtAdress.TabIndex = 16;
            // 
            // label2
            // 
            label2.Location = new Point(73, 115);
            label2.Name = "label2";
            label2.Size = new Size(186, 23);
            label2.TabIndex = 19;
            label2.Text = "Address";
            // 
            // txtHotel
            // 
            txtHotel.Location = new Point(73, 74);
            txtHotel.Name = "txtHotel";
            txtHotel.Size = new Size(186, 23);
            txtHotel.TabIndex = 17;
            // 
            // Hotel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 489);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn HotelId;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Stars;
        private Label label6;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label5;
        private Button btnAdd;
        private TextBox txtPhone;
        private TextBox txtStars;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtAdress;
        private Label label2;
        private TextBox txtHotel;
        private Label label7;
        private Button btnDelete;
    }
}
