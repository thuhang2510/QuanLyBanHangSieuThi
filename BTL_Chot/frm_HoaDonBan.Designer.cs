namespace BTL_Chot
{
    partial class frm_HoaDonBan
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_KhachHang = new System.Windows.Forms.ComboBox();
            this.cb_NhanVien = new System.Windows.Forms.ComboBox();
            this.d_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SoHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkb_NgayLap = new System.Windows.Forms.CheckBox();
            this.checkb_TenKH = new System.Windows.Forms.CheckBox();
            this.checkb_TenNV = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_CTHD = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.dgv_HDBan = new System.Windows.Forms.DataGridView();
            this.iSoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgaymuahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HDBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(910, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_KhachHang);
            this.groupBox1.Controls.Add(this.cb_NhanVien);
            this.groupBox1.Controls.Add(this.d_NgayLap);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_MaKH);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_MaNV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_SoHD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 167);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cb_KhachHang
            // 
            this.cb_KhachHang.FormattingEnabled = true;
            this.cb_KhachHang.Location = new System.Drawing.Point(615, 38);
            this.cb_KhachHang.Name = "cb_KhachHang";
            this.cb_KhachHang.Size = new System.Drawing.Size(225, 28);
            this.cb_KhachHang.TabIndex = 13;
            this.cb_KhachHang.SelectedIndexChanged += new System.EventHandler(this.cb_KhachHang_SelectedIndexChanged);
            this.cb_KhachHang.Validating += new System.ComponentModel.CancelEventHandler(this.cb_KhachHang_Validating);
            // 
            // cb_NhanVien
            // 
            this.cb_NhanVien.FormattingEnabled = true;
            this.cb_NhanVien.Location = new System.Drawing.Point(164, 79);
            this.cb_NhanVien.Name = "cb_NhanVien";
            this.cb_NhanVien.Size = new System.Drawing.Size(236, 28);
            this.cb_NhanVien.TabIndex = 12;
            this.cb_NhanVien.SelectedIndexChanged += new System.EventHandler(this.cb_NhanVien_SelectedIndexChanged);
            this.cb_NhanVien.Validating += new System.ComponentModel.CancelEventHandler(this.cb_NhanVien_Validating);
            // 
            // d_NgayLap
            // 
            this.d_NgayLap.CustomFormat = "dd/MM/yyyy";
            this.d_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.d_NgayLap.Location = new System.Drawing.Point(615, 123);
            this.d_NgayLap.Name = "d_NgayLap";
            this.d_NgayLap.Size = new System.Drawing.Size(149, 26);
            this.d_NgayLap.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ngày lập";
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Enabled = false;
            this.txt_MaKH.Location = new System.Drawing.Point(615, 79);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.ReadOnly = true;
            this.txt_MaKH.Size = new System.Drawing.Size(149, 26);
            this.txt_MaKH.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mã khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên khách hàng";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Enabled = false;
            this.txt_MaNV.Location = new System.Drawing.Point(164, 123);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.ReadOnly = true;
            this.txt_MaNV.Size = new System.Drawing.Size(149, 26);
            this.txt_MaNV.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên nhân viên";
            // 
            // txt_SoHD
            // 
            this.txt_SoHD.Location = new System.Drawing.Point(164, 38);
            this.txt_SoHD.Name = "txt_SoHD";
            this.txt_SoHD.Size = new System.Drawing.Size(149, 26);
            this.txt_SoHD.TabIndex = 1;
            this.txt_SoHD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoHD_KeyPress);
            this.txt_SoHD.Validating += new System.ComponentModel.CancelEventHandler(this.txt_SoHD_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkb_NgayLap);
            this.groupBox2.Controls.Add(this.checkb_TenKH);
            this.groupBox2.Controls.Add(this.checkb_TenNV);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(870, 81);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // checkb_NgayLap
            // 
            this.checkb_NgayLap.AutoSize = true;
            this.checkb_NgayLap.Location = new System.Drawing.Point(572, 33);
            this.checkb_NgayLap.Name = "checkb_NgayLap";
            this.checkb_NgayLap.Size = new System.Drawing.Size(96, 24);
            this.checkb_NgayLap.TabIndex = 2;
            this.checkb_NgayLap.Text = "Ngày lập";
            this.checkb_NgayLap.UseVisualStyleBackColor = true;
            // 
            // checkb_TenKH
            // 
            this.checkb_TenKH.AutoSize = true;
            this.checkb_TenKH.Location = new System.Drawing.Point(333, 33);
            this.checkb_TenKH.Name = "checkb_TenKH";
            this.checkb_TenKH.Size = new System.Drawing.Size(149, 24);
            this.checkb_TenKH.TabIndex = 1;
            this.checkb_TenKH.Text = "Tên khách hàng";
            this.checkb_TenKH.UseVisualStyleBackColor = true;
            // 
            // checkb_TenNV
            // 
            this.checkb_TenNV.AutoSize = true;
            this.checkb_TenNV.Location = new System.Drawing.Point(96, 33);
            this.checkb_TenNV.Name = "checkb_TenNV";
            this.checkb_TenNV.Size = new System.Drawing.Size(135, 24);
            this.checkb_TenNV.TabIndex = 0;
            this.checkb_TenNV.Text = "Tên nhân viên";
            this.checkb_TenNV.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_CTHD);
            this.groupBox3.Controls.Add(this.btnTaiLai);
            this.groupBox3.Controls.Add(this.dgv_HDBan);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(18, 398);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(870, 354);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hiện thông tin";
            // 
            // btn_CTHD
            // 
            this.btn_CTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CTHD.Location = new System.Drawing.Point(615, 25);
            this.btn_CTHD.Name = "btn_CTHD";
            this.btn_CTHD.Size = new System.Drawing.Size(234, 37);
            this.btn_CTHD.TabIndex = 6;
            this.btn_CTHD.Text = "Xem chi tiết hóa đơn";
            this.btn_CTHD.UseVisualStyleBackColor = true;
            this.btn_CTHD.Click += new System.EventHandler(this.btn_CTHD_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLai.Location = new System.Drawing.Point(19, 26);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(102, 37);
            this.btnTaiLai.TabIndex = 5;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.button6_Click);
            // 
            // dgv_HDBan
            // 
            this.dgv_HDBan.AllowUserToAddRows = false;
            this.dgv_HDBan.AllowUserToDeleteRows = false;
            this.dgv_HDBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HDBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HDBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSoHD,
            this.sTenNV,
            this.sTenKH,
            this.dNgaymuahang});
            this.dgv_HDBan.Location = new System.Drawing.Point(19, 72);
            this.dgv_HDBan.Name = "dgv_HDBan";
            this.dgv_HDBan.ReadOnly = true;
            this.dgv_HDBan.RowHeadersWidth = 51;
            this.dgv_HDBan.RowTemplate.Height = 24;
            this.dgv_HDBan.Size = new System.Drawing.Size(830, 265);
            this.dgv_HDBan.TabIndex = 0;
            this.dgv_HDBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HDBan_CellClick);
            // 
            // iSoHD
            // 
            this.iSoHD.DataPropertyName = "iSoHD";
            this.iSoHD.HeaderText = "Số hóa đơn";
            this.iSoHD.MinimumWidth = 6;
            this.iSoHD.Name = "iSoHD";
            this.iSoHD.ReadOnly = true;
            // 
            // sTenNV
            // 
            this.sTenNV.DataPropertyName = "sTenNV";
            this.sTenNV.HeaderText = "Tên NV";
            this.sTenNV.MinimumWidth = 6;
            this.sTenNV.Name = "sTenNV";
            this.sTenNV.ReadOnly = true;
            // 
            // sTenKH
            // 
            this.sTenKH.DataPropertyName = "sTenKH";
            this.sTenKH.HeaderText = "Tên KH";
            this.sTenKH.MinimumWidth = 6;
            this.sTenKH.Name = "sTenKH";
            this.sTenKH.ReadOnly = true;
            // 
            // dNgaymuahang
            // 
            this.dNgaymuahang.DataPropertyName = "dNgaymuahang";
            this.dNgaymuahang.HeaderText = "Ngày lập";
            this.dNgaymuahang.MinimumWidth = 6;
            this.dNgaymuahang.Name = "dNgaymuahang";
            this.dNgaymuahang.ReadOnly = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(109, 346);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 37);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(252, 346);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 37);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(399, 346);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 37);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(544, 346);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(103, 37);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(688, 346);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 37);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_HoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 765);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_HoaDonBan";
            this.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.Text = "frm_HoaDonBan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_HoaDonBan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HDBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_SoHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker d_NgayLap;
        private System.Windows.Forms.ComboBox cb_KhachHang;
        private System.Windows.Forms.ComboBox cb_NhanVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkb_NgayLap;
        private System.Windows.Forms.CheckBox checkb_TenKH;
        private System.Windows.Forms.CheckBox checkb_TenNV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_HDBan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btn_CTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgaymuahang;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}