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
            dvg = new DataGridView();
            btnAdd = new Button();
            txtEmail = new TextBox();
            txtAdress = new TextBox();
            txtHotel = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtStars = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtPhone = new TextBox();
            HotelId = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Stars = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dvg).BeginInit();
            SuspendLayout();
            // 
            // dvg
            // 
            dvg.BackgroundColor = Color.Thistle;
            dvg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg.Columns.AddRange(new DataGridViewColumn[] { HotelId, Name, Address, Phone, Email, Stars });
            dvg.Location = new Point(12, 26);
            dvg.Name = "dvg";
            dvg.Size = new Size(644, 368);
            dvg.TabIndex = 0;
            dvg.CellEndEdit += dvg_CellEndEdit;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(672, 364);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(186, 30);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(672, 256);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(186, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(672, 129);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(186, 23);
            txtAdress.TabIndex = 5;
            // 
            // txtHotel
            // 
            txtHotel.Location = new Point(672, 62);
            txtHotel.Name = "txtHotel";
            txtHotel.Size = new Size(186, 23);
            txtHotel.TabIndex = 6;
            // 
            // label1
            // 
            label1.Location = new Point(672, 36);
            label1.Name = "label1";
            label1.Size = new Size(186, 23);
            label1.TabIndex = 7;
            label1.Text = "Hotel";
            // 
            // label2
            // 
            label2.Location = new Point(672, 103);
            label2.Name = "label2";
            label2.Size = new Size(186, 23);
            label2.TabIndex = 8;
            label2.Text = "Adress";
            // 
            // label3
            // 
            label3.Location = new Point(672, 230);
            label3.Name = "label3";
            label3.Size = new Size(186, 23);
            label3.TabIndex = 9;
            label3.Text = "Email";
            // 
            // txtStars
            // 
            txtStars.Location = new Point(672, 318);
            txtStars.Name = "txtStars";
            txtStars.Size = new Size(186, 23);
            txtStars.TabIndex = 3;
            // 
            // label4
            // 
            label4.Location = new Point(672, 292);
            label4.Name = "label4";
            label4.Size = new Size(186, 23);
            label4.TabIndex = 10;
            label4.Text = "Stars";
            // 
            // label5
            // 
            label5.Location = new Point(672, 170);
            label5.Name = "label5";
            label5.Size = new Size(186, 23);
            label5.TabIndex = 12;
            label5.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(672, 196);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(186, 23);
            txtPhone.TabIndex = 11;
            // 
            // HotelId
            // 
            HotelId.HeaderText = "Id";
            HotelId.Name = "HotelId";
            HotelId.ReadOnly = true;
            // 
            // Name
            // 
            Name.HeaderText = "Hotel";
            Name.Name = "Name";
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.Name = "Address";
            // 
            // Phone
            // 
            Phone.HeaderText = "Phone";
            Phone.Name = "Phone";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Stars
            // 
            Stars.HeaderText = "Stars";
            Stars.Name = "Stars";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 403);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtHotel);
            Controls.Add(txtAdress);
            Controls.Add(txtEmail);
            Controls.Add(txtStars);
            Controls.Add(btnAdd);
            Controls.Add(dvg);
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dvg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvg;
        private Button btnAdd;
        private TextBox txtEmail;
        private TextBox txtAdress;
        private TextBox txtHotel;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtStars;
        private Label label4;
        private Label label5;
        private TextBox txtPhone;
        private DataGridViewTextBoxColumn HotelId;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Stars;
    }
}
