namespace BTL_Chot.report
{
    partial class report2DieuKien
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
            this.btnLoc = new System.Windows.Forms.Button();
            this.cbTenNV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeMin = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iSoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeMax = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(658, 32);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 32);
            this.btnLoc.TabIndex = 0;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // cbTenNV
            // 
            this.cbTenNV.FormattingEnabled = true;
            this.cbTenNV.Location = new System.Drawing.Point(218, 32);
            this.cbTenNV.Name = "cbTenNV";
            this.cbTenNV.Size = new System.Drawing.Size(265, 24);
            this.cbTenNV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lọc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày lập";
            // 
            // dateTimeMin
            // 
            this.dateTimeMin.CustomFormat = "dd/MM/yyyy";
            this.dateTimeMin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeMin.Location = new System.Drawing.Point(218, 77);
            this.dateTimeMin.Name = "dateTimeMin";
            this.dateTimeMin.Size = new System.Drawing.Size(155, 22);
            this.dateTimeMin.TabIndex = 5;
            this.dateTimeMin.Value = new System.DateTime(2022, 4, 27, 0, 0, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSoHD,
            this.dNgayLap,
            this.iMaNV,
            this.sTenNV,
            this.fTongTien});
            this.dataGridView1.Location = new System.Drawing.Point(12, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 274);
            this.dataGridView1.TabIndex = 6;
            // 
            // iSoHD
            // 
            this.iSoHD.DataPropertyName = "iSoHD";
            this.iSoHD.HeaderText = "Số HĐ";
            this.iSoHD.MinimumWidth = 6;
            this.iSoHD.Name = "iSoHD";
            this.iSoHD.ReadOnly = true;
            // 
            // dNgayLap
            // 
            this.dNgayLap.DataPropertyName = "dNgaymuahang";
            this.dNgayLap.HeaderText = "Ngày lập";
            this.dNgayLap.MinimumWidth = 6;
            this.dNgayLap.Name = "dNgayLap";
            this.dNgayLap.ReadOnly = true;
            // 
            // iMaNV
            // 
            this.iMaNV.DataPropertyName = "iMaNV";
            this.iMaNV.HeaderText = "Mã NV";
            this.iMaNV.MinimumWidth = 6;
            this.iMaNV.Name = "iMaNV";
            this.iMaNV.ReadOnly = true;
            // 
            // sTenNV
            // 
            this.sTenNV.DataPropertyName = "sTenNV";
            this.sTenNV.HeaderText = "Tên NV";
            this.sTenNV.MinimumWidth = 6;
            this.sTenNV.Name = "sTenNV";
            this.sTenNV.ReadOnly = true;
            // 
            // fTongTien
            // 
            this.fTongTien.DataPropertyName = "Tổng tiền";
            this.fTongTien.HeaderText = "Tổng tiền";
            this.fTongTien.MinimumWidth = 6;
            this.fTongTien.Name = "fTongTien";
            this.fTongTien.ReadOnly = true;
            // 
            // dateTimeMax
            // 
            this.dateTimeMax.CustomFormat = "dd/MM/yyyy";
            this.dateTimeMax.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeMax.Location = new System.Drawing.Point(447, 77);
            this.dateTimeMax.Name = "dateTimeMax";
            this.dateTimeMax.Size = new System.Drawing.Size(155, 22);
            this.dateTimeMax.TabIndex = 7;
            this.dateTimeMax.Value = new System.DateTime(2022, 4, 27, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "to";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(658, 90);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 30);
            this.btnReport.TabIndex = 9;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // report2DieuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimeMax);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimeMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTenNV);
            this.Controls.Add(this.btnLoc);
            this.Name = "report2DieuKien";
            this.Text = "report2DieuKien";
            this.Load += new System.EventHandler(this.report2DieuKien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.ComboBox cbTenNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeMin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn fTongTien;
        private System.Windows.Forms.DateTimePicker dateTimeMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReport;
    }
}