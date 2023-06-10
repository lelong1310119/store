namespace GUI
{
    partial class ReportDateTime
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_case = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_month = new System.Windows.Forms.ComboBox();
            this.cb_quarter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_year = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_method = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(943, 354);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(931, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // cb_case
            // 
            this.cb_case.FormattingEnabled = true;
            this.cb_case.Location = new System.Drawing.Point(628, 31);
            this.cb_case.Name = "cb_case";
            this.cb_case.Size = new System.Drawing.Size(174, 28);
            this.cb_case.TabIndex = 1;
            this.cb_case.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(453, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ca sáng/chiều";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(453, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Theo ngày";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(628, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 26);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(453, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Theo tháng";
            // 
            // cb_month
            // 
            this.cb_month.FormattingEnabled = true;
            this.cb_month.Location = new System.Drawing.Point(628, 165);
            this.cb_month.Name = "cb_month";
            this.cb_month.Size = new System.Drawing.Size(174, 28);
            this.cb_month.TabIndex = 7;
            this.cb_month.SelectedIndexChanged += new System.EventHandler(this.cb_month_SelectedIndexChanged);
            // 
            // cb_quarter
            // 
            this.cb_quarter.FormattingEnabled = true;
            this.cb_quarter.Location = new System.Drawing.Point(628, 235);
            this.cb_quarter.Name = "cb_quarter";
            this.cb_quarter.Size = new System.Drawing.Size(174, 28);
            this.cb_quarter.TabIndex = 9;
            this.cb_quarter.SelectedIndexChanged += new System.EventHandler(this.cb_quarter_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(453, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Theo quý";
            // 
            // cb_year
            // 
            this.cb_year.FormattingEnabled = true;
            this.cb_year.Location = new System.Drawing.Point(628, 303);
            this.cb_year.Name = "cb_year";
            this.cb_year.Size = new System.Drawing.Size(174, 28);
            this.cb_year.TabIndex = 11;
            this.cb_year.SelectedIndexChanged += new System.EventHandler(this.cb_year_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(453, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Theo năm";
            // 
            // cb_method
            // 
            this.cb_method.FormattingEnabled = true;
            this.cb_method.Location = new System.Drawing.Point(78, 34);
            this.cb_method.Name = "cb_method";
            this.cb_method.Size = new System.Drawing.Size(174, 28);
            this.cb_method.TabIndex = 12;
            this.cb_method.SelectedIndexChanged += new System.EventHandler(this.cb_method_SelectedIndexChanged);
            // 
            // ReportDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 718);
            this.Controls.Add(this.cb_method);
            this.Controls.Add(this.cb_year);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_quarter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_month);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_case);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReportDateTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportDateTime";
            this.Load += new System.EventHandler(this.ReportDateTime_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_case;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_month;
        private System.Windows.Forms.ComboBox cb_quarter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_year;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_method;
    }
}