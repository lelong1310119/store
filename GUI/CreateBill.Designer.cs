namespace GUI
{
    partial class CreateBill
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.lb_address = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lb_phone = new System.Windows.Forms.Label();
            this.lb_tp = new System.Windows.Forms.Label();
            this.cb_city = new System.Windows.Forms.ComboBox();
            this.btn_getCustomer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_product = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dt_create = new System.Windows.Forms.DateTimePicker();
            this.dt_received = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_staff = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 0;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_name.Location = new System.Drawing.Point(21, 35);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(148, 23);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "Tên khách hàng";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(231, 35);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(243, 26);
            this.txt_name.TabIndex = 2;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(231, 88);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(243, 26);
            this.txt_address.TabIndex = 4;
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_address.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_address.Location = new System.Drawing.Point(21, 88);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(69, 23);
            this.lb_address.TabIndex = 3;
            this.lb_address.Text = "Địa chỉ";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(231, 197);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(243, 26);
            this.txt_phone.TabIndex = 6;
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_phone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_phone.Location = new System.Drawing.Point(21, 197);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(124, 23);
            this.lb_phone.TabIndex = 5;
            this.lb_phone.Text = "Số điện thoại";
            // 
            // lb_tp
            // 
            this.lb_tp.AutoSize = true;
            this.lb_tp.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_tp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_tp.Location = new System.Drawing.Point(21, 140);
            this.lb_tp.Name = "lb_tp";
            this.lb_tp.Size = new System.Drawing.Size(101, 23);
            this.lb_tp.TabIndex = 7;
            this.lb_tp.Text = "Thành phố";
            // 
            // cb_city
            // 
            this.cb_city.FormattingEnabled = true;
            this.cb_city.Location = new System.Drawing.Point(231, 141);
            this.cb_city.Name = "cb_city";
            this.cb_city.Size = new System.Drawing.Size(243, 26);
            this.cb_city.TabIndex = 8;
            // 
            // btn_getCustomer
            // 
            this.btn_getCustomer.Location = new System.Drawing.Point(231, 307);
            this.btn_getCustomer.Name = "btn_getCustomer";
            this.btn_getCustomer.Size = new System.Drawing.Size(151, 33);
            this.btn_getCustomer.TabIndex = 9;
            this.btn_getCustomer.Text = "Lấy thông tin";
            this.btn_getCustomer.UseVisualStyleBackColor = true;
            this.btn_getCustomer.Click += new System.EventHandler(this.btn_getCustomer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 248);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khách hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(499, 220);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cb_product
            // 
            this.cb_product.FormattingEnabled = true;
            this.cb_product.Location = new System.Drawing.Point(763, 32);
            this.cb_product.Name = "cb_product";
            this.cb_product.Size = new System.Drawing.Size(281, 26);
            this.cb_product.TabIndex = 11;
            this.cb_product.SelectedIndexChanged += new System.EventHandler(this.cb_product_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(646, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 26);
            this.label2.TabIndex = 12;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(763, 125);
            this.quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(59, 26);
            this.quantity.TabIndex = 13;
            this.quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(623, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sản Phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(623, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Giá";
            // 
            // txt_price
            // 
            this.txt_price.Enabled = false;
            this.txt_price.Location = new System.Drawing.Point(763, 80);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(143, 26);
            this.txt_price.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(623, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Số lượng";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(397, 307);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(77, 33);
            this.btn_save.TabIndex = 18;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(949, 115);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(95, 33);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(628, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 248);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 22);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(518, 220);
            this.dataGridView2.TabIndex = 0;
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(763, 307);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(204, 26);
            this.txt_total.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(623, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tổng tiền";
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(995, 302);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(138, 33);
            this.btn_create.TabIndex = 23;
            this.btn_create.Text = "Tạo hóa đơn";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(623, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ngày tạo";
            // 
            // dt_create
            // 
            this.dt_create.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_create.Location = new System.Drawing.Point(763, 223);
            this.dt_create.Name = "dt_create";
            this.dt_create.Size = new System.Drawing.Size(200, 26);
            this.dt_create.TabIndex = 24;
            // 
            // dt_received
            // 
            this.dt_received.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_received.Location = new System.Drawing.Point(763, 264);
            this.dt_received.Name = "dt_received";
            this.dt_received.Size = new System.Drawing.Size(200, 26);
            this.dt_received.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(623, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 23);
            this.label8.TabIndex = 25;
            this.label8.Text = "Ngày nhận";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(623, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 23);
            this.label9.TabIndex = 27;
            this.label9.Text = "Nhân viên";
            // 
            // cb_staff
            // 
            this.cb_staff.FormattingEnabled = true;
            this.cb_staff.Location = new System.Drawing.Point(763, 179);
            this.cb_staff.Name = "cb_staff";
            this.cb_staff.Size = new System.Drawing.Size(281, 26);
            this.cb_staff.TabIndex = 28;
            // 
            // CreateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 623);
            this.Controls.Add(this.cb_staff);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dt_received);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dt_create);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.btn_getCustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_product);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cb_city);
            this.Controls.Add(this.lb_tp);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "CreateBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Label lb_tp;
        private System.Windows.Forms.ComboBox cb_city;
        private System.Windows.Forms.Button btn_getCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_product;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_create;
        private System.Windows.Forms.DateTimePicker dt_received;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_staff;
    }
}