namespace BTL_Chot
{
    partial class frm_ChiTietHDBan
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
            this.txt_SLBanMax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkb_slNhap = new System.Windows.Forms.CheckBox();
            this.txt_giaBanMax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_giaBanMin = new System.Windows.Forms.TextBox();
            this.checkb_GiaNhap = new System.Windows.Forms.CheckBox();
            this.checkb_TenHang = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_SlBanMin = new System.Windows.Forms.TextBox();
            this.cb_SoHD = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.dgv_ChiTietBan = new System.Windows.Forms.DataGridView();
            this.sMaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fGiaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fSoLuongmua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSLTon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_TenHang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SLBan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_GiaBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MaHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietBan)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_SLBanMax
            // 
            this.txt_SLBanMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SLBanMax.Location = new System.Drawing.Point(549, 50);
            this.txt_SLBanMax.Name = "txt_SLBanMax";
            this.txt_SLBanMax.Size = new System.Drawing.Size(86, 23);
            this.txt_SLBanMax.TabIndex = 24;
            this.txt_SLBanMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SLBanMax_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(392, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "<=  SL bán   <=";
            // 
            // checkb_slNhap
            // 
            this.checkb_slNhap.AutoSize = true;
            this.checkb_slNhap.Location = new System.Drawing.Point(277, 53);
            this.checkb_slNhap.Name = "checkb_slNhap";
            this.checkb_slNhap.Size = new System.Drawing.Size(18, 17);
            this.checkb_slNhap.TabIndex = 18;
            this.checkb_slNhap.UseVisualStyleBackColor = true;
            // 
            // txt_giaBanMax
            // 
            this.txt_giaBanMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giaBanMax.Location = new System.Drawing.Point(549, 15);
            this.txt_giaBanMax.Name = "txt_giaBanMax";
            this.txt_giaBanMax.Size = new System.Drawing.Size(86, 23);
            this.txt_giaBanMax.TabIndex = 5;
            this.txt_giaBanMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_giaBanMax_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "<=  Giá bán  <=";
            // 
            // txt_giaBanMin
            // 
            this.txt_giaBanMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giaBanMin.Location = new System.Drawing.Point(300, 16);
            this.txt_giaBanMin.Name = "txt_giaBanMin";
            this.txt_giaBanMin.Size = new System.Drawing.Size(86, 23);
            this.txt_giaBanMin.TabIndex = 3;
            this.txt_giaBanMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_giaBanMin_KeyPress);
            // 
            // checkb_GiaNhap
            // 
            this.checkb_GiaNhap.AutoSize = true;
            this.checkb_GiaNhap.Location = new System.Drawing.Point(277, 18);
            this.checkb_GiaNhap.Name = "checkb_GiaNhap";
            this.checkb_GiaNhap.Size = new System.Drawing.Size(18, 17);
            this.checkb_GiaNhap.TabIndex = 1;
            this.checkb_GiaNhap.UseVisualStyleBackColor = true;
            // 
            // checkb_TenHang
            // 
            this.checkb_TenHang.AutoSize = true;
            this.checkb_TenHang.Location = new System.Drawing.Point(99, 18);
            this.checkb_TenHang.Name = "checkb_TenHang";
            this.checkb_TenHang.Size = new System.Drawing.Size(100, 24);
            this.checkb_TenHang.TabIndex = 0;
            this.checkb_TenHang.Text = "Tên hàng";
            this.checkb_TenHang.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_SLBanMax);
            this.groupBox3.Controls.Add(this.txt_giaBanMax);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.checkb_slNhap);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_SlBanMin);
            this.groupBox3.Controls.Add(this.txt_giaBanMin);
            this.groupBox3.Controls.Add(this.checkb_GiaNhap);
            this.groupBox3.Controls.Add(this.checkb_TenHang);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(704, 87);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // txt_SlBanMin
            // 
            this.txt_SlBanMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SlBanMin.Location = new System.Drawing.Point(300, 51);
            this.txt_SlBanMin.Name = "txt_SlBanMin";
            this.txt_SlBanMin.Size = new System.Drawing.Size(86, 23);
            this.txt_SlBanMin.TabIndex = 20;
            this.txt_SlBanMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SlBanMin_KeyPress);
            // 
            // cb_SoHD
            // 
            this.cb_SoHD.FormattingEnabled = true;
            this.cb_SoHD.Location = new System.Drawing.Point(150, 64);
            this.cb_SoHD.Name = "cb_SoHD";
            this.cb_SoHD.Size = new System.Drawing.Size(96, 24);
            this.cb_SoHD.TabIndex = 26;
            this.cb_SoHD.SelectedIndexChanged += new System.EventHandler(this.cb_SoHD_SelectedIndexChanged);
            this.cb_SoHD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_SoHD_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTaiLai);
            this.groupBox2.Controls.Add(this.dgv_ChiTietBan);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 386);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(704, 273);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiện danh sách";
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLai.Location = new System.Drawing.Point(24, 24);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(84, 33);
            this.btnTaiLai.TabIndex = 32;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // dgv_ChiTietBan
            // 
            this.dgv_ChiTietBan.AllowUserToAddRows = false;
            this.dgv_ChiTietBan.AllowUserToDeleteRows = false;
            this.dgv_ChiTietBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ChiTietBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaHang,
            this.sTenHang,
            this.fGiaban,
            this.fSoLuongmua});
            this.dgv_ChiTietBan.Location = new System.Drawing.Point(23, 65);
            this.dgv_ChiTietBan.Name = "dgv_ChiTietBan";
            this.dgv_ChiTietBan.ReadOnly = true;
            this.dgv_ChiTietBan.RowHeadersWidth = 51;
            this.dgv_ChiTietBan.RowTemplate.Height = 24;
            this.dgv_ChiTietBan.Size = new System.Drawing.Size(661, 197);
            this.dgv_ChiTietBan.TabIndex = 9;
            this.dgv_ChiTietBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChiTietBan_CellClick);
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
            // fGiaban
            // 
            this.fGiaban.DataPropertyName = "fGiaban";
            this.fGiaban.HeaderText = "Giá bán";
            this.fGiaban.MinimumWidth = 6;
            this.fGiaban.Name = "fGiaban";
            this.fGiaban.ReadOnly = true;
            // 
            // fSoLuongmua
            // 
            this.fSoLuongmua.DataPropertyName = "fSoluongmua";
            this.fSoLuongmua.HeaderText = "Số lượng mua";
            this.fSoLuongmua.MinimumWidth = 6;
            this.fSoLuongmua.Name = "fSoLuongmua";
            this.fSoLuongmua.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSLTon);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cb_TenHang);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_SLBan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_GiaBan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_MaHang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 121);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtSLTon
            // 
            this.txtSLTon.Enabled = false;
            this.txtSLTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLTon.Location = new System.Drawing.Point(618, 81);
            this.txtSLTon.Name = "txtSLTon";
            this.txtSLTon.ReadOnly = true;
            this.txtSLTon.Size = new System.Drawing.Size(73, 24);
            this.txtSLTon.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(578, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tồn";
            // 
            // cb_TenHang
            // 
            this.cb_TenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TenHang.FormattingEnabled = true;
            this.cb_TenHang.Location = new System.Drawing.Point(119, 39);
            this.cb_TenHang.Name = "cb_TenHang";
            this.cb_TenHang.Size = new System.Drawing.Size(140, 26);
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
            // txt_SLBan
            // 
            this.txt_SLBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SLBan.Location = new System.Drawing.Point(413, 81);
            this.txt_SLBan.Name = "txt_SLBan";
            this.txt_SLBan.Size = new System.Drawing.Size(128, 24);
            this.txt_SLBan.TabIndex = 5;
            this.txt_SLBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SLBan_KeyPress);
            this.txt_SLBan.Validating += new System.ComponentModel.CancelEventHandler(this.txt_SLBan_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(307, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng bán";
            // 
            // txt_GiaBan
            // 
            this.txt_GiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaBan.Location = new System.Drawing.Point(413, 39);
            this.txt_GiaBan.Name = "txt_GiaBan";
            this.txt_GiaBan.Size = new System.Drawing.Size(128, 24);
            this.txt_GiaBan.TabIndex = 3;
            this.txt_GiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GiaBan_KeyPress);
            this.txt_GiaBan.Validating += new System.ComponentModel.CancelEventHandler(this.txt_GiaBan_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(307, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giá bán";
            // 
            // txt_MaHang
            // 
            this.txt_MaHang.Enabled = false;
            this.txt_MaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHang.Location = new System.Drawing.Point(119, 79);
            this.txt_MaHang.Name = "txt_MaHang";
            this.txt_MaHang.ReadOnly = true;
            this.txt_MaHang.Size = new System.Drawing.Size(142, 24);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Số hóa đơn: ";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(729, 61);
            this.label1.TabIndex = 13;
            this.label1.Text = "Chi tiết hóa đơn bán";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(71, 342);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 33);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(184, 342);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 33);
            this.btnSua.TabIndex = 28;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(308, 342);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 33);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(427, 342);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(84, 33);
            this.btnTim.TabIndex = 30;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(547, 342);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 33);
            this.btnReset.TabIndex = 31;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_ChiTietHDBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 665);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.cb_SoHD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox3);
            this.Name = "frm_ChiTietHDBan";
            this.Text = "frm_ChiTietHDBan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_ChiTietHDBan_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietBan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_SLBanMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkb_slNhap;
        private System.Windows.Forms.TextBox txt_giaBanMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_giaBanMin;
        private System.Windows.Forms.CheckBox checkb_GiaNhap;
        private System.Windows.Forms.CheckBox checkb_TenHang;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cb_SoHD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_ChiTietBan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_TenHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_SLBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_GiaBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MaHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SlBanMin;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSLTon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn fGiaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn fSoLuongmua;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}