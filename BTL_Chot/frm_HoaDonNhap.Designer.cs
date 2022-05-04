namespace BTL_Chot
{
    partial class frm_HoaDonNhap
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkb_TenNV = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkb_NgayLap = new System.Windows.Forms.CheckBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_TenNV = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.d_NgayNhapHang = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_maHDNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_XemCT = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.dgv_phieuNhap = new System.Windows.Forms.DataGridView();
            this.iSoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgaynhaphang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // checkb_TenNV
            // 
            this.checkb_TenNV.AutoSize = true;
            this.checkb_TenNV.Location = new System.Drawing.Point(452, 22);
            this.checkb_TenNV.Name = "checkb_TenNV";
            this.checkb_TenNV.Size = new System.Drawing.Size(135, 24);
            this.checkb_TenNV.TabIndex = 1;
            this.checkb_TenNV.Text = "Tên nhân viên";
            this.checkb_TenNV.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkb_TenNV);
            this.groupBox3.Controls.Add(this.checkb_NgayLap);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox3.Location = new System.Drawing.Point(45, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(922, 61);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Kiếm";
            // 
            // checkb_NgayLap
            // 
            this.checkb_NgayLap.AutoSize = true;
            this.checkb_NgayLap.Location = new System.Drawing.Point(240, 22);
            this.checkb_NgayLap.Name = "checkb_NgayLap";
            this.checkb_NgayLap.Size = new System.Drawing.Size(96, 24);
            this.checkb_NgayLap.TabIndex = 0;
            this.checkb_NgayLap.Text = "Ngày lập";
            this.checkb_NgayLap.UseVisualStyleBackColor = true;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(586, 324);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(93, 34);
            this.btn_TimKiem.TabIndex = 24;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 18);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 5);
            this.label1.Size = new System.Drawing.Size(826, 58);
            this.label1.TabIndex = 17;
            this.label1.Text = "Phiếu nhập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cb_TenNV
            // 
            this.cb_TenNV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_TenNV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_TenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TenNV.FormattingEnabled = true;
            this.cb_TenNV.Location = new System.Drawing.Point(570, 38);
            this.cb_TenNV.Name = "cb_TenNV";
            this.cb_TenNV.Size = new System.Drawing.Size(294, 24);
            this.cb_TenNV.TabIndex = 8;
            this.cb_TenNV.SelectedIndexChanged += new System.EventHandler(this.cb_TenNV_SelectedIndexChanged);
            this.cb_TenNV.Validating += new System.ComponentModel.CancelEventHandler(this.cb_TenNV_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_TenNV);
            this.groupBox1.Controls.Add(this.d_NgayNhapHang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_MaNV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_maHDNhap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(923, 144);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập";
            // 
            // d_NgayNhapHang
            // 
            this.d_NgayNhapHang.CustomFormat = "dd/MM/yyyy";
            this.d_NgayNhapHang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.d_NgayNhapHang.Location = new System.Drawing.Point(149, 92);
            this.d_NgayNhapHang.Name = "d_NgayNhapHang";
            this.d_NgayNhapHang.Size = new System.Drawing.Size(156, 26);
            this.d_NgayNhapHang.TabIndex = 7;
            this.d_NgayNhapHang.Value = new System.DateTime(2022, 3, 9, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày nhập";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Enabled = false;
            this.txt_MaNV.Location = new System.Drawing.Point(570, 92);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.ReadOnly = true;
            this.txt_MaNV.Size = new System.Drawing.Size(158, 26);
            this.txt_MaNV.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên nhân viên";
            // 
            // txt_maHDNhap
            // 
            this.txt_maHDNhap.Location = new System.Drawing.Point(148, 40);
            this.txt_maHDNhap.Name = "txt_maHDNhap";
            this.txt_maHDNhap.Size = new System.Drawing.Size(158, 26);
            this.txt_maHDNhap.TabIndex = 1;
            this.txt_maHDNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_maHDNhap_KeyPress);
            this.txt_maHDNhap.Validating += new System.ComponentModel.CancelEventHandler(this.txt_maHDNhap_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_XemCT);
            this.groupBox2.Controls.Add(this.btn_load);
            this.groupBox2.Controls.Add(this.dgv_phieuNhap);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(45, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(923, 313);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phiếu nhập";
            // 
            // btn_XemCT
            // 
            this.btn_XemCT.Location = new System.Drawing.Point(620, 33);
            this.btn_XemCT.Name = "btn_XemCT";
            this.btn_XemCT.Size = new System.Drawing.Size(283, 33);
            this.btn_XemCT.TabIndex = 2;
            this.btn_XemCT.Text = "Xem chi tiết phiếu nhập";
            this.btn_XemCT.UseVisualStyleBackColor = true;
            this.btn_XemCT.Click += new System.EventHandler(this.btn_XemCT_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(22, 33);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(98, 33);
            this.btn_load.TabIndex = 1;
            this.btn_load.Text = "Tải lại";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // dgv_phieuNhap
            // 
            this.dgv_phieuNhap.AllowUserToAddRows = false;
            this.dgv_phieuNhap.AllowUserToDeleteRows = false;
            this.dgv_phieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_phieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSoHD,
            this.iMaNV,
            this.sTenNV,
            this.dNgaynhaphang});
            this.dgv_phieuNhap.Location = new System.Drawing.Point(20, 84);
            this.dgv_phieuNhap.Name = "dgv_phieuNhap";
            this.dgv_phieuNhap.ReadOnly = true;
            this.dgv_phieuNhap.RowHeadersWidth = 51;
            this.dgv_phieuNhap.RowTemplate.Height = 24;
            this.dgv_phieuNhap.Size = new System.Drawing.Size(883, 210);
            this.dgv_phieuNhap.TabIndex = 0;
            this.dgv_phieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_phieuNhap_CellClick);
            // 
            // iSoHD
            // 
            this.iSoHD.DataPropertyName = "iSoHD";
            this.iSoHD.HeaderText = "Số hóa đơn";
            this.iSoHD.MinimumWidth = 6;
            this.iSoHD.Name = "iSoHD";
            this.iSoHD.ReadOnly = true;
            // 
            // iMaNV
            // 
            this.iMaNV.DataPropertyName = "iMaNV";
            this.iMaNV.HeaderText = "Mã nhân viên";
            this.iMaNV.MinimumWidth = 6;
            this.iMaNV.Name = "iMaNV";
            this.iMaNV.ReadOnly = true;
            // 
            // sTenNV
            // 
            this.sTenNV.DataPropertyName = "Tên nhân viên";
            this.sTenNV.HeaderText = "Tên nhân viên";
            this.sTenNV.MinimumWidth = 6;
            this.sTenNV.Name = "sTenNV";
            this.sTenNV.ReadOnly = true;
            // 
            // dNgaynhaphang
            // 
            this.dNgaynhaphang.DataPropertyName = "dNgaynhaphang";
            this.dNgaynhaphang.HeaderText = "Ngày nhập";
            this.dNgaynhaphang.MinimumWidth = 6;
            this.dNgaynhaphang.Name = "dNgaynhaphang";
            this.dNgaynhaphang.ReadOnly = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(296, 324);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(103, 34);
            this.btn_Sua.TabIndex = 22;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Location = new System.Drawing.Point(723, 324);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(93, 34);
            this.btn_Dong.TabIndex = 21;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(148, 324);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(99, 34);
            this.btn_Them.TabIndex = 20;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(442, 324);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(100, 34);
            this.btn_Xoa.TabIndex = 23;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // frm_HoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 711);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Xoa);
            this.Name = "frm_HoaDonNhap";
            this.Text = "frm_HoaDonNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_HoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkb_TenNV;
        private System.Windows.Forms.CheckBox checkb_NgayLap;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_TenNV;
        private System.Windows.Forms.DateTimePicker d_NgayNhapHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_maHDNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_XemCT;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.DataGridView dgv_phieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgaynhaphang;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
    }
}