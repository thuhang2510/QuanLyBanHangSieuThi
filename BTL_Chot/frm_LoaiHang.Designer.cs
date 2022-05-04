namespace BTL_Chot
{
    partial class frm_LoaiHang
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
            this.dgv_LoaiHang = new System.Windows.Forms.DataGridView();
            this.sMaLH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenLH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenLoaiHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txt_MaLoaiHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_LoaiHang
            // 
            this.dgv_LoaiHang.AllowUserToAddRows = false;
            this.dgv_LoaiHang.AllowUserToDeleteRows = false;
            this.dgv_LoaiHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LoaiHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LoaiHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaLH,
            this.sTenLH});
            this.dgv_LoaiHang.Location = new System.Drawing.Point(12, 208);
            this.dgv_LoaiHang.Name = "dgv_LoaiHang";
            this.dgv_LoaiHang.ReadOnly = true;
            this.dgv_LoaiHang.RowHeadersWidth = 51;
            this.dgv_LoaiHang.RowTemplate.Height = 24;
            this.dgv_LoaiHang.Size = new System.Drawing.Size(426, 150);
            this.dgv_LoaiHang.TabIndex = 14;
            this.dgv_LoaiHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LoaiHang_CellClick);
            // 
            // sMaLH
            // 
            this.sMaLH.DataPropertyName = "sMaLH";
            this.sMaLH.HeaderText = "Mã loại hàng";
            this.sMaLH.MinimumWidth = 6;
            this.sMaLH.Name = "sMaLH";
            this.sMaLH.ReadOnly = true;
            // 
            // sTenLH
            // 
            this.sTenLH.DataPropertyName = "sTenLH";
            this.sTenLH.HeaderText = "Tên loại hàng";
            this.sTenLH.MinimumWidth = 6;
            this.sTenLH.Name = "sTenLH";
            this.sTenLH.ReadOnly = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(253, 156);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 34);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(164, 156);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 34);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(42, 156);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 34);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenLoaiHang
            // 
            this.txtTenLoaiHang.Location = new System.Drawing.Point(166, 87);
            this.txtTenLoaiHang.Name = "txtTenLoaiHang";
            this.txtTenLoaiHang.Size = new System.Drawing.Size(187, 22);
            this.txtTenLoaiHang.TabIndex = 10;
            this.txtTenLoaiHang.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenLoaiHang_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên Loại Hàng";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(342, 156);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 34);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txt_MaLoaiHang
            // 
            this.txt_MaLoaiHang.Location = new System.Drawing.Point(167, 49);
            this.txt_MaLoaiHang.Name = "txt_MaLoaiHang";
            this.txt_MaLoaiHang.Size = new System.Drawing.Size(187, 22);
            this.txt_MaLoaiHang.TabIndex = 17;
            this.txt_MaLoaiHang.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MaLoaiHang_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã loại hàng";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_LoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 381);
            this.Controls.Add(this.txt_MaLoaiHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_LoaiHang);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenLoaiHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReset);
            this.Name = "frm_LoaiHang";
            this.Text = "frm_LoaiHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_LoaiHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_LoaiHang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenLoaiHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txt_MaLoaiHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaLH;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenLH;
    }
}