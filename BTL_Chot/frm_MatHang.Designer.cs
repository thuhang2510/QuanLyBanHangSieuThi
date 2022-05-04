namespace BTL_Chot
{
    partial class frm_MatHang
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
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiaHang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_MaLoaiHang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_TenLoaiHang = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_mathang = new System.Windows.Forms.DataGridView();
            this.sMaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaLH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fGiaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mathang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hàng";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(142, 37);
            this.txtMaHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(175, 26);
            this.txtMaHang.TabIndex = 1;
            this.txtMaHang.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaHang_Validating);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label2.Size = new System.Drawing.Size(798, 62);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mặt Hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(142, 80);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(175, 26);
            this.txtTenHang.TabIndex = 4;
            this.txtTenHang.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenHang_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên hàng";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(142, 124);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(175, 26);
            this.txtTenNCC.TabIndex = 6;
            this.txtTenNCC.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenNCC_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên nhà CC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(385, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tên loại hàng";
            // 
            // txtGiaHang
            // 
            this.txtGiaHang.Location = new System.Drawing.Point(504, 167);
            this.txtGiaHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaHang.Name = "txtGiaHang";
            this.txtGiaHang.Size = new System.Drawing.Size(170, 26);
            this.txtGiaHang.TabIndex = 10;
            this.txtGiaHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaHang_KeyPress);
            this.txtGiaHang.Validating += new System.ComponentModel.CancelEventHandler(this.txtGiaHang_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(385, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Giá hàng";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(504, 122);
            this.txtSL.Margin = new System.Windows.Forms.Padding(4);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(170, 26);
            this.txtSL.TabIndex = 12;
            this.txtSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress);
            this.txtSL.Validating += new System.ComponentModel.CancelEventHandler(this.txtSL_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(385, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Số lượng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_MaLoaiHang);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cb_TenLoaiHang);
            this.groupBox1.Controls.Add(this.txtSL);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtGiaHang);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTenNCC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTenHang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaHang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 215);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txt_MaLoaiHang
            // 
            this.txt_MaLoaiHang.Enabled = false;
            this.txt_MaLoaiHang.Location = new System.Drawing.Point(504, 77);
            this.txt_MaLoaiHang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaLoaiHang.Name = "txt_MaLoaiHang";
            this.txt_MaLoaiHang.ReadOnly = true;
            this.txt_MaLoaiHang.Size = new System.Drawing.Size(170, 26);
            this.txt_MaLoaiHang.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(385, 83);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mã loại hàng";
            // 
            // cb_TenLoaiHang
            // 
            this.cb_TenLoaiHang.FormattingEnabled = true;
            this.cb_TenLoaiHang.Location = new System.Drawing.Point(504, 35);
            this.cb_TenLoaiHang.Name = "cb_TenLoaiHang";
            this.cb_TenLoaiHang.Size = new System.Drawing.Size(170, 28);
            this.cb_TenLoaiHang.TabIndex = 13;
            this.cb_TenLoaiHang.SelectedIndexChanged += new System.EventHandler(this.cb_TenLoaiHang_SelectedIndexChanged);
            this.cb_TenLoaiHang.Validating += new System.ComponentModel.CancelEventHandler(this.cb_TenLoaiHang_Validating);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(165, 297);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 33);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(287, 297);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 33);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(411, 297);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 33);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(540, 297);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 33);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_mathang);
            this.groupBox2.Location = new System.Drawing.Point(35, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(724, 284);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiện danh sách";
            // 
            // dgv_mathang
            // 
            this.dgv_mathang.AllowUserToAddRows = false;
            this.dgv_mathang.AllowUserToDeleteRows = false;
            this.dgv_mathang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mathang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mathang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaHang,
            this.sTenHang,
            this.sTenNCC,
            this.sMaLH,
            this.fSoLuong,
            this.fGiaHang});
            this.dgv_mathang.Location = new System.Drawing.Point(28, 38);
            this.dgv_mathang.Name = "dgv_mathang";
            this.dgv_mathang.ReadOnly = true;
            this.dgv_mathang.RowHeadersWidth = 51;
            this.dgv_mathang.RowTemplate.Height = 24;
            this.dgv_mathang.Size = new System.Drawing.Size(672, 226);
            this.dgv_mathang.TabIndex = 0;
            this.dgv_mathang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mathang_CellClick);
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
            // sTenNCC
            // 
            this.sTenNCC.DataPropertyName = "sTenNCC";
            this.sTenNCC.HeaderText = "Tên NCC";
            this.sTenNCC.MinimumWidth = 6;
            this.sTenNCC.Name = "sTenNCC";
            this.sTenNCC.ReadOnly = true;
            // 
            // sMaLH
            // 
            this.sMaLH.DataPropertyName = "sMaLH";
            this.sMaLH.HeaderText = "Mã loại hàng";
            this.sMaLH.MinimumWidth = 6;
            this.sMaLH.Name = "sMaLH";
            this.sMaLH.ReadOnly = true;
            // 
            // fSoLuong
            // 
            this.fSoLuong.DataPropertyName = "fSoLuong";
            this.fSoLuong.HeaderText = "Số lượng";
            this.fSoLuong.MinimumWidth = 6;
            this.fSoLuong.Name = "fSoLuong";
            this.fSoLuong.ReadOnly = true;
            // 
            // fGiaHang
            // 
            this.fGiaHang.DataPropertyName = "fGiaHang";
            this.fGiaHang.HeaderText = "Giá hàng";
            this.fGiaHang.MinimumWidth = 6;
            this.fGiaHang.Name = "fGiaHang";
            this.fGiaHang.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_MatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 666);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_MatHang";
            this.Text = "frm_MatHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_MatHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mathang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGiaHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_TenLoaiHang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_mathang;
        private System.Windows.Forms.TextBox txt_MaLoaiHang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaLH;
        private System.Windows.Forms.DataGridViewTextBoxColumn fSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn fGiaHang;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}