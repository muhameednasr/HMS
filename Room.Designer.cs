namespace HMS
{
    partial class Room
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
            dvg = new DataGridView();
            RoomId = new DataGridViewTextBoxColumn();
            HotelID = new DataGridViewComboBoxColumn();
            TypeID = new DataGridViewComboBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtStatus = new TextBox();
            comboBoxType = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            comboBoxHotel = new ComboBox();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dvg).BeginInit();
            SuspendLayout();
            // 
            // dvg
            // 
            dvg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg.Columns.AddRange(new DataGridViewColumn[] { RoomId, HotelID, TypeID, Status });
            dvg.Location = new Point(12, 12);
            dvg.Name = "dvg";
            dvg.Size = new Size(450, 412);
            dvg.TabIndex = 0;
            dvg.CellEndEdit += dvg_CellEndEdit;
            // 
            // RoomId
            // 
            RoomId.HeaderText = "Id";
            RoomId.Name = "RoomId";
            RoomId.ReadOnly = true;
            // 
            // HotelID
            // 
            HotelID.HeaderText = "HotelID";
            HotelID.Name = "HotelID";
            HotelID.Resizable = DataGridViewTriState.True;
            HotelID.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // TypeID
            // 
            TypeID.HeaderText = "TypeID";
            TypeID.Name = "TypeID";
            TypeID.Resizable = DataGridViewTriState.True;
            TypeID.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // label1
            // 
            label1.Location = new Point(518, 284);
            label1.Name = "label1";
            label1.Size = new Size(170, 23);
            label1.TabIndex = 1;
            label1.Text = "Status";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(518, 319);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(170, 23);
            txtStatus.TabIndex = 2;
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(518, 223);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(170, 23);
            comboBoxType.TabIndex = 3;
            // 
            // label2
            // 
            label2.Location = new Point(518, 197);
            label2.Name = "label2";
            label2.Size = new Size(170, 23);
            label2.TabIndex = 4;
            label2.Text = "Type";
            // 
            // label3
            // 
            label3.Location = new Point(518, 118);
            label3.Name = "label3";
            label3.Size = new Size(170, 23);
            label3.TabIndex = 6;
            label3.Text = "Hotel";
            // 
            // comboBoxHotel
            // 
            comboBoxHotel.FormattingEnabled = true;
            comboBoxHotel.Location = new Point(518, 144);
            comboBoxHotel.Name = "comboBoxHotel";
            comboBoxHotel.Size = new Size(170, 23);
            comboBoxHotel.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(518, 375);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(170, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Room
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(comboBoxHotel);
            Controls.Add(label2);
            Controls.Add(comboBoxType);
            Controls.Add(txtStatus);
            Controls.Add(label1);
            Controls.Add(dvg);
            Name = "Room";
            Text = "Room";
            Load += Room_Load;
            ((System.ComponentModel.ISupportInitialize)dvg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvg;
        private DataGridViewTextBoxColumn RoomId;
        private DataGridViewComboBoxColumn HotelID;
        private DataGridViewComboBoxColumn TypeID;
        private DataGridViewTextBoxColumn Status;
        private Label label1;
        private TextBox txtStatus;
        private ComboBox comboBoxType;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxHotel;
        private Button btnAdd;
    }
}