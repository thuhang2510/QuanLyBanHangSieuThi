namespace BTL_Chot
{
    partial class frm_ChiTietHoaDonNhap
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_TenHang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SLNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_GiaNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MaHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.dgv_ChiTietNhapHang = new System.Windows.Forms.DataGridView();
            this.sMaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.cb_SoHD = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_giaNhapMax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_giaNhapMin = new System.Windows.Forms.TextBox();
            this.checkb_GiaNhap = new System.Windows.Forms.CheckBox();
            this.checkb_TenHang = new System.Windows.Forms.CheckBox();
            this.txt_SLNhapMax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SlNhapMin = new System.Windows.Forms.TextBox();
            this.checkb_slNhap = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_inHD = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietNhapHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(661, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiết hóa đơn nhập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số hóa đơn: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_TenHang);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_SLNhap);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_GiaNhap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_MaHang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 121);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cb_TenHang
            // 
            this.cb_TenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TenHang.FormattingEnabled = true;
            this.cb_TenHang.Location = new System.Drawing.Point(113, 39);
            this.cb_TenHang.Name = "cb_TenHang";
            this.cb_TenHang.Size = new System.Drawing.Size(119, 26);
            this.cb_TenHang.TabIndex = 7;
            this.cb_TenHang.SelectedIndexChanged += new System.EventHandler(this.cb_TenHang_SelectedIndexChanged);
            this.cb_TenHang.Validating += new System.ComponentModel.CancelEventHandler(this.cb_TenHang_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tên hàng";
            // 
            // txt_SLNhap
            // 
            this.txt_SLNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SLNhap.Location = new System.Drawing.Point(413, 81);
            this.txt_SLNhap.Name = "txt_SLNhap";
            this.txt_SLNhap.Size = new System.Drawing.Size(119, 24);
            this.txt_SLNhap.TabIndex = 5;
            this.txt_SLNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SLNhap_KeyPress);
            this.txt_SLNhap.Validating += new System.ComponentModel.CancelEventHandler(this.txt_SLNhap_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(307, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng nhập";
            // 
            // txt_GiaNhap
            // 
            this.txt_GiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaNhap.Location = new System.Drawing.Point(413, 39);
            this.txt_GiaNhap.Name = "txt_GiaNhap";
            this.txt_GiaNhap.Size = new System.Drawing.Size(119, 24);
            this.txt_GiaNhap.TabIndex = 3;
            this.txt_GiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GiaNhap_KeyPress);
            this.txt_GiaNhap.Validating += new System.ComponentModel.CancelEventHandler(this.txt_GiaNhap_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(307, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giá nhập";
            // 
            // txt_MaHang
            // 
            this.txt_MaHang.Enabled = false;
            this.txt_MaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHang.Location = new System.Drawing.Point(113, 79);
            this.txt_MaHang.Name = "txt_MaHang";
            this.txt_MaHang.ReadOnly = true;
            this.txt_MaHang.Size = new System.Drawing.Size(121, 24);
            this.txt_MaHang.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã hàng";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(74, 341);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(495, 341);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(390, 341);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(283, 341);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(178, 341);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 8;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // dgv_ChiTietNhapHang
            // 
            this.dgv_ChiTietNhapHang.AllowUserToAddRows = false;
            this.dgv_ChiTietNhapHang.AllowUserToDeleteRows = false;
            this.dgv_ChiTietNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ChiTietNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaHang,
            this.sTenHang,
            this.fGiaNhap,
            this.fSoLuong});
            this.dgv_ChiTietNhapHang.Location = new System.Drawing.Point(26, 58);
            this.dgv_ChiTietNhapHang.Name = "dgv_ChiTietNhapHang";
            this.dgv_ChiTietNhapHang.ReadOnly = true;
            this.dgv_ChiTietNhapHang.RowHeadersWidth = 51;
            this.dgv_ChiTietNhapHang.RowTemplate.Height = 24;
            this.dgv_ChiTietNhapHang.Size = new System.Drawing.Size(532, 197);
            this.dgv_ChiTietNhapHang.TabIndex = 9;
            this.dgv_ChiTietNhapHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChiTietNhapHang_CellClick);
            // 
            // sMaHang
            // 
            this.sMaHang.DataPropertyName = "sMaHang";
            this.sMaHang.HeaderText = "Mã hàng";
            this.sMaHang.MinimumWidth = 6;
            this.sMaHang.Name = "sMaHang";
            this.sMaHang.ReadOnly = true;
            // 
            // sTenHang
            // 
            this.sTenHang.DataPropertyName = "sTenHang";
            this.sTenHang.HeaderText = "Tên hàng";
            this.sTenHang.MinimumWidth = 6;
            this.sTenHang.Name = "sTenHang";
            this.sTenHang.ReadOnly = true;
            // 
            // fGiaNhap
            // 
            this.fGiaNhap.DataPropertyName = "fGiaNhap";
            this.fGiaNhap.HeaderText = "Giá nhập";
            this.fGiaNhap.MinimumWidth = 6;
            this.fGiaNhap.Name = "fGiaNhap";
            this.fGiaNhap.ReadOnly = true;
            // 
            // fSoLuong
            // 
            this.fSoLuong.DataPropertyName = "fSoluongnhap";
            this.fSoLuong.HeaderText = "Số lượng";
            this.fSoLuong.MinimumWidth = 6;
            this.fSoLuong.Name = "fSoLuong";
            this.fSoLuong.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_inHD);
            this.groupBox2.Controls.Add(this.btnTaiLai);
            this.groupBox2.Controls.Add(this.dgv_ChiTietNhapHang);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(38, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 273);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiện danh sách";
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLai.Location = new System.Drawing.Point(26, 29);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(75, 23);
            this.btnTaiLai.TabIndex = 10;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // cb_SoHD
            // 
            this.cb_SoHD.FormattingEnabled = true;
            this.cb_SoHD.Location = new System.Drawing.Point(127, 57);
            this.cb_SoHD.Name = "cb_SoHD";
            this.cb_SoHD.Size = new System.Drawing.Size(71, 24);
            this.cb_SoHD.TabIndex = 11;
            this.cb_SoHD.SelectedIndexChanged += new System.EventHandler(this.cb_SoHD_SelectedIndexChanged);
            this.cb_SoHD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_SoHD_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_giaNhapMax);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_giaNhapMin);
            this.groupBox3.Controls.Add(this.checkb_GiaNhap);
            this.groupBox3.Controls.Add(this.checkb_TenHang);
            this.groupBox3.Location = new System.Drawing.Point(38, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(585, 87);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // txt_giaNhapMax
            // 
            this.txt_giaNhapMax.Location = new System.Drawing.Point(443, 19);
            this.txt_giaNhapMax.Name = "txt_giaNhapMax";
            this.txt_giaNhapMax.Size = new System.Drawing.Size(86, 22);
            this.txt_giaNhapMax.TabIndex = 5;
            this.txt_giaNhapMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_giaNhapMax_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "<=  Giá nhập   <=";
            // 
            // txt_giaNhapMin
            // 
            this.txt_giaNhapMin.Location = new System.Drawing.Point(250, 19);
            this.txt_giaNhapMin.Name = "txt_giaNhapMin";
            this.txt_giaNhapMin.Size = new System.Drawing.Size(86, 22);
            this.txt_giaNhapMin.TabIndex = 3;
            this.txt_giaNhapMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_giaNhapMin_KeyPress);
            // 
            // checkb_GiaNhap
            // 
            this.checkb_GiaNhap.AutoSize = true;
            this.checkb_GiaNhap.Location = new System.Drawing.Point(227, 21);
            this.checkb_GiaNhap.Name = "checkb_GiaNhap";
            this.checkb_GiaNhap.Size = new System.Drawing.Size(18, 17);
            this.checkb_GiaNhap.TabIndex = 1;
            this.checkb_GiaNhap.UseVisualStyleBackColor = true;
            // 
            // checkb_TenHang
            // 
            this.checkb_TenHang.AutoSize = true;
            this.checkb_TenHang.Location = new System.Drawing.Point(49, 21);
            this.checkb_TenHang.Name = "checkb_TenHang";
            this.checkb_TenHang.Size = new System.Drawing.Size(91, 21);
            this.checkb_TenHang.TabIndex = 0;
            this.checkb_TenHang.Text = "Tên hàng";
            this.checkb_TenHang.UseVisualStyleBackColor = true;
            // 
            // txt_SLNhapMax
            // 
            this.txt_SLNhapMax.Location = new System.Drawing.Point(481, 287);
            this.txt_SLNhapMax.Name = "txt_SLNhapMax";
            this.txt_SLNhapMax.Size = new System.Drawing.Size(86, 22);
            this.txt_SLNhapMax.TabIndex = 9;
            this.txt_SLNhapMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SLNhapMax_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "<=  SL nhập   <=";
            // 
            // txt_SlNhapMin
            // 
            this.txt_SlNhapMin.Location = new System.Drawing.Point(288, 287);
            this.txt_SlNhapMin.Name = "txt_SlNhapMin";
            this.txt_SlNhapMin.Size = new System.Drawing.Size(86, 22);
            this.txt_SlNhapMin.TabIndex = 7;
            this.txt_SlNhapMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SlNhapMin_KeyPress);
            // 
            // checkb_slNhap
            // 
            this.checkb_slNhap.AutoSize = true;
            this.checkb_slNhap.Location = new System.Drawing.Point(265, 289);
            this.checkb_slNhap.Name = "checkb_slNhap";
            this.checkb_slNhap.Size = new System.Drawing.Size(18, 17);
            this.checkb_slNhap.TabIndex = 6;
            this.checkb_slNhap.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_inHD
            // 
            this.btn_inHD.Location = new System.Drawing.Point(443, 29);
            this.btn_inHD.Name = "btn_inHD";
            this.btn_inHD.Size = new System.Drawing.Size(114, 23);
            this.btn_inHD.TabIndex = 11;
            this.btn_inHD.Text = "In hóa đơn";
            this.btn_inHD.UseVisualStyleBackColor = true;
            this.btn_inHD.Click += new System.EventHandler(this.btn_inHD_Click);
            // 
            // frm_ChiTietHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 665);
            this.Controls.Add(this.txt_SLNhapMax);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_SlNhapMin);
            this.Controls.Add(this.checkb_slNhap);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cb_SoHD);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_ChiTietHoaDonNhap";
            this.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.Text = "frm_ChiTietHoaDonNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_ChiTietHoaDonNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietNhapHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_TenHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_SLNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_GiaNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MaHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.DataGridView dgv_ChiTietNhapHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn fGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn fSoLuong;
        private System.Windows.Forms.ComboBox cb_SoHD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkb_GiaNhap;
        private System.Windows.Forms.CheckBox checkb_TenHang;
        private System.Windows.Forms.TextBox txt_giaNhapMin;
        private System.Windows.Forms.TextBox txt_giaNhapMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_SLNhapMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_SlNhapMin;
        private System.Windows.Forms.CheckBox checkb_slNhap;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_inHD;
    }
}