namespace GUI
{
    partial class Staff
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_staff = new System.Windows.Forms.DataGridView();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.dtp_received = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad_FeMale = new System.Windows.Forms.RadioButton();
            this.rad_Male = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_addImage = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_addStaff = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_staff);
            this.groupBox1.Location = new System.Drawing.Point(10, 404);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            // 
            // dgv_staff
            // 
            this.dgv_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_staff.Location = new System.Drawing.Point(5, 25);
            this.dgv_staff.Name = "dgv_staff";
            this.dgv_staff.RowHeadersWidth = 62;
            this.dgv_staff.RowTemplate.Height = 28;
            this.dgv_staff.Size = new System.Drawing.Size(946, 287);
            this.dgv_staff.TabIndex = 0;
            this.dgv_staff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellContentClick);
            this.dgv_staff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellContentClick);
            this.dgv_staff.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellContentClick);
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(612, 205);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(321, 26);
            this.txt_phone.TabIndex = 2;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(612, 147);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(321, 26);
            this.txt_address.TabIndex = 1;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(612, 28);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(321, 26);
            this.txt_name.TabIndex = 4;
            // 
            // dtp_received
            // 
            this.dtp_received.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_received.Location = new System.Drawing.Point(612, 87);
            this.dtp_received.Name = "dtp_received";
            this.dtp_received.Size = new System.Drawing.Size(321, 26);
            this.dtp_received.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad_FeMale);
            this.groupBox2.Controls.Add(this.rad_Male);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(478, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 84);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giới tính";
            // 
            // rad_FeMale
            // 
            this.rad_FeMale.AutoSize = true;
            this.rad_FeMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rad_FeMale.Location = new System.Drawing.Point(302, 31);
            this.rad_FeMale.Name = "rad_FeMale";
            this.rad_FeMale.Size = new System.Drawing.Size(62, 29);
            this.rad_FeMale.TabIndex = 1;
            this.rad_FeMale.TabStop = true;
            this.rad_FeMale.Text = "Nữ";
            this.rad_FeMale.UseVisualStyleBackColor = true;
            // 
            // rad_Male
            // 
            this.rad_Male.AutoSize = true;
            this.rad_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rad_Male.Location = new System.Drawing.Point(157, 31);
            this.rad_Male.Name = "rad_Male";
            this.rad_Male.Size = new System.Drawing.Size(78, 29);
            this.rad_Male.TabIndex = 0;
            this.rad_Male.TabStop = true;
            this.rad_Male.Text = "Nam";
            this.rad_Male.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(486, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(486, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhận việc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(486, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(486, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(25, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "MaNV";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(104, 292);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(194, 26);
            this.txt_id.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(30, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btn_addImage
            // 
            this.btn_addImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_addImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_addImage.Location = new System.Drawing.Point(316, 136);
            this.btn_addImage.Name = "btn_addImage";
            this.btn_addImage.Size = new System.Drawing.Size(85, 44);
            this.btn_addImage.TabIndex = 11;
            this.btn_addImage.Text = "Thêm";
            this.btn_addImage.UseVisualStyleBackColor = false;
            this.btn_addImage.Click += new System.EventHandler(this.btn_addImage_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_delete.Location = new System.Drawing.Point(426, 357);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 44);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_addStaff
            // 
            this.btn_addStaff.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_addStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_addStaff.Location = new System.Drawing.Point(316, 357);
            this.btn_addStaff.Name = "btn_addStaff";
            this.btn_addStaff.Size = new System.Drawing.Size(87, 44);
            this.btn_addStaff.TabIndex = 13;
            this.btn_addStaff.Text = "Thêm";
            this.btn_addStaff.UseVisualStyleBackColor = false;
            this.btn_addStaff.Click += new System.EventHandler(this.btn_addStaff_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_edit.Location = new System.Drawing.Point(517, 357);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 44);
            this.btn_edit.TabIndex = 14;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_confirm.Location = new System.Drawing.Point(602, 357);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(124, 44);
            this.btn_confirm.TabIndex = 15;
            this.btn_confirm.Text = "Xác nhận";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_cancel.Location = new System.Drawing.Point(739, 357);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 44);
            this.btn_cancel.TabIndex = 16;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_reset.Location = new System.Drawing.Point(824, 357);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(109, 44);
            this.btn_reset.TabIndex = 17;
            this.btn_reset.Text = "Làm mới";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_search.Location = new System.Drawing.Point(212, 360);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(86, 42);
            this.btn_search.TabIndex = 18;
            this.btn_search.Text = "Tìm";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(15, 368);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(191, 26);
            this.txt_search.TabIndex = 19;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 734);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_addStaff);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_addImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtp_received);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.groupBox1);
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_staff;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.DateTimePicker dtp_received;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rad_FeMale;
        private System.Windows.Forms.RadioButton rad_Male;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_addImage;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_addStaff;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
    }
}