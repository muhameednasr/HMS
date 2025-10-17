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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel4 = new Panel();
            label7 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            rooms_hotelCombo = new ComboBox();
            rooms_clearBtn = new Button();
            rooms_deleteBtn = new Button();
            rooms_updateBtn = new Button();
            rooms_addBtn = new Button();
            rooms_status = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            rooms_type = new ComboBox();
            rooms_roomPrice = new TextBox();
            rooms_roomID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvRooms = new DataGridView();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(3, 14, 28);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1134, 50);
            panel4.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1086, 8);
            label7.Name = "label7";
            label7.Size = new Size(18, 18);
            label7.TabIndex = 13;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(469, 10);
            label4.Name = "label4";
            label4.Size = new Size(152, 22);
            label4.TabIndex = 12;
            label4.Text = "🏨 Room's Data";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dgvRooms);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 50);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1134, 540);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(rooms_hotelCombo);
            panel2.Controls.Add(rooms_clearBtn);
            panel2.Controls.Add(rooms_deleteBtn);
            panel2.Controls.Add(rooms_updateBtn);
            panel2.Controls.Add(rooms_addBtn);
            panel2.Controls.Add(rooms_status);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(rooms_type);
            panel2.Controls.Add(rooms_roomPrice);
            panel2.Controls.Add(rooms_roomID);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(18, 294);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1083, 218);
            panel2.TabIndex = 13;
            // 
            // rooms_hotelCombo
            // 
            rooms_hotelCombo.FormattingEnabled = true;
            rooms_hotelCombo.Items.AddRange(new object[] { "Nile View", "Grand Hotel" });
            rooms_hotelCombo.Location = new Point(143, 124);
            rooms_hotelCombo.Margin = new Padding(3, 2, 3, 2);
            rooms_hotelCombo.Name = "rooms_hotelCombo";
            rooms_hotelCombo.Size = new Size(231, 23);
            rooms_hotelCombo.TabIndex = 22;
            // 
            // rooms_clearBtn
            // 
            rooms_clearBtn.BackColor = Color.FromArgb(3, 14, 28);
            rooms_clearBtn.FlatAppearance.BorderSize = 0;
            rooms_clearBtn.FlatStyle = FlatStyle.Flat;
            rooms_clearBtn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms_clearBtn.ForeColor = Color.White;
            rooms_clearBtn.Location = new Point(923, 169);
            rooms_clearBtn.Margin = new Padding(3, 2, 3, 2);
            rooms_clearBtn.Name = "rooms_clearBtn";
            rooms_clearBtn.Size = new Size(126, 31);
            rooms_clearBtn.TabIndex = 21;
            rooms_clearBtn.Text = "Clear";
            rooms_clearBtn.UseVisualStyleBackColor = false;
            rooms_clearBtn.Click += rooms_clearBtn_Click_1;
            // 
            // rooms_deleteBtn
            // 
            rooms_deleteBtn.BackColor = Color.FromArgb(3, 14, 28);
            rooms_deleteBtn.FlatAppearance.BorderSize = 0;
            rooms_deleteBtn.FlatStyle = FlatStyle.Flat;
            rooms_deleteBtn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms_deleteBtn.ForeColor = Color.White;
            rooms_deleteBtn.Location = new Point(640, 169);
            rooms_deleteBtn.Margin = new Padding(3, 2, 3, 2);
            rooms_deleteBtn.Name = "rooms_deleteBtn";
            rooms_deleteBtn.Size = new Size(126, 31);
            rooms_deleteBtn.TabIndex = 20;
            rooms_deleteBtn.Text = "Delete";
            rooms_deleteBtn.UseVisualStyleBackColor = false;
            rooms_deleteBtn.Click += rooms_deleteBtn_Click_1;
            // 
            // rooms_updateBtn
            // 
            rooms_updateBtn.BackColor = Color.FromArgb(3, 14, 28);
            rooms_updateBtn.FlatAppearance.BorderSize = 0;
            rooms_updateBtn.FlatStyle = FlatStyle.Flat;
            rooms_updateBtn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms_updateBtn.ForeColor = Color.White;
            rooms_updateBtn.Location = new Point(374, 169);
            rooms_updateBtn.Margin = new Padding(3, 2, 3, 2);
            rooms_updateBtn.Name = "rooms_updateBtn";
            rooms_updateBtn.Size = new Size(126, 31);
            rooms_updateBtn.TabIndex = 19;
            rooms_updateBtn.Text = "Update";
            rooms_updateBtn.UseVisualStyleBackColor = false;
            rooms_updateBtn.Click += rooms_updateBtn_Click_1;
            // 
            // rooms_addBtn
            // 
            rooms_addBtn.BackColor = Color.FromArgb(3, 14, 28);
            rooms_addBtn.FlatAppearance.BorderSize = 0;
            rooms_addBtn.FlatStyle = FlatStyle.Flat;
            rooms_addBtn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms_addBtn.ForeColor = Color.White;
            rooms_addBtn.Location = new Point(115, 169);
            rooms_addBtn.Margin = new Padding(3, 2, 3, 2);
            rooms_addBtn.Name = "rooms_addBtn";
            rooms_addBtn.Size = new Size(126, 31);
            rooms_addBtn.TabIndex = 18;
            rooms_addBtn.Text = "Add";
            rooms_addBtn.UseVisualStyleBackColor = false;
            rooms_addBtn.Click += rooms_addBtn_Click_1;
            // 
            // rooms_status
            // 
            rooms_status.FormattingEnabled = true;
            rooms_status.Items.AddRange(new object[] { "available", "Occupied" });
            rooms_status.Location = new Point(537, 74);
            rooms_status.Margin = new Padding(3, 2, 3, 2);
            rooms_status.Name = "rooms_status";
            rooms_status.Size = new Size(231, 23);
            rooms_status.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(463, 80);
            label6.Name = "label6";
            label6.Size = new Size(54, 16);
            label6.TabIndex = 14;
            label6.Text = "Status:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(463, 25);
            label5.Name = "label5";
            label5.Size = new Size(46, 16);
            label5.TabIndex = 12;
            label5.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 126);
            label3.Name = "label3";
            label3.Size = new Size(65, 16);
            label3.TabIndex = 11;
            label3.Text = "Hotel ID:";
            // 
            // rooms_type
            // 
            rooms_type.FormattingEnabled = true;
            rooms_type.Items.AddRange(new object[] { "Single Room", "Double Room", "Suite Room" });
            rooms_type.Location = new Point(143, 78);
            rooms_type.Margin = new Padding(3, 2, 3, 2);
            rooms_type.Name = "rooms_type";
            rooms_type.Size = new Size(231, 23);
            rooms_type.TabIndex = 10;
            // 
            // rooms_roomPrice
            // 
            rooms_roomPrice.Location = new Point(537, 22);
            rooms_roomPrice.Margin = new Padding(3, 2, 3, 2);
            rooms_roomPrice.Name = "rooms_roomPrice";
            rooms_roomPrice.Size = new Size(247, 23);
            rooms_roomPrice.TabIndex = 9;
            // 
            // rooms_roomID
            // 
            rooms_roomID.Location = new Point(143, 20);
            rooms_roomID.Margin = new Padding(3, 2, 3, 2);
            rooms_roomID.Name = "rooms_roomID";
            rooms_roomID.Size = new Size(231, 23);
            rooms_roomID.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 80);
            label2.Name = "label2";
            label2.Size = new Size(45, 16);
            label2.TabIndex = 7;
            label2.Text = "Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 22);
            label1.Name = "label1";
            label1.Size = new Size(67, 16);
            label1.TabIndex = 6;
            label1.Text = "Room ID:";
            // 
            // dgvRooms
            // 
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(3, 14, 28);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRooms.EnableHeadersVisualStyles = false;
            dgvRooms.Location = new Point(22, 17);
            dgvRooms.Margin = new Padding(3, 2, 3, 2);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.RowHeadersWidth = 51;
            dgvRooms.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvRooms.Size = new Size(1080, 262);
            dgvRooms.TabIndex = 1;
            dgvRooms.CellContentClick += dgvRooms_CellContentClick_1;
            // 
            // admin_rooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 590);
            Controls.Add(panel1);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "admin_rooms";
            Text = "admin_rooms";
            Load += admin_rooms_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel4;
        private Panel panel1;
        private Label label4;
        private DataGridView dgvRooms;
        private Label label7;
        private Panel panel2;
        private ComboBox rooms_hotelCombo;
        private Button rooms_clearBtn;
        private Button rooms_deleteBtn;
        private Button rooms_updateBtn;
        private Button rooms_addBtn;
        private ComboBox rooms_status;
        private Label label6;
        private Label label5;
        private Label label3;
        private ComboBox rooms_type;
        private TextBox rooms_roomPrice;
        private TextBox rooms_roomID;
        private Label label2;
        private Label label1;
    }
}