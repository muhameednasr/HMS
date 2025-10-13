namespace HMS
{
    partial class admin_rooms
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
            label4 = new Label();
            dgvRooms = new DataGridView();
            panel2 = new Panel();
            rooms_clearBtn = new Button();
            rooms_deleteBtn = new Button();
            rooms_updateBtn = new Button();
            rooms_addBtn = new Button();
            rooms_importBtn = new Button();
            panel3 = new Panel();
            rooms_picture = new PictureBox();
            rooms_status = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            rooms_type = new ComboBox();
            rooms_roomPrice = new TextBox();
            rooms_roomID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            rooms_hotelCombo = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rooms_picture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dgvRooms);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1212, 408);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(57, 23);
            label4.Name = "label4";
            label4.Size = new Size(100, 17);
            label4.TabIndex = 12;
            label4.Text = "Room's Data";
            // 
            // dgvRooms
            // 
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(3, 14, 28);
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRooms.EnableHeadersVisualStyles = false;
            dgvRooms.Location = new Point(19, 55);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.RowHeadersWidth = 51;
            dgvRooms.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvRooms.Size = new Size(1161, 350);
            dgvRooms.TabIndex = 1;
            dgvRooms.CellContentClick += dgvRooms_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(rooms_hotelCombo);
            panel2.Controls.Add(rooms_clearBtn);
            panel2.Controls.Add(rooms_deleteBtn);
            panel2.Controls.Add(rooms_updateBtn);
            panel2.Controls.Add(rooms_addBtn);
            panel2.Controls.Add(rooms_importBtn);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(rooms_status);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(rooms_type);
            panel2.Controls.Add(rooms_roomPrice);
            panel2.Controls.Add(rooms_roomID);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 443);
            panel2.Name = "panel2";
            panel2.Size = new Size(1212, 282);
            panel2.TabIndex = 1;
            // 
            // rooms_clearBtn
            // 
            rooms_clearBtn.BackColor = Color.FromArgb(3, 14, 28);
            rooms_clearBtn.FlatAppearance.BorderSize = 0;
            rooms_clearBtn.FlatStyle = FlatStyle.Flat;
            rooms_clearBtn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms_clearBtn.ForeColor = Color.White;
            rooms_clearBtn.Location = new Point(759, 225);
            rooms_clearBtn.Name = "rooms_clearBtn";
            rooms_clearBtn.Size = new Size(144, 41);
            rooms_clearBtn.TabIndex = 21;
            rooms_clearBtn.Text = "Clear";
            rooms_clearBtn.UseVisualStyleBackColor = false;
            rooms_clearBtn.Click += rooms_clearBtn_Click;
            // 
            // rooms_deleteBtn
            // 
            rooms_deleteBtn.BackColor = Color.FromArgb(3, 14, 28);
            rooms_deleteBtn.FlatAppearance.BorderSize = 0;
            rooms_deleteBtn.FlatStyle = FlatStyle.Flat;
            rooms_deleteBtn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms_deleteBtn.ForeColor = Color.White;
            rooms_deleteBtn.Location = new Point(527, 225);
            rooms_deleteBtn.Name = "rooms_deleteBtn";
            rooms_deleteBtn.Size = new Size(144, 41);
            rooms_deleteBtn.TabIndex = 20;
            rooms_deleteBtn.Text = "Delete";
            rooms_deleteBtn.UseVisualStyleBackColor = false;
            rooms_deleteBtn.Click += rooms_deleteBtn_Click;
            // 
            // rooms_updateBtn
            // 
            rooms_updateBtn.BackColor = Color.FromArgb(3, 14, 28);
            rooms_updateBtn.FlatAppearance.BorderSize = 0;
            rooms_updateBtn.FlatStyle = FlatStyle.Flat;
            rooms_updateBtn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms_updateBtn.ForeColor = Color.White;
            rooms_updateBtn.Location = new Point(313, 225);
            rooms_updateBtn.Name = "rooms_updateBtn";
            rooms_updateBtn.Size = new Size(144, 41);
            rooms_updateBtn.TabIndex = 19;
            rooms_updateBtn.Text = "Update";
            rooms_updateBtn.UseVisualStyleBackColor = false;
            rooms_updateBtn.Click += rooms_updateBtn_Click;
            // 
            // rooms_addBtn
            // 
            rooms_addBtn.BackColor = Color.FromArgb(3, 14, 28);
            rooms_addBtn.FlatAppearance.BorderSize = 0;
            rooms_addBtn.FlatStyle = FlatStyle.Flat;
            rooms_addBtn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms_addBtn.ForeColor = Color.White;
            rooms_addBtn.Location = new Point(120, 225);
            rooms_addBtn.Name = "rooms_addBtn";
            rooms_addBtn.Size = new Size(144, 41);
            rooms_addBtn.TabIndex = 18;
            rooms_addBtn.Text = "Add";
            rooms_addBtn.UseVisualStyleBackColor = false;
            rooms_addBtn.Click += rooms_addBtn_Click;
            // 
            // rooms_importBtn
            // 
            rooms_importBtn.BackColor = Color.FromArgb(3, 14, 28);
            rooms_importBtn.FlatAppearance.BorderSize = 0;
            rooms_importBtn.FlatStyle = FlatStyle.Flat;
            rooms_importBtn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms_importBtn.ForeColor = Color.White;
            rooms_importBtn.Location = new Point(1036, 200);
            rooms_importBtn.Name = "rooms_importBtn";
            rooms_importBtn.Size = new Size(144, 41);
            rooms_importBtn.TabIndex = 17;
            rooms_importBtn.Text = "Import";
            rooms_importBtn.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(rooms_picture);
            panel3.Location = new Point(1036, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(144, 172);
            panel3.TabIndex = 16;
            // 
            // rooms_picture
            // 
            rooms_picture.Location = new Point(3, 4);
            rooms_picture.Name = "rooms_picture";
            rooms_picture.Size = new Size(138, 165);
            rooms_picture.TabIndex = 0;
            rooms_picture.TabStop = false;
            // 
            // rooms_status
            // 
            rooms_status.FormattingEnabled = true;
            rooms_status.Items.AddRange(new object[] { "available", "Booked" });
            rooms_status.Location = new Point(612, 106);
            rooms_status.Name = "rooms_status";
            rooms_status.Size = new Size(263, 28);
            rooms_status.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(527, 114);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 14;
            label6.Text = "Status:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(527, 40);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 12;
            label5.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 175);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 11;
            label3.Text = "Hotel ID:";
            // 
            // rooms_type
            // 
            rooms_type.FormattingEnabled = true;
            rooms_type.Items.AddRange(new object[] { "Single Room", "Double Room", "Suite Room" });
            rooms_type.Location = new Point(161, 111);
            rooms_type.Name = "rooms_type";
            rooms_type.Size = new Size(263, 28);
            rooms_type.TabIndex = 10;
            // 
            // rooms_roomPrice
            // 
            rooms_roomPrice.Location = new Point(612, 36);
            rooms_roomPrice.Name = "rooms_roomPrice";
            rooms_roomPrice.Size = new Size(282, 27);
            rooms_roomPrice.TabIndex = 9;
            // 
            // rooms_roomID
            // 
            rooms_roomID.Location = new Point(161, 33);
            rooms_roomID.Name = "rooms_roomID";
            rooms_roomID.Size = new Size(263, 27);
            rooms_roomID.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(77, 114);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 7;
            label2.Text = "Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 36);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 6;
            label1.Text = "Room ID:";
            // 
            // rooms_hotelCombo
            // 
            rooms_hotelCombo.FormattingEnabled = true;
            rooms_hotelCombo.Items.AddRange(new object[] { "Nile View", "Grand Hotel" });
            rooms_hotelCombo.Location = new Point(161, 172);
            rooms_hotelCombo.Name = "rooms_hotelCombo";
            rooms_hotelCombo.Size = new Size(263, 28);
            rooms_hotelCombo.TabIndex = 22;
            // 
            // admin_rooms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 737);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admin_rooms";
            Text = "admin_rooms";
            Load += admin_rooms_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rooms_picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvRooms;
        private Label label4;
        private TextBox rooms_roomPrice;
        private TextBox rooms_roomID;
        private Label label2;
        private Label label1;
        private ComboBox rooms_type;
        private Label label5;
        private Label label3;
        private ComboBox rooms_status;
        private Label label6;
        private Panel panel3;
        private PictureBox rooms_picture;
        private Button rooms_importBtn;
        private Button rooms_clearBtn;
        private Button rooms_deleteBtn;
        private Button rooms_updateBtn;
        private Button rooms_addBtn;
        private ComboBox rooms_hotelCombo;
    }
}