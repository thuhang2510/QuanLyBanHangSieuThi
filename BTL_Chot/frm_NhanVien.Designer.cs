namespace BTL_Chot
{
    partial class frm_NhanVien
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
            this.btn_Sua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.d_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_LuongCB = new System.Windows.Forms.TextBox();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.masktxt_SDTNV = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.checkedListBox_TimKiem = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnInDSNV = new System.Windows.Forms.Button();
            this.btn_LoadNV = new System.Windows.Forms.Button();
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_titleNhanVien = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.d_NgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayVaoLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(303, 358);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(109, 41);
            this.btn_Sua.TabIndex = 43;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Số điện thoại";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(467, 358);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(109, 41);
            this.btn_Xoa.TabIndex = 42;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // d_NgaySinh
            // 
            this.d_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.d_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.d_NgaySinh.Location = new System.Drawing.Point(574, 41);
            this.d_NgaySinh.Name = "d_NgaySinh";
            this.d_NgaySinh.Size = new System.Drawing.Size(201, 26);
            this.d_NgaySinh.TabIndex = 21;
            this.d_NgaySinh.Value = new System.DateTime(2004, 3, 8, 0, 0, 0, 0);
            this.d_NgaySinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.d_NgaySinh_KeyPress);
            // 
            // txt_LuongCB
            // 
            this.txt_LuongCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LuongCB.Location = new System.Drawing.Point(574, 144);
            this.txt_LuongCB.Name = "txt_LuongCB";
            this.txt_LuongCB.Size = new System.Drawing.Size(201, 26);
            this.txt_LuongCB.TabIndex = 18;
            this.txt_LuongCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_LuongCB_KeyPress);
            this.txt_LuongCB.Validating += new System.ComponentModel.CancelEventHandler(this.txt_LuongCB_Validating);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.Location = new System.Drawing.Point(950, 358);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(109, 41);
            this.btn_Dong.TabIndex = 44;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(131, 358);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(109, 41);
            this.btn_Them.TabIndex = 41;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // masktxt_SDTNV
            // 
            this.masktxt_SDTNV.Location = new System.Drawing.Point(168, 196);
            this.masktxt_SDTNV.Mask = "000 000 0000";
            this.masktxt_SDTNV.Name = "masktxt_SDTNV";
            this.masktxt_SDTNV.Size = new System.Drawing.Size(201, 26);
            this.masktxt_SDTNV.TabIndex = 23;
            this.masktxt_SDTNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.masktxt_SDTNV_KeyPress);
            this.masktxt_SDTNV.Validating += new System.ComponentModel.CancelEventHandler(this.masktxt_SDTNV_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(438, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Lương cơ bản";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(438, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ngày vào làm";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(790, 358);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(109, 41);
            this.btn_Reset.TabIndex = 49;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // checkedListBox_TimKiem
            // 
            this.checkedListBox_TimKiem.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox_TimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_TimKiem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkedListBox_TimKiem.FormattingEnabled = true;
            this.checkedListBox_TimKiem.Items.AddRange(new object[] {
            "Tên nhân viên",
            "Địa chỉ",
            "Ngày sinh",
            "Ngày vào làm",
            "Số điện thoại"});
            this.checkedListBox_TimKiem.Location = new System.Drawing.Point(26, 44);
            this.checkedListBox_TimKiem.Name = "checkedListBox_TimKiem";
            this.checkedListBox_TimKiem.Size = new System.Drawing.Size(190, 147);
            this.checkedListBox_TimKiem.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkedListBox_TimKiem);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(912, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 243);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // btnInDSNV
            // 
            this.btnInDSNV.Location = new System.Drawing.Point(860, 28);
            this.btnInDSNV.Name = "btnInDSNV";
            this.btnInDSNV.Size = new System.Drawing.Size(226, 39);
            this.btnInDSNV.TabIndex = 31;
            this.btnInDSNV.Text = "In danh sách nhân viên";
            this.btnInDSNV.UseVisualStyleBackColor = true;
            this.btnInDSNV.Click += new System.EventHandler(this.btnInDSNV_Click);
            // 
            // btn_LoadNV
            // 
            this.btn_LoadNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadNV.Location = new System.Drawing.Point(26, 28);
            this.btn_LoadNV.Name = "btn_LoadNV";
            this.btn_LoadNV.Size = new System.Drawing.Size(111, 39);
            this.btn_LoadNV.TabIndex = 30;
            this.btn_LoadNV.Text = "Tải lại";
            this.btn_LoadNV.UseVisualStyleBackColor = true;
            this.btn_LoadNV.Click += new System.EventHandler(this.btn_LoadNV_Click);
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.AllowUserToAddRows = false;
            this.dgv_NhanVien.AllowUserToDeleteRows = false;
            this.dgv_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.bGioiTinh,
            this.TenNV,
            this.DiaChiNV,
            this.SDT_NV,
            this.NgaySinh,
            this.NgayVaoLam,
            this.LCB});
            this.dgv_NhanVien.Location = new System.Drawing.Point(26, 80);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.ReadOnly = true;
            this.dgv_NhanVien.RowHeadersWidth = 51;
            this.dgv_NhanVien.RowTemplate.Height = 24;
            this.dgv_NhanVien.Size = new System.Drawing.Size(1060, 333);
            this.dgv_NhanVien.TabIndex = 0;
            this.dgv_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhanVien_CellClick);
            this.dgv_NhanVien.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_NhanVien_CellFormatting);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(627, 358);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(109, 41);
            this.btn_TimKiem.TabIndex = 48;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInDSNV);
            this.groupBox2.Controls.Add(this.btn_LoadNV);
            this.groupBox2.Controls.Add(this.dgv_NhanVien);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(67, 428);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1112, 435);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(438, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Ngày Sinh";
            // 
            // lb_titleNhanVien
            // 
            this.lb_titleNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_titleNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titleNhanVien.Location = new System.Drawing.Point(0, 0);
            this.lb_titleNhanVien.Name = "lb_titleNhanVien";
            this.lb_titleNhanVien.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lb_titleNhanVien.Size = new System.Drawing.Size(1227, 57);
            this.lb_titleNhanVien.TabIndex = 40;
            this.lb_titleNhanVien.Text = "Quản Lý Nhân Viên";
            this.lb_titleNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.masktxt_SDTNV);
            this.groupBox1.Controls.Add(this.d_NgaySinh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_LuongCB);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_TenNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_MaNV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.d_NgayVaoLam);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(67, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 244);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Location = new System.Drawing.Point(168, 144);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(201, 26);
            this.txt_DiaChi.TabIndex = 12;
            this.txt_DiaChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DiaChi_KeyPress);
            this.txt_DiaChi.Validating += new System.ComponentModel.CancelEventHandler(this.txt_DiaChi_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Địa chỉ";
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNV.Location = new System.Drawing.Point(168, 93);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(201, 26);
            this.txt_TenNV.TabIndex = 10;
            this.txt_TenNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TenNV_KeyPress);
            this.txt_TenNV.Validating += new System.ComponentModel.CancelEventHandler(this.txt_TenNV_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên nhân viên";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNV.Location = new System.Drawing.Point(168, 41);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(201, 26);
            this.txt_MaNV.TabIndex = 8;
            this.txt_MaNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MaNV_KeyPress);
            this.txt_MaNV.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MaNV_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên";
            // 
            // d_NgayVaoLam
            // 
            this.d_NgayVaoLam.CustomFormat = "dd/MM/yyyy";
            this.d_NgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.d_NgayVaoLam.Location = new System.Drawing.Point(574, 93);
            this.d_NgayVaoLam.Name = "d_NgayVaoLam";
            this.d_NgayVaoLam.Size = new System.Drawing.Size(201, 26);
            this.d_NgayVaoLam.TabIndex = 22;
            this.d_NgayVaoLam.Value = new System.DateTime(2022, 3, 9, 0, 0, 0, 0);
            this.d_NgayVaoLam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.d_NgayVaoLam_KeyPress);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "iMaNV";
            this.MaNV.FillWeight = 76.22739F;
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // bGioiTinh
            // 
            this.bGioiTinh.DataPropertyName = "bGioiTinh";
            this.bGioiTinh.HeaderText = "Giới tính";
            this.bGioiTinh.MinimumWidth = 6;
            this.bGioiTinh.Name = "bGioiTinh";
            this.bGioiTinh.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "sTenNV";
            this.TenNV.FillWeight = 97.22922F;
            this.TenNV.HeaderText = "Tên nhân viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // DiaChiNV
            // 
            this.DiaChiNV.DataPropertyName = "sDiachi";
            this.DiaChiNV.FillWeight = 104.1602F;
            this.DiaChiNV.HeaderText = "Địa chỉ";
            this.DiaChiNV.MinimumWidth = 6;
            this.DiaChiNV.Name = "DiaChiNV";
            this.DiaChiNV.ReadOnly = true;
            // 
            // SDT_NV
            // 
            this.SDT_NV.DataPropertyName = "sDienthoai";
            this.SDT_NV.FillWeight = 110.3569F;
            this.SDT_NV.HeaderText = "Số điện thoại";
            this.SDT_NV.MinimumWidth = 6;
            this.SDT_NV.Name = "SDT_NV";
            this.SDT_NV.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "dNgaysinh";
            this.NgaySinh.FillWeight = 115.8971F;
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // NgayVaoLam
            // 
            this.NgayVaoLam.DataPropertyName = "dNgayvaolam";
            this.NgayVaoLam.FillWeight = 120.8503F;
            this.NgayVaoLam.HeaderText = "Ngày vào làm";
            this.NgayVaoLam.MinimumWidth = 6;
            this.NgayVaoLam.Name = "NgayVaoLam";
            this.NgayVaoLam.ReadOnly = true;
            // 
            // LCB
            // 
            this.LCB.DataPropertyName = "fLuongcoban";
            this.LCB.FillWeight = 125.2788F;
            this.LCB.HeaderText = "Lương cơ bản";
            this.LCB.MinimumWidth = 6;
            this.LCB.Name = "LCB";
            this.LCB.ReadOnly = true;
            // 
            // frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 873);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lb_titleNhanVien);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_NhanVien";
            this.Text = "frm_NhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Xoa;
        public System.Windows.Forms.DateTimePicker d_NgaySinh;
        private System.Windows.Forms.TextBox txt_LuongCB;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.MaskedTextBox masktxt_SDTNV;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox checkedListBox_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnInDSNV;
        private System.Windows.Forms.Button btn_LoadNV;
        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private System.Windows.Forms.Label lb_titleNhanVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker d_NgayVaoLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn bGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayVaoLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn LCB;
    }
}